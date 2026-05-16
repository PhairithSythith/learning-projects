using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._16_otthon_gyak_3
{
    internal class ElektromosAuto : Auto, Berelheto
    {
        public int HatoTav { get; set; }
        public ElektromosAuto(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            HatoTav = int.Parse(adatok[6]);
        }   
        public void Berles()
        {
            if (HatoTav <= 300) { Napidij = Napidij * 1.10; }
            else if(HatoTav > 300 && HatoTav <= 500) { Napidij = Napidij * 1.20; }
            else if(HatoTav > 500) { Napidij = Napidij * 1.35; }
        }
        public override string Kategoria() { 
            Tipus = "Elektromos";
            return Tipus;
        }
         public override string ToString()
         {
            return base.ToString() + $", Hatótáv: {HatoTav} km";
         }
    }
}
