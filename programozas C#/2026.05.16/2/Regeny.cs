using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_2
{
    internal class Regeny :Konyv
    {
        public int Oldalszam { get; set; }
        public Regeny(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Oldalszam = int.Parse(adatok[5]);
        }
        public override string Tipus()
        {
            if (Oldalszam < 300)
            {
                return "Kisregény";
            }
            else { return "Nagyregény"; }
        }
        public override string ToString()
        {
            return base.ToString()+ $", Oldalszám: {Oldalszam}";
        }
    }
}
