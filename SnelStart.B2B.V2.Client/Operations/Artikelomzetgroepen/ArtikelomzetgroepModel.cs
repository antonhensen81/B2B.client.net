using System;

namespace SnelStart.B2B.V2.Client.Operations
{
    public class ArtikelomzetgroepModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "artikelomzetgroepen";

        /// <summary>
        /// Geeft een instantie van een <see cref="ArtikelomzetgroepModel"/> terug.
        /// </summary>
        public ArtikelomzetgroepModel() : base(ResourceName)
        {
        }

        public int Nummer { get; set; }

        public string Omschrijving { get; set; }
    }
}
