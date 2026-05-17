namespace _2026._05._17_otthon_gyak_3
{
    internal class Program
    {
        static List<Media> mediaLista;
        static bool Beolvas()
        {
            try
            {
                StreamReader sr = new StreamReader("media.txt");
                mediaLista = new List<Media>();
                while (!sr.EndOfStream)
                {
                    string fajlSor = sr.ReadLine();
                    string[] fajlSorTomb = fajlSor.Split(';');
                        switch(fajlSorTomb[0]) {
                        case "f":
                            mediaLista.Add(new Film(fajlSor));
                            break;
                        case "s":
                            mediaLista.Add(new Sorozat(fajlSor));
                            break;
                        case "a":
                            mediaLista.Add(new Anime(fajlSor));
                            break;
                        }
                }
                sr.Close();
                Console.WriteLine("A fájl beolvasása sikeres.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba a fájl beolvasása közben: {ex.Message}");
                return false;
            }
        }
        static void Main(string[] args)
        {

            if(Beolvas())
            {
                StreamingPlatform platform = new StreamingPlatform(mediaLista.ToArray());
                Console.WriteLine("Animék:");
                platform.Animek();
                Console.WriteLine("\nLeghosszabb film:");
                platform.LeghosszabbFilm();
                Console.WriteLine("\nPremium tartalmak:");
                platform.PremiumTartalmak();
                Console.WriteLine("\nÁtlag hossz:");
                platform.AtlagHossz();
                foreach(Media m in mediaLista)
                {
                    if(m is Anime a)
                    {
                        a.Lejatszas();
                        a.Megallit();
                    }
                }
            }
            else { Console.WriteLine("A fájl beolvasása sikertelen."); }

            Console.ReadKey();
            
        }
    }
}
