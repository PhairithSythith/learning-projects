using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_2
{
    internal class Allatkert
    {
        List<Allat> allatok;
        public Allatkert(Allat[] allat) {
            allatok = new List<Allat>(allat);
        }
        public void Papagajok()
        {
            foreach (Allat a in allatok)
            {
                if (a is Papagaj)
                {
                    Console.WriteLine(a);
                }
            }
        }
        public void LegnehezebbRagadozo()
        {
            double maxSuly = 0;
            Ragadozo legnehezebb = null;
            foreach (Allat a in allatok)
            {
                if (a is Ragadozo r && r.Suly > maxSuly)
                {
                    maxSuly = r.Suly;
                    legnehezebb = r;
                }
            }
            if (legnehezebb != null)
            {
                Console.WriteLine("A legnehezebb ragadozó:");
                Console.WriteLine(legnehezebb);
            }
        }
        public void VedettAllatok()
        {
            Console.WriteLine("Védett állatok:");
            foreach (Allat a in allatok)
            {
                if (a.Vedett)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
