using System.Collections.Generic;

namespace Unity.Services.Core.Networking.Internal;

internal struct ReadOnlyHttpResponse
{
	private HttpResponse m_Response;

	public ReadOnlyHttpRequest Request => default(ReadOnlyHttpRequest);

	public IReadOnlyDictionary<string, string> Headers => null;

	public byte[] Data => null;

	public long StatusCode => 0L;

	public string ErrorMessage => null;

	public bool IsHttpError => false;

	public bool IsNetworkError => false;

	public ReadOnlyHttpResponse(HttpResponse response)
	{
		m_Response = null;
	}
}
