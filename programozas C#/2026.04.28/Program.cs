using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026._04._28_oraai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 999; i++)
            {
                KutyaGyilok k = new KutyaGyilok();
                k.nev = "Fifi";
                // k = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                Console.WriteLine(k);                
            }


            string a = "alma";
            string b = a;

            a += "fa";
            Console.WriteLine(a);
            Console.WriteLine(b);

            string y = "körte";
            string x = "körte";
            Console.WriteLine(Object.ReferenceEquals(y, x));
        }







        class KutyaGyilok
        {
            public string nev;
            public int eletkor;
            ~KutyaGyilok() {
                Console.WriteLine("törölve...");
            }
        }
    }
}
