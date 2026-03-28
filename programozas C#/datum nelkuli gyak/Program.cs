using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2026._03._24_orai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Radio r = new Radio(false, "SOny");
            r.SwitchOn();
            r.ListenRadio();
            TV tv = new TV(false, "Samsung");
            tv.WatchTv();*/
            /*
            Dog dog =new Dog("Bolha", 2);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old and is s/he hungry? {dog.isHungry}");
            dog.MakeSound();
            dog.Eat();
            dog.Play();
            dog.Eat();*/
            /*
            FolyoSzamla sz = new FolyoSzamla("1234",5000,300);
            sz.Kifizetes(5000);
            sz.Haviszamladij();
            Console.WriteLine(sz);
            BetetSzamla b = new BetetSzamla(10000, "3455", 5);
            b.Kamatozik();
            Console.WriteLine(b);*/











            MountainBike bike = new MountainBike(3,40,25);
            Console.WriteLine(bike);
            bike.UlesAllitas(1);
            bike.Fekez(10);
            Console.WriteLine(bike);
            bike.Gyorsit(20);
            bike.UlesAllitas(2);
            Console.WriteLine(bike);
            

            Console.ReadKey();
        }
    }
    class Bicikli
    {
        protected int Sebesseg;
        protected int Fokozat;
        public Bicikli(int sebes, int fok)
        {
            Sebesseg = sebes;
            Fokozat = fok;
        }
        public void Fekez(int csokken)
        {
            if(Sebesseg>0) Sebesseg-=csokken;
        }
        public void Gyorsit(int gyors)
        {   
            Sebesseg+=gyors;
        }
        public override string ToString()
        {
            return $"A kerékpár fokozata: {Fokozat} és a sebessége: {Sebesseg}";
        }
    }
    class MountainBike :Bicikli
    {
        private int ulesMagassag;
        public MountainBike(int ulesmagas,int sebes,int fok):base(sebes, fok) {
            this.ulesMagassag = ulesmagas;
        }
        public void UlesAllitas(int magassag)
        {
            this.ulesMagassag=magassag;
        }
        public override string ToString()
        {
            return base.ToString() +$", és az ülés magassága: {ulesMagassag}";
        }
    }






















    /*
    
    class Bankszamola
    {
        protected string SzamlaSzam {  get;}
        protected double Egyenleg { get; set; }
        public Bankszamola(string szamlasz, int kezdoE)
        {
            SzamlaSzam = szamlasz;
            Egyenleg = kezdoE;
        }
        public void Befizetes(double osszeg)
        {
            if (osszeg > 0) Egyenleg += osszeg;
        }
        public void Kifizetes(double osszeg) 
        {
            if (this.Egyenleg >= osszeg)
            {
                this.Egyenleg -= osszeg;
            }
            else { Console.WriteLine("Nincs elegendő fedezet a számlán"); }
        }
        //override után ha oda írjuk hogy sealed akkor nem lehet tovább felülírni
        public override string ToString()
        {
            return $"Számlaszám: {SzamlaSzam}\nEgyenleg: {Egyenleg} FT";
        }
    }
    class FolyoSzamla:Bankszamola
    { private int szamlaDij;
        public FolyoSzamla(string szamlasz, int kezdoE, int szamlad):base(szamlasz, kezdoE)
        { this.szamlaDij = szamlad; }
        public void Haviszamladij()
        {
            base.Kifizetes(szamlaDij);
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nHavi számladíj: {szamlaDij} FT";
        }
    }
    class BetetSzamla : Bankszamola
    {
        private double Kamat;
        public BetetSzamla(double kamat, string szamlaszam, int kezdoE):base(szamlaszam,kezdoE)
        { this.Kamat = kamat; }
        public void Kamatozik()
        {
            double osszeg = base.Egyenleg * (this.Kamat / 100);
            //base.Egyenleg += osszeg;
            base.Befizetes(osszeg);
        }
        public override string ToString()
        {
            return base.ToString() + $" A kamat mértéke: {Kamat}";
        }
    }


    */
    
    
    
    /*class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool isHungry { get; set; }
        public Animal(string name, int age )
        {
            isHungry = true;
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Grrrrr!");
        }

        public virtual void Eat()
        {
        if(isHungry)
            { Console.WriteLine($"{Name} is eating"); }
        else { Console.WriteLine($"{Name} is not hungry"); }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
    class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age):base(name,age)
        { IsHappy = true; }
        public override void Eat()
        {
            base.Eat();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Wuf!Wuf!");
        }
        public override void Play()
        {
            if(IsHappy) {base.Play();}
        }
    }


    */



    /*
    class ElectricalDevice
    {
        public bool IsOn {  get; set; }
        public string Brand { get; set; }
        public ElectricalDevice(bool isOn, string brand) 
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void SwitchOn()
        { IsOn = true; }
        public void SwitchOff()
        { IsOn = false; }
    }
    class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand) { }
        public void ListenRadio()
        { if (base.IsOn)
            { Console.WriteLine("Listening to the Radio."); }
            else { Console.WriteLine("Radio is turned off, turn it on first!"); }
        }
    }
    class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand){}
        public void WatchTv()
        {
            if (base.IsOn)
            { Console.WriteLine("Watching TV."); }
            else { Console.WriteLine("TV is turned off, turn it on first!"); }
        }
    }

    */


     /*
    class Szulo
    {
        private int x = 1;
        protected int y = 2;
        internal int z = 3;
        public int w = 4;
    }

    class Gyermek : Szulo
    {
        public void Teszt()
        { Console.WriteLine(x,y,z,w); }
    }
    */
}
