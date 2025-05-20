using System;

namespace Unity.Services.Core.Internal;

internal class HashException : Exception
{
	public int Hash { get; }

	public HashException(int hash)
	{
	}

	public HashException(int hash, string message)
	{
	}

	public HashException(int hash, string message, Exception inner)
	{
	}
}
