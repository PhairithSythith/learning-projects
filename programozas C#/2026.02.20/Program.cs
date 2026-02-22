using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozosgyak2026._02._20
{
    internal class Program
    {

        static string Mozik()
        {
            string[] mozik = { "mozi1", "mozi2", "mozi3", "mozi4", "mozi5" };
            //Random rnd = new Random();
            //string mozik = mozik[rnd.Next(0, mozik.Length)];
            //return mozik;
            int rnd = new Random().Next(0, mozik.Length);
            return mozik[rnd];
        }

        static void Hetvege(bool a)
        {
            int dbJegy = new Random().Next(2, 9);
            //int dbJegy= rnd.Next(2, 9);ű
            int ar = 3200;
            if (a==true)
            {
                Console.WriteLine($"A jegyek ára 15%-al olcsóbban: {dbJegy * ar * 0.85} Ft");
            }
            else
            {
                Console.WriteLine($"A jegyek ára: {dbJegy * ar} Ft");
            }
        }

        static string[] General()
        {
            string[] jegy = new string[10];
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rnd = new Random();

            for (int i = 0; i < jegy.Length; i++)
            {
                char x1 = abc[rnd.Next(abc.Length)];
                char x2 = abc[rnd.Next(abc.Length)];
                char x3 = abc[rnd.Next(abc.Length)];
                char x4 = abc[rnd.Next(abc.Length)];

                int szam = rnd.Next(0, 10); 

                jegy[i] = $"C{x1}{x2}{szam}{szam}{x3}{x4}";
            }

            return jegy;


        }

        static void Egyforma(string[] jegyek)
        { 
            int dbEgyforma = 0;
            foreach (string j in jegyek)
            {
                int szam = int.Parse(j[3].ToString());
                if (szam % 2 == 0)
                { dbEgyforma++; }
            }
            Console.WriteLine($"Páros számpárok száma: {dbEgyforma}");
        }

                static void Main(string[] args)
        {
            Console.WriteLine( Mozik());
            Console.WriteLine("Hétvége van?");
            string hetvege = Console.ReadLine().Trim().ToLower();
            if (hetvege == "igen")
            {
                Hetvege(true);
            }
            else
            {
                Hetvege(false);
            }

            string[] jegyek = General();
            Console.WriteLine("A generált jegyek: ");
            foreach (string jegy in jegyek)
            {
                Console.Write(jegy +", ");
            }
            Console.WriteLine();
            Egyforma(jegyek);

            Console.ReadKey();
        }

        

    }
}
