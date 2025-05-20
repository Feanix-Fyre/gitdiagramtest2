using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Mono/Coroutine.h")]
public sealed class Coroutine : YieldInstruction
{
	internal IntPtr m_Ptr;

	private Coroutine()
	{
	}

	~Coroutine()
	{
	}

	[FreeFunction("Coroutine::CleanupCoroutineGC", true)]
	private static void ReleaseCoroutine(IntPtr ptr)
	{
	}
}
