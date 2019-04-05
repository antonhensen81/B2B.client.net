using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    public interface IGetAllOperations<T>
    {
        Task<Response<T[]>> GetAllAsync();
        Task<Response<T[]>> GetAllAsync(CancellationToken cancellationToken);
    }
}