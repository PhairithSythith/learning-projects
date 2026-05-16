using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_2
{
    internal class Konyvtar
    {
        List<Konyv> konyvek;
        public Konyvtar(Konyv[] konyvs)
        {
            konyvek = new List<Konyv>(konyvs);
        }
        public void scifiKonyvek()
        {
            foreach(Konyv k in konyvek)
            {
                if (k is Scifi)
                {
                    Console.WriteLine(k);
                }
            }
        }
        public void legdradabbRegeny()
        {
            double maxAr = 0;
            Regeny r = null;
            foreach (Konyv k in konyvek)
            {
                if (k is Regeny re && !(k is Scifi))
                {
                    if (re.Ar > maxAr)
                    {
                        maxAr = re.Ar;
                        r = re;
                    }
                }
            }
            Console.WriteLine(r);
        }
        public void modernKonyvek()
        {
            foreach(Konyv k in konyvek)
            {
                if(k is Tankonyv t && t.Tipus() == "Modern tankönyv")
                {
                    Console.WriteLine(t);
                }
            }
        }
    }
}
