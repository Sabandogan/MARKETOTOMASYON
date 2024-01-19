using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace marketOtomasyonn
{
    public partial class Stoklar : Form
    {
        public Stoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CRHOTCV\\SQLEXPRESS;Initial Catalog=MARKET;Integrated Security=True");
        public static string gelenveri;

        //Stoklar tablosu için kolonlar gelir ve stoklar listelenir
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            //btnGuncelle.Enabled = false;
            dgvStoklar.Columns[0].Width = 50;
            dgvStoklar.Columns[1].Width = 100;
            dgvStoklar.Columns[2].Width = 500;
            dgvStoklar.Columns[3].Width = 100;
            dgvStoklar.Columns[4].Width = 100;
            dgvStoklar.Columns[5].Width = 100;
            dgvStoklar.Columns[6].Width = 100;
            this.dgvStoklar.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvStoklar.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvStoklar.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgvStoklar.DefaultCellStyle.SelectionBackColor = Color.Black;
            ToplamKayit();
            
        }

        //Ürünleri listeleme metodu.
        public void Listele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM URUNLER", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvStoklar.DataSource = dt;
            baglanti.Close();   
        }
        //Textboxları temizleme metodu.
        public void yaziTemizle()
        {
            txtBarkod.Text = string.Empty;
            txturunAdi.Text = string.Empty;
            txturunFiyat.Text = string.Empty;
            txturunBirimi.Text = string.Empty;
            txturunStok.Text = string.Empty;
            txturunMarka.Text = string.Empty;
        }

        //Ürün kaydetme işlemi yapılır.
        private void btnurunKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBarkod.Text == "" || txturunAdi.Text == "" || txturunFiyat.Text == "" || txturunBirimi.Text == "" || txturunStok.Text == "" || txturunMarka.Text == "")
                {
                    MessageBox.Show("LÜTFEN BİLGİLERİ TAM DOLDURUNUZ....", "ÜRÜN EKLEME UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yaziTemizle();
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO URUNLER (BARKOD,URUNADI,FIYAT,BİRİM,STOK,MARKA) VALUES (@barkod,@urunadi,@fiyat,@birim,@stok,@marka)", baglanti);
                    komut.Parameters.AddWithValue("@barkod", txtBarkod.Text);
                    komut.Parameters.AddWithValue("@urunadi", txturunAdi.Text);
                    komut.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txturunFiyat.Text));
                    komut.Parameters.AddWithValue("@birim", txturunBirimi.Text);
                    komut.Parameters.AddWithValue("@stok", txturunStok.Text);
                    komut.Parameters.AddWithValue("@marka", txturunMarka.Text);
                    komut.ExecuteNonQuery();
                    komut.Parameters.Clear();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Eklendi!");
                    Listele();
                    ToplamKayit();
                    yaziTemizle();
                }
            }
            //Hatalı veri girişi olursa bu uyarı çıkar.
            catch (FormatException ex)
            {

                MessageBox.Show("LÜTFEN SAYISAL VERİLERİ DOĞRU BİR ŞEKİLDE GİRİNİZ.");
                baglanti.Close();
            }
            //Sql hatası alındığında bu uyarı verilir.
            catch (SqlException ex2)
            {
                MessageBox.Show("LÜTFEN SAYISAL VERİLERİ DOĞRU BİR ŞEKİLDE GİRİNİZ.");
                baglanti.Close();
            }          
           


        }
        //Ürün güncelleme işlemi yapılır.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (txturunbarkodGuncelle.Text == "" || txturunadiGuncelle.Text == "" || txtfiyatGuncelle.Text == "" || txtbirimGuncelle.Text == "" || txtstokGuncelle.Text == "" || txtmarkaGuncelle.Text == "")
                {
                    MessageBox.Show("LÜTFEN LİSTEDEN BİR ÜRÜN SEÇİNİZ...", "ÜRÜN GÜNCELLEME UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    if (dgvStoklar.Rows.Count == 0)
                    {
                        MessageBox.Show("GÜNCELLENİCEK ÜRÜN YOK");
                    }
                    else
                    {
                        baglanti.Open();

                        string secili_urun = dgvStoklar.CurrentRow.Cells[1].Value.ToString();
                        SqlCommand komut = new SqlCommand("UPDATE URUNLER SET BARKOD=@barkod,URUNADI=@urunadi,FIYAT=@fiyat,BİRİM=@birim,STOK=@stok,MARKA=@marka WHERE BARKOD=" + secili_urun, baglanti);
                        komut.Parameters.AddWithValue("@barkod", txturunbarkodGuncelle.Text);
                        komut.Parameters.AddWithValue("@urunadi", txturunadiGuncelle.Text);
                        komut.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtfiyatGuncelle.Text));
                        komut.Parameters.AddWithValue("@birim", txtbirimGuncelle.Text);
                        komut.Parameters.AddWithValue("@stok", txtstokGuncelle.Text);
                        komut.Parameters.AddWithValue("@marka", txtmarkaGuncelle.Text);
                        komut.ExecuteNonQuery();
                        komut.Parameters.Clear();
                        baglanti.Close();
                        MessageBox.Show("ÜRÜN GÜNCELLENDİ", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Listele();
                        yaziTemizle();
                    }


                }
            }
            //Hatalı veri girişi olursa bu uyarı çıkar.
            catch (FormatException ex)
            {

                MessageBox.Show("LÜTFEN SAYISAL VERİLERİ DOĞRU BİR ŞEKİLDE GİRİNİZ.");
                baglanti.Close();
            }

            //Sql hatası alındığında bu uyarı verilir.
            catch (SqlException ex2)
            {
                MessageBox.Show("LÜTFEN SAYISAL VERİLERİ DOĞRU BİR ŞEKİLDE GİRİNİZ.");
                baglanti.Close();
            }


        }

        //Silme işlemi yapılır.
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(dgvStoklar.Rows.Count==0)
            {
                MessageBox.Show("VERİTABANINDA HİÇ ÜRÜN YOK");
            }

            else
            {
                baglanti.Open();

                string secilen_urun = dgvStoklar.CurrentRow.Cells[1].Value.ToString();
                SqlCommand komut = new SqlCommand("DELETE FROM URUNLER WHERE BARKOD=" + secilen_urun, baglanti);
                DialogResult cevap = MessageBox.Show("Kayıt silinecek emin misiniz ?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (cevap == DialogResult.OK)
                {
                    komut.ExecuteNonQuery();
                    MessageBox.Show("KAYIT SİLİNDİ", "BİLGİLENDİRME");
                    baglanti.Close();
                    Listele();
                    ToplamKayit();
                   
                }
                else
                {
                    baglanti.Close();
                }

            }

        }
        //Datagridviev de seçili satırın değerlerini textboxlara aktarır.
        private void dgvStoklar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txturunbarkodGuncelle.Text= dgvStoklar.CurrentRow.Cells[1].Value.ToString();
            txturunadiGuncelle.Text = dgvStoklar.CurrentRow.Cells[2].Value.ToString();
            txtfiyatGuncelle.Text = dgvStoklar.CurrentRow.Cells[3].Value.ToString();
            txtbirimGuncelle.Text = dgvStoklar.CurrentRow.Cells[4].Value.ToString();
            txtstokGuncelle.Text = dgvStoklar.CurrentRow.Cells[5].Value.ToString();
            txtmarkaGuncelle.Text = dgvStoklar.CurrentRow.Cells[6].Value.ToString();
        }

        //txtarama değiştikçe bu aranan ürün bulunur.
        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM URUNLER WHERE URUNADI LIKE '%"+txtarama.Text+"%'", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvStoklar.DataSource = dt;
            baglanti.Close();   
          
        }
        //Formu kapatır.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Toplam kayıt sayısını lbltoplamKayıt ' a yazar.
        public void ToplamKayit()
        {
            int _toplamkayit=dgvStoklar.Rows.Count;
            lbltoplamKayıt.Text = "Toplam Kayıt: " + _toplamkayit.ToString();
        }

        //Butona tıklayınca kritik stokları turuncu renge çevirir.
        bool renklendirme = false;
        private void btnKritikStoklar_Click(object sender, EventArgs e)
        {
            renklendirme = !renklendirme;

            if (renklendirme)
            {
                foreach (DataGridViewRow row in dgvStoklar.Rows)
                {



                    // 5. kolondaki hücrenin değerini alır.
                    int hucreDegeri;
                    if (int.TryParse(row.Cells[5].Value.ToString(), out hucreDegeri))
                    {
                        // 10 ve daha az olan satırları kırmızı renge boyar.
                        if (hucreDegeri <= 10)
                        {

                            row.DefaultCellStyle.BackColor = Color.Orange;
                        }
                        else
                        {
                            // Eğer koşul sağlanmıyorsa, varsayılan arka plan rengini kullanır.
                            row.DefaultCellStyle.BackColor = dgvStoklar.DefaultCellStyle.BackColor;
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row1 in dgvStoklar.Rows)
                {
                    row1.DefaultCellStyle.BackColor = dgvStoklar.DefaultCellStyle.BackColor;
                }
            }

        }
    }
}
