using System;
using System.Diagnostics.Tracing;
using System.Security.AccessControl;

namespace _2026._02._24_Prog_gyak
{
    //Névtér: logikai elválasztó, ha létrehozok egy osztályt akkor bármilyen nevet adhatok neki

    internal class Program
    {
        //internal: ugyanabban az assembly-ben lehet használni, 1 projekt amit átadsz, ez a szó a láthatóságot jelzi, ez az alapértelmezett
        /*class Kutya
        {
            
            //osztályváltozók, ez a teljes osztályban elérhetőek
            public string nev; //ha a public nincs megadva akkor privátnak veszi a C#
            public string fajta;
            public int meret;

            public void Ugat()
            {
                Console.WriteLine("Vau! Vau!");
            }

        }*/
        /*

        class Human
        {
            public string FirstName;
            public string LastName;

            public void Bemutatkozas()
            {
                Console.WriteLine("Hi, my name is: {0} {1}", FirstName, LastName);
            }
        }

        */
        /*
        class Auto
        {
            public string marka;
            public string szin;
            public int tank;

            //híváskor elfogyaszt 5 liter a tankból
            public void Vezet()
            {
                if (tank >= 5)
                {
                    tank = tank- 5;
                    Console.WriteLine($"A tankban még: {tank} l üzemanyag van.");
                }
                else { Console.WriteLine("Nincs üzemanyag, nem tudunk elindulni."); }
            }

            public void Kii()
            {
                Console.WriteLine($"A {marka} márkájú {szin} színű autóban {tank} l üzemanyag van!");
            }
        }*/
        /*
        class Macska
        {
            public string nev;
            public double suly;
            public bool ehes;

            public bool Eszik(double etel)
            {
                if (ehes)
                {
                    suly += etel;
                    ehes = false;
                    return true;
                }
                else return false;
            }

            public void Futkos()
            {
                if (suly - 0.1 > 0)
                {
                    suly -= 0.1;
                    if (!ehes) ehes = true;
                }
                
            }
            //felülírás
            override
                public string ToString()
            {
                return nev + " macska " + Math.Round(suly) + " kg. és " + (ehes ? "éhes" : "nem éhes");
            }
        }

        class Kacsa
        {
            public string nev;
            public double suly;
            public int hapogas;

            public Kacsa(string nev, double suly, int hapogas)
            {
                this.nev = nev;
                this.suly = suly;
                this.hapogas = hapogas;
            }

            public Kacsa(string nev, double suly) : this(nev, suly, 15) { }
            

            override
                public string ToString()
            {
                return nev + " nevű kacsa " + suly + " kg. nehéz és " + hapogas + " darabot hápog egy nap.";
            }
        }
        */
        //1. Konstruktor, ami beállítja a 2 osztályváltozót
        //2.Konstruktor: osztályváltozó nélkül
        //ez hívja meg az 1. konstruktort alapértékkel: 1024, false
        class Szamitogep
        {
            public double memoria;
            public bool bekapcsolva;

            public Szamitogep(double memoria, bool bekapcsolva)
            {
                this.memoria = memoria;
                this.bekapcsolva= bekapcsolva;
            }

            public Szamitogep(): this(1024, false){ }
            override

                public void Kapcsol()
            {
                bekapcsolva = !bekapcsolva;
            }

            public bool ProgramMasol(double meret)
            {
                if (this.bekapcsolva && meret <= this.memoria)
                { this.memoria = this.memoria - meret; return true; }
                else return false;
              
            }
                public string ToString()
            {
                return "A számítógép " + memoria + " memóriával rendelkezik " + (bekapcsolva ? "be van kapcsolva" : "nincs bekapcsolva");
            }

        }


        static void Main(string[] args)
        {
            /*
            //kutya objekrtum létrehozása
            //<típus><változónév>= new <típus>
            Kutya k = new Kutya();
            //k- példányon keresztül hívható a metódus ill.
            k.nev = "ZOKNI";
            k.fajta = "Corgi";
            k.meret = 18;
            //le lehet ezeket is kérdezni
            Console.WriteLine($"A kutya neve: {k.nev},\nfajtája: {k.fajta},\nmérete: {k.meret} cm.");
            k.Ugat();
            Kutya m =new Kutya();
            m.nev = "Fánk";
            m.fajta = "Labrador";
            m.meret = 40;
            Console.WriteLine($"A kutya neve: {m.nev}, fajtája: {m.fajta}, mérete: {m.meret} cm.");
            m.Ugat();
            */
            /*
            Human gitaron= new Human();
            gitaron.FirstName = "Áron";
            gitaron.LastName = "Git";
            Human rizotto= new Human();
            rizotto.FirstName = "Ottó";
            rizotto.LastName = "Riz";
            gitaron.Bemutatkozas();
            rizotto.Bemutatkozas();
            */
            /*
            Auto a = new Auto();
            a.marka = "Audi";
            a.szin = "fekete";
            a.tank = 40;
            a.Vezet();
            a.Kii();

            Auto b = new Auto();
            b.marka = "BMW";
            b.szin = "Piros";
            b.tank = 5;
            b.Vezet();
            b.Kii();
            b.Vezet();

            b = a;
            b.Vezet(); b.Kii();
            a.Vezet(); a.Kii();
            */
            /*
            Macska tom = new Macska();
            tom.nev = "Tom";
            tom.suly = 10;
            tom.ehes=true;
            Console.WriteLine(tom);
            Macska kormi = new Macska()
            {
                nev = "Kormi",
                suly = 3,
                ehes = false
            };
            Console.WriteLine(kormi);

            if(tom.Eszik(0.2)) Console.WriteLine($"{tom.nev} macska evett");
            else Console.WriteLine($"{tom.nev} nem evett");
            if (kormi.Eszik(0.2)) Console.WriteLine($"{kormi.nev} macska evett");
            else Console.WriteLine($"{kormi.nev} nem evett");

            tom.Futkos();
            Console.WriteLine(tom);
            kormi.Futkos();
            Console.WriteLine(kormi);

            Kacsa kacsa = new Kacsa("Hápi", 12.5, 11);
             Console.WriteLine(kacsa);
            Kacsa madar = new Kacsa("Árpi ",12.8);
            Console.WriteLine(madar);
            */



            Console.ReadKey();
        }


    }

    
}
