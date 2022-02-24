using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models {
    public class Rekorde {
        
        private int spielerID;
        private decimal gehalt;
        public int RekordeID {
            get { return this.spielerID; }
            set {
                if (value >= 0) {
                    this.spielerID = value;
                }
            }
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal Gehalt {
            get { return this.gehalt; }
            set {
                if (value >= 100000) {
                    this.gehalt = value;
                }
            }
        }
    }
}