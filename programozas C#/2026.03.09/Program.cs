using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026._03._08_Otthon_gyak_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    namespace _2026._03._09_Othhon_gyak
    {/*
        public class Lotto
        {
            public int[] Lottozas;
            private readonly int Hanyas;
            public int Talalatok;

            public Lotto(int hanyasok)
            {
                if (hanyasok >= 5 &&  hanyasok <= 6)
                {
                    this.Hanyas = hanyasok;
                    this.Lottozas = new int[this.Hanyas];
                }

            }
            public Lotto() : this(5) { }

            private void BenneVan()
            {
                int n = 0;
                do
                {
                    Console.WriteLine("Kérem a tippet (1 és 90 között): ");
                    if (this.BenneVan(Convert.ToInt32(Console.ReadLine())))
                    {
                        this.Talalatok++;
                        n++;
                        Console.WriteLine("Gratulálok! Eltalált egy számot! Találatok száma: " + this.Talalatok);
                    }
                    else Console.WriteLine("Nem talált!");
                } while (this.Talalatok < this.Lottozas.Length);
                Console.WriteLine("Nyertél! Vége a játéknak");
            }
            private void General()
            {
                Console.WriteLine("A program éppen generálja a nyerő számokat...");
                Random rnd = new Random();
                int n = 0; int general = 0;
                do
                {
                    general = rnd.Next(1, 91);
                    if (!this.BenneVan(general))
                    {
                        this.Lottozas[n] = general;
                        n++;
                    }
                } while (n < this.Lottozas.Length);
                Console.WriteLine("A generálás befejeződött!");
            }
            private bool BenneVan(int huzott)
            {
                for (int i = 0; i < this.Lottozas.Length; i++)
                {
                    if (Lottozas[i] == huzott) { return true; }
                }
                return false;
            }
            private void Eredmeny()
            {
                Console.WriteLine("A nyerőszámok: " + string.Join(", ", this.Lottozas));
            }

        }

        */

        internal class Program
        {
            static void Main(string[] args)
            {
             //   Lotto teszt = new Lotto();
             //   Console.ReadKey();

                Auto car1 = new Auto("AOGP604");
                car1.Utazas(213);
                car1.Tankolas(20);
                car1.Utazas(122);
                car1.Utazas(220);
                car1.Utazas(170);
                car1.Tankolas(20);
                Console.WriteLine( car1.GetTank());
                Console.WriteLine( car1.GetPenz());

                Console.WriteLine();

                Auto car2 =new Auto("AIGX576");
                car2.Utazas(220);
                car2.Tankolas(5);
                car2.Utazas(90);
                car2.Utazas(350);
                car2.Utazas(80);
                car2.Tankolas(30);
                Console.WriteLine( car2.GetTank());
                Console.WriteLine( car2.GetPenz());

                Console.ReadKey();

            }
        }
    }
}
