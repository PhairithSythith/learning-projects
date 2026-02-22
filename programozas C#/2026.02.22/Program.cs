using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026._002._22_otthongyak
{
    internal class Program
    {
        static Random rnd = new Random();
        static int osszeg = 0;
        static int kor = 0;
        static int gyozelem = 0;
        static int vereseg = 0;
        static int megallas = 0;
        static int dontetlen = 0;
        static int AIosszeg = 0;
        static int AIkor = 0;
        static int AIgyozelem = 0;
        static int AIdontetlen = 0;
        static int AIvereseg = 0;
        static int AImegallas = 0;
        static int General()
        { return rnd.Next(1,11); }

        static int Tipp()
        {
            do
            {
                Console.Write("Húzol lapot? (1-igen, 0-nem) ");
                string valasz = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                        if (valasz == "1")
                        {
                            return 1;
                        }
                        else if (valasz == "0")
                        {
                            return 0;
                        }
                        else
                        {
                            Console.WriteLine("Hibás válasz, próbáld újra!");
                        }
            } while (true);

        }

        static void Jatek()
        {
            osszeg = 0;
            AIosszeg = 0;
            kor = 0;
            AIkor = 0;

            bool jatekosMegallt = false;
            bool AIMegallt = false;

            while (true)
            {
                if (!jatekosMegallt)
                {
                    int lap = General();
                    int tipp = Tipp();
                    if (tipp == 1)
                    {
                        kor++;
                        osszeg += lap;
                        Console.WriteLine($"Húztál egy {lap}-es lapot. Összeg: {osszeg}");
                        if (osszeg > 21)
                        {
                            Console.WriteLine("Vesztettél! Összeg meghaladta a 21-et.");
                            vereseg++;
                            AIgyozelem++;
                            break;
                        }
                        else if (osszeg == 21)
                        {
                            Console.WriteLine("Gratulálok! Nyertél! Összeg: 21");
                            gyozelem++;
                            AIvereseg++;
                            break;
                        }
                    }
                    else
                    {
                        jatekosMegallt = true;
                        megallas++;
                        Console.WriteLine($"Megálltál. Összeg: {osszeg}");
                    }
                }

                if (!AIMegallt)
                {
                    if (AIosszeg < 17)
                    {
                        AIkor++;
                        int AIlap = General();
                        AIosszeg += AIlap;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"AI húzott egy {AIlap}-es lapot. Összeg: {AIosszeg}");
                        Console.WriteLine();
                        Console.ResetColor();

                        if (AIosszeg > 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Az AI vesztett! Összeg meghaladta a 21-et.");
                            Console.ResetColor();
                            AIvereseg++;
                            gyozelem++;
                            break;
                        }
                        else if (AIosszeg == 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Az AI nyert! Összeg: 21");
                            Console.ResetColor();
                            AIgyozelem++;
                            vereseg++;
                            break;
                        }
                    }
                    else
                    {
                        AIMegallt = true;
                        AImegallas++;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Az AI megállt. Összeg: {AIosszeg}");
                        Console.ResetColor();
                    }
                }

                if (jatekosMegallt && AIMegallt)
                {
                    if (osszeg == AIosszeg)
                    {
                        Console.WriteLine("Döntetlen! Mindketten ugyanazt az összeget értétek el.");
                        dontetlen++;
                        AIdontetlen++;
                    }
                    else if (osszeg > AIosszeg)
                    {
                        Console.WriteLine("Te nyertél az AI ellen!");
                        gyozelem++;
                        AIvereseg++;
                    }
                    else
                    {
                        Console.WriteLine("Az AI nyert ellened!");
                        AIgyozelem++;
                        vereseg++;
                    }
                    break;
                }
            }
        }



        static void Kiir()
        {
            Console.WriteLine();
            Console.WriteLine($"Statisztika: {gyozelem}. győzelem, {vereseg}. vereség, {megallas}. megállás, {dontetlen}. döntetlen");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"AI Statisztika: {AIgyozelem}. győzelem, {AIvereseg}. vereség, {AImegallas}. megállás, {AIdontetlen}. döntetlen");
            Console.ResetColor();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Jatek();
                Kiir();

                Console.Write("Szeretnél újra játszani? (igen/nem) ");
                string ujra = Console.ReadLine().Trim().ToLower();
                if (ujra == "nem")
                {
                    Console.WriteLine("Köszönöm, hogy játszottál! Viszlát!");
                    break;
                }
                else if (ujra != "igen")
                {
                    Console.WriteLine("Hibás válasz, próbáld újra!");
                }
            }

            /*
             * Feladat – „Húzzunk lapot 21-ig” konzolos játék
Készíts egy C# konzolos alkalmazást, amely egy egyszerű lap húzós játékot valósít meg.
A játék menete:
• A játékos egymás után lapokat húzhat.
• Minden lap értéke 1 és 10 közötti véletlen szám.
• A húzott lapok értéke összeadódik.
• A játékos minden körben eldönti, hogy:
o húz még egy lapot (1),
o vagy megáll (0).
• A játék addig tart, amíg:
o a játékos meg nem áll, vagy
o az összeg 21 fölé nem megy.
Játék kimenetek
A program a végén írja ki:
• Pont 21 → győzelem
• 21 alatt megáll → biztonságos megállás
• 21 fölé megy → vereség
Kötelező metódusok
A programot több metódusra bontva kell megírni.
Main
Feladat: a program belépési pontja, elindítja a játékot és kiírja az eredményt.
General
Feladat: generál egy véletlen számot 1 és 10 között (lap húzása).
Paraméter: nincs
Visszatérés: egész szám
Tipp
Feladat: bekéri a játékos döntését, hogy húz-e még lapot.
• Csak 0 vagy 1 lehet érvényes bemenet.
• Hibás bemenet esetén újra kérdez.
Paraméter: nincs
Visszatérés: egész szám (0 vagy 1)
Jatek
Feladat: a teljes játéklogika megvalósítása.
• Körök kezelése
• Lapok összegzése
• Játék leállási feltételek kezelése
• Játék eredményének meghatározása
Visszatérési érték jelentése:
• 2 - Pont 21 → győzelem
• 1 - 21 alatt megáll → biztonságos megállás
• 0 - 21 fölé megy → vereség
Paraméter: nincs
Visszatérés: egész szám
Kiir
Feladat: a játék eredményének kiírása a képernyőre.
• Győzelem
• Megállás
• Vereség
Paraméter: egész szám (a játék eredménye)
Visszatérés: nincs (void)
Extra:
• Írd ki a körök számát
• Legyen „Új játék?” kérdés
• Hibakezelés szöveges inputra
• AI ellenfél (aki 17-nél megáll)
• Statisztika: hány győzelem / vereség
             */

            Console.ReadKey();
        }
    }
}
