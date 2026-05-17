using System.Text;

namespace _2026._05._17_otthon_gyak_1
{
    internal class Program
    {
        static List<Hus> husik;
        public static bool Beolvas()
        {
            try
            {
                StreamReader husok_csv = new StreamReader("husok.csv", Encoding.Default);
                while (!husok_csv.EndOfStream)
                {
                    string sor = husok_csv.ReadLine();
                    string[] adatok = sor.Split(';');
                    switch (adatok[0])
                    {
                        case "b":
                            husik.Add(new TokeHus(sor));
                            break;
                        case "bb":
                            husik.Add(new FustoltHus(sor));
                            break;
                        case "c":
                            husik.Add(new DaraltHus(sor));
                            break;
                    }
                }
                Console.WriteLine("A beolvasás sikeres.");
                return true;

            }
            catch (Exception ex) {
                Console.WriteLine("HIBA: " + ex.Message);
                return false;
            }
        }
        static void Main(string[] args)
        {
            husik = new List<Hus>();
            if(Beolvas())
            {
                HusPult husPult = new HusPult(husik.ToArray());
                husPult.FustoltHus();
                husPult.LegdragabbHus();
                husPult.Tartos();
                foreach(Hus hus in husik)
                {
                    if(hus is FustoltHus fust)
                    {
                        fust.Fustol(fust.Fa);
                    }
                }
            }
            else
            {
                Console.WriteLine("A beolvasás nem sikerült.");
            }

            Console.ReadKey();

        }
    }
}
