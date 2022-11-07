using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsOrszagok
{
    internal class Orszag
    {
        readonly int id;
        readonly string orszagNev;
        readonly string fovaros;
        readonly double terulet;
        readonly double nepesseg;
        readonly string allamforma;

        public int Id => id;

        public string OrszagNev => orszagNev;

        public string Fovaros => fovaros;

        public double Terulet => terulet;

        public double Nepesseg => nepesseg;

        public string Allamforma => allamforma;

        public Orszag(int id, string orszagNev, string fovaros, double terulet, double nepesseg, string allamforma)
        {
            this.id = id;
            this.orszagNev = orszagNev;
            this.fovaros = fovaros;
            this.terulet = terulet;
            this.nepesseg = nepesseg * 1000;
            this.allamforma = allamforma;
        }

        public override string ToString()
        {
            return orszagNev;
        }
    }
}
