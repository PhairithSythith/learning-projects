using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_3
{
    internal abstract class Jarmu
    {
       public string Rendszam { get; set; }
        public string Marka { get; set; }
        public int Evjarat { get; set; }
        public double Napidij { get; set; }
        public string Tipus { get; set; }
        public Jarmu(string fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Rendszam = adatok[1];
            Marka = adatok[2];
            Evjarat = int.Parse(adatok[3]);
            Napidij = double.Parse(adatok[4]);
        }
        public abstract string Kategoria();
        public override string ToString()
        {
            return $"Rendszám: {Rendszam}, Márka: {Marka}, Évjárat: {Evjarat}, Napidíj: {Napidij} Ft, Kategória: {Tipus}";
        }
    }
}
