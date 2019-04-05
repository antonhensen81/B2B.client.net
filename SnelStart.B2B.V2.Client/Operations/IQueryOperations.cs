using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    public interface IQueryOperations<T>
    {
        Task<Response<T[]>> GetAsync(string queryString);
        Task<Response<T[]>> GetAsync(string queryString, CancellationToken cancellationToken);
    }
}