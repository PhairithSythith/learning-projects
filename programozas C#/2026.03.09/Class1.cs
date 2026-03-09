using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026._03._08_Otthon_gyak_2
{
    public class Auto 
    {
        private readonly string  Rendszam;
        private int Fogyasztas=6;
        private int BenzinAr = 600;
        private int Tank = 20;
        private int Penz = 20000;

        public Auto(string rendszam)
        {
            this.Rendszam = rendszam;
        }
        public string GetRendszam() { return this.Rendszam; }
        public int GetFogyasztas() { return this.Fogyasztas; }
        public int GetBenzinAr() { return this.BenzinAr;}
        public int GetTank() { return this.Tank; }
        public int GetPenz() { return this.Penz; }

        public void Utazas(int km)
        {
            int kell;
            int fogyasztas = km * Fogyasztas/100;
            if (this.Rendszam.Length == 7)
            {
                if (this.Tank >= fogyasztas)
                {
                    this.Tank -= fogyasztas;
                    Console.WriteLine($"{fogyasztas} L üzemanyag felhasználásával érted el az úticélt.");
                }
                else if(this.Tank<fogyasztas)
                {
                    kell = fogyasztas - this.Tank;
                    Console.WriteLine($"Nincs elegendő mennyiségű üzemanyag! Még {kell} L üzemanyagot kellene tankolnod, hogy elérd az úticélod!");
                }
            }
            else
            {
                Console.WriteLine("Érvénytelen rendszám!");
            }
        }
        public void Tankolas(int liter)
        {
            int fizetendo = liter * this.BenzinAr;
            if (this.Penz >= fizetendo)
            {
                 this.Penz -= fizetendo;
                this.Tank += liter;
                Console.WriteLine($"{liter} L üzemanyagot tankoltál {fizetendo} FT-ért.");
            }
            else if (this.Penz < fizetendo)
            {
                Console.WriteLine("Nincs elég fedezet emmyi liter üzemanyag tankolásához!");
            }
        }

    }
    internal class Class1
    {
    }
}
