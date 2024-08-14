using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    internal class BulasikMakinesi:BeyazEsya
    {

        public double IcHacim;
        public int ProgramSayisi;

        public override string Yazdir()
        {
            return base.Yazdir() + "\nİç Hacim = " + IcHacim + "\nProgram Sayısı = " + ProgramSayisi; 
        }
    }
}
