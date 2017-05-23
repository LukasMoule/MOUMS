using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moums.DataTypes;
using Moums.Models.Artikel;

namespace Moums.Models
{
    public interface IUnternehmen
    {

        string FirmenName { get; set; }
        Adresse Adresse { get; set; }
        Branche Branche { get; set; }
        int Id { get; set; }

    }
}
