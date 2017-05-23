using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moums.Models.Artikel
{
    public interface IArtikel
    {
        IIdentification Identification { get; set; }
        IPhysicalDescription PhysicalDescription { get; set; }
        IPresentationData PresentationData { get; set; }
        ITradingData TradingData { get; set; }
        IManufacturingData ManufacturingData { get; set; }
    }
}
