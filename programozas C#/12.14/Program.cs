using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ea_otthongyak_12_14
{ public struct Eredmenyek
    {
        public string Nev, kategoria;
        public int kilometer, ido, sorszam;
    }

    public struct Kiirando
    {
        public string nev;
        public int ido;
    }
    internal class Program
    {
        static int z = 0;
        static Eredmenyek[] eredmenyek = new Eredmenyek[40];
        static Kiirando[] kiirando = new Kiirando[40];

        static bool Beolvas()
        {
            try
            {
                StreamReader futas_csv = new StreamReader("futas.csv", Encoding.Default);
            while (!futas_csv.EndOfStream)
            {
                string[] darabok = futas_csv.ReadLine().Split(';');
                eredmenyek[z].Nev = darabok[0];
                eredmenyek[z].sorszam = int.Parse( darabok[1]);
                eredmenyek[z].kilometer = int.Parse(darabok[2]);
                eredmenyek[z].ido = int.Parse(darabok[3]);
                eredmenyek[z].kategoria = darabok[4];
                z++;
            }
                futas_csv.Close();
                Console.WriteLine("0.Feladat\nAZ adatok beolvasása megtörtént!");
                return true;
            } 
            catch (Exception hiba)
            { Console.WriteLine("Hiba történt a fájlbeolvasás közben! "+hiba.Message);
                return false;
            }
        }

        static bool Kiir()
        {
            int t;
            int u = 0;
            bool jo;
            for (int i = 0; i < z; i++)
            {
                jo = false;
                for (t = 0; t < u; t++)
                {
                    if (eredmenyek[i].Nev == kiirando[t].nev)
                    {
                        jo = true; break;
                    }
                }
                if (jo)
                {
                    kiirando[t].ido += eredmenyek[i].ido;
                }
                else
                {
                    kiirando[u].nev = eredmenyek[i].Nev;
                    kiirando[u].ido = eredmenyek[i].ido;
                    u++;
                }
            }
            try
            {
                StreamWriter versenyzok_txt = new StreamWriter("versenyzok.txt", false, Encoding.Default);
                for (t = 0; t < u; t++)
                { versenyzok_txt.WriteLine(kiirando[t].nev +" "  + kiirando[t].ido +" perc"); }
                versenyzok_txt.Close();
                Console.WriteLine("A fájlkiírás megtörtént!");
                return true;
            } catch (Exception hiba)
            { Console.WriteLine("A fájlkiírás közben hiba történt! "+hiba.Message);
                return false;
            }

        }

        static void Main(string[] args)
        {
            if (Beolvas())
            {
                int gyors = int.MaxValue;
                Eredmenyek legjobb = new Eredmenyek();
                for (int i = 0; i < z; i++)
                {
                    if (eredmenyek[i].ido < gyors)
                    {
                        gyors = eredmenyek[i].ido;
                        legjobb = eredmenyek[i];
                    }
                }
                Console.WriteLine($"1.Feladat\nA leggyorsabb {legjobb.Nev}, {legjobb.sorszam}. futam, {legjobb.ido} perc volt.");

                Console.WriteLine("Írja be egy versenyző nevét: ");
                string beNev = Console.ReadLine().Trim();
                int kiloMeter = 0;
                int db = 0;
                for (int i=0;i<z;i++)
                {
                    if (beNev == eredmenyek[i].Nev)
                    { kiloMeter += eredmenyek[i].kilometer;
                        db++;
                    }
                }
                if (db != 0)
                {
                    Console.WriteLine($"2.Feladat\n{beNev} nevű versenyző összesen {kiloMeter} km-t futott.");
                }
                else
                { Console.WriteLine("2.Feladat\nIlyen nevű versenyző nem szerepel az adatokban!"); }

                int amatorDB = 0, amatorOszz = 0;
                int profiDB = 0, profiOssz = 0;
                for (int i = 0; i < z; i++)
                { 
                    if (eredmenyek[i].kategoria == "amator")
                    {
                        amatorDB++; amatorOszz += eredmenyek[i].ido;
                    }
                    if (eredmenyek[i].kategoria == "profi")
                    {
                        profiDB++; profiOssz += eredmenyek[i].ido;
                    }
                }
                Console.WriteLine($"3.Feladat\nAz amator kategoriában az átlagos idő: {Math.Round((double)amatorOszz/amatorDB),0} perc." +
                    $"\nA profi kategóriában az átlagos idő: {Math.Round((double)profiOssz/profiDB)} perc.");

             
            }
            if (Kiir())
            { }
            else
            { Console.WriteLine("Viszlát!"); }
            Console.ReadKey();
        }
    }
}
