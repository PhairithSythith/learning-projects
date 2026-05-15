namespace DE5JFI_OOP_GYAK_ZH_2
{
    internal class Program
    {
        static List<Konyv> konyvek = new();
        static List<CD> cdk = new();
        static Random random = new Random();
        static public void RendelesFelvesz(string fajlNev) {
            string[] beolvasas = File.ReadAllLines(fajlNev);
            foreach (string sorok in beolvasas) {
                string[] szok = sorok.Split(';');
                switch (szok[0].ToLower()) {
                    case "cd": cdk.Add(new CD(szok[1].ToLower(), szok[2].ToLower())); break;
                    case "peldatar": konyvek.Add(new Peldatar(szok[1].ToLower(), szok[2].ToLower(), Convert.ToInt32(szok[3]))); break;
                    case "regeny": konyvek.Add(new Regeny(szok[1].ToLower(), szok[2].ToLower(), szok[3].ToLower())); break;
                }
                Regeny r = null;
                Peldatar p = null;
                CD cd=null;
                foreach(Konyv konyv in konyvek)
                {
                    if(r is Regeny && r == null) { r = (Regeny)konyv; }
                    if(p is Peldatar &&p == null) { p = (Peldatar)konyv; }
                }
                foreach(CD c in cdk)
                {
                    if(c is CD && cd == null) { cd = (CD)c; }
                }
                
            }
        
        }
        static public void Rendel()
        {
            int rnd = random.Next(5, 21);
            foreach (Konyv konyv in konyvek)
            {
                if ((konyv is Regeny || konyv is Peldatar) && konyv != null)
                {
                    if (konyv is IRendelheto rendeles)
                    {
                    
                        rendeles.Rendel(rnd);
                        //Console.WriteLine(konyv);
                    }
                }
            }
            foreach (CD cd in cdk)
            {
                if (cd is CD && cd != null) { cd.Rendel(rnd);
                    //Console.WriteLine(cd);
                }
               
            }
        }


        static void Main(string[] args)
        {
            try
            {
                RendelesFelvesz(@"C:\Users\ritzo\source\repos\DE5JFI_OOP_GYAK_ZH_2\DE5JFI_OOP_GYAK_ZH_2\bemeneti_fajl.txt");
                Rendel();
            }
            catch (FileNotFoundException) { Console.WriteLine("A fájl nem található"); }
            catch (FormatException) { Console.WriteLine("A fájl nem megfelelő formátumú"); }
            catch (DirectoryNotFoundException) { Console.WriteLine("A mappa nem található"); }
            catch (IOException ex) { Console.WriteLine($"Valami hiba történt!\nHiba: {ex.Message}"); }

            Console.ReadKey();
        }


        interface IRendelheto
        {
            void Rendel(int db);
        }
        abstract class Konyv
        {
            protected string cim {  get; set; }
            protected string szerzo { get; set; }

            public Konyv(string iro, string cim) {
                this.szerzo = iro;
                this.cim = cim;
            }
            abstract public bool DedikalASzerzo();
            public override string ToString()
            {
                return $"A köny szerzője: {this.szerzo}, a  könyv címe: {this.cim}";
            }
        }
        class Peldatar : Konyv
        {
            int feladatokSzama; 
            public Peldatar(string szerzo, string cim,int feladatokSzama) :base(szerzo,cim)
            {
             this.feladatokSzama = feladatokSzama;
            }
            public override bool DedikalASzerzo()
            {
                return false;
            }
            public override string ToString()
            {
                return base.ToString() +", Dedikálás: " + (DedikalASzerzo() ? "igen" : "nem");
            }
        }
        class Regeny : Konyv, IRendelheto
        {
            string tartalmiOsszefoglalo;
            public Regeny(string szerzo, string cim, string tartalmiOsszefoglalo) : base(szerzo, cim) {
                this.tartalmiOsszefoglalo= tartalmiOsszefoglalo;
            }
            public void Rendel(int db)
            {
                Console.WriteLine($"Rendelni kell {db} regényt az alábbiból: {this.szerzo} - {this.cim}");
            }
            public override bool DedikalASzerzo()
            {
                return true;
            }
            public override string ToString()
            {
                return base.ToString() + $", Tartalmi összefoglaló: {this.tartalmiOsszefoglalo}";
            }
        }
        class CD : IRendelheto {
            string eloadoNeve;
            string abumCim;
            public CD(string eloadoNeve, string abumCim) {
                this.eloadoNeve = eloadoNeve;
                this.abumCim = abumCim;
            }
            public void Rendel(int db)
            {
                Console.WriteLine($"Rendelni kell {db} CD-t az alábbiból: {this.eloadoNeve} - {this.abumCim}");
            }
            public override string ToString()
            {
                return $"A zene szerzője: {this.eloadoNeve}, az album címe: {this.abumCim}";
            }
        }
    }
}
