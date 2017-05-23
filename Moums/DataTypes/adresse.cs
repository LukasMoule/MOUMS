using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moums.DataTypes
{
    public class Adresse
    {
        public string Strasse { get; set; }
        public int PLZ { get; set; }
        public string Ort { get; set; }
        public string Land { get; set; }

        public Adresse(string strasse,int pLZ, string ort,string land)
        {
            Strasse = strasse;
            PLZ = pLZ;
            Ort = ort;
            Land = land;

        }

        public Adresse()
        {
            Strasse = "";
            PLZ = 0;
            Ort = "";
            Land = "";
        }
        
    }
}
