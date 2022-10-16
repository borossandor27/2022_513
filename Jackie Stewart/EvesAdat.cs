using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackie_Stewart
{/**
  * jackie.txt állomány sorait tárolja 
  */
    internal class EvesAdat
    {
        /// <summary>
        /// a versenyzés éve (year), például: 1-973
        /// </summary>
        readonly int year;
        /// <summary>
        /// hany versenyen  indult (races), például: ]-8
        /// </summary>
        readonly int races;
        /// <summary>
        /// hány versenyt  nyert meg (wins), például: s
        /// </summary>
        readonly int wins;
        /// <summary>
        /// hányszor volt dobogós  eredménye (podíums)' például: 9
        /// </summary>
        readonly int podiums;
        /// <summary>
        /// hányszor  indult első  helyről  (po1es), például: 4
        /// </summary>
        readonly int poles;
        /// <summary>
        /// hiínyszor volt övé  a leggyorsabb  kör  (f astests},  például: 1
        /// </summary>
        readonly int fastests;

        public EvesAdat(string[] sor)
        {
            this.year = int.Parse(sor[0]);
            this.races = int.Parse(sor[1]);
            this.wins = int.Parse(sor[2]);
            this.podiums = int.Parse(sor[3]);
            this.poles = int.Parse(sor[4]);
            this.fastests = int.Parse(sor[5]);
        }

    
    }
}
