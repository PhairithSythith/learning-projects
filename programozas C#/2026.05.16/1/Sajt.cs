using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_1
{
    internal class Sajt : Tejtermek
    {
        public string Fogyaszthato { get; set; }
        public Sajt(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Fogyaszthato = adatok[5];
        }
        public override string Tipus()
        {
            if(Laktozmentes==true)
            {
                return "Tömb sajt";
            }
            else
            {
                return "Kocka sajt";
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()} - Szavatossági idő: {Fogyaszthato}";
        }
    }
}
