using System.Collections.Generic;

namespace SnelStart.B2B.Client.Operations
{
    public class GrootboekMutatieModel : IdentifierModel
    {              
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public new const string ResourceName = "grootboekmutaties";

        public GrootboekMutatieModel(string resource) : base(resource)
        {
        }

        /// <summary>Het grootboek</summary>
        public GrootboekIdentifierModel Grootboek { get; set; }

        /// <summary>De kostenplaats</summary>
        public KostenplaatsIdentifierModel Kostenplaats { get; set; }

        /// <summary>Datum</summary>
        public System.DateTimeOffset Datum { get; set; }

        /// <summary>Datum aangemaakt of voor het laatst gewijzigd</summary>
        public System.DateTimeOffset ModifiedOn { get; set; }

        public DagboekIdentifierModel Dagboek { get; set; }

        /// <summary>De omschrijving</summary>
        public string Omschrijving { get; set; }

        /// <summary>Debet</summary>
        public decimal Debet { get; set; }

        /// <summary>Credit</summary>
        public decimal Credit { get; set; }

        /// <summary>Waarde Debet - Credit</summary>
        public decimal Saldo { get; set; }

        /// <summary>De bijlagen van deze grootboekmutatie</summary>
        public IEnumerable<DocumentModel> Documents { get; set; }
    }
}
