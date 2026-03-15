using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026._03._15_Otthon_gyak_6
{
    internal class Program
    { static Random random = new Random();
        public class Versenyzo
        { string nev; int pont; int futottTav;
            public Versenyzo(string nev)
            { this.nev = nev;
                this.pont = 0;
            }
            public int Fut()
            { this.futottTav= random.Next(1,11);
                return this.futottTav;
            }
            public void SetPont() { this.pont++; }
            public int GetPont() { return this.pont; }
            public int GetFutottTav() { return this.futottTav; }
            public override string ToString()
            {
                return $"{this.nev}  futása: {this.futottTav}, pontjai: {this.pont}";
            }
        }
        public class VersenyBiro
        {
            int korSzam;
            public VersenyBiro()
            { this.korSzam = 1; }
            public void Kezdes()
            {
                Console.WriteLine();
                Console.WriteLine($"{this.korSzam}. kör kezdődik!");
                this.korSzam++;
            }
        }
        public class VersenyMenet
        {
            List<Versenyzo> versenyzok;
            public VersenyMenet(int db)
            {
                versenyzok = new List<Versenyzo>();
                List<string> hasznaltnevek = new List<string>();
                for (int i = 0; i < db; i++)
                {
                    string nev;
                    do {
                        nev = GetNev();
                    } while(hasznaltnevek.Contains(nev));
                    hasznaltnevek.Add(nev);
                    versenyzok.Add(new Versenyzo(nev));
                } 
            }
            private string GetNev()
            { string[] nevek= { "Laci", "Zoli", "Bori", "Zita", "Rita", "Imi", "Gazsi", "Géza", "Misi", "Mari", "Lajos", "Lili", "Kira", "Tomi", "Zoé" };
                return nevek[random.Next(nevek.Length)]; }
            public void Kor(VersenyBiro b)
            {
                int legtobb=0; 
                foreach(Versenyzo v in versenyzok)
                {
                    v.Fut();
                    
                    if (v.GetFutottTav() > legtobb)
                    { legtobb = v.GetFutottTav(); }
                }
                foreach(Versenyzo v in versenyzok)
                { if(v.GetFutottTav()==legtobb)
                    { v.SetPont(); }
                }
                Console.WriteLine();
                Console.WriteLine("Eredmények: ");
                foreach(Versenyzo v in versenyzok)
                { Console.WriteLine(v); }
            }
            public void TopLista()
            {
                int max = 0;
                foreach (Versenyzo v in versenyzok)
                { if (v.GetPont() > max)
                    { max = v.GetPont(); }
                }
                if (max == 0){ Console.WriteLine("Senki sem szerzett pontot!"); return; }
                Console.WriteLine();
                Console.WriteLine("A legtöbb pontot szerző(k): ");
                foreach(Versenyzo v in versenyzok)
                { if(v.GetPont() == max) Console.WriteLine(v); }
            }
        }
        static void Main(string[] args)
        {
            VersenyMenet menet = new VersenyMenet(10);
            VersenyBiro biro = new VersenyBiro();
            for(int i = 0; i <6; i++)
            {
                biro.Kezdes();
                menet.Kor(biro);
            }
            menet.TopLista();
            Console.ReadKey();
        }
    }
}
