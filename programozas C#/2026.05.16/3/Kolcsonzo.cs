using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace _2026._05._16_otthon_gyak_3
{
    internal class Kolcsonzo
    {
        List<Jarmu> jarmuvek= new List<Jarmu>();
        public Kolcsonzo(Jarmu[] tomb)
        {
            foreach (Jarmu j in tomb)
            {
                jarmuvek.Add(j);
            }
        }
        public void ElektromosAutok()
        {
            foreach(Jarmu j in jarmuvek)
            {
                if (j is ElektromosAuto)
                {
                    Console.WriteLine(j);
                }
            }
        }
        public void LegdragabbAuto()
        {
            double m = 0;
            Jarmu legdragabb = null;
            foreach (Jarmu j in jarmuvek)
            { 
                    if (j is Auto && !(j is ElektromosAuto) && j.Napidij > m)
                    {
                        m = j.Napidij;
                        legdragabb = j;
                    } 
            }
            Console.WriteLine(legdragabb);
        }
        public void UjJarmuvek()
        {
            foreach (Jarmu j in jarmuvek)
            {
                if (j.Evjarat >= 2020)
                {
                    Console.WriteLine(j);
                }
            }
        }
        public void AtlagMotor()
        {
            double ossz = 0;
            int db = 0;
            foreach (Jarmu j in jarmuvek)
            {
                if (j is Motor)
                {
                    ossz += j.Napidij;
                    db++;
                }
            }
            if (db > 0)
            {
                Console.WriteLine("Átlagos napi díj a motorokra: " + (ossz / db));
            }
            else
            {
                Console.WriteLine("Nincs motor.");
            }
        }
    }
}
