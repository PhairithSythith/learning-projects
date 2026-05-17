using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_1
{
    internal class FustoltHus : TokeHus, Fustolo
    {
        public string Fa { get; }
        public FustoltHus(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Fa = adatok[6];
        }
        public void Fustol(string fa)
        {
            switch (fa) {
                case "bükk": Ar*=1.05; break;
                    case "tölgy": Ar*=1.15; break;
                    case "akác": Ar*=1.20; break;
                    case "dió": Ar*=1.25; break;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $", Füstöléshez használt fa: {Fa}";
        }
    }
}
