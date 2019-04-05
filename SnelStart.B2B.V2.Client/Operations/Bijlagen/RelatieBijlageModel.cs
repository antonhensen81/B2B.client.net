using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class RelatieBijlageModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "relaties/{RelatieId}/bijlagen";
        /// <summary>
        /// 
        /// </summary>
        protected RelatieBijlageModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// Geeft de naam van de resource (type object) terug waartoe deze identifier behoort.
        /// </summary>
        protected override string Resource()
        {
            return $"relaties/{RelatieId}/bijlagen";
        }

        /// <summary>
        /// De public identifier van de gekoppelde relatie.
        /// </summary>
        public Guid RelatieId { get; set; }

        /// <summary>
        /// De naam van de bijlage.
        /// </summary>
        public string FileName { get; set; }
    }
}
