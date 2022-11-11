using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartyas
{
    internal class Pakli
    {
        public Kartya[] pakli = new Kartya[52];
        string[] szinek = new string[] { "Kör", "Káró", "Treff", "Pikk" };
        string[] ertekek = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        int ind = 0;
        Random random = new Random();

        public Pakli()
        {
            for (int i = 0; i < szinek.Length; i++)
            {
                for (int j = 0; j < ertekek.Length; j++)
                {
                    pakli[ind] = new Kartya(szinek[i], ertekek[j]);
                    ind++;
                }
            }
        }

        public void PakliTerites()
        {
            for (int i = 0; i < pakli.Length; i++)
            {
                Console.WriteLine($"{pakli[i].szin} {pakli[i].ertek}");
            }
        }
        public Pakli Keveres(int cntr, Pakli p)
        {
            Random rnd = new Random();
            Pakli a = p;
            for (int i = 0; i < cntr; i++)
            {
                int egyikIndex = rnd.Next(52);
                int masikIndex = rnd.Next(52);
                Kartya egyik = a.pakli[egyikIndex];
                Kartya masik = a.pakli[masikIndex];
                Kartya seged = egyik;
                egyik = masik;
                masik = seged;
                a.pakli[egyikIndex] = egyik;
                a.pakli[masikIndex] = masik;
            }

            return a;
        }
        public Kartya Huzas(int i)
        {
            Kartya a = pakli[i];
            return a;
        }
        public void Mutatas(Kartya a)
        {
            Console.WriteLine($"{a.szin} {a.ertek}");
        }
    }
}
