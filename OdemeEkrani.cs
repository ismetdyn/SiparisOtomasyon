using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis_Otomasyon
{
    public partial class OdemeEkrani : Form
    {
        
        public OdemeEkrani()
        {
            InitializeComponent();
        }
        
        private void OdemeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void tbAdSoyad_TextChanged(object sender, EventArgs e)
        {
            lAdSoyad.Text = tbAdSoyad.Text;
        }

        private void mtbKartNo_KeyUp(object sender, KeyEventArgs e)
        {
            lKartNo.Text = mtbKartNo.Text;
        }

        private void cbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lSKT.Text = cbAy.Text + "/" + cbYil.Text;
        }

        private void cbYil_SelectedIndexChanged(object sender, EventArgs e)
        {
            lSKT.Text = cbAy.Text + "/" + cbYil.Text;
        }

        private void mtbCvv_KeyUp(object sender, KeyEventArgs e)
        {
            lCVV.Text = mtbCvv.Text;
        }

        private void tbAd_TextChanged(object sender, EventArgs e)
        {
            lblAd.Text = tbAd.Text;
        }

        private void tbBanka_TextChanged(object sender, EventArgs e)
        {
            lblBanka.Text = tbBanka.Text;
        }

       
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOdemeYapCard_Click(object sender, EventArgs e)
        {
            Payment.Kart kart = new Payment.Kart();
            kart.Dogrulama();
            if (kart.Onay)
            {
                MusteriMenu.OdemeYapildimi = true;
                MusteriMenu.OdemeTuru = "Kart";
                this.Close();
            }
        }

        private void btnOdemeYapCheck_Click(object sender, EventArgs e)
        {
            Payment.Check check = new Payment.Check();
            check.Dogrulama();
            if (check.Onay)
            {
                MusteriMenu.OdemeYapildimi = true;
                MusteriMenu.OdemeTuru = "Check";
                this.Close();
            }
        }

        private void btnEldenOdeme_Click(object sender, EventArgs e)
        {
            Payment.Nakit nakit = new Payment.Nakit();
            if (chckbxElden.Checked)
            {
                nakit.Dogrulama();
                if (nakit.Onay)
                {
                    MusteriMenu.OdemeYapildimi = true;
                    MusteriMenu.OdemeTuru = "Nakit";
                    this.Close();
                }
            }
        }
    }
}
