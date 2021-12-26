using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Otomasyon
{
    public class Siparis
    {
        public List<Urun_ve_Adet> sepet { get; private set; }
        public DateTime SiparisTarihi { get; private set; }
        public Musteri musteri;
        public enum Durum
        {
            OlusturulduOdemeYapilmadi = 1,
            OlusturulduOdemeYapildi = 2,
            SiparisKargoyaVerildi = 3,
        } 
        public  Durum SiparisDurumu { get; set; }
        public Siparis(List<Urun_ve_Adet> sepet, Musteri musteri)
        {
            this.sepet = new List<Urun_ve_Adet>();
            sepet.ForEach((item) =>
            {
                this.sepet.Add(item);
            });
            this.musteri = new Musteri()
            {
                MusteriID = musteri.MusteriID,
                MusteriAd = musteri.MusteriAd,
                MusteriSifre = musteri.MusteriAdres,
                MusteriAdres = musteri.MusteriAdres,
            };
            SiparisDurumu = Durum.OlusturulduOdemeYapildi;
            SiparisTarihi = DateTime.Now;
        }

        public float NetTutarHesapla()
        {
            float toplam = 0;

            sepet.ForEach((item) =>
           {
               toplam += item.innerUrun.Fiyat * item.Adet;
           });

            return toplam;
        }

        public float VergiHesapla()
        {   
            return NetTutarHesapla()*18/100;
        }

        public float BrutTutarHesapla()
        {
            return NetTutarHesapla() + VergiHesapla();
        }

        public int ToplamAgirlikHesapla()
        {
            int toplam = 0;

            sepet.ForEach(item =>
            {
                toplam = item.innerUrun.Agirlik * item.Adet;
            });

            return toplam;
        }
    }
}
