using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026._02._23_Otthon_gyak
{
    internal class Program
    {
        /*
         * Feladat – Nevek feldolgozása tömbben
Készíts egy C# konzolos alkalmazást, amely keresztneveket kér be a felhasználótól, majd
különböző műveleteket végez a neveken.
A program működése:
1. Bekér N darab keresztnevet (string).
2. Eltárolja őket egy tömbben.
3. Meghatározza:
o a nevek összes karakterének számát,
o a leghosszabb nevet,
o minden név monogramját (első + utolsó betű, nagybetűvel).
4. Kiírja az eredményeket.
Kötelező metódusok
Main
Feladat:
• Feltölti a neveket tartalmazó tömböt
• Meghívja a feldolgozó metódusokat
• Kiírja az eredményeket
Paraméter: string tömb
Visszatérés: nincs (void)
Nevek
Feladat: Bekér egy keresztnevet a felhasználótól.
Paraméter: nincs
Visszatérés: string (a beírt név)
Feltolt
Feladat: Létrehoz egy adott méretű string tömböt, majd feltölti nevekkel a Nevek metódus
segítségével.
Paraméter: egész szám (a nevek darabszáma)
Visszatérés: string tömb
HanyKarakter
Feladat: Összeszámolja, hogy a tömbben lévő nevek összesen hány karakterből állnak.
Paraméter: string tömb
Visszatérés: egész szám
LeghosszabbNev
Feladat: Megkeresi és visszaadja a tömbben szereplő leghosszabb nevet.
Paraméter: string tömb
Visszatérés: string
ElsoUtolso
Feladat: Minden névhez elkészíti a monogramot:
• első betű + utolsó betű
• nagybetűs formában
Az eredményt egy új string tömbben adja vissza.
Paraméter: string tömb
Visszatérés: string tömb
         */
        static string Nevek()
        {
            string Knev;
            string KulKarakterek = "0123456789!@#$%^&*()_+-=~`|\\:;\"'<>,.?/";
            do
            {
                Console.WriteLine("Írja be a keresztnevét: ");
                Knev = Console.ReadLine().Trim();
                if (Knev.Length < 2)
                {
                    Console.WriteLine("A keresztnevnek legalább 2 karakter hosszúnak kell lennie!");
                }
                else if (KulKarakterek.Any(Knev.Contains))
                {
                    Console.WriteLine("A keresztnev nem tartalmazhat számokat vagy speciális karaktereket!");
                }
                else
                {
                    break;
                }
            } while (true);
            return Knev;
        }

        static string[] Feltolt(int db)
        {
            string[] Nev = new string[db];
            for (int i = 0; i < db; i++)
            {
                Nev[i] = Nevek();
            }
            return Nev;

        }

        static int HanyKarakter(string[] Nev)
        {
            int db = 0;
            for (int i = 0; i < Nev.Length; i++)
            {
                db += Nev[i].Length;
            }
            return db;
        }

        static string LeghosszabbNev(string[] Nev)
        {
            string leghosszabb = Nev[0];
            for(int i=0;i<Nev.Length;i++)
            {
                if (Nev[i].Length > leghosszabb.Length)
                {
                    leghosszabb = Nev[i];
                }
            }
            return leghosszabb;
        }

        static string[] ElsoUtolso(string[] Nev)
        {
            string[] eu = new string[Nev.Length];
            for (int i = 0; i < Nev.Length; i++)
            {
                eu[i] = Nev[i][0].ToString().ToUpper() + Nev[i][Nev[i].Length - 1].ToString().ToUpper();
            }
            return eu;

        }

        static void Main(string[] args)
        {
            string db;
            int dbszam;
            bool jo;

            while (true)
            {
                Console.WriteLine("Hány darab nevet szeretne megadni? ");
                db = Console.ReadLine().Trim();

                jo = true;

                for (int i = 0; i < db.Length; i++)
                {
                    if (db[i] < '0' || db[i] > '9')
                    {
                        jo = false;
                    }
                }

                if (!jo)
                {
                    Console.WriteLine("Csak számot adhat meg!");
                }
                else
                {
                    dbszam = int.Parse(db);

                    if (dbszam <= 0)
                    {
                        Console.WriteLine("Nem lehet nulla vagy negatív!");
                    }
                    else
                    {
                        break;
                    }
                }
            }

            string[] Nev = Feltolt(dbszam);

            Console.WriteLine("Karakterek száma: " + HanyKarakter(Nev));

            Console.WriteLine("Leghosszabb név: " + LeghosszabbNev(Nev));
            string[] mono = ElsoUtolso(Nev);

            Console.WriteLine("Monogramok:");

            for (int i = 0; i < mono.Length; i++)
            {
                Console.WriteLine(mono[i]);
            }


            Console.ReadKey();
        }
    }
}
