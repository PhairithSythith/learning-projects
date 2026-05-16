using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_4
{
    internal class SimaBeteg : Beteg
    {
        public SimaBeteg(string fajlSor) : base(fajlSor){}
        public override string KezelesTipus()
        {
            if (Allapot < 50)
            {
                return "Sürgős";
            }
            else { return "Normál"; }
        }
    }
}
