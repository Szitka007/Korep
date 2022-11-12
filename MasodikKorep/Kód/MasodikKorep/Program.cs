using System;


namespace MasodikKorep
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Szemely KovacsJanos = new Szemely("Kovács János", "1969.4.20",1046);
            Console.WriteLine(KovacsJanos.Nev);
            Console.WriteLine(KovacsJanos.IranyitoSzam);
            Console.WriteLine(KovacsJanos.SzuletesiDatum);*/

            Szemely[] emberek = new Szemely[5];
            for (int i = 0; i < 5; i++)
            {
                emberek[i] = new Szemely();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(emberek[i].Nev + " ");
                Console.Write(emberek[i].SzuletesiDatum + " ");
                Console.Write(emberek[i].IranyitoSzam + " ");
                Console.Write("Egyéb tulajdonságok: ");
                Console.Write($"{emberek[i].SzuletesiEv} ");
                Console.Write($"{emberek[i].Hanyeves} éves ");
                Console.Write($"Macska: {emberek[i].VanMacskaja} ");
                Console.Write($"{emberek[i].HanyHaziAllataVan} ");
                Console.Write($"{emberek[i].HanyTipusuHaziAllat} ");
                Console.WriteLine();
            }






            //Házifeladat lábjegyzet

            /*int hanyszor = 12;
            for (int i = 0; i < hanyszor; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    //vízszintesek
                    for (int i = 0; i < length; i++)
                    {

                    }
                    for (int i = 0; i < length; i++)
                    {

                    }

                    //Függőlegesek
                    for (int i = 0; i < length; i++)
                    {

                    }
                    for (int i = 0; i < length; i++)
                    {

                    }
                }
            }*/
            
            
            Console.ReadKey();
        }
    }
}
