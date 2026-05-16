using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_4
{
    internal class Mutet :KorhaziBeteg, Gyogyithato
    {
        public string Sulyossag { get; set; }
        public Mutet(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Sulyossag = adatok[6];
        }
        public void Gyogyitas()
        {
            Allapot = Allapot + 50;
            Koltseg = Koltseg *1.2;
        }
        public override string KezelesTipus()
        {
            return "Műtéti";
        }
    }
}
