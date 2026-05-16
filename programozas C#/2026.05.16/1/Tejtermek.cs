using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_1
{
    abstract internal class Tejtermek
    {
        public string Nev { get; set; }
        public string Gyarto { get; set; }
        public bool Laktozmentes { get; set; }
        public string Fajta { get; set; }
        public double Ar { get; set; }
        public Tejtermek(string fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Nev = adatok[1];
            Gyarto = adatok[2];
            Laktozmentes = bool.Parse(adatok[3]);
            Ar = double.Parse(adatok[4]);
            Fajta = Tipus();
        }
        public abstract string Tipus();

        public override string ToString()
        {
             return $"{Nev} ({Gyarto}) - {Fajta} - {(Laktozmentes ? "Laktozmentes" : "Nem laktozmentes")} - {Ar} Ft ";
        }
    }
}
