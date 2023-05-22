﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConVizibicikli
{
    internal class Program
    {
        static List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();

        static void Main(string[] args)
        {
            /*
            // Hagyományos
            StreamReader sr = new StreamReader("Datasources\\kolcsonzesek.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var mezok = sr.ReadLine().Split(';');
                Kolcsonzes ujAdat = new Kolcsonzes(mezok[0],
                                                   mezok[1][0],
                                                   int.Parse(mezok[2]),
                                                   int.Parse(mezok[3]),
                                                   int.Parse(mezok[4]),
                                                   int.Parse(mezok[5]));
            }
            sr.Close();
            */
            

            // LINQ + Foreach + Konstruktor
            /*foreach (var sor in File.ReadAllLines("Datasources\\kolcsonzesek.txt"))
            {
                kolcsonzesek.Add(new Kolcsonzes(sor));
            }
            */

            // LINQ
            kolcsonzesek = File.ReadAllLines("Datasources\\kolcsonzesek.txt").Skip(1).Select(x => new Kolcsonzes(x)).ToList();

            // 5.
            Console.WriteLine($"5. feladat: Napi kölcsönzések száma: {kolcsonzesek.Count()}");

            // 6.
            Console.Write($"6. feladat: Kérek egy nevet: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"\t{nev} kölcsönzései:");

            if (kolcsonzesek.Count(x => x.Nev == nev) == 0)
            {
                Console.WriteLine("Nem volt ilyen nevű kölcsönző");
            }
            else
            {
                /*foreach (var akt in kolcsonzesek.Where(x => x.Nev == nev))
                {
                    Console.WriteLine($"\t{akt.EOra}:{akt.EPerc}-{akt.VOra}:{akt.VPerc}");
                }*/

                kolcsonzesek.Where(x => x.Nev == nev).ToList().ForEach(x => Console.WriteLine($"\t{x.EOra}:{x.EPerc}-{x.VOra}:{x.VPerc}"));
            }

            // 7.

            // 8.
            Console.WriteLine($"8. feladat: A napi bevétel: {2400 * kolcsonzesek.Sum(x => x.IdoHossz())/ 30 + 1} Ft");

            // 9.


            // 10.
            kolcsonzesek.GroupBy(x => x.JAzon).OrderBy(x => x.Key).ToList().ForEach(x => Console.WriteLine($"\t{x.Key} - {x.Count()}"));
        }
    }
}
