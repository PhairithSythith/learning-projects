using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_3
{
    internal class Sorozat : Media
    {
        public int EvadokSzama { get; set; }
        public Sorozat(string fajlSor) : base(fajlSor)
        {
            string[] fajlSorTomb = fajlSor.Split(';');
            EvadokSzama = int.Parse(fajlSorTomb[5]);
            Kategoria=Tipus();
        }
        public override string Tipus()
        {
            if (EvadokSzama >= 5) { return "Hosszú sorozat"; }
            else { return "Mini sorozat"; }
        }
    }
}
