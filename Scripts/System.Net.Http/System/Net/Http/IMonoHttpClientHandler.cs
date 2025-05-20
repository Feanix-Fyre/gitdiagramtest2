using System.Net.Security;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http;

internal interface IMonoHttpClientHandler : IDisposable
{
	SslClientAuthenticationOptions SslOptions { get; set; }

	Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

	void SetWebRequestTimeout(TimeSpan timeout);
}
