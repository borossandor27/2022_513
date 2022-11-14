using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAutok2
{
    internal class Auto
    {
        int id;
        string rendszam;
        int evjarat;
        string szin;

        public int Id { get => id; set => id = value; }
        public string Rendszam { get => rendszam; set => rendszam = value; }
        public int Evjarat { get => evjarat; set => evjarat = value; }
        public string Szin { get => szin; set => szin = value; }

        public Auto(int id, string rendszam, int evjarat, string szin)
        {
            Id = id;
            Rendszam = rendszam;
            Evjarat = evjarat;
            Szin = szin;
        }
        public override string ToString()
        {
            return rendszam + " (" + evjarat + ") " + szin;
        }
    }
}
