using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    public interface IVerkoopfacturenOperations : IQueryOperations<VerkoopFactuurModel>
    {
        Task<Response<VerkoopFactuurModel>> GetByIdAsync(Guid id);
        Task<Response> GetUblByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}