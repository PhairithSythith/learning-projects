using System.Diagnostics.Metrics;

namespace _2026._05._16_otthon_gyak_4
{
    internal class Program
    {
        static List<Beteg> betegek = new List<Beteg>();
        static public bool Beolvas()
        {
            try
            {
                StreamReader streamReader = new StreamReader("betegadatok.txt");
                while (!streamReader.EndOfStream)
                {
                    string fajlSor = streamReader.ReadLine();
                    string[] adatok = fajlSor.Split(';');
                    switch(adatok[0]) {
                        case "a":
                            SimaBeteg sm= new SimaBeteg(fajlSor);
                            sm.KezelesTipus();
                            betegek.Add(sm);
                            break;
                        case "b":
                            KorhaziBeteg kb = new KorhaziBeteg(fajlSor);
                            kb.KezelesTipus();
                            betegek.Add(kb);
                            break;
                        case "bb":
                            Mutet m = new Mutet(fajlSor);
                            m.KezelesTipus();
                            betegek.Add(m);
                            break;
                        }
                    }
                streamReader.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba a fájl beolvasásakor: " + ex.Message);
                return false;
            }
        }
        static void Main(string[] args)
        {
            if (Beolvas())
            {

                Beteg[] beteg = betegek.ToArray();
                Korhaz korhaz = new Korhaz(beteg);

                foreach (Beteg b in beteg)
                {
                    if (b is Gyogyithato gy)
                    {
                        gy.Gyogyitas();
                    }
                }

                Console.WriteLine("Sürgős esetek:");
                korhaz.SurgosEsetek();
                Console.WriteLine("\nLegdrágább beteg:");
                korhaz.LegdragabbBeteg();
                Console.WriteLine("\nGyenge állapotú betegek:");
                korhaz.GyengeAllapot();
                Console.WriteLine("\nÁtlagos költség gyógyítható betegek esetén:");
                korhaz.AtlagKoltseg();

            }
            else
            {
                Console.WriteLine("A fájl beolvasása sikertelen.");
            }
        }
    }
}
