using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Otomasyon
{
    public class Urun_ve_Adet
    {
        public Urun innerUrun;
        public int Adet { get; set; }
        public Urun_ve_Adet(Urun urun, int adet)
        {
            innerUrun = new Urun
            {
                Kod = urun.Kod,
                Kategori = urun.Kategori,
                Ad = urun.Ad,
                Agirlik = urun.Agirlik,
                Fiyat = urun.Fiyat,
            };
            Adet = adet;
        }
    }
}
