using System;

namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een verwijzing naar een verkoopboeking.
    /// </summary>
    public class VerkoopboekingIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// De gegevenscontainer voor een verwijzing naar een verkoopboeking.
        /// </summary>
        public VerkoopboekingIdentifierModel() : base(VerkoopBoekingModel.ResourceName)
        {
        }

        internal VerkoopboekingIdentifierModel(Guid id) : this()
        {
            Id = id;
        }
    }
}