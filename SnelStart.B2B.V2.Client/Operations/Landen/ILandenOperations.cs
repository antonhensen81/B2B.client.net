using System;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    public interface ILandenOperations
    {
        Task<Response<LandModel[]>> GetAllAsync();
        Task<Response<LandModel>> GetByIdAsync(Guid id);
    }
}