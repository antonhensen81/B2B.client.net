using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    public interface ICompanyInformationOperations
    {
        Task<Response<CompanyInfoModel>> GetAsync();
        Task<Response<CompanyInfoModel>> GetAsync(CancellationToken cancellationToken);
    }
}