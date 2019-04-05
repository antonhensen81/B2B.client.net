using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    public interface IGetAllOperationsWithParent<T>
    {
        Task<Response<T[]>> GetAllAsync(Guid parentId);
        Task<Response<T[]>> GetAllAsync(Guid parentId, CancellationToken cancellationToken);
    }
}