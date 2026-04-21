using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _2026._04._21_OOP_gyak_orai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kivétel kezelés, kivételek
            //try{}catch(){}
            /* TRY -> sew without condom
             * CATCH -> AIDS */
            /*
            Kor k = new Kor();
            k.SetKor(-10);*/
            /*
            int eredmeny = 0;
            Console.WriteLine("Kérem a számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a számot: ");
            int b= Convert.ToInt32(Console.ReadLine());
            eredmeny = a / b;
            try
            {
                eredmeny = a / b;
            }
            catch(DivideByZeroException ex) { Console.WriteLine("Nullával való osztás hiba!");
                eredmeny = a / 1;
            }
            catch(Exception ex) { Console.WriteLine("Súlyos hiba!"); }

            Console.WriteLine($"Az eredmény: {eredmeny}");*/
            /*
            int eredmeny = 0, n = 0;
            int[] szamok=new int[2];

            do
            {
                Console.WriteLine($"Kérem a(z) {n + 1} számot: ");
                try
                {
                    szamok[n] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { Console.WriteLine("A megadott bemenet nem szám");
                    n--; //visszalépünk egyet, ez így nulláz
                }
                catch (IndexOutOfRangeException) { Console.WriteLine("Nincs ennyi eleme a tömbnek!"); break; }
                catch (Exception) { Console.WriteLine("Nem várt hiba!"); };
                n++;
            } while (n < 2);
            try
            {
                eredmeny = szamok[0] / szamok[1];
            }
            catch (DivideByZeroException) { Console.WriteLine("Nullával nem  lehet osztani!"); eredmeny = szamok[0] / 1; }
            catch (Exception) { Console.WriteLine("Nem várt hiba!"); }
            finally //mindig lefut a végén, ez főleg fájl műveleteknél jó
            {
                Console.WriteLine($"Az eredmény: {eredmeny}");
            } */
            /*
            Console.WriteLine("Kérek egy számot:");
            string input= Console.ReadLine();

            if (int.TryParse(input, out int szam)) 
            {
                Console.WriteLine($"Sikeres konvertálás: {szam}");
            }
            else
            {
                Console.WriteLine($"Sikertelen konvertálás: {szam}");
            }*/
            /*
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(@"C:\\Users\ritzo\\source\\repos\\2026.04.21_OOP_gyak_orai\\2026.04.21_OOP_gyak_orai");
                sw.WriteLine("Helló");
            }
            finally {
                sw.Dispose();
            }

            using StreamWriter sw2 = new(@"C:\\Users\ritzo\\source\\repos\\2026.04.21_OOP_gyak_orai\\2026.04.21_OOP_gyak_orai");
            sw2.WriteLine("Tsá");
            */
            /*
            string text = File.ReadAllText(@"C:\\Users\ritzo\\source\\repos\\2026.04.21_OOP_gyak_orai\\2026.04.21_OOP_gyak_orai", Encoding.UTF8);

            string[] lines=File.ReadAllLines(@"C:\\Users\ritzo\\source\\repos\\2026.04.21_OOP_gyak_orai\\2026.04.21_OOP_gyak_orai", Encoding.UTF8);
            foreach (var line in lines)
            {
                Console.WriteLine(line); 
            }

            string[] line = {"Finom","az","alma","ami","ANett","fenekéből","potyog" }; ;
            File.WriteAllLines(@"C:\\Users\ritzo\\source\\repos\\2026.04.21_OOP_gyak_orai\\2026.04.21_OOP_gyak_orai", line);*/
            /*
            try
            {
                FileReader(@"C:\\Users\ritzo\\source\\repos\\nemLetezik.txt");
            }
            catch (DirectoryNotFoundException) { Console.WriteLine("A keresett mappa nem létezik"); }
            catch (FileNotFoundException) { Console.WriteLine("A keresett fájl nem létezik!"); }
            catch (Exception) { Console.WriteLine("Ismeretlen iba!"); }*/
            /*
            string[] lines = {"egy","kettő","hérom" };
            try
            {

                File.WriteAllLines(@"C:\\Users\\ritzo\\source\\repos\\2026.04.21_OOP_gyak_orai\\2026.04.21_OOP_gyak_orai\\iras.txt", lines);
            }
            catch (UnauthorizedAccessException) { Console.WriteLine("A fájl írásvédett"); }
            catch (DirectoryNotFoundException) { Console.WriteLine("Hibás elérési útvonal"); }
            catch (Exception) { Console.WriteLine("Ismeretlen hiba!"); }*/

            /*
            try
            {
                string[] nevek = File.ReadAllLines(@"C:\Users\ritzo\source\repos\2026.04.21_OOP_gyak_orai\2026.04.21_OOP_gyak_orai\09_nevek.txt");
                Random rnd = new Random();

                foreach (string nev in nevek)
                {   
                    string tisztaNev = nev.Trim();
                    int randomSzam = rnd.Next(100, 999);
                    StreamWriter sw = null;
                    try
                    {
                        if (nev.Equals(""))
                        {
                            sw = new StreamWriter(tisztaNev + ".txt");
                            sw.WriteLine("Név: "+tisztaNev);
                            sw.WriteLine("Random szám: "+randomSzam);
                        }
                    }
                    finally
                    {
                        if (sw != null)
                            sw.Dispose(); 
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("A nevek.txt nem található!");
            }
            catch (Exception)
            {
                Console.WriteLine("Hiba történt!");
            }*/



            //THROW - STACK TRACE
            // throw ex - lenullázza a stack trace-t és így úgy dobja a hibát mintha most keletkezett volna

            /*
            MyException.MethodA();*/



            try
            {
                Account acc = new Account
                {
                    Nev = "Ödön",
                    Egyenleg = 5000
                };

                string nev = "Kálmán";
                acc.GetAccount(nev);

                int osszeg = -500;
                acc.Fizet(osszeg);

                Console.WriteLine("Sikeres fizetés!");
            }
            catch (SzamlaNemTalalhatoException ex)
            {
                Console.WriteLine(ex.Message); // kiírja az üzenetet
                Console.WriteLine("Számla tulajdonos: " + ex.Nev);
            }
            catch (NegativOsszegException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TulNagyOsszegException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NincsElegEGyenlegException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Tranzakció lezárva.");
            }

            Console.ReadKey();
        }

        class Account { 
            public string Nev { get; set; }
            public int Egyenleg { get; set; }
            public void Fizet(int osszeg)
            {
                if (osszeg < 0)
                {
                    throw new NegativOsszegException();
                }
                if (osszeg > 1000000) 
                {
                    throw new TulNagyOsszegException();
                }
                if (osszeg > Egyenleg)
                {
                    throw new NincsElegEGyenlegException();
                }
                Egyenleg -= osszeg;
            }
            public Account GetAccount(string nev) {
                if (nev != this.Nev)
                {
                    
                }
                return new Account { Nev = nev, Egyenleg = 5000 };
            }
        }

        class NincsElegEGyenlegException : Exception {
            public NincsElegEGyenlegException() : base("NIncs elég pénzed!") { }
        }

        class NegativOsszegException : Exception
        {
            public NegativOsszegException() : base("Negatív összeget nem adhatsz meg!") { }
        }

        class TulNagyOsszegException : Exception
        {
            public TulNagyOsszegException() : base("Túl nag yösszeget adtál meg") { }
        }

        class SzamlaNemTalalhatoException : Exception
        {
            public string Nev { get; set; }
            public SzamlaNemTalalhatoException(string nev) : base("Nincs ilyen számla") {
                Nev = nev;
            }
        }










        /*
        static class MyException
        {
            public static void MethodC() 
            {
                int x = 0;
                int y = 5 / x;
            }
            public static void MethodB()
            {
                MethodC();
            }
            public static void MethodA() {
                try { MethodB(); }
                catch(Exception ex) { throw ex; }
            }
        }
        */



        /*
        public static void FileReader(string fileName)
        {
            string text= File.ReadAllText(fileName, Encoding.UTF8);
        }*/



        /*
        class Kor
        {
            private int kor;
            public void SetKor(int kor) {
                if (this.kor < 0) {
                    throw new ArgumentOutOfRangeException("kor","A kor nem lehet negatív!");
                }
                this.kor = kor;
            }
        } */
    }
}
