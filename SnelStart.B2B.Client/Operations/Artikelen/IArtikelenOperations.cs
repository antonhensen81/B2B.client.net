using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    public interface IArtikelenOperations : ICrudOperations<ArtikelModel>, IGetAllOperations<ArtikelModel>, IQueryOperations<ArtikelModel>
    {
        Task<Response<ArtikelModel>> GetByIdAsync(Guid id, string queryString);
        Task<Response<ArtikelModel>> GetByIdAsync(Guid id, string queryString, CancellationToken cancellationToken);
    }
}
