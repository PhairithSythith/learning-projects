using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026._03._02_Otthon_gyak
{
    internal class Program
    {

        static int kor;
        static int osszeg;
        static int gyoz;
        static int veszit;
        static int megall;
        static int AIkor;
        static int AIosszeg;
        static int AIgyoz;
        static int AIveszit;
        static int AImegall;
        static int dontetlen;
        static Random rnd = new Random();

        static int General()
        {
            return rnd.Next(1, 11);
        }

        static int Tipp()
        {
            string dontes;
            do
            {
                Console.Write("Húz még lapot? 1-igen, 0-nem:   ");
                dontes = Console.ReadLine().Trim();
                Console.WriteLine();
                if (dontes != "1" && dontes != "0")
                    Console.WriteLine("Hibás bemenet! Próbálja újra!");
            } while (dontes != "1" && dontes != "0");
            return Convert.ToInt32(dontes);
        }

        static int Jatek()
        {
            bool emberMegallt = false;
            bool AIMegallt = false;
            kor = 0;
            AIkor = 0;
            while (!emberMegallt || !AIMegallt)
            {
                if (!emberMegallt)
                {
                    int tipp = Tipp();
                    if (tipp == 1)
                    {
                        int lap = General();
                        osszeg += lap;
                        kor++;
                        Console.WriteLine($"{kor}. körben a {lap} lapot húztad. Összeg: {osszeg}");
                        if (osszeg >= 21) emberMegallt = true;
                    }
                    else
                    {
                        emberMegallt = true;
                        megall++;
                        Console.WriteLine("Megálltál.\n");
                    }
                }

                if (!AIMegallt)
                {
                    if (AIosszeg < 17)
                    {
                        int AIlap = General();
                        AIosszeg += AIlap;
                        AIkor++;
                        Console.WriteLine($"{AIkor}. körben az AI a {AIlap} lapot húzta. Összeg: {AIosszeg}\n");
                        if (AIosszeg >= 17)
                        {
                            AIMegallt = true;
                            AImegall++;
                            Console.WriteLine("AI megállt.\n");
                        }
                    }
                    else
                    {
                        AIMegallt = true;
                        AImegall++;
                        Console.WriteLine("AI megállt.\n");
                    }
                }

                if (osszeg > 21 || AIosszeg > 21) break;
            }

            if (osszeg == 21)
            {
                gyoz++;
                AIveszit++;
                return 2;
            }
            else if (AIosszeg == 21)
            {
                veszit++;
                AIgyoz++;
                return 0;
            }
            else if (osszeg > 21 && AIosszeg <= 21)
            {
                veszit++;
                AIgyoz++;
                return 0;
            }
            else if (AIosszeg > 21 && osszeg <= 21)
            {
                gyoz++;
                AIveszit++;
                return 2;
            }
            else if (osszeg > AIosszeg)
            {
                gyoz++;
                AIveszit++;
                return 2;
            }
            else if (AIosszeg > osszeg)
            {
                veszit++;
                AIgyoz++;
                return 0;
            }
            else
            {
                dontetlen++;
                return 3;
            }
        }

        static void Kiir(int eredmeny)
        {
            if (eredmeny == 0) Console.WriteLine("Vesztettél!");
            if (eredmeny == 1) Console.WriteLine("Biztonságosan megálltál!");
            if (eredmeny == 2) Console.WriteLine("Győztél!");
            if (eredmeny == 3) Console.WriteLine("Döntetlen!");
            Console.WriteLine($"Győzelem: {gyoz}, Vesztés: {veszit}, Megállás: {megall}, Döntetlen: {dontetlen}");
            Console.WriteLine($"AI győzelem: {AIgyoz}, AI vesztés: {AIveszit}, AI megállás: {AImegall}, Döntetlen: {dontetlen}");
        }

        static void Main(string[] args)
        {
            string valasz;
            do
            {
                int eredmeny = Jatek();
                Kiir(eredmeny);
                Console.WriteLine();
                Console.WriteLine("Szeretnél újra játszani?");
                valasz = Console.ReadLine().Trim().ToLower();
                if (valasz == "igen")
                {
                    osszeg = 0;
                    AIosszeg = 0;
                }
                else break;
            } while (true);
        }
    }
}
