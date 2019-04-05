namespace SnelStart.B2B.V2.Client.Operations
{
    internal class MemoriaalboekingenOperations : CrudOperationsBase<MemoriaalboekingModel>,
        IMemoriaalboekingenOperations
    {
        public MemoriaalboekingenOperations(ClientState clientState) : base(clientState,
            MemoriaalboekingModel.ResourceName)
        {
        }
    }
}