using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozos_gyak_2026._02._28
{
    internal class Program
    {
        static string Nevek()
            { Console.WriteLine("Írja be a keresztnevet: ");
            return Console.ReadLine().Trim().ToLower();
        }
        static string[] Feltolt(int n)
        { string[] nevek = new string[n];
            for (int i = 0; i < n; i++)
            { nevek[i] = Nevek(); }
            return nevek;
        }
        static int HanyKarakter(string[] nevek)
        {
            int osszeg = 0;
            for (int i = 0; i < nevek.Length; i++)
            { osszeg += nevek[i].Length; }
            return osszeg;
            /*
             * foreach(string i in i.Lenght;)
             * {osszeg+=i.Lenght;}
             * return osszeg;
             */
        }
        static string LeghosszabbNev(string[] nevek)
        {
            string leghosszabb = "";
            foreach (string i in nevek)
            {if (i.Length > leghosszabb.Length)
                    leghosszabb = i;
            }
            return leghosszabb;
        }
        static string[] ElsoUtolso(string[] nevek)
        {
            string[] monogrammok= new string[nevek.Length];
            for (int i = 0; i < nevek.Length; i++)
            {
                string nev = nevek[i];
                char elso = char.ToUpper(nev[0]);
                char utolso = char.ToLower(nev[nev.Length - 1]);

                monogrammok[i]=elso.ToString()+utolso.ToString();
            }
            return monogrammok;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hány keresztnevet szeretne megadni?");
            int n= Convert.ToInt32(Console.ReadLine());
            string[] nevek = Feltolt(n);
            Console.WriteLine("A nevek összesen ennyi karakterből állnak: "+ HanyKarakter(nevek));
            Console.WriteLine("A leghosszabb név: "+ LeghosszabbNev(nevek));
            Console.WriteLine("A nevek monogrammjai: " + ElsoUtolso(nevek)) ;




            bool[] cella = new bool[101];

            for (int i = 1; i <= 100; i++)
            {
                for (int j = i; j <= 100; j += i)
                {
                    cella[j] = !cella[j];
                }
            }

            for (int i = 1; i <= 100; i++)
            {
                if (cella[i])
                {
                    Console.Write(i + ", ");
                }
            }


        }

    }
}
