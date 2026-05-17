using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_2
{
    internal abstract class Allat
    {
        public string Nev { get; set; }
        public string SzarmazasiHely { get; set; }
        public bool Vedett { get; set; }
        public double Suly { get; set; }
        public string Fajta { get; set; }
        public Allat(string fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Nev = adatok[1];
            SzarmazasiHely = adatok[2];
            Vedett = bool.Parse(adatok[3]);
            Suly = double.Parse(adatok[4]);
            Fajta = Tipus();
        }
        public abstract string Tipus();
        public override string ToString()
        {
            return $"Név: {Nev}, Származási hely: {SzarmazasiHely}, Védett: {(Vedett ? "védett" : "nem védett")}, Súly: {Suly} kg, Fajta: {Fajta}";
        }
    }
}
