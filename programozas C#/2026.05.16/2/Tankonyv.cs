using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_2
{
    internal class Tankonyv : Konyv
    {
        public Tankonyv(string fajlSor) : base(fajlSor){}
        public override string Tipus()
        {
            if (Ev < 2020) { return "Régi tankönyv"; }
            else { return "Modern tankönyv"; }
        }
    }
}
