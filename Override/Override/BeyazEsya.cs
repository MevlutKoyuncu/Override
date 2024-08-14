using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    internal class BeyazEsya
    {

        public string Marka;
        public string Model;
        public double Fiyat;

        public virtual string Yazdir()
        {
            return Marka + " - " + Model + "\nFiyat = " + Fiyat + " TL";
        }
    }
}
