using System;

namespace HarmadikKorep
{
    internal class Person
    {
        private string dolgozik;
        
        public string Nev { get; private set; }
        public DateTime SzuletesiDatum { get; private set; }
        public int IranyitoSzam { get; private set; }
        public bool isDolgozik { get; private set; }

        public Person(string nev, DateTime szuldat, int ir, bool dolgoz)
        {
            Nev = nev;
            SzuletesiDatum = szuldat;
            IranyitoSzam = ir;
            isDolgozik = dolgoz;
        }

        public Person(string ForrasEgySora)
        {
            string[] src = ForrasEgySora.Split(';');
            Nev = src[0];
            SzuletesiDatum = DateTime.Parse(src[1]);
            IranyitoSzam = int.Parse(src[2]);
            dolgozik=src[3];
            if (dolgozik == "Van")
            {
                isDolgozik = true;
            }
            else isDolgozik = false;
        }

        public override string ToString()
        {
            return $"{Nev};{SzuletesiDatum.ToShortDateString()};{IranyitoSzam};{isDolgozik}";
        }

        public bool VaneMunka()
        {
            return isDolgozik;
        }
    }
}