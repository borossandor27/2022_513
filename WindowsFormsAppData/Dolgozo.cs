using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppData
{
    class Dolgozo
    {
        int id;
        string nev;
        DateTime szuletett;
        bool hazas;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletett { get => szuletett; set => szuletett = value; }
        public bool Hazas { get => hazas; set => hazas = value; }

        public Dolgozo(int id, string nev, DateTime szuletett, bool hazas)
        {
            Id = id;
            Nev = nev;
            Szuletett = szuletett;
            Hazas = hazas;
        }
    }
}
