using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekocsi
{
    internal class Auto
    {
        readonly string indulas;
        readonly string cel;
        readonly string rendszam;
        readonly string telefonszam;
        readonly int ferohely;

        public string Indulas => indulas;

        public string Cel => cel;

        public string Rendszam => rendszam;

        public string Telefonszam => telefonszam;

        public int Ferohely => ferohely;

        public Auto(string indulas, string cel, string rendszam, string telefonszam, int ferohely)
        {
            this.indulas = indulas;
            this.cel = cel;
            this.rendszam = rendszam;
            this.telefonszam = telefonszam;
            this.ferohely = ferohely;
        }

        public Auto(string[] sor)
        {
            this.indulas = sor[0];
            this.cel = sor[1];
            this.rendszam = sor[2];
            this.telefonszam = sor[3];
            this.ferohely = int.Parse(sor[4]);
        }
    }
}
