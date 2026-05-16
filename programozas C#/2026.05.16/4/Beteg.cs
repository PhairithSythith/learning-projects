using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_4
{
    internal abstract class Beteg
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public int Allapot { get; set; }
        public double Koltseg { get; set; }
        public string Tipus { get; set; }
        public Beteg(string fajlSor) {
            string[] adatok = fajlSor.Split(';');
            Nev = adatok[1];
            Kor = int.Parse(adatok[2]);
            Allapot = int.Parse(adatok[3]);
            Koltseg = double.Parse(adatok[4]);
            Tipus = KezelesTipus();
        }
        public abstract string KezelesTipus();
        public override string ToString()
        {
             return $"Név: {Nev}, Kor: {Kor} éves, Állapot: {Allapot}, Költség: {Koltseg} Ft, Kezelés típusa: {Tipus}";
        }
    }
}
