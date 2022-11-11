using System;

namespace Videojatek
{
    internal class Jatek
    {
        public string Mufaj;
        public double Ar;
        public int KiadasEve;
        public string Platform;
        public byte PEGI;

        public Jatek(string mufaj, double ar, int kiadaseve, string platform, byte pegi)
        {
            Mufaj = mufaj;
            Ar = ar;
            KiadasEve = kiadaseve;
            Platform = platform;
            PEGI = pegi;
        }
    }
}
