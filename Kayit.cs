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

namespace Siparis_Otomasyon
{
    public partial class Kayit : Form
    {
        public bool KayitDenetimi { get;  set; }
        public Musteri musteri;
        public Kayit()
        {
            InitializeComponent();
        }
        
        private void btnKayit_Click(object sender, EventArgs e)
        {
            if ((tbAd.Text != "" && tbSifre.Text != "")  && 
                (tbSifre.Text == tbSifreTekrar.Text))
            {
                int id = Data.IDKontrol("Otomasyon",
                    "SELECT * FROM girisBilgileri where ID=@id",
                    "@id");
                Data.VeriEkle("Otomasyon",
                    "INSERT INTO girisBilgileri (Ad,Sifre,ID)values (@ad,@sifre,@id)",
                    "@ad", tbAd.Text.ToString(),
                    "@sifre", tbSifre.Text.ToString(),
                    "@id",id);
                KayitDenetimi = true;
                musteri = new Musteri()
                {
                    MusteriAd = tbAd.Text,
                    MusteriSifre = tbSifre.Text,
                    MusteriID = id,
                };
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor/Şifre alanları boş","Uyarı!",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
