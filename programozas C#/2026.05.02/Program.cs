namespace _2026._05._02_zh_gyak_5
{
    internal class Program
    {
        static List<Szoba> panzio = new();

        public static void SzobatKiad(string fajl)
        {
            string[] sorok = File.ReadAllLines(fajl);

            foreach (string line in sorok)
            {
                string[] sz = line.Split(';');
                Szoba szoba = null;

                switch (sz[0].ToLower())
                {
                    case "egyagyas":
                        szoba = new Egyagyas();
                        break;

                    case "ketagyas":
                        szoba = new Ketagyas();
                        break;

                    case "lakosztaly":
                        szoba = new Lakosztaly(Convert.ToInt32(sz[1]));
                        break;
                }

                if (szoba != null)
                    panzio.Add(szoba);
            }
        }
        public static void Berel()
        {
            foreach (Szoba sz in panzio)
            {
                if (sz is Kedvezmenyes kedv)
                {
                    kedv.KedvezmenytKer();
                }

                Console.WriteLine(sz);
            }
        }

        static void Main(string[] args)
        {
            SzobatKiad("input.txt");
            Egyagyas elsoEgy = panzio.OfType<Egyagyas>().FirstOrDefault();
            Lakosztaly elsoLak = panzio.OfType<Lakosztaly>().FirstOrDefault();

            if (elsoEgy != null && elsoLak != null)
            {
                elsoLak.Kikoltozik(1);
                elsoEgy.Atkoltozik(elsoLak, 1);
            }

            Berel();
        }

        interface IArak
        {
            public const int EGYAGYAS = 8000;
            public const int KETAGYAS = 12000;
        }

        interface Kedvezmenyes
        {
            void KedvezmenytKer();
        }

        abstract class Szoba : IArak
        {
            public int berletiDij { get; set; }
            public int fekvoHely { get; set; }
            public int lakok { get; set; }

            public Szoba(int lakokSzama)
            {
                lakok = lakokSzama;
                fekvoHely = lakokSzama;

                if (lakokSzama <= 2)
                    berletiDij = IArak.KETAGYAS * lakokSzama;
                else
                    berletiDij = IArak.KETAGYAS + (lakokSzama - 2) * IArak.EGYAGYAS;
            }

            public void Kikoltozik(int db)
            {
                lakok = Math.Max(0, lakok - db);
            }

            public abstract void Atkoltozik(Szoba sz, int db);

            public override string ToString()
            {
                return $"Fekvő: {fekvoHely}, Lakók: {lakok}, Díj: {berletiDij} Ft";
            }
        }

        class Egyagyas : Szoba
        {
            public Egyagyas() : base(1) { }

            public override void Atkoltozik(Szoba sz, int db)
            {
                if (sz is Ketagyas || sz is Lakosztaly)
                {
                    if (sz.fekvoHely >= db)
                    {
                        sz.Kikoltozik(db);
                        this.lakok += db;
                    }
                }
            }

            public override string ToString()
            {
                return base.ToString() + " <- Egyágyas";
            }
        }

        class Ketagyas : Szoba, Kedvezmenyes
        {
            public Ketagyas() : base(2) { }

            public void KedvezmenytKer()
            {
                if (lakok == 1)
                    berletiDij = IArak.EGYAGYAS;
            }

            public override void Atkoltozik(Szoba sz, int db)
            {
                if (sz is Lakosztaly && sz.fekvoHely >= db)
                {
                    sz.Kikoltozik(db);
                    this.lakok += db;
                }
            }

            public override string ToString()
            {
                return base.ToString() + " <- Kétágyas";
            }
        }

        class Lakosztaly : Szoba
        {
            public Lakosztaly(int lakokSzama) : base(lakokSzama) { }

            public override void Atkoltozik(Szoba sz, int db)
            {
                Console.WriteLine("Lakosztályból nem költözik ki senki.");
            }

            public override string ToString()
            {
                return base.ToString() + " <- Lakosztály";
            }
        }
    }
}
