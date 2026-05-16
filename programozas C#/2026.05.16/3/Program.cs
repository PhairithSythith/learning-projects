namespace _2026._05._16_otthon_gyak_3
{
    internal class Program
    {
        static public List<Jarmu> jarmuvek = new List<Jarmu>();
        static public bool Beolvas()
        {
            try
            {
                StreamReader sr = new StreamReader("vmi.txt");
                while (!sr.EndOfStream)
                {
                    string fajlSor = sr.ReadLine();
                    string[] adatok = fajlSor.Split(';');
                    switch (adatok[0])
                    {
                        case "a": Auto a = new Auto(fajlSor);
                            a.Kategoria();
                            jarmuvek.Add(a);
                            break;
                        case "aa": ElektromosAuto e = new ElektromosAuto(fajlSor);
                            e.Berles();
                            e.Kategoria();
                            jarmuvek.Add(e); break;
                        case "m": Motor m = new Motor(fajlSor);
                            m.Kategoria();
                            jarmuvek.Add(m); 
                            break;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba a történt fájlbeolvasás közben: " + e.Message);
                return false;
            }
        }
            static void Main(string[] args)
            {
                if (Beolvas())
                {
                    foreach (Jarmu j in jarmuvek)
                    {
                        Console.WriteLine(j);
                    }
                    Jarmu[] tomb = jarmuvek.ToArray();
                    Kolcsonzo kolcsonzo = new Kolcsonzo(tomb);
                    kolcsonzo.ElektromosAutok();
                    kolcsonzo.LegdragabbAuto();
                    kolcsonzo.UjJarmuvek();
                    kolcsonzo.AtlagMotor();
                }
                else
                {
                    Console.WriteLine("Nem sikerült beolvasni a fájlt.");
                }

            }
    }
}

