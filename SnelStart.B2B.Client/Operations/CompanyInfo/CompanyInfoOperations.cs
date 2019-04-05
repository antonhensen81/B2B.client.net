using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client.Operations
{
    class CompanyInfoOperations : ICompanyInformationOperations
    {
        private readonly ClientState _clientState;
        public const string ResourceName = CompanyInfoModel.ResourceName;

        public CompanyInfoOperations(ClientState clientState)
        {
            _clientState = clientState;

        }

        public Task<Response<CompanyInfoModel>> GetAsync() => GetAsync(CancellationToken.None);
        public Task<Response<CompanyInfoModel>> GetAsync(CancellationToken cancellationToken) => _clientState.ExecuteGetAsync<CompanyInfoModel>(ResourceName, cancellationToken);
    }
}
