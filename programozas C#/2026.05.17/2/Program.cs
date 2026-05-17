namespace _2026._05._17_otthon_gyak_2
{
    internal class Program
    {
        public static List<Allat> allatok;
        public static bool Beolvas()
        {
            try
            {
                StreamReader sr = new StreamReader("allatok.txt");
                allatok = new List<Allat>();
                while(!sr.EndOfStream)
                {
                    string adatok = sr.ReadLine();
                    string[] sor = adatok.Split(';');
                    switch (sor[0]) { 
                        case "r": allatok.Add(new Ragadozo(adatok)); break;
                            case "m": allatok.Add(new Madar(adatok)); break;
                            case "p": allatok.Add(new Papagaj(adatok)); break;
                    }
                }
                Console.WriteLine("A fájl beolvasása sikeres.");
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
            if(Beolvas())
            {
                Allatkert allatkert = new Allatkert(allatok.ToArray());
                allatkert.Papagajok();
                allatkert.LegnehezebbRagadozo();
                allatkert.VedettAllatok();
                foreach(Allat allat in allatok)
                {
                   if(allat is Papagaj Pmadar)
                    {
                       Pmadar.Etet(Pmadar.KedvencEtel);
                    }
                }
            }
            else { Console.WriteLine("Nem sikerült beolvasni a fájlt."); }
        }
    }
}
