using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Otomasyon
{
        public abstract class Payment
        {
            public abstract bool Onay { get; set; }
            public abstract void Dogrulama();

            public class Kart : Payment
            {
                public override bool Onay { get; set; }
                public override void Dogrulama()
                {
                    this.Onay = true;
                }
            }

            public class Nakit:Payment
            {
                public override bool Onay { get; set; }
                public override void Dogrulama()
                {
                    this.Onay = true;
                }
            }

            public class Check : Payment
            {
                public override bool Onay { get; set; }
                public override void Dogrulama()
                {
                    this.Onay = true;
                }
            }

        }
}
