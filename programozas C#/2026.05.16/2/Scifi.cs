using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_2
{
    internal class Scifi :Regeny, Kolcsonozheto
    {
        public string Bolygo { get; }
        public Scifi(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Bolygo = adatok[6];
        }
        public void Kolcsonzes()
        {
            switch(Bolygo)
            {
                case "Mars":
                    Ar= Ar*1.10;
                    break;
                case "Jupiter":
                    Ar= Ar*1.20;
                    break;
                case "Szaturnusz":
                    Ar= Ar*1.30;
                    break; 
            }
        }
         public override string Tipus()
        {
            return "Tudományos-fantasztikus";
        }
         public override string ToString()
        {
             return base.ToString()+ $", Bolygó: {Bolgyo}";
        }
    }
}
