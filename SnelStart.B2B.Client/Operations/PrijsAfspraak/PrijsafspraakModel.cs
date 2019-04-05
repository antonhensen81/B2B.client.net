using System;

namespace SnelStart.B2B.Client.Operations
{
    public class PrijsafspraakModel
    {
        /// <summary>
        /// Relatie waarvoor de prijs van een artikel moet worden berekend. Dit veld is verplicht
        /// </summary>
        public RelatieIdentifierModel Relatie { get; set; }

        /// <summary>
        /// Het artikel waarvoor de prijs moet worden berekend. Dit veld is verplicht
        /// </summary>
        public ArtikelIdentifierModel Artikel { get; set; }

        /// <summary>
        /// Een prijsafspraak kan afhankelijk zijn van een datum. Geef hier de datum op waarop de prijsafspraak moet gelden. Optioneel veld
        /// </summary>
        public DateTime? Datum { get; set; }

        /// <summary>
        /// Het te leveren aantal. Dit veld is verplicht
        /// </summary>
        public decimal Aantal { get; set; }

        /// <summary>
        /// Het kortingpercentage van deze prijsafspraak. Dit is een readonly veld
        /// </summary>
        public decimal Korting { get; set; }

        /// <summary>
        /// De verkoopprijs van het artikel obv de geldende prijsafspraak.
        /// </summary>
        public decimal Verkoopprijs { get; set; }

        /// <summary>
        /// De basis verkoopprijs van het artikel zonder prijsafspraken.
        /// </summary>
        public decimal Basisprijs { get; set; }

        /// <summary>
        /// De datum vanaf wanneer de huidig geldende prijsafspraak geldig is. Dit veld is leeg indien niet van toepassing.
        /// </summary>
        public DateTime? DatumVanaf { get; set; }

        /// <summary>
        /// De datum tot en met de huidig geldende prijsafspraak geldig is. Dit veld is leeg indien niet van toepassing.
        /// </summary>
        public DateTime? DatumTotEnMet { get; set; }

        /// <summary>
        /// De prijsbepalingsoort van de huidig geldende prijsafspraak geldig is.
        /// </summary>
        public PrijsBepalingSoortModel PrijsBepalingSoort { get; set; }
    }
}
