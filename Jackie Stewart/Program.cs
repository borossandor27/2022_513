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
            Console.WriteLine("\nprogram vége!");
            Console.Read();
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
