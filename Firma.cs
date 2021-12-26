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
    public partial class Firma : Form
    {
        public Firma()
        {
            InitializeComponent();
        }

        int siparisRow;
        DataGridView dgw;

        private void Firma_Load(object sender, EventArgs e)
        {
            Customize_design();
            btnSiparisler_Click(sender, e);
        }

        private void Customize_design()
        {
            panelYanMenu.Visible = true;
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            btnSiparisler_Click(sender, e);
        }


        private void btnPanel_Click(object sender, EventArgs e)
        {
            if (panelYanMenu.Visible == true)
            {
                panelYanMenu.Visible = false;
                btnPanel.Text = ">";
            }
            else if (panelYanMenu.Visible == false)
            {
                panelYanMenu.Visible = true;
                btnPanel.Text = "<";
            }
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            panelOrtaInnerSol.Visible = true;
            panelOrtaInnerSol.Dock = DockStyle.Fill;
            Data.DataGridViewDoldur("Siparisler", "SELECT * FROM SiparislerListesi", dgwSol);
            panelOrtaInnerOrta.Visible = false;
            panelOrtaInnerSag.Visible = false;
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            panelOrtaInnerOrta.Visible = true;
            panelOrtaInnerOrta.Dock = DockStyle.Fill;
            Data.DataGridViewDoldur("Otomasyon", "SELECT *FROM Urun", dgwOrta);
            panelOrtaInnerSol.Visible = false;
            panelOrtaInnerSag.Visible = false;
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            panelOrtaInnerSag.Visible = true;
            panelOrtaInnerSag.Dock = DockStyle.Fill;
            Data.DataGridViewDoldur("Otomasyon", "SELECT * FROM girisBilgileri", dgwSag);
            panelOrtaInnerOrta.Visible = false;
            panelOrtaInnerSol.Visible = false;
        }

        

        private void dgwSiparisler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                siparisRow = e.RowIndex;
                panelOrtaInnerSol.Dock = DockStyle.Fill;
                panelOrtaInnerOrta.Visible = true;
                panelOrtaInnerSag.Visible=false;
                panelOrtaInnerOrta.Dock = DockStyle.Right;
                string siparisID = dgwSol.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblDeneme1.Text = siparisID;
                Data.DataGridViewDoldur("Siparisler", " SELECT * FROM " + siparisID, dgwOrta);
            }

        }

        private void dgwUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (panelOrtaInnerSol.Visible == true)
                {
                    panelOrtaInnerSag.Visible = true;
                    panelOrtaInnerSol.Visible = false;
                    panelOrtaInnerOrta.Dock = DockStyle.Fill;
                    panelOrtaInnerSag.Dock = DockStyle.Right;
                    string musteriID = dgwSol.Rows[siparisRow].Cells[1].Value.ToString();
                    Data.DataGridViewDoldur("Otomasyon", "SELECT * FROM girisBilgileri WHERE ID='" + musteriID + "'", dgwSag);
                }
            }
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunEkle();
            btnUrunler.Click += new EventHandler(btnUrunler_Click);
            btnUrunler_Click(sender, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(dgw != null && dgw.SelectedRows.Count > 0)
            {
                    if (dgw == dgwSol)
                    {
                        foreach (DataGridViewRow row in dgw.SelectedRows)
                        {
                            Data.VeriSil("Siparisler",
                            "DELETE FROM SiparislerListesi WHERE SiparisID=@siparisid",
                            "@siparisid", row.Cells["SiparisID"].Value.ToString());
                            Data.TabloSil(row.Cells["SiparisID"].Value.ToString());
                        }
                        btnSiparisler_Click(sender, e);
                    }
                    else if (dgw == dgwOrta)
                    {
                        if((panelOrtaInnerOrta.Dock == DockStyle.Fill && panelOrtaInnerSag.Visible == true) ||
                            panelOrtaInnerSol.Visible == true && panelOrtaInnerOrta.Dock == DockStyle.Right)
                        {
                            foreach (DataGridViewRow row in dgw.SelectedRows)
                            {
                                Data.VeriSil("Siparisler",
                                "DELETE FROM "+
                                Convert.ToString(dgwSol.Rows[dgwSol.CurrentCell.RowIndex].Cells["SiparisID"].Value)
                                +" WHERE Kod=@urunkod",
                                "@urunkod", row.Cells["Kod"].Value.ToString());
                            }
                            btnUrunler_Click(sender, e);
                        }
                        else
                        {
                            foreach (DataGridViewRow row in dgw.SelectedRows)
                            {
                                Data.VeriSil("Otomasyon",
                                "DELETE FROM Urun WHERE Kod=@urunkod",
                                "@urunkod", row.Cells["Kod"].Value.ToString());
                            }
                            btnUrunler_Click(sender, e);
                        }
                    }
                    else if (dgw == dgwSag)
                    {
                        foreach (DataGridViewRow row in dgw.SelectedRows)
                        {
                            Data.VeriSil("Otomasyon",
                            "DELETE FROM girisBilgileri WHERE ID=@id",
                            "@id", row.Cells["ID"].Value.ToString());
                        }
                        btnMusteriler_Click(sender, e);
                    }
                }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(dgw != null && 
                dgw.SelectedRows.Count == 1 && 
                dgw.CurrentCell.RowIndex > 0)
            {
                if(dgw == dgwOrta)
                {
                    Data.VeriEkle("Otomasyon",
                "UPDATE Urun SET Kategori=@kategori, Ad=@urunad, Agirlik=@urunagirlik, Fiyat=@urunfiyat WHERE Ad=@urunad",
                cbKategori.SelectedItem.ToString(),
                "@urunad", tbAd.Text.ToString(),
                "@urunagirlik", Convert.ToInt32(tbAgirlik.Text),
                "@urunfiyat", Convert.ToDouble(tbFiyat.Text));
                    Data.DataGridViewDoldur("Otomasyon", "SELECT *FROM Urun", dgwOrta);
                }else if(dgw == dgwSag)
                {
                    Data.VeriEkle("Otomasyon",
                "UPDATE Urun SET Kategori=@kategori, Ad=@urunad, Agirlik=@urunagirlik, Fiyat=@urunfiyat WHERE Ad=@urunad",
                cbKategori.SelectedItem.ToString(),
                "@urunad", tbAd.Text.ToString(),
                "@urunagirlik", Convert.ToInt32(tbAgirlik.Text),
                "@urunfiyat", Convert.ToDouble(tbFiyat.Text));
                    Data.DataGridViewDoldur("Otomasyon", "SELECT *FROM Urun", dgwOrta);
                }
            }
        }

        public void UrunEkle()
        {
            int kod = Data.IDKontrol("Otomasyon", 
                "SELECT * FROM Urun where Kod=@kod",
                    "@kod");
            if (tbAd.Text != "" &&
                tbAgirlik.Text != "" &&
                tbFiyat.Text != "")
            {
                Data.VeriEkle("Otomasyon",
                    "INSERT INTO Urun (Kod,Kategori,Ad,Agirlik,Fiyat)values (@urunkodu,@kategori,@urunad,@urunagirlik,@urunfiyat)",
                    "@urunkodu", kod,
                    "@kategori", cbKategori.SelectedItem.ToString(),
                    "@urunad", tbAd.Text,
                    "@urunagirlik", Convert.ToDouble(tbAgirlik.Text),
                    "@urunfiyat", Convert.ToDouble(tbFiyat.Text));
            }
            else
            {
                MessageBox.Show("Lütfen Kod, Kategori, Agirlik ve Fiyat bilgisi giriniz.",
                    "Eksik Bilgi!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void dgwOrta_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgwSol_Enter(object sender, EventArgs e)
        {
            dgw = dgwSol;
        }

        private void dgwOrta_Enter(object sender, EventArgs e)
        {
            dgw = dgwOrta;
        }

        private void dgwSag_Enter(object sender, EventArgs e)
        {
            dgw = dgwSag;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
