namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een Artikel.
    /// </summary>
    public class ArtikelIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "artikelen";

        /// <summary>
        /// Geeft een instantie van een <see cref="ArtikelModel"/> terug.
        /// </summary>
        public ArtikelIdentifierModel() : base(ResourceName)
        {
        }

        internal ArtikelIdentifierModel(string resourceName) : base(resourceName)
        {
        }
    }
}