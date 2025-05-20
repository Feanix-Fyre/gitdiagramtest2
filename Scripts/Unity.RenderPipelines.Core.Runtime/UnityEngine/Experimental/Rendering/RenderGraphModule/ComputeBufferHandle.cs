using System.Diagnostics;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("ComputeBuffer ({handle.index})")]
public struct ComputeBufferHandle
{
	private static ComputeBufferHandle s_NullHandle;

	internal ResourceHandle handle;

	public static ComputeBufferHandle nullHandle => default(ComputeBufferHandle);

	internal ComputeBufferHandle(int handle, bool shared = false)
	{
		this.handle = default(ResourceHandle);
	}

	public static implicit operator ComputeBuffer(ComputeBufferHandle buffer)
	{
		return null;
	}

	public bool IsValid()
	{
		return false;
	}
}
