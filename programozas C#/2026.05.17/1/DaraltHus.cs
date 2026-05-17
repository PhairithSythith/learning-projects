using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_1
{
    internal class DaraltHus : Hus
    {
        public DaraltHus(string fajlSor) : base(fajlSor){}
        public override string Tipus()
        {
            return Koser ? "báránycomb" : "sertéscomb";
        }
    }
}
