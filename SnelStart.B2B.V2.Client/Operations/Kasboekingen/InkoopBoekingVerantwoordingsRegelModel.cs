using SnelStart.B2B.V2.Client.Operations;

namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// Container met gegevens voor een boekingsreegel met een inkoopboeking
    /// </summary>
    public class InkoopBoekingVerantwoordingsRegelModel : VerantwoordingsRegelModel
    {
        /// <summary>
        /// Verwijzing naar een inkoopboeking
        /// </summary>
        public InkoopboekingIdentifierModel BoekingId { get; set; }
    }
}