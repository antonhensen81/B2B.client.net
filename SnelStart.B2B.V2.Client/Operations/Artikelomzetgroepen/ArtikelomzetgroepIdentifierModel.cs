namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een Artikelomzetgroep.
    /// </summary>
    public class ArtikelomzetgroepIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "artikelomzetgroepen";

        /// <summary>
        /// Geeft een instantie van een <see cref="ArtikelomzetgroepModel"/> terug.
        /// </summary>
        public ArtikelomzetgroepIdentifierModel() : base(ResourceName)
        {
        }

        internal ArtikelomzetgroepIdentifierModel(string resourceName) : base(resourceName)
        {
        }
    }
}