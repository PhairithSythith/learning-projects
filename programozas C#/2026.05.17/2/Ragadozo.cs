using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_2
{
    internal class Ragadozo : Allat
    {
        public bool VadaszikEjszakan { get; set; }
        public Ragadozo(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            VadaszikEjszakan = bool.Parse(adatok[5]);
        }
        public override string Tipus()
        {
            if (Vedett)
            {
                return "Oroszlán";
            }
            else return "Hiéna";
        }
        public override string ToString()
        {
            return base.ToString() + $", Vadászik éjszaka: {(VadaszikEjszakan ? "igen" : "nem")}";
        }
    }
}
