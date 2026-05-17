using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_3
{
    internal class Film : Media
    {
        public int Korhatar { get; set; }
        public Film(string fajlSor) : base(fajlSor)
        {
            string[] fajlSorTomb = fajlSor.Split(';');
            Korhatar = int.Parse(fajlSorTomb[5]);
        }
        public override string Tipus()
        {
            if(Korhatar==18) { return "Felnőtt film"; }
            else { return "Családi film"; }
        }
        public override string ToString()
        {
            return base.ToString() + $", Korhatár: {Korhatar}+";
        }
    }
}
