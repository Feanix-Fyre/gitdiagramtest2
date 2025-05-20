using System.Collections.Generic;

namespace Unity.Services.Core.Networking.Internal;

internal class HttpRequest
{
	public string Method;

	public string Url;

	public Dictionary<string, string> Headers;

	public byte[] Body;

	public HttpOptions Options;

	public HttpRequest()
	{
	}

	public HttpRequest(string method, string url, Dictionary<string, string> headers, byte[] body)
	{
	}

	public HttpRequest SetMethod(string method)
	{
		return null;
	}

	public HttpRequest SetUrl(string url)
	{
		return null;
	}

	public HttpRequest SetHeader(string key, string value)
	{
		return null;
	}

	public HttpRequest SetHeaders(Dictionary<string, string> headers)
	{
		return null;
	}

	public HttpRequest SetBody(byte[] body)
	{
		return null;
	}

	public HttpRequest SetOptions(HttpOptions options)
	{
		return null;
	}

	public HttpRequest SetRedirectLimit(int redirectLimit)
	{
		return null;
	}

	public HttpRequest SetTimeOutInSeconds(int timeout)
	{
		return null;
	}
}
