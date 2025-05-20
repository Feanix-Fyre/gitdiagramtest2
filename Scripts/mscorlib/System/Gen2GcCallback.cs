using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System;

internal sealed class Gen2GcCallback : CriticalFinalizerObject
{
	private Func<object, bool> _callback;

	private GCHandle _weakTargetObj;

	private Gen2GcCallback()
	{
	}

	public static void Register(Func<object, bool> callback, object targetObj)
	{
	}

	private void Setup(Func<object, bool> callback, object targetObj)
	{
	}

	~Gen2GcCallback()
	{
	}
}
