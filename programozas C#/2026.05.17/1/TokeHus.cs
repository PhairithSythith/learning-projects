using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_1
{
    internal class TokeHus : Hus
    {
        public string Fogyaszthato { get; set; }
        public TokeHus(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Fogyaszthato = adatok[5];
        }
        public override string Tipus()
        {
            return Koser ? "kecskecomb":"lapocka" ;
        }
        public override string ToString()
        {
            return base.ToString() + $", Fogyasztható: {Fogyaszthato}";
        }
    }
}
