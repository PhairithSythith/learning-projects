using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2026._03._20_Otthon_gyak_zh
{
    internal class Program
    {
        static Random random=new Random();
        static int nyer1, veszit1, dontetlen;
        static int nyer2, veszit2;
        class Jatekos
        {
            string nev;
            string gondolt;
            //int szamlaloV = 0;
            //int szamlaloD = 0;
            //int szamlaloGY = 0;
            
            public Jatekos(string nev)
            {
                this.nev = nev;
                switch (KoPapirOlloGyikSpock(General(0, 4)))
                {
                    case "kő": gondolt = "kő"; break;
                    case "papír": gondolt = "papír"; break;
                    case "olló": gondolt = "olló"; break;
                    case "gyík": gondolt = "gyík"; break;
                    case "spock": gondolt = "spock"; break;
                }

            }
            public string GetGondolt() { return gondolt; }
            public string KoPapirOlloGyikSpock(int n)
            { string[] kap = { "kő", "papír", "olló", "gyík", "spock" };
                return kap[n];
            }
            public int General(int min, int max)
            { return random.Next(min,max+1); }
            public override string ToString()
            {
                return $"{this.nev} játékos gondolt eleme: {this.gondolt}";
            }
        }

        class Jatek
        {
            public List<Jatekos> jatekosok;
            public Jatek(string[] nevek)
            {
                jatekosok = new List<Jatekos>();
                foreach(string n in nevek)
                { 
                    jatekosok.Add(new Jatekos(n));  
                }
            }

            public void Jatszma(int korSzam)
            {
                Jatekos jatekos1 = jatekosok[0];
                Jatekos jatekos2= jatekosok[1];
                Console.WriteLine($"Játékos 1: {jatekos1}\nJátékos 2: {jatekos2} ");
                string gondolas1=jatekos1.GetGondolt();
                string gondolas2=jatekos1.GetGondolt();
                for (int i = 0; i < korSzam; i++)
                {
                    if (gondolas1 == gondolas2)
                    {
                        dontetlen++;
                        Console.WriteLine("Döntetlen!");
                    }
                    else if (gondolas1 == "olló" && gondolas2 == "papír" || gondolas1 == "papír" && gondolas2 == "kő" ||
                    gondolas1 == "kő" && gondolas2 == "gyík" || gondolas1 == "gyík" && gondolas2 == "spock" ||
                    gondolas1 == "spock" && gondolas2 == "olló" || gondolas1 == "olló" && gondolas2 == "gyík" ||
                    gondolas1 == "gyík" && gondolas2 == "papír" || gondolas1 == "papír" && gondolas2 == "spock" ||
                    gondolas1 == "spock" && gondolas2 == "kő" || gondolas1 == "kő" && gondolas2 == "olló")
                    {
                        nyer1++;veszit2++;
                        Console.WriteLine($"Ezt a kört {jatekos1} nyerte! A gondolása: {gondolas1}");
                    }
                    else { nyer2++; veszit1++;
                        Console.WriteLine($"Ezt a kört {jatekos2} nyerte! A gondolása: {gondolas2}");
                    }
                }
            }
            public void Jatekosok()
            {
                foreach(Jatekos j in jatekosok)
                { Console.WriteLine($"{j} játékos "); } //eddig győzött: {}, vesztett: {}, és döntetlent játszott: {}
            }
        }

        class JatekIndit
        {
            public JatekIndit()
            {
                string[] nevek = { "Zoli", "Tita" };
                Jatek jatek = new Jatek(nevek);
                jatek.Jatszma(4);
                jatek.Jatekosok();
            }
        }

        static void Main(string[] args)
        {
            JatekIndit j=new JatekIndit();
        }
    }
}
