using System;

namespace Unity.Services.Core;

public class RequestFailedException : Exception
{
	public int ErrorCode { get; }

	public RequestFailedException(int errorCode, string message)
	{
	}

	public RequestFailedException(int errorCode, string message, Exception innerException)
	{
	}
}
