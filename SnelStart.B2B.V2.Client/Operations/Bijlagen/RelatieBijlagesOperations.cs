using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    internal class RelatieBijlagesOperations : CrudOperationsWithParentBase<RelatieBijlageContentModel>,
        IRelatieBijlagesOperations
    {
        public RelatieBijlagesOperations(ClientState clientState)
            : base(clientState, "relaties", "bijlagen")
        { }

        public Task<Response<RelatieBijlageContentModel[]>> GetAllAsync(Guid parentId) => GetAllAsync(parentId, CancellationToken.None);
        public Task<Response<RelatieBijlageContentModel[]>> GetAllAsync(Guid parentId, CancellationToken cancellationToken) => ClientState.ExecuteGetAllAsync<RelatieBijlageContentModel>(GetBaseUri(parentId), cancellationToken);
    }
}