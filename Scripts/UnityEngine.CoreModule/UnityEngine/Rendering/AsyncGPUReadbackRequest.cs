using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/Texture.h")]
[UsedByNativeCode]
public struct AsyncGPUReadbackRequest
{
	internal IntPtr m_Ptr;

	internal int m_Version;

	public bool done => false;

	public bool hasError => false;

	public int layerCount => 0;

	public int layerDataSize => 0;

	public void WaitForCompletion()
	{
	}

	public NativeArray<T> GetData<T>(int layer = 0) where T : struct
	{
		return default(NativeArray<T>);
	}

	private bool IsDone()
	{
		return false;
	}

	private bool HasError()
	{
		return false;
	}

	private int GetLayerCount()
	{
		return 0;
	}

	private int GetLayerDataSize()
	{
		return 0;
	}

	internal void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback)
	{
	}

	private IntPtr GetDataRaw(int layer)
	{
		return (IntPtr)0;
	}

	private static void WaitForCompletion_Injected(ref AsyncGPUReadbackRequest _unity_self)
	{
	}

	private static bool IsDone_Injected(ref AsyncGPUReadbackRequest _unity_self)
	{
		return false;
	}

	private static bool HasError_Injected(ref AsyncGPUReadbackRequest _unity_self)
	{
		return false;
	}

	private static int GetLayerCount_Injected(ref AsyncGPUReadbackRequest _unity_self)
	{
		return 0;
	}

	private static int GetLayerDataSize_Injected(ref AsyncGPUReadbackRequest _unity_self)
	{
		return 0;
	}

	private static void SetScriptingCallback_Injected(ref AsyncGPUReadbackRequest _unity_self, Action<AsyncGPUReadbackRequest> callback)
	{
	}

	private static IntPtr GetDataRaw_Injected(ref AsyncGPUReadbackRequest _unity_self, int layer)
	{
		return (IntPtr)0;
	}
}
