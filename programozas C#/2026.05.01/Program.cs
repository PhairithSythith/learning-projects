namespace _2026._05._01_zh_gyak_6
{
    internal class Program
    {
        static List<Auto> autok = new();
        public static void Betolt(string fajl)
        {
            string[] sorok = File.ReadAllLines(fajl);

            foreach (string line in sorok)
            {
                string[] szok = line.Split(';');

                switch (szok[0].ToLower())s
                {
                    case "kis":
                        autok.Add(new KisAuto());
                        break;

                    case "csaladi":
                        autok.Add(new CsaladiAuto());
                        break;

                    case "luxus":
                        autok.Add(new LuxusAuto(Convert.ToInt32(szok[1])));
                        break;
                }
            }
        }
        public static void Feldolgoz()
        {
            foreach (Auto au in autok)
            {
                if (au is IKedvezmenyes kedv)
                {
                    au.berletiDij = kedv.KedvezmenytSzamol(au.bereltNap);
                }

                Console.WriteLine(au);
            }
            KisAuto kis = null;
            CsaladiAuto csal = null;
            LuxusAuto lux = null;
            foreach (Auto au in autok)
            {
                if (kis == null && au is KisAuto) kis = (KisAuto)au;
                if (csal == null && au is CsaladiAuto) csal = (CsaladiAuto)au;
                if (lux == null && au is LuxusAuto) lux = (LuxusAuto)au;
            }
            if (kis != null && csal != null && lux != null)
            {
                kis.Athelyez(csal, 2);
                csal.Athelyez(lux, 2);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Betolt("auto.txt");
                Feldolgoz();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    interface IDijak
    {
        const int KisAuto = 6000;
        const int CsaladiAuto = 10000;
        const int LuxusAuto = 18000;
    }

    interface IKedvezmenyes
    {
        int KedvezmenytSzamol(int napok);
    }

    abstract class Auto : IDijak
    {
        public int berletiDij { get; set; }
        public int kapacitasNap { get; set; }
        public int bereltNap { get; set; }

        public Auto(int napok)
        {
            kapacitasNap = napok;
            bereltNap = 0;
            if (napok <= 5) berletiDij = IDijak.KisAuto;
            else if (napok <= 10) berletiDij = IDijak.CsaladiAuto;
            else berletiDij = IDijak.LuxusAuto;
        }

        public void Berel(int nap)
        {
            if (bereltNap + nap <= kapacitasNap)
                bereltNap += nap;
        }

        public void Visszahoz(int nap)
        {
            bereltNap -= nap;
            if (bereltNap < 0) bereltNap = 0;
        }

        public override string ToString()
        {
            return $"Díj: {berletiDij}, kapacitás: {kapacitasNap}, bérlés: {bereltNap}";
        }

        public abstract void Athelyez(Auto cel, int nap);
    }

    class KisAuto : Auto
    {
        public KisAuto() : base(5) { }

        public override void Athelyez(Auto cel, int nap)
        {
            if (cel is CsaladiAuto || cel is LuxusAuto)
            {
                if (bereltNap >= nap && cel.bereltNap + nap <= cel.kapacitasNap)
                {
                    cel.bereltNap += nap;
                    Visszahoz(nap);
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + " (KisAuto)";
        }
    }

    class CsaladiAuto : Auto, IKedvezmenyes
    {
        public CsaladiAuto() : base(8) { }

        public int KedvezmenytSzamol(int napok)
        {
            if (napok >= 7)
                return (int)(berletiDij * 0.85);
            return berletiDij;
        }

        public override void Athelyez(Auto cel, int nap)
        {
            if (cel is LuxusAuto)
            {
                if (bereltNap >= nap && cel.bereltNap + nap <= cel.kapacitasNap)
                {
                    cel.bereltNap += nap;
                    Visszahoz(nap);
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + " (Családi)";
        }
    }

    class LuxusAuto : Auto
    {
        public LuxusAuto(int napok) : base(napok) { }
        public override void Athelyez(Auto cel, int nap)
        {
            Console.WriteLine("Luxus autó nem helyezhető át!");
        }

        public override string ToString()
        {
            return base.ToString() + " (Luxus)";
        }
    }
}
/*Gyakorló ZH – Autókölcsönző rendszer
 Feladat leírás

Egy autókölcsönző cég nyilvántartja a különböző típusú autóit és azok bérlését.

A rendszerben az autók különböző kategóriákba tartoznak:

kisautó
családi autó
luxus autó

A feladatod egy objektumorientált rendszer elkészítése, amely kezeli az autók bérlését, kedvezményeit és mozgatását (pl. telephelyek között).

 1. Interfész: Dijak

Hozz létre egy interfészt, amely tartalmazza az alábbi konstansokat:

KISAUTO = 6000
CSALADI = 10000
LUXUS = 18000
 2. Interfész: Kedvezmenyes

Hozz létre egy interfészt:

int KedvezmenytSzamol(int napok);
 jelentése:
visszaadja a kedvezményes bérleti díjat
a napok száma alapján számol
 3. Absztrakt osztály: Auto

Ez az összes autó ősosztálya.

abstract class Auto : Dijak
🔹 Adattagok:
public int berletiDij
public int kapacitasNap (hány napra bérelhető)
public int bereltNap (eddig hány napra van kiadva)
🔹 Konstruktor:
Auto(int napok)

Feladata:

kapacitasNap = napok
bereltNap = 0
ár beállítása:
ha napok ≤ 5 → KISAUTO
ha 6–10 → CSALADI
ha > 10 → LUXUS
🔹 Metódusok:
 Bérlés:
void Berel(int nap)
növeli a bereltNap értéket
nem mehet túl a kapacitáson
 Visszahozás:
void Visszahoz(int nap)
csökkenti a bérlés napjait
nem mehet 0 alá
 ToString()

Kiírja:

bérleti díj
kapacitás
bérelt napok
🔹 Absztrakt metódus:
void Athelyez(Auto cel, int nap);

 jelentése:

egy autót áthelyezünk egy másik kategóriába / telephelyre
 4. Gyerekosztályok
 KisAuto
class KisAuto : Auto
🔹 Konstruktor:
public KisAuto() : base(5) { }
🔹 Athelyez:
csak CsaladiAuto vagy LuxusAuto felé mozgatható
ha van elég szabad kapacitás → áthelyezhető
 CsaladiAuto
class CsaladiAuto : Auto, Kedvezmenyes
🔹 Konstruktor:
public CsaladiAuto() : base(8) { }
🔹 Kedvezmény:
ha bérlés ≥ 7 nap → 15% kedvezmény
return (int)(berletiDij * 0.85);
🔹 Athelyez:
csak LuxusAuto-ba mozgatható
ha van hely → átadás
 LuxusAuto
class LuxusAuto : Auto
🔹 Konstruktor:
public LuxusAuto(int napok) : base(napok) { }
🔹 Athelyez:
nem mozgatható
kiírja:
"Luxus autó nem helyezhető át!"
 5. Program osztály
static List<Auto> autok = new List<Auto>();
 Betöltés
public static void Betolt(string fajl)

Fájl formátum:

kis
csaladi
luxus;12
Feladat:
soronként feldolgozás
objektum létrehozás
listába mentés
 Feldolgozás
public static void Feldolgoz()
végigmegy az összes autón
ha Kedvezmenyes → kiszámolja a kedvezményt
kiírja az adatokat
 EXTRA ZH FELADAT

Ha van:

legalább 1 KisAuto
legalább 1 LuxusAuto

akkor:

KisAutóból 2 napot át kell helyezni a LuxusAutóba
 Main
Betolt("auto.txt");
Feldolgoz();*/