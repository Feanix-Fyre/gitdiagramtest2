using System;

namespace Unity.Services.Core.Internal;

internal class DependencyTreeComponentHashException : HashException
{
	public DependencyTreeComponentHashException(int hash)
		: base(0)
	{
	}

	public DependencyTreeComponentHashException(int hash, string message)
		: base(0)
	{
	}

	public DependencyTreeComponentHashException(int hash, string message, Exception inner)
		: base(0)
	{
	}
}
