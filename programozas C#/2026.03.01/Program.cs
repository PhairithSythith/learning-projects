using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026._03._01_Otthon_gyak2
{
    internal class Program
    {

       static int lap = 0;
        static int tipp = 0;
        static int kor = 1;
        static int megvan = 0;
        static int nyert = 0;
        static int vesztett = 0;
        static int megallt = 0;
        static int AIlap = 0;
        static int AIkor = 1;
        static int AImegvan = 0;
        static int AInyert = 0;
        static int AIvesztett = 0;
        static int AImegallt = 0;
        static int Dontetlen = 0;

        static Random rnd= new Random();
        static int General()
        { return rnd.Next(1,11); }
        static int Tipp()
        {
            string valasz;
            while (true)
            {
                Console.WriteLine("Húzol lapt? (1-igen, 0-nem)");
                valasz = Console.ReadLine().Trim();
                Console.WriteLine();
                if (valasz == "1" || valasz == "0")
                { return Convert.ToInt32(valasz); }
                else Console.WriteLine("Hibás bemenet! Próbálja újra!");
                Console.WriteLine();
            }
        }
            
        static int Jatek()
        {
            int eredmeny;
            tipp = 1;

            while (megvan<21&& tipp==1||AImegvan<17)
            {
                if (megvan < 21)
                {
                    tipp = Tipp();
                    if (tipp == 1)
                    {
                        lap = General();
                        megvan += lap;
                        Console.WriteLine($"Te {kor}. kör. A húzott lap: {lap}, a lapok összege: {megvan}");
                        kor++;
                    }
                }
                else if(tipp==0 && megvan<=21)
                { megallt++; }
                if (AImegvan < 17)
                {
                        AIlap = General();
                        AImegvan += AIlap;
                        Console.WriteLine($"AI {AIkor}. kör. AI húzott lap: {AIlap}, a lapok összege: {AImegvan}");
                        Console.WriteLine();
                        AIkor++;
                }
                if (megvan >= 21 && AImegvan >= 21) break;
            }
            if (megvan > 21 && AImegvan > 21)
            {
                vesztett++;
                AIvesztett++;
                eredmeny = 0; 
            }
            else if (megvan > 21)
            {
                vesztett++;
                if (AImegvan <= 21) AInyert++;
                eredmeny = 0;
            }
            else if (AImegvan > 21)
            {
                nyert++;
                AIvesztett++;
                eredmeny = 2;
            }
            else if (megvan == AImegvan)
            {
                Dontetlen++;
                eredmeny = 3;
            }
            else if (megvan > AImegvan)
            {
                nyert++;
                AIvesztett++;
                eredmeny = 2;
            }
            else
            {
                vesztett++;
                AInyert++;
                eredmeny = 0;
            }
            if (megvan <= 21 && eredmeny == 0 && AImegvan < 21)
            {
                megallt++;
                eredmeny = 1; 
            }
            if (AImegvan <= 21 && AImegvan >= 17 && eredmeny != 2 && eredmeny != 0 && eredmeny != 3)
            {
                AImegallt++;
            }
            return eredmeny;
        }
        static void Kiir(int eredmeny)
        {
            if (eredmeny == 2)
                Console.WriteLine($"Gratulálok nyertél!");
            else if (eredmeny == 0)
                Console.WriteLine("Sajnálom, vesztettél!");
            else if (eredmeny == 1)
                Console.WriteLine("Biztonságosan megálltál!");
            else if (eredmeny == 3)
                Console.WriteLine("Döntetlen!");
            Console.WriteLine($"Győzelem: {nyert}, Vesztett: {vesztett}, Biztonságosan megállt: {megallt}, Döntetlen: {Dontetlen}");
            Console.WriteLine($"AI győzelem: {AInyert}, AI vesztett: {AIvesztett}, AI biztonságosan megállt: {AImegallt}, Döntetlen: {Dontetlen}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int eredmeny = Jatek();
            Kiir(eredmeny);
            string ujJatek;
            while (true) 
            {
                Console.WriteLine("Szeretnél újra játszani? ");
                ujJatek = Console.ReadLine().Trim().ToLower();
                if (ujJatek == "igen")
                {
                    kor = 1;
                    lap = 0;
                    megvan = 0;
                    tipp = 0;
                    AIkor = 1;
                    AIlap = 0;
                    AImegvan = 0;
                    Console.WriteLine();
                    eredmeny=Jatek();
                    Kiir(eredmeny);
                }
                else if (ujJatek == "nem")
                { Console.WriteLine("Köszönöm a játékot!"); }
                else Console.WriteLine("Hibás bemenet! Próbálja újra!");
                Console.WriteLine();

            } 
            

        }
    }
}
