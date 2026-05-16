using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_2
{
     abstract internal class Konyv
    {
        public string Cim { get; set; }
        public string Szerzo { get; set; }
        public int Ev { get; set; }
        public double Ar { get; set; }
        public string Mufaj { get; set; }
        public Konyv(string fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Cim = adatok[1];
            Szerzo = adatok[2];
            Ev = int.Parse(adatok[3]);
            Ar = double.Parse(adatok[4]);
            Mufaj = Tipus();
        }
        public abstract string Tipus();

        public override string ToString()
        {
             return $"Cím: {Cim}, SzerzŐ: {Szerzo}, Kiadás éve: {Ev}, Ár: {Ar} Ft, Műfaj: {Mufaj)}";
        }
     }
}
