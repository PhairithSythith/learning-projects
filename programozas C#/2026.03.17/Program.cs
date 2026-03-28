using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026._03._17_DE5JFI
{
    internal class Program
    {
            static Random random = new Random();

            public class Jatekos
            {
                private string nev;
                private string gondolt;

                public Jatekos(string nev)
                {
                    this.nev = nev;

                    switch (General(0, 2))
                    {
                        case 0: gondolt = "kő"; break;
                        case 1: gondolt = "papír"; break;
                        case 2: gondolt = "olló"; break;
                    }
                }

                public string GetGondolt()
                {
                    return gondolt;
                }

                private int General(int min, int max)
                {
                    return random.Next(min, max);
                }

                public override string ToString()
                {
                    return $"{nev} játékos gondolt eleme: {gondolt}";
                }
            }

            public class Jatek
            {
                private List<Jatekos> jatekosok;

                public Jatek(string[] nevek)
                {
                    jatekosok = new List<Jatekos>();

                    foreach (string nev in nevek)
                    {
                        jatekosok.Add(new Jatekos(nev));
                    }
                }

                public void Jatszma()
                {
                    Jatekos jatekos1 = jatekosok[0];
                    Jatekos jatekos2 = jatekosok[1];

                    Console.WriteLine(jatekos1);
                    Console.WriteLine(jatekos2);

                    string gondolt1 = jatekos1.GetGondolt();
                    string gondolt2 = jatekos2.GetGondolt();

                    if (gondolt1 == gondolt2)
                    {

                        Console.WriteLine("\nDöntetlen!\n");
                    }
                    else if (
                        (gondolt1 == "kő" && gondolt2 == "olló") || (gondolt1 == "papír" && gondolt2 == "kő") || (gondolt1 == "olló" && gondolt2 == "papír")
                    )
                    {
                        Console.WriteLine($"\n{jatekos1} nyert!\n");
                    }
                    else
                    {
                        Console.WriteLine($"\n{jatekos2} nyert!\n");
                    }
                }

                public void Jatekosok()
                {
                    foreach (Jatekos j in jatekosok)
                    {
                        Console.WriteLine(j);
                    }
                }
            }



            static void Main(string[] args)
            {

                string[] nevek = { "Lili", "Marci" };
                Jatek jatek = new Jatek(nevek);
                jatek.Jatszma();
                Console.WriteLine("Játékosok: ");
                jatek.Jatekosok();


            }
        }
    }
    
