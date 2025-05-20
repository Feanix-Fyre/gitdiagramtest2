using System.Collections.Generic;

namespace Unity.Services.Core.Networking.Internal;

internal struct ReadOnlyHttpRequest
{
	private HttpRequest m_Request;

	public string Method => null;

	public string Url => null;

	public IReadOnlyDictionary<string, string> Headers => null;

	public byte[] Body => null;

	public ReadOnlyHttpRequest(HttpRequest request)
	{
		m_Request = null;
	}
}
