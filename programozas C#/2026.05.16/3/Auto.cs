using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_3
{
    internal class Auto : Jarmu
    {
        public int AjtokSzama { get; set; }
        public Auto(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            AjtokSzama = int.Parse(adatok[5]);
        }
        public override string Kategoria()
        {
            if (AjtokSzama <= 3)
            {
                Tipus = "Mini";
                return Tipus;
            }
            else
            {
                Tipus = "Családi";
                return Tipus;
            }
        }
        public override string ToString()
        {
             return base.ToString() + $", Ajtók száma: {AjtokSzama}";
        }
    }
}
