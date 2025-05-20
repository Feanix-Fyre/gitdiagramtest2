using Unity.Jobs;
using UnityEngine;
using UnityEngine.Scripting;

namespace Unity.Collections;

[NativeClass(null)]
internal struct NativeArrayDisposeJob : IJob
{
	internal NativeArrayDispose Data;

	public void Execute()
	{
	}

	[RequiredByNativeCode]
	internal static void RegisterNativeArrayDisposeJobReflectionData()
	{
	}
}
