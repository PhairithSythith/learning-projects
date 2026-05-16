using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _2026._05._16_otthon_gyak_4
{
    internal class KorhaziBeteg : Beteg, Gyogyithato
    {
        public string Osztaly { get; set; }
        public KorhaziBeteg(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            Osztaly = adatok[5];
        }
        public void Gyogyitas()
        {
            if (Allapot>0 && Allapot <= 30)
            {
                Allapot = Allapot + 40;
                Koltseg = Koltseg * 1.5;
            }
            else if (Allapot > 30 && Allapot < 70)
            {
                Allapot = Allapot + 20;
                Koltseg = Koltseg * 1.10;
            }
            else{ 
                Allapot = Allapot + 10;
                Koltseg = Koltseg * 1.15;            
            }
        }
        public override string KezelesTipus()
        {
            return "Kórházi";
        }
    }
}
