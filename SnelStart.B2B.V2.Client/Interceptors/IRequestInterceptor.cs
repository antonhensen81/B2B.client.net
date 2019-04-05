using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Interceptors
{
    public interface IRequestInterceptor
    {
        Task OnBeforeSendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
        Task OnResponseReceivedAsync(HttpResponseMessage response, CancellationToken cancellationToken);
    }
}