using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_1
{
    internal class Joghurt : Tejtermek
    {
        public Joghurt(string fajlSor) : base(fajlSor) { }
        public override string Tipus()
        {
            if (Laktozmentes == false  )
            {
                return "Poharas";
            }
            else { return "Dobozos"; }
        }

    }
}
