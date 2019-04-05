using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    class ArtikelomzetgroepenOperations : CrudOperationsBase<ArtikelomzetgroepModel>, IArtikelomzetgroepenOperations
    {
        public ArtikelomzetgroepenOperations(ClientState clientState)
            : base(clientState, ArtikelomzetgroepModel.ResourceName)
        { }

        public Task<Response<ArtikelomzetgroepModel[]>> GetAllAsync() => GetAllAsync(CancellationToken.None);
        public Task<Response<ArtikelomzetgroepModel[]>> GetAllAsync(CancellationToken cancellationToken) => ClientState.ExecuteGetAllAsync<ArtikelomzetgroepModel>(ResourceName, cancellationToken);

        public Task<Response<ArtikelomzetgroepModel[]>> GetAsync(string queryString) => GetAsync(queryString, CancellationToken.None);
        public Task<Response<ArtikelomzetgroepModel[]>> GetAsync(string queryString, CancellationToken cancellationToken) => ClientState.ExecuteGetAsync<ArtikelomzetgroepModel>(ResourceName, queryString, cancellationToken);
    }
}
