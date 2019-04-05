namespace SnelStart.B2B.V2.Client.Operations
{
    internal class BankboekingenOperations : CrudOperationsBase<BankboekingModel>,
        IBankboekingenOperations
    {
        public BankboekingenOperations(ClientState clientState) : base(clientState,
            BankboekingModel.ResourceName)
        {
        }
    }
}