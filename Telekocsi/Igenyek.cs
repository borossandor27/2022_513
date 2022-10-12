using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekocsi
{
    internal class Igeny
    {
        readonly string azonosito;
        readonly string indulas;
        readonly string cel;
        readonly int szemelyek;

        public string Azonosito => azonosito;

        public string Indulas => indulas;

        public string Cel => cel;

        public int Szemelyek => szemelyek;

        public Igeny(string azonosito, string indulas, string cel, int szemelyek)
        {
            this.azonosito = azonosito;
            this.indulas = indulas;
            this.cel = cel;
            this.szemelyek = szemelyek;
        }

        public Igeny(string[] sor)
        {
            this.azonosito = sor[0];
            this.indulas = sor[1];
            this.cel = sor[2];
            this.szemelyek = int.Parse(sor[3]);
        }
    }
}
