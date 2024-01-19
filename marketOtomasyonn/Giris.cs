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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CRHOTCV\\SQLEXPRESS;Initial Catalog=MARKET;Integrated Security=True");

        //Kullanıcı bilgisini kontrol eder var ise satış ekranını açar yoksa uyarı verir
        private void button1_Click(object sender, EventArgs e)
        {   
            string ad = txtkullanici.Text;
            string sifre = txtsifre.Text;

            if(txtkullanici.Text =="" || txtsifre.Text=="")
            {
                MessageBox.Show("Kullanıcı adı ve şifreyi eksizsin yazın","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
              

            else if(KullanıcıDogrula(ad,sifre))
            {
                SatısEkrani satısEkrani = new SatısEkrani(ad);
                this.Visible = false;

                satısEkrani.ShowDialog();
            }
           
            else
            {
                MessageBox.Show("Yetkisiz kullanıcı girişi","Hatalı Giriş",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        //Uygulamadan çıkış yapar
        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }


        //Veritabanında girilen değerde bir kullanıcı varmı bakan metottur.
        private bool KullanıcıDogrula(string ad , string sifre)
        {
            
            if(baglanti.State== ConnectionState.Closed)
            {
                baglanti.Open();
              
            }

            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM KULLANICILAR WHERE KULLANICIADI =@kullaniciadi AND SIFRE = @sifre", baglanti);

            komut.Parameters.AddWithValue("@kullaniciadi", ad);
            komut.Parameters.AddWithValue("@sifre", sifre);


            int sonuc = (int)komut.ExecuteScalar();

            return sonuc == 1;
        
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Yeni Kullanıcı oluşturma ekranına gider.
            YeniKullanici yeniKullanici = new YeniKullanici();
            yeniKullanici.ShowDialog();
        }

        
    }
}
