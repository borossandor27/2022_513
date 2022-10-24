using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jackie_Stewart
{
    internal class Program
    {
        static List<EvesAdat> evesAdatok = new List<EvesAdat>();
        static void Main(string[] args)
        {
            feladat02("jackie.txt");
            feladat03();
            feladat04();
            feladat05();
            feladat06();
            Console.WriteLine("\nprogram vége!");
            Console.Read();
        }

        private static void feladat06()
        {

            string htmlFajl = "<!DOCTYPE html><html lang=\"hu\"><head>    <meta charset=\"UTF-8\">    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">    <meta name=\"viewport\" content=\"width=<, initial-scale=1.0\">    <title>Document</title></head><body>    <h1>Jackie Stuart</h1>" +
                "<table>" +
                "<tr><th>év</th><th>versenyek</th><th>győzelmek</th></tr>";
            foreach (EvesAdat item in evesAdatok)
            {
                htmlFajl += $"<tr><td>{item.Year}</td><td>{item.Races}</td><td>{item.Wins}</td></tr> ";
            }
            htmlFajl += "</table></body></html>";
            File.WriteAllText("Jackie.html", htmlFajl);
            Console.WriteLine("\n6. feladat: Jackie.html");
        }

        private static void feladat05()
        {
            Console.WriteLine("\n5. feladat:");
            var megnyertVersenyek = evesAdatok.GroupBy(a => Math.Round((a.Year / 10.0), 0)).Select(b => new { evek = b.Key, db = b.Sum(c => c.Wins) });
            foreach (var item in megnyertVersenyek)
            {
                Console.WriteLine($"\t{item.evek}0-es évek: {item.db} megnyert verseny");
            }
        }

        private static void feladat04()
        {
            EvesAdat legtobbVerseny = evesAdatok.Find(a => a.Races == evesAdatok.Max(b => b.Races));
            Console.WriteLine($"\n4. feladat: {legtobbVerseny.Year}");
        }

        private static void feladat03()
        {
            Console.WriteLine($"\n3.feladat: {evesAdatok.Count}");
        }

        /***
        * olvassa be a jackie.txt állomány sorait,  és tárolja az adatokat  
        * egy összetett adatszerkezetben
        */
        private static void feladat02(string adatForras)
        {
            if (File.Exists(adatForras))
            {
                using (StreamReader sr = new StreamReader(adatForras, Encoding.Default))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        evesAdatok.Add(new EvesAdat(sr.ReadLine().Split('\t')));
                    }

                }
            }
            else
            {
                Console.WriteLine("Hiányzó adataforrás!\nA program leáll!");
                Console.Read();
                Environment.Exit(0);
            }
        }
    }
}
