using System;
using System.IO;

/*
 * "C:\\hol\van\a\fajl.txt" -> abszolút
 * 
 * "..\..\fajl.txt" -> relatív
 */

namespace HarmadikKorep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[1500];

            StreamReader sr = new StreamReader("src.txt");
            int item = 0;
            while (!sr.EndOfStream)
            {
                people[item] = new Person(sr.ReadLine());
                item++;
            }
            sr.Close();

            Console.WriteLine($"Ebben a csoportban {HanyEmberDolgozik(people)} ember dolgozik és {HanyEmberMunkanelkuli(people)} ember munkanélküli");

            Person[] FutyCsalad = new Person[IlyenNevuEmberDb("Füty",people)];

            for (int i = 0; i < FutyCsalad.Length; i++)
            {
                for (int j = 0; j < people.Length; j++)
                {
                    string[] full = people[j].Nev.Split(' ');
                    if (full[0] == "Füty")
                    {
                        FutyCsalad[i] = people[j];
                    }
                }
            }

            bool imre = VaneImre(FutyCsalad);

            DateTime most = DateTime.Today;
            StreamWriter sw = new StreamWriter("cel.txt", true);
            for (int i = 0; i < people.Length; i++)
            {
                TimeSpan eves = most - people[i].SzuletesiDatum;
                sw.WriteLine($"{people[i].Nev} most {eves.Days/365} éves");
            }


            
            
            Console.ReadKey();

        }

        static int HanyEmberDolgozik(Person[] people)
        {
            int cntr = 0;
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].isDolgozik)
                {
                    cntr++;
                }
            }
            return cntr;
        }

        static int HanyEmberMunkanelkuli(Person[] people)
        {
            int cntr = 0;
            for (int i = 0; i < people.Length; i++)
            {
                if (!people[i].isDolgozik)
                {
                    cntr++;
                }
            }
            return cntr;
        }
        static int IlyenNevuEmberDb(string nev, Person[] p)
        {
            int cntr = 0;
            for (int i = 0; i < p.Length; i++)
            {
                string[] teljesnev = p[i].Nev.Split(' ');
                string csaladnev = teljesnev[0];
                string keresztnev = teljesnev[1];
                if (csaladnev == nev || keresztnev == nev)
                {
                    cntr++;
                }
            }
            return cntr;
        }
        static bool VaneImre(Person[] p)
        {
            int szam = IlyenNevuEmberDb("Imre",p);
            if (szam == 0) return false;
            else return true;
        }
    }
}
