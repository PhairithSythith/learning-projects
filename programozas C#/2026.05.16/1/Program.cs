using System.Text;

namespace _2026._05._16_otthon_gyak_1
{
    internal class Program
    {
        static List<Tejtermek> adatok = new List<Tejtermek>();

        static private bool Beolvas()
        {
            string sor;
            try
            {
                StreamReader input = new StreamReader("tejtermek.csv", Encoding.Default);
                while (!input.EndOfStream)
                {
                    sor = input.ReadLine();
                    string[] sd = sor.Split(';');

                    switch (sd[0])
                    {
                        case "b":
                            adatok.Add(new Sajt(sor));
                            break;
                        case "bb":
                            FustoltSajt fs= new FustoltSajt(sor);
                            fs.Fustolni();
                            adatok.Add(fs);
                            break;
                        case "c":
                            adatok.Add(new Joghurt(sor));
                            break;
                    }
                }
                Console.WriteLine("Az adatok beolvasása sikeres!");
                return true;
            }
            catch
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            if (Beolvas())
            {    
                Tejtermek[] adatTomb = adatok.ToArray();
                TejesPult tejesPult = new TejesPult(adatTomb);
                tejesPult.fustoltSajt();
                tejesPult.legdragabb();
                tejesPult.tartos();
                foreach (var a in adatok)
                {
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine("Hiba történt az adatok beolvasása közben!");
            }
        }
    }
}
