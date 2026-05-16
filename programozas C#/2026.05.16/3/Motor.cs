using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_3
{
    internal class Motor : Jarmu
    {
        public bool Sport { get; set; }
        public Motor(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Sport = bool.Parse(adatok[6]);
        }
        public override string Kategoria() {
            if (Sport) { 
             Tipus = "Sportmotor";
                return Tipus;
            }
            else
            {
                Tipus = "Túramotor";
                return Tipus;
            }
        }
    }
}
