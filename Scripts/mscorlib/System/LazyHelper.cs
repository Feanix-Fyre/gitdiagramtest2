using System.Runtime.ExceptionServices;
using System.Threading;

namespace System;

internal class LazyHelper
{
	internal static readonly LazyHelper NoneViaConstructor;

	internal static readonly LazyHelper NoneViaFactory;

	internal static readonly LazyHelper PublicationOnlyViaConstructor;

	internal static readonly LazyHelper PublicationOnlyViaFactory;

	internal static readonly LazyHelper PublicationOnlyWaitForOtherThreadToPublish;

	private readonly ExceptionDispatchInfo _exceptionDispatch;

	internal LazyState State { get; }

	internal LazyHelper(LazyState state)
	{
	}

	internal LazyHelper(LazyThreadSafetyMode mode, Exception exception)
	{
	}

	internal void ThrowException()
	{
	}

	internal static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor)
	{
		return null;
	}

	internal static object CreateViaDefaultConstructor(Type type)
	{
		return null;
	}
}
