using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using System.Data.SqlClient;

namespace Siparis_Otomasyon
{
    public partial class Login : Form
    {
        public bool KullaniciGirisDenetimi { get; set; }
        public bool YoneticiGirisDenetimi { get; set; }

        Kayit kayit;

        public Musteri musteri;

        public Login()
        {
            InitializeComponent();
            AyarDenetimi();
        }

        SqlConnection baglanti;
        DataTable dt;




        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisDenetimi();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void GirisDenetimi()
        {
            string ad = tbAd.Text;
            string sifre = tbSifre.Text;
            baglanti = new SqlConnection("Data Source=AbraA5V1584;Initial Catalog=Otomasyon;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM girisBilgileri WHERE Ad='"+tbAd.Text+
                "' AND Sifre='"+tbSifre.Text+"'",baglanti);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                KullaniciGirisDenetimi = true;
                AyarKaydet();
                musteri = new Musteri()
                {
                    MusteriID = Convert.ToInt32(dt.Rows[0]["ID"]),
                    MusteriAd = tbAd.Text,
                    MusteriSifre = tbSifre.Text,
                };
                    this.Close();
            }
            else if (ad == "admin" && sifre == "admin")
                    {
                YoneticiGirisDenetimi = true;
                        AyarKaydet();
                this.Close();
                    }
            else 
            {
                MessageBox.Show("Giriş Bilgileri Hatalı!\n" +
                    "Kaydol veya Yeniden Dene", "Uyarı!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void AyarDenetimi()
        {
            if(Properties.Settings.Default.AdSoyad != String.Empty)
            {
                if (Properties.Settings.Default.BeniHatirla == true)
                {
                    tbAd.Text = Properties.Settings.Default.AdSoyad;
                    tbSifre.Text = Properties.Settings.Default.Sifre;
                    cbBeniHatirla.Checked = true;
                }
                else
                {
                    tbAd.Text = Properties.Settings.Default.AdSoyad;
                }
            }
        }

        private void AyarKaydet()
        {
            if (cbBeniHatirla.Checked)
            {
                Properties.Settings.Default.AdSoyad = tbAd.Text;
                Properties.Settings.Default.Sifre = tbSifre.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.AdSoyad = "";
                Properties.Settings.Default.Sifre = "";
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }
        }

        private void lnkLblYeniKullanici_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayit = new Kayit();
            Hide();
            kayit.Show();
            kayit.FormClosed += new FormClosedEventHandler(KayitFormu_Kapandi);
        }

        void KayitFormu_Kapandi(object sender, FormClosedEventArgs e)
        {
            if (kayit.KayitDenetimi)
            {
                KullaniciGirisDenetimi = true;
                musteri = kayit.musteri;
                kayit.Dispose();
                Close();
            }

            else
            {
                Show();
                kayit.Dispose();
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
    }
}
