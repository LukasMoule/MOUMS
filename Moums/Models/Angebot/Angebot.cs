using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moums.Models.Artikel;
using Moums.Models;

namespace Moums.Models.Angebot
{
    public class Angebot
    {
        private string angebotsNummer;
        private Kunde kunde;
        private List<IArtikel> artikelListe;
        private double frachtkosten;
        private string versandart;
        private string verpackung;
        private Lieferzeit lieferzeit;
        private DateTime lieferDatum;
        private DateTime gueltigkeitsDatum;
        private IEnumerable<Nachlass> nachlass;
    }
}
