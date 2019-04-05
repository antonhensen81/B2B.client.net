using System;

namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public class InkoopboekingIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// 
        /// </summary>
        public InkoopboekingIdentifierModel() : base(InkoopboekingModel.ResourceName)
        {
        }

        internal InkoopboekingIdentifierModel(Guid id):this()
        {
            Id = id;
        }
    }
}