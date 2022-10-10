using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nobel
{
    internal class Program
    {
        static List<KiosztottDij> kiosztottDijak = new List<KiosztottDij>();
        static void Main(string[] args)
        {

            adatokBeolvasasa();
            feladat03();
            feladat04();
            feladat05();
            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }

        private static void feladat05()
        {
            Console.WriteLine("5. feladat:");
            List<KiosztottDij> talalatiLista = kiosztottDijak.FindAll(a => a.Ev >= 1990 && a.Ev <= DateTime.Now.Year && a.Tipus.Equals("béke") && String.IsNullOrEmpty(a.Vezeteknev));
            foreach (KiosztottDij item in talalatiLista)
            {
                Console.WriteLine($"\t{item.Ev}: {item.Keresztnev}");
            }
        }

        private static void feladat04()
        {
            //-- ki kapott 2017-ben irodalmi Nóbel-díjat
            KiosztottDij keresettDij = kiosztottDijak.Find(a => a.Ev == 2017 && a.Tipus.Equals("irodalmi"));
            Console.WriteLine($"4. feladat: {keresettDij.Vezeteknev} {keresettDij.Keresztnev}");
        }

        private static void feladat03()
        {
            //-- Kiirja "Arthur B." milyen típusú díjat kapott
            KiosztottDij keresettDij = kiosztottDijak.Find(a => a.Keresztnev.Equals("Arthur B."));
            Console.WriteLine($"1. feladat: {keresettDij.Tipus}");
        }

        static void adatokBeolvasasa()
        {
            using (StreamReader sr = new StreamReader("nobel.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    KiosztottDij kiosztottDij = new KiosztottDij(int.Parse(sor[0]), sor[1], sor[2], sor[3]);
                    kiosztottDijak.Add(kiosztottDij);
                }
            }   
        } //-- elengedi az erőforrást sr.close(
    }
}
