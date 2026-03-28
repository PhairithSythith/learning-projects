using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2026._03._16_Otthon_gyak.Program;

namespace _2026._03._16_Otthon_gyak
{
    internal class Program
    { static Random rnd = new Random();
        public class Jatekos
        {
            string nev; int tipp, nyeresek;
            public Jatekos(string nev)
            {
                this.nev = nev;
                this.nyeresek = 0;
            }
            public void SetNyeresek() { this.nyeresek++; }
            public int GetNyeresek() { return this.nyeresek; }
            public int GetTipp() { return this.tipp; }
            public int General()
            { return rnd.Next(1,21); }
            public int Tipp()
            { return (General() + General()) / 2; }
            public override string ToString()
            {
                return $"{this.nev} tippje: {this.tipp}, nyerések száma: {this.nyeresek}";
            }
        }

        public class Jatekmester
        {
            int megoldas; int szamlalo;
            public Jatekmester()
            { this.szamlalo = 1; }
            public void Kitalal()
            {
                do
                {
                    Console.WriteLine("Gondolt szám: ");
                    this.megoldas = int.Parse(Console.ReadLine().Trim());
                    this.szamlalo++;

                } while (this.megoldas > 21 || this.megoldas < 1);
            }
            public int GetMegoldas() { return this.megoldas; }
        }

        public class Jatekmenet
        {
            List<Jatekos> jatekosok;
            public Jatekmenet(int db)
            {
                jatekosok = new List<Jatekos>();
                for (int i = 0; i < db; i++)
                {   
                    jatekosok.Add(new Jatekos(NevGeneral()));
                }
            }
            private string NevGeneral()
            { string[] nevek= { "Laci", "Zoli", "Bori", "Zita", "Rita", "Imi", "Gazsi", "Géza", "Misi", "Mari", "Lajos", "Lili", "Kira", "Tomi", "Zoé" };
            return nevek[rnd.Next(nevek.Length)];}

            public void Jatek(Jatekmester jm)
            {
                int megoldas=jm.GetMegoldas();
                foreach (Jatekos k in jatekosok)
                {
                    int tipp = k.Tipp();
                    if (tipp == megoldas)
                    { k.SetNyeresek(); }
                    Console.WriteLine(k);
                }
            }
            public void Elso()
            {
                int maxNyeres = 0;
                Jatekos gyoztes = null;
                foreach (Jatekos j in jatekosok)
                {
                    if (j.GetNyeresek() > maxNyeres)
                    {
                        maxNyeres = j.GetNyeresek();
                        gyoztes = j;
                    }
                }
                if (gyoztes == null)
                { Console.WriteLine("Mindenki béna volt, nincs nyertes!"); }
                else
                {
                    Console.WriteLine($"A győztes: {gyoztes.ToString()}");
                }
            }
        }
        
        static void Main(string[] args)
        {
            Jatekmenet menet = new Jatekmenet(15);
            Jatekmester mester=new Jatekmester();
            for (int i = 0; i < 5; i++)
            {
                mester.Kitalal();
                menet.Jatek(mester);
            }
            menet.Elso();
            Console.ReadKey();
           
        }
    }
}
