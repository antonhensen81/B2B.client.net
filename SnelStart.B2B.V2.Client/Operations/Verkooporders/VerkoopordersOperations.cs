using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    class VerkoopordersOperations : CrudOperationsBase<VerkooporderModel>, IVerkoopordersOperations
    {
        public VerkoopordersOperations(ClientState clientState)
            : base(clientState, VerkooporderModel.ResourceName)
        { }

        public Task<Response<VerkooporderModel[]>> GetAllAsync() => GetAllAsync(CancellationToken.None);
        public Task<Response<VerkooporderModel[]>> GetAllAsync(CancellationToken cancellationToken) => ClientState.ExecuteGetAllAsync<VerkooporderModel>(ResourceName, cancellationToken);

        public Task<Response<VerkooporderModel[]>> GetAsync(string queryString) => GetAsync(queryString, CancellationToken.None);
        public Task<Response<VerkooporderModel[]>> GetAsync(string queryString, CancellationToken cancellationToken) => ClientState.ExecuteGetAsync<VerkooporderModel>(ResourceName, queryString, cancellationToken);
    }
}
