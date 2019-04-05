using System;

namespace SnelStart.B2B.V2.Client.Operations
{
    public class DocumentModel : IdentifierModel
    {
        public DocumentModel(string resource) : base(resource)
        {
        }

        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "documenten";

        /// <summary>De public identifier van de gekoppelde parent.</summary>
        public Guid ParentIdentifier { get; set; }

        /// <summary>Geeft de filename terug</summary>
        public string FileName { get; set; }

        /// <summary>Document is alleen lezen</summary>
        public bool ReadOnly { get; set; }
    }

}
