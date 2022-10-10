using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasmegye
{
    internal class SzemelyiSzam
    {
        readonly string szam;

        public string Szam => szam;

        public SzemelyiSzam(string szam)
        {
            this.szam = szam;
        }
        public int evSzam()
        {
            int ev = int.Parse(szam.Substring(2,2));
            ev = szam[0] == '1' || szam[0] == '2' ? 1900 + ev : 2000 + ev;
            return ev;
        }
    }
}
