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
    public partial class MusteriMenu : Form
    {
        readonly Musteri musteri = Program.musteri;
        Siparis siparis;
        readonly Urun currentUrun = new Urun();
        Urun_ve_Adet currentUrunVeAdet;
        public static List<Urun_ve_Adet> sepet = new List<Urun_ve_Adet>();

        public static bool OdemeYapildimi { get; set; }
        public static string OdemeTuru { get; set; }

        public MusteriMenu()
        {
            InitializeComponent();
        }

        private void MusteriMenu_Load(object sender, EventArgs e)
        {
            Customize_design();
            Data.DataGridViewDoldur("Otomasyon", "SELECT *FROM Urun", dgwUrunler);
            ButonlariKapat();
            lDeneme.Text = musteri.MusteriAd + " " + musteri.MusteriSifre + " " + musteri.MusteriID;
        }


        private void Customize_design()
        {
            panelKategoriSubMenu.Visible = false;
            panelHesapSubMenu.Visible = false;
            panelYanMenu.Visible = true;
            panelSepet.Visible = false;
            dgwSiparisler.Visible = false;
            dgwUrunler.Dock = DockStyle.Fill;
        }

        private void HideSubMenu()
        {
            if(panelKategoriSubMenu.Visible == true)
                panelKategoriSubMenu.Visible=false;
            if(panelHesapSubMenu.Visible == true)
                panelHesapSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible=true;
            }
            else
            {
                subMenu.Visible=false;
            }
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

        private void btnKategori_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelKategoriSubMenu);
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            panelKategoriSubMenu.Visible = false;
            dgwSiparisler.Visible = true;
            dgwUrunler.Visible = false;
            dgwSiparisler.Dock = DockStyle.Fill;
            Data.DataGridViewDoldur(
                "Siparisler", 
                " SELECT * FROM SiparislerListesi WHERE MusteriID='"+ musteri.MusteriID+"'", dgwSiparisler);
        }

        private void dgwSiparisler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgwUrunler.Visible= true;
                dgwUrunler.Dock= DockStyle.Right;
                string siparisID = dgwSiparisler.Rows[e.RowIndex].Cells[0].Value.ToString();
                Data.DataGridViewDoldur("Siparisler", " SELECT * FROM " + siparisID, dgwUrunler);
            }
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelHesapSubMenu);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnSepet_Click(object sender, EventArgs e)
        {

            if(panelSepet.Visible == false)
            {
                panelSepet.Visible = true;
            }else if(panelSepet.Visible == true)
            {
                panelSepet.Visible=false;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHesabiSil_Click(object sender, EventArgs e)
        {
            DialogResult dr2;
            DialogResult dr = 
            MessageBox.Show("Hesabınız silinmek üzere ?", "Bilgilendirme",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                dr2 = MessageBox.Show("Emin misiniz? Bu adım geri alınamaz.", "Dikkat! Hesabınız silinmek üzere",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr2 == DialogResult.Yes)
                {
                    Data.VeriSil("Otomasyon", "DELETE FROM girisBilgileri WHERE ID=@id", "@id", musteri.MusteriID);
                    MessageBox.Show("Hesabınız Silindi.");
                    Application.Exit();
                }
            }
        }

        private void lbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwSiparisler.Visible = false;
            dgwUrunler.Visible = true;
            dgwUrunler.Dock = DockStyle.Fill;
            string str = lbKategori.SelectedItem.ToString();
            Data.DataGridViewDoldur("Otomasyon", " SELECT * FROM Urun WHERE Kategori LIKE '%" + str + "%'", dgwUrunler);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

            Data.DataGridViewDoldur("Otomasyon", " SELECT * FROM Urun WHERE Ad LIKE '%"
                + tbSearch.Text + "%' OR Kategori LIKE '%" +
                tbSearch.Text + "%'", dgwUrunler);
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            Data.DataGridViewDoldur("Otomasyon", "SELECT * FROM Urun", dgwUrunler);
            dgwSiparisler.Visible = false;
            dgwUrunler.Visible = true;
            dgwUrunler.Dock = DockStyle.Fill;
        }


        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            lvSepet.Items.Clear();
            SepetListesineEkle();
            SepetToListViewSepet();
            lblToplam.Text = "TOPLAM: " + SepetToplamHesapla();
            ButonlariAc();
        }

        private void btnSepettenCikar_Click(object sender, EventArgs e)
        {
            SepettenCikar();
            lvSepet.Items.Clear();
            SepetToListViewSepet();
            lblToplam.Text = "TOPLAM: " + SepetToplamHesapla();
            if(lvSepet.Items.Count == 0)
            {
                btnOnaylaVeIlerle.Enabled = false;
                btnSepettenCikar.Enabled = false;
                btnSepetiBosalt.Enabled = false;
            }
        }

        private void btnSepetiBosalt_Click(object sender, EventArgs e)
        {
            lvSepet.Items.Clear();
            sepet.Clear();
            lblToplam.Text = "TOPLAM: 0";
            btnOnaylaVeIlerle.Enabled = false;
            btnSepettenCikar.Enabled = false;
            btnSepetiBosalt.Enabled = false;
        }

        private float SepetToplamHesapla()
        {
            float toplam = 0;
            sepet.ForEach(item =>
            {
                toplam += item.Adet * item.innerUrun.Fiyat;
            });
            return toplam;
        }

        public void SepetListesineEkle()
        {
            bool icinde = false;
            if (sepet.Count != 0)
            {
                for(int i = 0; i < sepet.Count; i++)
                {
                    if (currentUrun.Kod == sepet[i].innerUrun.Kod)
                    {
                        sepet[i].Adet += (int)nudAdet.Value;
                        icinde = true;
                        break;
                    }
                }
                if (icinde == false)
                {
                    sepet.Add(new Urun_ve_Adet(currentUrun, (int)nudAdet.Value));
                }
            }
            else
            {
                currentUrunVeAdet = new Urun_ve_Adet(currentUrun, (int)nudAdet.Value);
                sepet.Add(currentUrunVeAdet);
            }
        }

        

        public void SepetToListViewSepet()
        {
            sepet.ForEach(item =>
            {
                string[] lvi = new[]
                {
                    Convert.ToString(item.innerUrun.Kod),
                    item.innerUrun.Ad,
                    Convert.ToString(item.innerUrun.Fiyat),
                    Convert.ToString(item.Adet),
                    Convert.ToString(item.Adet*item.innerUrun.Fiyat),
                };
                lvSepet.Items.Add(new ListViewItem(lvi));
            });
        }

        public void SepettenCikar()
        {
            if (lvSepet.SelectedItems.Count != 0)
            {
                for (int i = 0; i < lvSepet.SelectedItems.Count; i++)
                {
                    for (int y = 0; y < sepet.Count; y++)
                    {
                        if (lvSepet.SelectedItems[i].SubItems[1].Text ==
                            sepet[y].innerUrun.Ad)
                            sepet.RemoveAt(y);
                    }
                }
            }
        }
        private void btnOnaylaVeIlerle_Click(object sender, EventArgs e)
        {
            if (sepet.Count != 0)
            {
                OdemeEkrani childForm = new OdemeEkrani();
                openChildForm(childForm);
                ButonlariKapat();
                btnSepeteEkle.Enabled = false;
                activeForm.FormClosed += new FormClosedEventHandler(OdemeFormu_Kapandi);
            } 
        }

        void OdemeFormu_Kapandi(object sender, FormClosedEventArgs e)
        {
            btnSepeteEkle.Enabled = true;
            ButonlariAc();
            lblDeneme6.Text = OdemeYapildimi.ToString();
            SiparisOnay();
        }
        public void SiparisOnay()
        {
            if (OdemeYapildimi)
            {
                siparis = new Siparis(sepet, musteri)
                {
                    SiparisDurumu = Siparis.Durum.OlusturulduOdemeYapildi,
                };
                SiparisToVeritabani();
                MessageBox.Show("Siparişiniz Alınmıştır." +
                "");
                sepet.Clear();
                lvSepet.Items.Clear();
                OdemeYapildimi = false;
            }
            OdemeYapildimi = false;
        }
        private void SiparisToVeritabani()
        {
            string siparisid = SiparisIDKontrol();
            if (siparis != null)
            {
                Data.VeriEkle("Siparisler", "INSERT INTO SiparislerListesi (SiparisID,MusteriID,SiparisTarihi,SiparisDurumu,NetTutar,Vergi,BrutTutar,Aciklama)" +
                    " values (@siparisid,@musteriid,@siparistarihi,@siparisdurumu,@nettutar,@vergi,@bruttutar,@aciklama)",
                    "@siparisid", siparisid,
                    "@musteriid", siparis.musteri.MusteriID,
                    "@siparistarihi", Convert.ToString(siparis.SiparisTarihi),
                    "@siparisdurumu", siparis.SiparisDurumu,
                    "@nettutar", siparis.NetTutarHesapla(),
                    "@vergi", siparis.VergiHesapla(),
                    "@bruttutar", siparis.BrutTutarHesapla(),
                    "@aciklama", "deneme");

                Data.TabloOlustur(siparisid);

                siparis.sepet.ForEach(item =>
                {
                    Data.VeriEkle("Siparisler", "INSERT INTO " + siparisid +
                    " (Kod,Kategori,Ad,Agirlik,Fiyat,Adet)values (@kod,@kategori,@ad,@agirlik,@fiyat,@adet)",
                    "@kod", item.innerUrun.Kod,
                    "@kategori", item.innerUrun.Kategori,
                    "@ad", item.innerUrun.Ad,
                    "@agirlik", item.innerUrun.Agirlik,
                    "@fiyat", item.innerUrun.Fiyat,
                    "@adet", item.Adet);
                });
            }
        }

        void ButonlariKapat()
        {
            btnOnaylaVeIlerle.Enabled = false;
            btnSepetiBosalt.Enabled = false;
            btnSepettenCikar.Enabled = false;
        }

        void ButonlariAc()
        {
            btnOnaylaVeIlerle.Enabled = true;
            btnSepetiBosalt.Enabled = true;
            btnSepettenCikar.Enabled = true;
        }

        private string SiparisIDKontrol()
        {
            string siparisid = "S_" + musteri.MusteriID + "_0";
            DataTable dt;
            dt = Data.VeriCek("Siparisler", 
                "SELECT SiparisID FROM SiparislerListesi where SiparisID LIKE '%_" +
                Convert.ToString(musteri.MusteriID) + "_%'");
            if (dt.Rows.Count != 0)
            {
                List<string> listSiparisId = new List<string>();
                List<int> listSiparisNo = new List<int>();
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    listSiparisId.Add(Convert.ToString(dt.Rows[i]["SiparisID"]));
                    int index = listSiparisId[i].LastIndexOf("_");
                    listSiparisNo.Add(Convert.ToInt32(listSiparisId[i].Substring(index+1)));
                }

                listSiparisNo.Sort();
                listSiparisNo.Reverse();
                int sonSiparisNo = listSiparisNo[0];
                siparisid = "S_"+Convert.ToString(musteri.MusteriID)+"_"+Convert.ToString(sonSiparisNo+1);
            }

            return siparisid;
        }

        private void dgwUrunler_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentUrun.Kod = Convert.ToInt32(dgwUrunler.Rows[e.RowIndex].Cells[0].Value);
                currentUrun.Kategori = dgwUrunler.Rows[e.RowIndex].Cells[1].Value.ToString();
                currentUrun.Ad = dgwUrunler.Rows[e.RowIndex].Cells[2].Value.ToString();
                currentUrun.Agirlik = Convert.ToInt32(dgwUrunler.Rows[e.RowIndex].Cells[3].Value);
                currentUrun.Fiyat = (float)Convert.ToDouble(dgwUrunler.Rows[e.RowIndex].Cells[4].Value);
                lblDeneme3.Text = currentUrun.Kod.ToString() + "\n" +
                                  currentUrun.Kategori + "\n" +
                                  currentUrun.Ad + "\n" +
                                  currentUrun.Agirlik.ToString() + "\n" +
                                  currentUrun.Fiyat.ToString() + "\n";
            }
        }
    }
}
