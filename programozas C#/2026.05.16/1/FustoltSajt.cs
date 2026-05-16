using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_1
{
    internal class FustoltSajt : Sajt, Fustol
    {
        public string Fa { get; }
        public FustoltSajt(string fajlSor) : base(fajlSor)
        {   
             string[] adatok = fajlSor.Split(';');
             Fa = adatok[6];
        }
        public void Fustolni()
        {
            switch(Fa) {
                case "bükk":
                    Ar=Ar*1.15;
                    break;
                case "tölgy":
                    Ar=Ar*1.25;
                    break;
                case "akác":
                    Ar=Ar*1.30;
                    break;
                case "dió": 
                    Ar=Ar*1.35;
                    break;
            }
        }
        public override string Tipus()
        {
            return "Füstölt sajt";
        }
        public override string ToString()
        {
            return base.ToString() + $" - Füstölő fa: {Fa}";
        }
    }
}
