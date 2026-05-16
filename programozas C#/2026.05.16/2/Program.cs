using System.Runtime.InteropServices;

namespace _2026._05._16_otthon_gyak_2
{
    internal class Program
    {
        public static List<Konyv> konyvek = new List<Konyv>();
        public static bool Beolvas()
        {
            try
            {
                StreamReader be= new StreamReader("konyvek.txt");
                while (!be.EndOfStream)
                {
                    string sor = be.ReadLine();
                    string[] adatok = sor.Split(';');
                    switch (adatok[0])
                    {
                        case "b": konyvek.Add(new Regeny(sor)); break;
                        case "bb": 
                            Scifi sc = new Scifi(sor);
                            sc.Kolcsonzes();
                            konyvek.Add(sc);
                            break;
                        case "c": konyvek.Add(new Tankonyv(sor)); break;
                    }
                }
                Console.WriteLine("Az adatok beolvasása sikeres.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hiba a fájl beolvasásakor: {e.Message}");
                return false;
            }
        }
        static void Main(string[] args)
        {
            if (Beolvas())
            {
                foreach(Konyv k in konyvek)
                {
                    Console.WriteLine(k);
                }
                Konyv[] adatTomb = konyvek.ToArray(); ;
                Konyvtar konyvtar = new Konyvtar(adatTomb);
                konyvtar.scifiKonyvek();
                konyvtar.legdradabbRegeny();
                konyvtar.modernKonyvek();
            }
            else
            {
                Console.WriteLine("Az adatok beolvasása sikertelen.");
            }
        }
    }
}
