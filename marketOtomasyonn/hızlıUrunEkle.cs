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

namespace marketOtomasyonn
{
    public partial class hızlıUrunEkle : Form
    {
        public hızlıUrunEkle()
        {
            InitializeComponent();
        }
        //Formu kapatır
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CRHOTCV\\SQLEXPRESS;Initial Catalog=MARKET;Integrated Security=True");

       //Ürünü veritabanına kaydeder.
        private void btnurunKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtBarkod.Text == "" || txturunAdi.Text == "" || txturunFiyat.Text == "" || txturunBirimi.Text == "" || txturunStok.Text == "" || txturunMarka.Text == "")
                {
                    MessageBox.Show("LÜTFEN BİLGİLERİ TAM DOLDURUNUZ....", "ÜRÜN EKLEME UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Temizle();

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
                    MessageBox.Show("Kayıt Eklendi!", "KAYIT EKLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("LÜTFEN SAYISAL VERİLERİ DOĞRU BİR ŞEKİLDE GİRİNİZ.");
                baglanti.Close();
            }

            catch (SqlException ex2)
            {

                MessageBox.Show("LÜTFEN SAYISAL VERİLERİ DOĞRU BİR ŞEKİLDE GİRİNİZ.");
                baglanti.Close();
            }




        }
        //Textboxları temizler.
        private void Temizle()
        {
            txtBarkod.Text = string.Empty;
            txturunAdi.Text = string.Empty;
            txturunFiyat.Text = string.Empty;
            txturunBirimi.Text = string.Empty;
            txturunStok.Text = string.Empty;
            txturunMarka.Text = string.Empty;
        }

        //Barkod verisini hızlı ürün ekle formuna gönderir.
        private void hızlıUrunEkle_Load(object sender, EventArgs e)
        {
            txtBarkod.Text = Stoklar.gelenveri;
        }
    }
    
}
