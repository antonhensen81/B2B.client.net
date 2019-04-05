namespace SnelStart.B2B.V2.Client.Operations
{
    internal class VerkoopboekingenOperations : CrudOperationsBase<VerkoopBoekingModel>,
        IVerkoopboekingenOperations
    {
        public VerkoopboekingenOperations(ClientState clientState) : base(clientState,
            VerkoopBoekingModel.ResourceName)
        {
        }
    }
}