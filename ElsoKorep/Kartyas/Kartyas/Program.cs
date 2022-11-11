using System;


namespace Kartyas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pakli p = new Pakli();
            p.PakliTerites();

            Random rnd = new Random();
            Console.WriteLine();
            p = p.Keveres(520, p);
            p.PakliTerites();

            Console.WriteLine();

            Kartya huzott = p.Huzas(0);
            p.Mutatas(huzott);

        }
    }
}
