using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_1
{
    internal class TejesPult
    {
        List<Tejtermek> termekek;
        public TejesPult(Tejtermek[] termek)
        {
            termekek = new List<Tejtermek>(termek);
        }
        public void fustoltSajt()
        {
            foreach (Tejtermek t in termekek)
            {
                if (t is FustoltSajt)
                {
                    Console.WriteLine(t);
                }
            }
        }
        public void legdragabb()
        {
            double maxAr = 0;
            Tejtermek legdragabb = null;
            foreach (Tejtermek t in termekek)
            {
                if (t is Sajt && !(t is FustoltSajt))
                {
                    if (t.Ar > maxAr)
                    {
                        maxAr = t.Ar;
                        legdragabb = t;
                    }
                }
            }
            Console.WriteLine($"A legdrágább termék: {legdragabb}");
        }
        public void tartos()
        {
            foreach (Tejtermek t in termekek)
            { 
                if(t is Sajt s && (s.Fogyaszthato == "augusztus" || s.Fogyaszthato=="szeptember" || s.Fogyaszthato=="október" || s.Fogyaszthato=="november" || s.Fogyaszthato=="december"))
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
