using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    internal class CamasırMakinesi:BeyazEsya
    {

        public string YikamaKapasitesi;
        public bool Kurutma;

        public override string Yazdir()
        {
            return base.Yazdir() + "\nYikama Kapasitesi = " + YikamaKapasitesi + "\nKurutma" + Kurutma;
        }
    }
}
