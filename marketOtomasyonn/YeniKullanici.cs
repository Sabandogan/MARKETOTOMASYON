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
    public partial class YeniKullanici : Form
    {
        public YeniKullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CRHOTCV\\SQLEXPRESS;Initial Catalog=MARKET;Integrated Security=True");
      
        //Yeni Kullanıcı formunu kapatır.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Veritabanına yeni kullanıcı ekler.
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtkullaniciadi.Text=="" || txtsifre.Text =="")
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ DOLDURUNUZ...", "YENİ KULLANICI EKLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO KULLANICILAR (KULLANICIADI , SIFRE) VALUES (@kullaniciadi,@sifre)", baglanti);
                komut.Parameters.AddWithValue("@kullaniciadi", txtkullaniciadi.Text);
                komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
                komut.ExecuteNonQuery();
                komut.Parameters.Clear();
                baglanti.Close();
                MessageBox.Show("Kullancıcı Oluşturuldu!","BAŞARILI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                kullanıcıListele();
                txtkullaniciadi.Text = string.Empty;
                txtsifre.Text = string.Empty;
            }
        }

        private void YeniKullanici_Load(object sender, EventArgs e)
        {
            kullanıcıListele();
        }

        private void kullanıcıListele()
        {
            baglanti.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM KULLANICILAR", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvKullanıcılar.DataSource = dt;
            baglanti.Close();
        }


        //Listeden Seçilen kullanıcıyı veritabanından siler.
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secilen_kullanici = dgvKullanıcılar.CurrentRow.Cells[0].Value.ToString();
            SqlCommand komut = new SqlCommand("DELETE FROM KULLANICILAR WHERE ID =" + secilen_kullanici, baglanti);
            DialogResult cevap = MessageBox.Show("Kullanıcı silinecek emin misiniz ?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (cevap == DialogResult.OK)
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("KULLANICI SİLİNDİ", "BİLGİLENDİRME");
                baglanti.Close();
                kullanıcıListele();
            }
            else
            {
                baglanti.Close();
            }
        }
    }
}
