using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_1
{
    internal abstract class Hus
    {
        public string Megnevezes { get; set; }
        public string Szarmazas { get; set; }
        public bool Koser { get; set; }
        public string Fajta { get; set; }
        public double Ar { get; set; }
        public Hus(string fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Megnevezes = adatok[1];
            Szarmazas = adatok[2];
            Koser = bool.Parse(adatok[3]);
            Ar = double.Parse(adatok[4]);
            Fajta = Tipus();
        }
        public abstract string Tipus();
        public override string ToString()
        {
            return $"Név: {Megnevezes}, Származás: {Szarmazas}, Fajta: {Fajta}, Kóser: {(Koser ? "szarvasmarha" : "sertés")}, Ár: {Ar} Ft";
        }
    }
}
