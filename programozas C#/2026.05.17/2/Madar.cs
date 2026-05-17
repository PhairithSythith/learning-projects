using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_2
{
    internal class Madar : Allat
    {
        public int Szarnyfesztav { get; set; }
        public Madar(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Szarnyfesztav = int.Parse(adatok[5]);
        }
        public override string Tipus()
        {
            if (Vedett == true)
            { return "Sas"; }
            else return "Galamb";
        }
        public override string ToString()
        {
            return base.ToString() + $", Szárnyfesztáv: {Szarnyfesztav} cm";
        }
    }
}
