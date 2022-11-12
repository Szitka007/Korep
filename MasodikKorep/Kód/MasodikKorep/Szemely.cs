using System;

namespace MasodikKorep
{
    class Szemely
    {
        public static Random rnd = new Random();
        //Adattagjai - Field
        private string nev;
        private string haziAllatok;
        
        //Tulajdonságai - Property
        public string Nev 
        {
            get
            { 
                return nev;
            }
            set 
            { 
                nev = value;
            } 
        }
        public string SzuletesiDatum { get; set; }
        public int IranyitoSzam { get; set; }
        public string[] HaziAllatok 
        {
            get
            {
                if (haziAllatok.Length == 0)
                {
                    return null;
                }
                else
                {
                    return haziAllatok.Split(';');
                }
            }
        }
        public string SzuletesiEv
        {
            get 
            {
                string kiszedett = SzuletesiDatum.Substring(0,4);
                return kiszedett;
            }
        }
        public int Hanyeves 
        {
            get
            {
                return 2022 - int.Parse(SzuletesiEv);
            }
        }
        public bool VanMacskaja
        {
            get 
            {
                if (haziAllatok.Length == 0)
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < HaziAllatok.Length; i++)
                    {
                        if (HaziAllatok.Length == 0)
                        {
                            return false;
                        }
                        else if (HaziAllatok[i] == "macska")
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
        }
        public int HanyHaziAllataVan
        {
            get{
                if (haziAllatok.Length == 0)
                {
                    return 0;
                }
                else return HaziAllatok.Length;
            }
        }
        public int HanyTipusuHaziAllat
        {
            get 
            {
                int cntr = 0;
                if (haziAllatok.Length == 0)
                {
                    return 0;
                }
                else
                {
                    string[] valasztek = new string[] { "kutya", "macska", "aranyhal", "aranyhörcsög", "kígyó", "iguána", "papagáj", "mamagáj" };
                    string voltmar = "";
                    for (int i = 0; i < HaziAllatok.Length; i++)
                    {
                        if (!voltmar.Contains(valasztek[i]))
                        {
                            cntr++;
                            voltmar = voltmar + valasztek[i];
                        }
                    }
                }
                return cntr;
            }
        }
        
        //Konstruktor
        public Szemely(string nev, string szuldat, int irszam)
        {
            this.nev = nev;
            SzuletesiDatum = szuldat;
            IranyitoSzam = irszam;
            haziAllatok = "";
        }

        public Szemely()
        {
            this.nev = NevGenerator.GenerateName();
            
            int[] x = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int ev = rnd.Next(1990, 2021);
            if (IsSzokoev(ev))
            {
                x[1]++;
            }
            int honap = rnd.Next(1, 13);
            int nap = rnd.Next(1, x[honap-1]);  
            SzuletesiDatum = $"{ev}.{honap}.{nap}";
            
            IranyitoSzam = rnd.Next(1000, 10000);

            string[] valasztek = new string[] { "kutya", "macska", "aranyhal", "aranyhörcsög", "kígyó", "iguána", "papagáj", "mamagáj" };
            int hanyAllat = rnd.Next(0, 6);
            if (hanyAllat != 0)
            {
                for (int i = 0; i < hanyAllat; i++)
                {
                    haziAllatok = haziAllatok + valasztek[rnd.Next(0, 8)] + ';'; //string tulajdonság CSAK OLVASHATÓ
                }
            }
            else
            {
                haziAllatok = "";
            }
        }
        //Függvények/metódusok
        static bool IsSzokoev(int ev)
        {
            if (ev % 4 != 0)
            {
                return false;
            }
            else if (ev % 100 == 0)
            {
                return false;
            }
            else if (ev % 400 != 0)
            {
                return false;
            }
            return true;
        }
    }
}
