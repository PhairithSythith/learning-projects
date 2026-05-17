using System;
using System.Collections.Generic;
using System.Text;

namespace _2026._05._17_otthon_gyak_2
{
    internal class Papagaj : Madar, IEtetheto
    {
        public string KedvencEtel { get; }
        public Papagaj(string fajlSor) : base(fajlSor)
        {
            string[] adatok = fajlSor.Split(';');
            KedvencEtel = adatok[6];
        }
        public void Etet(string etel)
        {
            switch (etel) {
                case "mag": Suly += 1.05; break;
                    case "gyümölcs": Suly += 1.10; break;
                    case "dió": Suly += 1.15; break;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $", Kedvenc étel: {KedvencEtel}";
        }
    }
}
