using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_1
{
    internal class HusPult
    {
        List<Hus> husok;
        public HusPult(Hus[] hus)
        {
            husok = new List<Hus>(hus);
        }
        public void FustoltHus()
        {
            foreach(Hus hus in husok)
            {
                if(hus is FustoltHus)
                {
                    Console.WriteLine(hus);
                }
            }
        }
        public void LegdragabbHus()
        {
            double max = 0;
            Hus husi= null;
            foreach(Hus hus in husok)
            {
                if (hus is TokeHus && !(hus is FustoltHus))
                {
                    if (hus.Ar > max)
                    {
                        max = hus.Ar;
                        husi = hus;
                    }
                }
            }
            Console.WriteLine("Legdrágább: "+husi);
        }
        public void Tartos()
        {
            foreach(Hus hus in husok)
            {
                if(hus is TokeHus tokeHus && (tokeHus.Fogyaszthato == "augusztus" || tokeHus.Fogyaszthato == "szeptember" || tokeHus.Fogyaszthato == "október" || tokeHus.Fogyaszthato == "november" || tokeHus.Fogyaszthato == "december"))
                {
                    Console.WriteLine("Legalább augusztusig fogyasztható húsok: "+hus);
                }
            }
        }
    }
}
