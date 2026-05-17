using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_3
{
    internal class Anime : Sorozat, ILejatszhato
    {
        public bool Szinkronos { get; set; }
        public Anime(string fajlSor) : base(fajlSor)
        {
            string[] fajlSorTomb = fajlSor.Split(';');
            Szinkronos = bool.Parse(fajlSorTomb[6]);
        }
        public void Lejatszas()
        {
            Console.WriteLine($"Lejátszás elindítva....");
        }
        public void Megallit()
        {
            Console.WriteLine($"Lejátszás megállítva....");
        }
        public override string Tipus()
        {
            if (Szinkronos) { return "Szinkronos anime"; }
            else { return "Feliratos anime"; }
        }
    }
}
