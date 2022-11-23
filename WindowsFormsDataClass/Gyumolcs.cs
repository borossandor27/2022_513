using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDataClass
{
    internal class Gyumolcs
    {
        int id;
        string nev;
        double egysegAr;
        double mennyiseg;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public double EgysegAr { get => egysegAr; set => egysegAr = value; }
        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public Gyumolcs(int id, string nev, double egysegAr, double mennyiseg)
        {
            Id = id;
            Nev = nev;
            EgysegAr = egysegAr;
            Mennyiseg = mennyiseg;
        }
        public override string ToString()
        {
            return nev;
        }
    }
}
