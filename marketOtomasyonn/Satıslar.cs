using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace marketOtomasyonn
{
    public partial class Satıslar : Form
    {
        public Satıslar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CRHOTCV\\SQLEXPRESS;Initial Catalog=MARKET;Integrated Security=True");
        private void Satıslar_Load(object sender, EventArgs e)
        {
            //Fişleri getirir.
            FisGetir();
            //KASA HESABI METODU
            GunlukCiro();
            mtxtTarih.Focus();
            //Bugünün tarihini getirir.
            mtxtTarih.Text = DateTime.Now.ToString();
        }
        //Günlük ciroyu getirme metodu
        private void GunlukCiro()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT SUM(FISTUTARI) FROM FISLER WHERE FISTARIHI = CONVERT(DATE,GETDATE())", baglanti);
            var ciro = komut.ExecuteScalar();
            btnCiro.Text = ciro.ToString() + " TL";
            baglanti.Close();
        }

        //Fişleri getirme metodu
        private void FisGetir()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FISLER", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvFısler.DataSource = dt;
            baglanti.Close();
        }

        private void dgvFısler_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("değişti");
        }

        //Seçili ürünü detaylarını getirir.
        private void button1_Click(object sender, EventArgs e)
        {

            dgvFısler.SelectionChanged += dgvFısler_SelectionChanged;

            int secilen_urun = Convert.ToInt32(dgvFısler.CurrentRow.Cells[0].Value.ToString());

            baglanti.Open();


            SqlCommand komut = new SqlCommand(
                 "SELECT FD.FISNO,FD.URUNBARKOD, FD.URUNADI, FD.ADET, FD.URUNFIYAT, FD.TOPLAMTUTAR " +
                   "FROM FISDETAY AS FD " +
                   "INNER JOIN FISLER AS F ON F.FISID = FD.FISID " +
                   "WHERE F.FISID = @secilenurun", baglanti);


            komut.Parameters.AddWithValue("@secilenurun", secilen_urun);

            SqlDataReader reader = komut.ExecuteReader();
            dgvSatisDetaylar.Rows.Clear();
            while (reader.Read())
            {
                
                string dfisno = reader["FISNO"].ToString();
                string urun_barkod = reader["URUNBARKOD"].ToString();
                string durunadi = reader["URUNADI"].ToString();
                int dadet = Convert.ToInt32(reader["ADET"]);
                decimal durunfiyat = Convert.ToDecimal(reader["URUNFIYAT"]);
                decimal dtoplamtutar = Convert.ToDecimal(reader["TOPLAMTUTAR"]);


                dgvSatisDetaylar.Rows.Add(dfisno,urun_barkod, durunadi, durunfiyat, dadet, dtoplamtutar);
            }

            baglanti.Close();
        }
        //Seçilen fişin silme işlemini yapar.
        private void button2_Click(object sender, EventArgs e)
        {



            if (dgvFısler.Rows.Count == 0)
            {
                MessageBox.Show("SİLİNECEK FİŞ KALMADI....");
            }

            else
            {

                baglanti.Open();
                if(dgvSatisDetaylar.Rows.Count<=0)
                {
                    MessageBox.Show("Fişin detaylarını getiriniz...");
                    baglanti.Close();

                }
                else
                {
                    foreach (DataGridViewRow veri in dgvSatisDetaylar.Rows)
                    {

                        string stokbarkod = veri.Cells["URUNBARKOD"].Value.ToString();
                        int iadeadet = Convert.ToInt32(veri.Cells["ADET"].Value);
                        SqlCommand stokGuncelle = new SqlCommand("UPDATE URUNLER SET STOK = STOK + @iadeadet WHERE BARKOD =@barkod", baglanti);
                        stokGuncelle.Parameters.AddWithValue("@iadeadet", iadeadet);
                        stokGuncelle.Parameters.AddWithValue("@barkod", stokbarkod);
                        stokGuncelle.ExecuteNonQuery();

                    }



                    string secilen_urun = dgvFısler.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand komut = new SqlCommand("DELETE FROM FISLER WHERE FISID=" + secilen_urun, baglanti);
                    DialogResult cevap = MessageBox.Show("Kayıt silinecek emin misiniz ?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (cevap == DialogResult.OK)
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("FİŞ  SİLİNDİ", "BİLGİLENDİRME");
                        baglanti.Close();
                        FisGetir();
                        GunlukCiro();
                    }
                    else
                    {
                        baglanti.Close();
                    }
                }
               

            }
            
        }
        //Tarihe göre fişleri getirir.
        private void button2_Click_1(object sender, EventArgs e)
        {
            string tarih = mtxtTarih.Text;
            string gun, ay, yıl;

            if (tarih =="")
            {
                MessageBox.Show("GÜN - AY - YIL OLACAK ŞEKİLDE TARİH GİRİNİZ...", "TARİH BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    gun = tarih.Substring(0, 2);
                    ay = tarih.Substring(3, 2);
                    yıl = tarih.Substring(6, 4);


                    string yeniTarih = yıl + "-" + ay + "-" + gun;

                    baglanti.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FISLER WHERE FISTARIHI LIKE '%" + yeniTarih + "%'", baglanti);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvFısler.DataSource = dt;




                    SqlCommand komut = new SqlCommand("SELECT SUM(FISTUTARI) FROM FISLER WHERE FISTARIHI LIKE  '%" + yeniTarih + "%'", baglanti);

                    var tarihCiro = komut.ExecuteScalar();

                    btnCiro.Text = tarihCiro.ToString() + " TL";

                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("TARİHİ GÜN - AY - YIL OLACAK ŞEKİLDE GİRİNİZ...","TARİH BİLGİSİ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                }

            }
 
        }

        //Bütün fişleri getirir.
        private void button3_Click(object sender, EventArgs e)
        {
            FisGetir();
            GunlukCiro();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtKasiyerSorgu.Visible = !txtKasiyerSorgu.Visible;
        }

        private void txtKasiyerSorgu_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FISLER WHERE KASİYER LIKE  '%" + txtKasiyerSorgu.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvFısler.DataSource = dt;
            baglanti.Close();
        }
    }
}
