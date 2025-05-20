using System.Collections.Generic;

namespace Unity.Services.Core.Networking.Internal;

internal class HttpResponse
{
	public ReadOnlyHttpRequest Request;

	public Dictionary<string, string> Headers;

	public byte[] Data;

	public long StatusCode;

	public string ErrorMessage;

	public bool IsHttpError;

	public bool IsNetworkError;

	public HttpResponse SetRequest(HttpRequest request)
	{
		return null;
	}

	public HttpResponse SetRequest(ReadOnlyHttpRequest request)
	{
		return null;
	}

	public HttpResponse SetHeader(string key, string value)
	{
		return null;
	}

	public HttpResponse SetHeaders(Dictionary<string, string> headers)
	{
		return null;
	}

	public HttpResponse SetData(byte[] data)
	{
		return null;
	}

	public HttpResponse SetStatusCode(long statusCode)
	{
		return null;
	}

	public HttpResponse SetErrorMessage(string errorMessage)
	{
		return null;
	}

	public HttpResponse SetIsHttpError(bool isHttpError)
	{
		return null;
	}

	public HttpResponse SetIsNetworkError(bool isNetworkError)
	{
		return null;
	}
}
