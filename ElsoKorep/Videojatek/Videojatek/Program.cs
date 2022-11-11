using System;

namespace Videojatek
{
    class Program
    {
        static void Megjelenit(Jatek[] js)
        {
            for (int i = 0; i < js.Length; i++)
            {
                Console.WriteLine($"{js[i].Mufaj}\t {js[i].Ar}\t {js[i].KiadasEve}\t {js[i].Platform}\t {js[i].PEGI}");
            }
        }

        static int LegregebbiJatek(Jatek[] js)
        { 
            int index = 0;
            int kiindulas = 2021;

            for (int i = 0; i < js.Length; i++)
            {
                if (js[i].KiadasEve <= kiindulas)
                {
                    kiindulas = js[i].KiadasEve;
                    index = i;
                }
            }

            return index;
        }
        static void HanyJatek(Jatek[] js, string platform)
        {
            int cntr = 0;
            for (int i = 0; i < js.Length; i++)
            {
                if (js[i].Platform == platform)
                {
                    cntr++;
                }
            }
            Console.WriteLine($"A boltban {platform} platformra {cntr}db játék található");
        }
        static double Atlag(Jatek[] js, string mufaj)
        {
            double atlag = 0;
            double cntr = 0;
            double summa = 0;
            for (int i = 0; i < js.Length; i++)
            {
                if (js[i].Mufaj == mufaj)
                {
                    summa += js[i].PEGI;
                    cntr++;
                }
            }
            atlag = summa / cntr;
            return Math.Round(atlag);
        }
        
        static void Main(string[] args)
        {
            /*megj.:
            Jatek CallofBugyi = new Jatek("Hentai", 20310, 1, "pc", 12);
            Console.WriteLine(CallofBugyi.Mufaj);*/
            
            int jatekokSzama = int.Parse(Console.ReadLine());
            Jatek[] jateks = new Jatek[jatekokSzama];
            Random rnd = new Random();

            for (int i = 0; i < jatekokSzama; i++)
            {
                string[] mufajok = new string[] {"RPG", "action", "RTS", "sport", "MMORPG", "indie"};
                string[] platformok = new string[] { "PC","XBOX", "PS"};
                byte[] pegik = new byte[] { 3, 7, 12, 16, 18 }; //5

                string mufaj = mufajok[rnd.Next(mufajok.Length)];
                int kiadev = rnd.Next(1990,2022);
                double ar = (1 - (2021 - kiadev) / 50.0) * 20000;
                string platform = platformok[rnd.Next(platformok.Length)];
                byte pegi = pegik[rnd.Next(pegik.Length)];


                jateks[i] = new Jatek(mufaj,ar,kiadev,platform,pegi); 
            }

            Megjelenit(jateks);
            Console.WriteLine($"A boltban a legrégebbi játékot {jateks[LegregebbiJatek(jateks)].KiadasEve}-ben/ban adták ki");
            HanyJatek(jateks,"PC");
            Console.WriteLine($"A keresett műfajra az átlag életkor: {Atlag(jateks,"RPG")}");


            Console.ReadLine();
        }
    }
}
