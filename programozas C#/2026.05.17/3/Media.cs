using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_3
{
    internal abstract class Media
    {
        public string Cim { get; set; }
        public string Kiado { get; set; }
        public int Hossz { get; set; }
        public bool Premium { get; set; }
        public string Kategoria { get; set; }
        public Media(string fajlSor)
        {
            string[] fajlSorTomb = fajlSor.Split(';');
            Cim = fajlSorTomb[1];
            Kiado = fajlSorTomb[2];
            Hossz = int.Parse(fajlSorTomb[3]);
            Premium = bool.Parse(fajlSorTomb[4]);
        }
        public abstract string Tipus();
        public override string ToString()
        {
            return $"Cím: {Cim}, Kiadó: {Kiado}, Hossz: {Hossz} perc, Prémium: {(Premium ? "Premium" : "Ingyenes")}, Kategória: {Kategoria}";
        }
    }
}
