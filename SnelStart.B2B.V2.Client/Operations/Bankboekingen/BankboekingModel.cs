using System;


namespace SnelStart.B2B.V2.Client.Operations
{

    public class BankboekingModel : IdentifierModel
    {
        /// <summary>
        /// 
        /// </summary>
        public const string ResourceName = "bankboekingen";
        public BankboekingModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// Het tijdstip waarop de bankboeking is aangemaakt of voor het laatst is gewijzigd
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        public DateTime Datum { get; set; }

        /// <summary>
        /// Deze bankboeking verdient speciale aandacht, in SnelStart wordt dit visueel benadrukt.
        /// </summary>
        public bool Markering { get; set; }

        /// <summary>
        /// Het boekstuknummer van de bankboeking.</summary>
        public string Boekstuk { get; set; }

        /// <summary>
        /// Geeft aan of deze bankboeking is aangepast door de accountant.
        /// </summary>
        public bool GewijzigdDoorAccountant { get; set; }

        public string Omschrijving { get; set; }

        public GrootboekBoekingsRegelModel[] GrootboekBoekingsRegels { get; set; } = new GrootboekBoekingsRegelModel[0];

        public InkoopBoekingVerantwoordingsRegelModel[] InkoopboekingBoekingsRegels { get; set; } = new InkoopBoekingVerantwoordingsRegelModel[0];

        public VerkoopBoekingVerantwoordingsRegelModel[] VerkoopboekingBoekingsRegels { get; set; } = new VerkoopBoekingVerantwoordingsRegelModel[0];

        public BtwBoekingregelModel[] BtwBoekingsregels { get; set; } = new BtwBoekingregelModel[0];

        public decimal BedragUitgegeven { get; set; }

        public decimal BedragOntvangen { get; set; }

        public DagboekIdentifierModel Dagboek { get; set; }
    }
}