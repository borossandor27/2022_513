using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.SqlServer.Server;

namespace Telekocsi
{
    internal class Program
    {
        static List<Auto> autok = new List<Auto>();
        static List<Igeny> igenyek = new List<Igeny>();
        static void Main(string[] args)
        {
            autokBeolvasasa("autok.csv", ref autok);
            igenyekBeolvasasa("igenyek.csv", ref igenyek);
            feladat02();
            feladat03();
            feladat04();
            feladat05();
            feladat06();
            Console.WriteLine("\nProgram vége!");
            Console.ReadLine();
        }

        private static void feladat06()
        {
            Console.WriteLine("\n6. feladat");
            Console.WriteLine("\tutasuzenetek.txt létrehozása ...");
            using (StreamWriter sw = new StreamWriter("utasuzenetek.txt"))
            {
                foreach (Igeny igeny in igenyek)
                {
                    var talalat = autok.Find(a => igeny.Indulas.Equals(a.Indulas) && igeny.Cel.Equals(a.Cel) && igeny.Szemelyek <= a.Ferohely);
                    if (talalat != null)
                    {
                        sw.WriteLine($"{igeny.Azonosito}: Rendszám: {talalat.Rendszam}, Telefonszám: {talalat.Telefonszam}");
                    }
                    else
                    {
                        sw.WriteLine($"{igeny.Azonosito}: Sajnos nem sikerült autót találni!");
                    }
                }
            }
            
 
        }

        private static void feladat05()
        {
            Console.WriteLine("\n5. feladat");
            foreach (Igeny igeny in igenyek)
            {
                var talalat = autok.Find(a => igeny.Indulas.Equals(a.Indulas) && igeny.Cel.Equals(a.Cel) && igeny.Szemelyek <= a.Ferohely);
                if (talalat!=null)
                {
                    Console.WriteLine($"\t{igeny.Azonosito} => {talalat.Rendszam}");
                }
            }

        }

        private static void feladat04()
        {
            //-- Határozza meg és írja ki, hogy melyik volt
            //   az az útvonal (induló- és célállomás),
            //   amelyhez a legtöbb férőhelyet ajánlották fel a hirdetők!
            Console.WriteLine("\n4. feladat");
            var utak = autok.GroupBy(a => new { a.Indulas, a.Cel }).Select(b => new { ut = b.Key, fo = b.Sum(c => c.Ferohely) }).OrderByDescending(d => d.fo).FirstOrDefault();
            Console.WriteLine($"A legtöbb férőhelyet ({utak.fo}-et) a {utak.ut.Indulas} - {utak.ut.Cel} útvonalon ajánlották fel a hirdetők");
        }

        private static void feladat03()
        {
            //-- Határozza meg és írja ki a képernyőre,
            //hogy Budapestről Miskolcra összesen hány férőhelyet hirdettek a sofőrök!
            Console.WriteLine("\n3. feladat");
            int db = autok.FindAll(a => a.Indulas.Equals("Budapest")&& a.Cel.Equals("Miskolc")).Count();
            Console.WriteLine($"\tÖsszesen {db} férőhelyet hirdettek az autósok Budapestről Miskolcra");

        }

        private static void feladat02()
        {
            Console.WriteLine("\n2. feladat");
            Console.WriteLine($"\t{autok.Select(a => a.Rendszam).ToList().Distinct().Count()} autós hirdetett fuvart");
        }

        private static void igenyekBeolvasasa(string forras, ref List<Igeny> igenyek)
        {
            Console.WriteLine($"{forras} fájl beolvasása..."); ;
            try
            {
                foreach (string item in File.ReadAllLines(forras, Encoding.Default).Skip(1))
                {
                    igenyek.Add(new Igeny(item.Split(';')));
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        private static void autokBeolvasasa(string forras, ref List<Auto> autok)
        {
            Console.WriteLine($"{forras} fájl beolvasása..."); ;
            try
            {
                foreach (string item in File.ReadAllLines(forras, Encoding.Default).Skip(1))
                {
                    autok.Add(new Auto(item.Split(';')));
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
