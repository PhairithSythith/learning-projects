using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_4
{
    internal class Korhaz
    {
        List<Beteg> betegek = new List<Beteg>();
        public Korhaz(Beteg[] adatTomb)
        {
            foreach (Beteg b in adatTomb)
            {
                betegek.Add(b);
            }
        }
        public void SurgosEsetek()
        {
            foreach (Beteg b in betegek)
            {
                if (b is SimaBeteg s && s.Allapot<50)
                {
                    Console.WriteLine(b);
                }
            }
        }
        public void LegdragabbBeteg()
        {
            double m = 0;
            Beteg legdragabb = null;
            foreach (Beteg b in betegek)
            {
                if (!(b is Mutet))
                {
                    if (b.Koltseg > m)
                    {
                        m = b.Koltseg;
                        legdragabb = b;
                    }
                }
            }
            if (legdragabb != null)
                Console.WriteLine("Legdrágább beteg: " + legdragabb);
            else Console.WriteLine("Nincs megfelelő beteg");
        }
        public void GyengeAllapot()
        {
            foreach (Beteg b in betegek)
            {
                if (b.Allapot < 40)
                {
                    Console.WriteLine(b);
                }
            }
        }
        public void AtlagKoltseg()
        {
            double ossz = 0;
            int db = 0;
            foreach (Beteg b in betegek)
            {
                if (b is KorhaziBeteg)
                {
                    ossz += b.Koltseg;
                    db++;
                }
            }
            Console.WriteLine("Átlag költség: " + (ossz / db));
        }
    }
}
