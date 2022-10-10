using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vasmegye
{
    internal class Program
    {
        static List<SzemelyiSzam> szemelyiSzamok = new List<SzemelyiSzam>();
        static void Main(string[] args)
        {
            Console.WriteLine("2. feladat: Adatok beolvasása, tárolása");
            adatokBeolvasasa("vas.txt");
            Console.WriteLine("\n4. feladat: Ellenőrzés");
            feladat04();
            Console.WriteLine($"\n5. feladat: Vas megyében a vizsgált évek alatt {szemelyiSzamok.Count} csecsemő született.");
            Console.WriteLine($"\n6. feladat: Fiúk száma {szemelyiSzamok.FindAll(a => a.Szam[0]=='1' || a.Szam[0] =='3').Count} csecsemő született.");
            Console.WriteLine($"\n7. feladat: Vizsgált időszak {szemelyiSzamok.Min(a => a.evSzam())} - {szemelyiSzamok.Max(a => a.evSzam())}");
            if (szokoEvbenSzuletett())
            {
                Console.WriteLine("8. feladat: Szökőnapon született baba!");
            }
            else
            {
                Console.WriteLine("8. feladat: Szökőnapon nem született baba!");
            }
            feladat09();
            Console.WriteLine("\nProgram vége");
            Console.ReadLine();
        }

        private static void feladat09()
        {
            Console.WriteLine("9. feladat: Statisztika");
            var statisztika = szemelyiSzamok.GroupBy(a => a.evSzam()).Select(b => new { ev = b.Key, fo = b.Count() });
            foreach (var item in statisztika)
            {
                Console.WriteLine($"\t{item.ev} - {item.fo} fő");
            }
        }

        private static bool szokoEvbenSzuletett()
        {
            var szokoEvi = szemelyiSzamok.Find(a => a.evSzam() % 4 == 0 && a.Szam.Substring(4, 4).Equals("0224"));
            return szokoEvi != null;
        }

        private static void feladat04()
        {
            List<SzemelyiSzam> hibasSzamok = szemelyiSzamok.FindAll(a => !CdvEll(a.Szam));
            //foreach (SzemelyiSzam item in szemelyiSzamok)
            //{
            //    if (!CdvEll(item.Szam))
            //    {
            //        hibasSzamok.Add(item);
            //    }
            //}
            foreach (SzemelyiSzam item in hibasSzamok)
            {
                Console.WriteLine($"\tHibás a {item.Szam} személyi azonosító!");
                szemelyiSzamok.Remove(item);
            }
        }

        public static bool CdvEll(string szam)
        {
            //-- 3. feladat 1-980227-1258
            string szamNumeric = new string(szam.Where(a => char.IsDigit(a)).ToArray());
            if (szamNumeric.Length != 11)
            {
                return false;
            }
            double szum = 0;
            for (int i = 0; i < szamNumeric.Length-1; i++)
            {
                szum += char.GetNumericValue(szamNumeric[i]) * (10 - i);
            }
            return char.GetNumericValue(szamNumeric[10]) == szum % 11;
        }

        private static void adatokBeolvasasa(string adatFile)
        {
            if (!File.Exists(adatFile))
            {
                Console.WriteLine("A forrás adatok hiányoznak!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            using (StreamReader sr = new StreamReader(adatFile))
            {
                while (!sr.EndOfStream)
                {
                    szemelyiSzamok.Add(new SzemelyiSzam(sr.ReadLine()));
                }
            }
        }
    }
}
