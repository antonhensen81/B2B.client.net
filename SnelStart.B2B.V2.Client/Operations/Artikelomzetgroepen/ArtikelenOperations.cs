using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    class ArtikelenOperations : CrudOperationsBase<ArtikelModel>, IArtikelenOperations
    {
        public ArtikelenOperations(ClientState clientState)
            : base(clientState, ArtikelModel.ResourceName)
        { }

        public Task<Response<ArtikelModel[]>> GetAllAsync() => GetAllAsync(CancellationToken.None);
        public Task<Response<ArtikelModel[]>> GetAllAsync(CancellationToken cancellationToken) => ClientState.ExecuteGetAllAsync<ArtikelModel>(ResourceName, cancellationToken);

        public Task<Response<ArtikelModel[]>> GetAsync(string queryString) => GetAsync(queryString, CancellationToken.None);
        public Task<Response<ArtikelModel[]>> GetAsync(string queryString, CancellationToken cancellationToken) => ClientState.ExecuteGetAsync<ArtikelModel>(ResourceName, queryString, cancellationToken);
    }
}
