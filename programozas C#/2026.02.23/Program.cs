using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026._02._23_Otthon_gyak_2
{
    internal class Program
    {
        static int dobasokSzama = 0;
        static int osszegDobas = 0;
        static Random rnd = new Random();
     
        static int Dobas()
        {
            return rnd.Next(1, 7);
        }

        static int Tipp()
        {
            while (true) 
            {
                Console.Write ("Szeretnél dobni? (1-igen, 0-nem) ");
                string valasz = Console.ReadLine().Trim();
                if (valasz == "0")
                {
                    return 0;
                }
                else if (valasz == "1")
                {
                    return 1;
                }
                else
                {
                    Console.WriteLine("Kérem, adjon meg egy érvényes választ! (1-igen, 0-nem)");
                }

            } 
        }

        static int Jatek()
        {
            while (true)
            {
                int tipp = Tipp();
                if (tipp == 0)
                {   
                    break;
                }
                else if (tipp == 1)
                {
                    int dobas = Dobas();
                    dobasokSzama++;
                    osszegDobas += dobas;
                    Console.WriteLine($"Dobás eredménye: {dobas}, {dobasokSzama}. dobásnál tartasz, dobások összege eddig: {osszegDobas}");
                    Console.WriteLine();
                    if (osszegDobas == 30)
                    {
                        return 2;
                    }
                    else if (osszegDobas > 30)
                    {
                        return 1;
                    }
                   /* else if (osszegDobas < 30)
                    {
                        continue;
                    }*/
                }
            }
            return 0;
        }

        static void Kiir(int eredmeny)
        {
            
            if (eredmeny == 2)
            {
                Console.WriteLine($"Gratulálok, nyertél! Ennyi dobásból érted el: {dobasokSzama}");
            }
            else if (eredmeny == 1)
            {
                Console.WriteLine($"Sajnos vesztettél! Ennyi dobásból érted el: {dobasokSzama}");
            }
            else if (eredmeny == 0)
            {
                Console.WriteLine($"Biztonságosan megálltál. Ennyi dobásból érted el: {dobasokSzama}");
            }
            
            Console.WriteLine("Köszönöm, hogy játszottál!");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int eredmeny = Jatek();
                Kiir(eredmeny);
                Console.WriteLine();
                Console.WriteLine("Szeretnél újra játszani? (igen/nem)");
                string ujra = Console.ReadLine().Trim().ToLower();
               if (ujra =="nem")
                {
                    Console.WriteLine("Viszlát!");
                    break;
                }
                else if (ujra == "igen")
                {
                    dobasokSzama = 0;
                    osszegDobas = 0;
                    Console.WriteLine("Kezdődik az új játék!");

                }
                
            }
        }
    }
}
