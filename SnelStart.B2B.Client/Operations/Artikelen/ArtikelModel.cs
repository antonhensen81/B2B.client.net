using System;

namespace SnelStart.B2B.Client.Operations
{
    public class ArtikelModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "artikelen";

        /// <summary>
        /// Geeft een instantie van een <see cref="ArtikelModel"/> terug.
        /// </summary>
        public ArtikelModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// Datum waarop de gegevens van dit artikel zijn aangepast
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        public string Artikelcode { get; set; }

        public string Omschrijving { get; set; }

        public ArtikelomzetgroepIdentifierModel ArtikelOmzetgroep { get; set; }

        public double? Verkoopprijs { get; set; }

        /// <summary>
        /// Een vlag dat aangeeft of een artikel niet meer actief is binnen de administratie.
        /// </summary>
        public bool IsNonactief { get; }

        /// <summary>
        /// Een vlag dat aangeeft of voor een artikel wel of geen voorraad wordt bijgehouden.
        /// </summary>
        public bool Voorraadcontrole { get; set; }

        public double TechnischeVoorraad { get; }

        public double VrijeVoorraad { get; }

        public PrijsafspraakModel Prijsafspraak { get; set; }
    }
}
