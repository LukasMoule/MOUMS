using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moums.DataTypes;

namespace Moums.Models
{
    public class Kunde : IUnternehmen
    {
        public Adresse Adresse { get; set; }

        public Branche Branche { get; set; }

        public string FirmenName { get; set; }

        public int Id { get; set; }
    }
}
