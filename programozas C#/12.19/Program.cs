using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE5JFI._12._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vonatjegy();
            Diakjegy(false);


        }

        static double[] Vonatjegy()
        {
            Console.WriteLine("Írja be a kedvezményt: ");
            double kedvezmeny = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Írja be a teljes jegyárat: ");
            double teljesAr = Convert.ToInt32(Console.ReadLine().Trim());
            double kedvar = teljesAr * kedvezmeny;
            double hossz = kedvar + teljesAr;
            double[] arak = new double[0];
            for (int i = 0; i < arak.Length; i++)
            {
                if (arak[i] / 2 == 0)
                { arak[i] = teljesAr; }
                else { arak[i] = kedvar; }
            }
            Console.WriteLine(string.Join("", arak));
            return arak;

        }

        static void Diakjegy(bool ertek)
        { Random rnd = new Random();
            int generalt = rnd.Next(2000, 4001);
            
                if (ertek = true)
                    { Console.WriteLine( (generalt * 10) * 0.9 ); }
                    else if (ertek = false)
                    { Console.WriteLine(generalt/2); }
        }
        
    
    }
}
