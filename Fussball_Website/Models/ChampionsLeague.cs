using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models {
    public class ChampionsLeague {
        private int ChampionsLeagueID;

        public int ChampionsLeagueID {
            get { return this.ChampionsLeagueID; }
            set {
                if (value >= 0) {
                    this.ChampionsLeagueID = value;
                }
            }
        }
        public string Mannschaft { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
