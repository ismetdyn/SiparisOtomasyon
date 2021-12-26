using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis_Otomasyon
{
    public class Urun
    {
        public int Kod { get; set; }
        public string Kategori { get; set; }
        public string Ad { get; set; }
        public int Agirlik { get; set; }
        public float Fiyat { get; set; }
    }
}
