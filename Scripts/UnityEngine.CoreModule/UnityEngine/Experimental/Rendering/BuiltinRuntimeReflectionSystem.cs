using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable
{
	public bool TickRealtimeProbes()
	{
		return false;
	}

	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	[StaticAccessor("GetReflectionProbes()", Type = StaticAccessorType.Dot)]
	private static bool BuiltinUpdate()
	{
		return false;
	}

	[RequiredByNativeCode]
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New()
	{
		return null;
	}
}
