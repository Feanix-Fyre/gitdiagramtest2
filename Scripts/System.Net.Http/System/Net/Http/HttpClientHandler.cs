using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http;

/// <summary>The default message handler used by <see cref="T:System.Net.Http.HttpClient" />.</summary>
public class HttpClientHandler : HttpMessageHandler
{
	private readonly IMonoHttpClientHandler _delegatingHandler;

	private ClientCertificateOption _clientCertificateOptions;

	/// <summary>Gets or sets a value that indicates if the certificate is automatically picked from the certificate store or if the caller is allowed to pass in a specific client certificate.</summary>
	/// <returns>The collection of security certificates associated with this handler.</returns>
	public ClientCertificateOption ClientCertificateOptions
	{
		get
		{
			return default(ClientCertificateOption);
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of security certificates that are associated requests to the server.</summary>
	/// <returns>The X509CertificateCollection that is presented to the server when performing certificate based client authentication.</returns>
	public X509CertificateCollection ClientCertificates => null;

	private static IMonoHttpClientHandler CreateDefaultHandler()
	{
		return null;
	}

	/// <summary>Creates an instance of a <see cref="T:System.Net.Http.HttpClientHandler" /> class.</summary>
	public HttpClientHandler()
	{
	}

	internal HttpClientHandler(IMonoHttpClientHandler handler)
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Http.HttpClientHandler" /> and optionally disposes of the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to releases only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	private void ThrowForModifiedManagedSslOptionsIfStarted()
	{
	}

	internal void SetWebRequestTimeout(TimeSpan timeout)
	{
	}

	/// <summary>Creates an instance of  <see cref="T:System.Net.Http.HttpResponseMessage" /> based on the information provided in the <see cref="T:System.Net.Http.HttpRequestMessage" /> as an operation that will not block.</summary>
	/// <param name="request">The HTTP request message.</param>
	/// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
	/// <returns>The task object representing the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was <see langword="null" />.</exception>
	protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		return null;
	}
}
