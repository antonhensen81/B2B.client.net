namespace SnelStart.B2B.V2.Client.Operations
{
    internal class InkoopBoekingBijlagesOperations : CrudOperationsWithParentBase<InkoopBoekingBijlageContentModel>, IInkoopBoekingBijlagesOperations
    {
        public InkoopBoekingBijlagesOperations(ClientState clientState)
            : base(clientState, "inkoopboekingen", "bijlagen")
        { }
    }
}