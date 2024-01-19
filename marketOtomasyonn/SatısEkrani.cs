using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketOtomasyonn
{
    public partial class SatısEkrani : Form
    {
        //Yapıcı metot ile parametre verilmiştir.
        public SatısEkrani(string ad)
        {
            InitializeComponent();
            this.ad = ad;
        }
        int satir = 1;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CRHOTCV\\SQLEXPRESS;Initial Catalog=MARKET;Integrated Security=True");
        private string ad;
        private void SatısEkrani_Load(object sender, EventArgs e)
        {
            //Form yüklendiğnde Satışlar tablosuna kolon oluşturur ve renklendirir.
            dgvSatis.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvSatis.ColumnHeadersDefaultCellStyle.BackColor;
            dgvSatis.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvSatis.ColumnHeadersDefaultCellStyle.ForeColor;
            dgvSatis.Columns.Add("BARKOD", "BARKOD NO");
            dgvSatis.Columns.Add("no", "NO");
            dgvSatis.Columns.Add("urunAdi", "ÜRÜN ADI");
            dgvSatis.Columns.Add("fiyat", "ÜRÜN FİYATI");
            dgvSatis.Columns.Add("adet", "ADET");
            dgvSatis.Columns.Add("toplamTutar", "TOPLAM TUTAR");
            dgvSatis.Columns["urunAdi"].Width = 300;
            dgvSatis.Columns["no"].Width = 50;

            //Giriş yapılan kullanıcı ekrana yazar.
            lblKasiyer.Text = "AKTİF KASİYER : " + ad;
            txtBarkod.Focus();
        }

      
        //Stok düzenleme ekranını açar
        private void button5_Click(object sender, EventArgs e)
        {
            Stoklar frm = new Stoklar();
            frm.ShowDialog();

        }


        //Tablodaki satılmak üzere bulunan ürünleri siler ve değerleri normale döndürür.
        private void button2_Click(object sender, EventArgs e)
        {
            dgvSatis.Rows.Clear();
            btnanaToplam.Text = "0";
            txtBarkod.Text = string.Empty;
            satir = 1;
            txtBarkod.Focus();
        }



        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {         

            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    //Satılan ürünün stok kontrolü yapılır.
                    baglanti.Open();
                    SqlCommand komutStokKontrol = new SqlCommand(
                        "SELECT STOK FROM URUNLER WHERE BARKOD = @barkod", baglanti
                    );

                    komutStokKontrol.Parameters.AddWithValue("@barkod", txtBarkod.Text);

                    var sonuc = komutStokKontrol.ExecuteScalar();

                    if (sonuc != null && sonuc != DBNull.Value)
                    {
                        var guncelStok = Convert.ToInt32(sonuc);

                        if (guncelStok <= 0)
                        {
                            MessageBox.Show("Girilen barkod'a ait ürün stokta kalmamıştır.", "STOK UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtBarkod.Text = string.Empty;
                            baglanti.Close();
                        }
                        //Ürün stokta varsa ürünü tabloya getirir.
                        else
                        {
                            SqlCommand komut = new SqlCommand("SELECT URUNADI , FIYAT,BARKOD FROM URUNLER WHERE BARKOD='" + txtBarkod.Text + "'", baglanti);

                            SqlDataReader dr = komut.ExecuteReader();

                            try
                            {
                                while (dr.Read())
                                {
                                    string ad = dr["URUNADI"].ToString();
                                    string fiyat = dr["FIYAT"].ToString();
                                    string barkod = dr["BARKOD"].ToString();
                                    int adet = 1;
                                    decimal toplam = Convert.ToDecimal(fiyat) * adet;


                                    satir = dgvSatis.Rows.Count + 1;
                                    bool urunVarmi = false;

                                    //Tablodaki ürünleri döngü ile dönüp adet sayısı stoktan fazla ise yeteri kadar stok olmadığını uyarı olarak verir.
                                    foreach (DataGridViewRow row in dgvSatis.Rows)
                                    {

                                        if (row.Cells["BARKOD"].Value.ToString() == txtBarkod.Text.ToString())
                                        {

                                            int guncelAdet = Convert.ToInt32(row.Cells["adet"].Value);

                                            if (guncelStok <= guncelAdet)
                                            {
                                                MessageBox.Show("SATILAN ÜRÜNDE YETERİ KADAR STOK YOK", "STOK UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                guncelAdet = guncelStok;
                                                row.Cells["adet"].ReadOnly = true;
                                            }

                                            else
                                            {
                                                row.Cells["adet"].Value = guncelAdet + 1;
                                            }


                                            urunVarmi = true;
                                            break;


                                        }
                                    }

                                    // Eğer ürün yoksa yeni bir satır oluştur
                                    if (!urunVarmi)
                                    {
                                        dgvSatis.Rows.Add(barkod, satir, ad, fiyat, adet, toplam);

                                    }

                                    //Tablodaki ürünlerin toplamnını btnAnaToplam butonuna yazar.
                                    double anapara = 0;

                                    for (int i = 0; i < dgvSatis.Rows.Count; i++)
                                    {
                                        anapara += Convert.ToDouble(dgvSatis.Rows[i].Cells["toplamTutar"].Value);
                                    }

                                    btnanaToplam.Text = anapara.ToString();

                                }
                            }
                            //Hatalı barkod girilirse uyarı verir
                            catch
                            {
                                MessageBox.Show("BARKOD YANLIŞ GİRİLDİ", "BARKOD BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            baglanti.Close();
                            txtBarkod.Text = string.Empty;
                        }

                    }
                    //Girilen barkod veritabanında bulunamaz ise hızlı ürün ekleme ekranını açar. 
                    else
                    {
                        DialogResult cevap;
                        cevap = MessageBox.Show("Girilen barkod'a ait ürün bulunamadı. Ürünü kaydetmek ister misiniz ?", "ÜRÜN BULUNAMADI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (cevap == DialogResult.Yes)
                        {
                            Stoklar.gelenveri = txtBarkod.Text;
                            hızlıUrunEkle hızlıUrunEkle = new hızlıUrunEkle();
                            hızlıUrunEkle.ShowDialog();

                        }


                        txtBarkod.Text = string.Empty;
                        baglanti.Close();
                    }
                }
                //Sql exception hatası alırsa aşağıdaki hatayı fırlatır.
                catch (SqlException ex)
                {

                    MessageBox.Show("GEÇERLİ BİR BARKOD GİRİLMEDİ","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    baglanti.Close();
                }

            }
        }

        //Tabloda hücre değişikliği olduğu zaman adet ile fiyat çarpar ve ana toplama ekler.
        private void dgvSatis_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvSatis.Rows.Count; i++)
            {
                double toplam = Convert.ToDouble(dgvSatis.Rows[i].Cells["adet"].Value) * Convert.ToDouble(dgvSatis.Rows[i].Cells["fiyat"].Value);
                dgvSatis.Rows[i].Cells["toplamTutar"].Value = toplam;

                double anapara = 0;
                for (int j = 0; j < dgvSatis.Rows.Count; j++)
                {
                    anapara += Convert.ToDouble(dgvSatis.Rows[j].Cells["toplamTutar"].Value);
                }

                btnanaToplam.Text = anapara.ToString();
            }
        }

        //Ana toplam değiştikçe paraustu fonksiyonunu çalıştırır.
        private void btnanaToplam_TextChanged(object sender, EventArgs e)
        {
            paraUstu();
        }

        //Para Üstü Fonksiyonu
        public void paraUstu()
        {
            double toplam = Convert.ToDouble(btnanaToplam.Text);
            btnikiyuzUstu.Text = (200 - toplam).ToString();
            btnyuzUstu.Text = (100 - toplam).ToString();
            btnelliUstu.Text = (50 - toplam).ToString();
            btnyirmiUstu.Text = (20 - toplam).ToString();

            if (Convert.ToDouble(btnikiyuzUstu.Text) < 0)
            {
                btnikiyuzUstu.Text = "0";
            }
            if (Convert.ToDouble(btnyuzUstu.Text) < 0)
            {
                btnyuzUstu.Text = "0";
            }
            if (Convert.ToDouble(btnelliUstu.Text) < 0)
            {
                btnelliUstu.Text = "0";
            }
            if (Convert.ToDouble(btnyirmiUstu.Text) < 0)
            {
                btnyirmiUstu.Text = "0";
            }
        }

      

       
        //Satışlar ekranını açar.
        private void button4_Click_1(object sender, EventArgs e)
        {
            Satıslar satıslar = new Satıslar();
            satıslar.ShowDialog();
        }

        //Satış işlemini gerçekleştirir.
        private void button1_Click(object sender, EventArgs e)
        {
            //dgvSatis.Columns.Add("BARKOD", "BARKOD NO");
            //dgvSatis.Columns.Add("no", "NO");
            //dgvSatis.Columns.Add("urunAdi", "ÜRÜN ADI");
            //dgvSatis.Columns.Add("fiyat", "ÜRÜN FİYATI");
            //dgvSatis.Columns.Add("adet", "ADET");
            //dgvSatis.Columns.Add("toplamTutar", "TOPLAM TUTAR");


            int sepet = dgvSatis.RowCount;
            //Tabloda ürün yoksa bu uyarıyı verir.
            if(sepet == 0) 
            {
                MessageBox.Show("Sepette Hiç Ürün Yok ","HAYDİ BİR ÜRÜN EKLE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                //FISLER tablosuna bir kayıt ekler
                baglanti.Open();
                decimal toplamTutar2 = Convert.ToDecimal(btnanaToplam.Text);
                SqlCommand komut = new SqlCommand("INSERT INTO FISLER (FISTARIHI,FISSAATİ,FISTUTARI,KASİYER) VALUES (CONVERT(DATE,GETDATE()), GETDATE() ,@toplamTutar,@kasiyer) ; SELECT SCOPE_IDENTITY();", baglanti);

                komut.Parameters.AddWithValue("@toplamTutar", toplamTutar2);
                komut.Parameters.AddWithValue("@kasiyer", lblKasiyer.Text.Substring(16));


                int fisID = Convert.ToInt32(komut.ExecuteScalar());
                string rastgelefis = rastgeleFisNoUretme();
                foreach (DataGridViewRow row in dgvSatis.Rows)
                {
                    string barkod = row.Cells["BARKOD"].Value.ToString();
                    string urunad = row.Cells["urunAdi"].Value.ToString();
                    decimal urunfiyat = Convert.ToDecimal(row.Cells["fiyat"].Value.ToString());
                    int adet = Convert.ToInt32(row.Cells["adet"].Value);
                    decimal toplamtutar1 = Convert.ToDecimal(row.Cells["toplamTutar"].Value);
                    string urunbarkod =row.Cells["BARKOD"].Value.ToString();






                    //FISDETAY tablosuna satılan ürünleri ekler.
                    SqlCommand komut2 = new SqlCommand("INSERT INTO FISDETAY (FISID,FISNO,URUNBARKOD, URUNADI, URUNFIYAT, ADET, TOPLAMTUTAR) VALUES (@fisid,@fisno,@urunbarkod,@urunadi,@fiyat,@adet,@toplamtutar)", baglanti);

                    komut2.Parameters.AddWithValue("@fisid", fisID);
                    komut2.Parameters.AddWithValue("@fisno", rastgelefis);
                    komut2.Parameters.AddWithValue("@urunbarkod", barkod);
                    komut2.Parameters.AddWithValue("@urunadi", urunad);
                    komut2.Parameters.AddWithValue("@fiyat", urunfiyat);
                    komut2.Parameters.AddWithValue("@adet", adet);
                    komut2.Parameters.AddWithValue("@toplamtutar", toplamtutar1);
                    komut2.ExecuteNonQuery();

                    //Satış yapıldığında satılan adet kadar stoktan düşer.
                    SqlCommand komut3 = new SqlCommand("UPDATE URUNLER SET STOK = STOK - @satisadet WHERE BARKOD = @barkod", baglanti);
                    komut3.Parameters.AddWithValue("@satisadet", adet);
                    komut3.Parameters.AddWithValue("@barkod", barkod);
                    komut3.ExecuteNonQuery();
                }

                dgvSatis.Rows.Clear();
                btnanaToplam.Text = "0";
                txtBarkod.Text = string.Empty;
                satir = 1;
                txtBarkod.Focus();

                MessageBox.Show("Satış yapıldı.","SATIŞ BİLGİSİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

               

                baglanti.Close();

            }


        }

        //Rastegele fiş üretme metodu.
        private static string rastgeleFisNoUretme()
        {
            Random random = new Random();
            int randomNumber = random.Next(100000, 1000000); // 100000 ile 999999 arasında rastgele bir sayı
            return "FIS" + randomNumber.ToString();
        }
        //Programı kapatır.
        private void SatısEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
    }
}
