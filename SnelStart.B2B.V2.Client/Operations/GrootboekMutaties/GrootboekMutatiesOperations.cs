using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    internal class GrootboekMutatiesOperations : CrudOperationsBase<GrootboekMutatieModel>, IGrootboekMutatiesOperations
    {
        public GrootboekMutatiesOperations(ClientState clientState)
            : base(clientState, GrootboekMutatieModel.ResourceName)
        { }

        public Task<Response<GrootboekMutatieModel[]>> GetAsync(string queryString) => GetAsync(queryString, CancellationToken.None);
        public Task<Response<GrootboekMutatieModel[]>> GetAsync(string queryString, CancellationToken cancellationToken) => ClientState.ExecuteGetAsync<GrootboekMutatieModel>(ResourceName, queryString, cancellationToken);
    }
}