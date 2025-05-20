using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/GPUFence.h")]
[UsedByNativeCode]
public struct GraphicsFence
{
	internal IntPtr m_Ptr;

	internal int m_Version;

	internal GraphicsFenceType m_FenceType;

	internal static SynchronisationStageFlags TranslateSynchronizationStageToFlags(SynchronisationStage s)
	{
		return default(SynchronisationStageFlags);
	}

	internal void InitPostAllocation()
	{
	}

	internal bool IsFencePending()
	{
		return false;
	}

	internal void Validate()
	{
	}

	private int GetPlatformNotSupportedVersion()
	{
		return 0;
	}

	[NativeThrows]
	[FreeFunction("GPUFenceInternals::GetVersionNumber")]
	private static int GetVersionNumber(IntPtr fencePtr)
	{
		return 0;
	}
}
