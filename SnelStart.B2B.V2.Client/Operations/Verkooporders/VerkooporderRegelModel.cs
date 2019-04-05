using System;

namespace SnelStart.B2B.Client.Operations
{
    public class VerkooporderRegelModel
    {
        public ArtikelIdentifierModel Artikel { get; set; }

        /// <summary>
        /// Omschrijving van de orderregel. Indien deze leeg is wordt de omschrijving van het artikel in dit veld gezet.
        /// </summary>
        public string Omschrijving { get; set; }

        public double Stuksprijs { get; set; }

        public double Aantal { get; set; } 

        public double KortingsPercentage { get; set; }

        public double Totaal { get; set; } 
    }
}
