using System.Diagnostics;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("RendererList ({handle})")]
public struct RendererListHandle
{
	private bool m_IsValid;

	internal int handle { get; private set; }

	internal RendererListHandle(int handle)
	{
		m_IsValid = false;
		this.handle = 0;
	}

	public static implicit operator int(RendererListHandle handle)
	{
		return 0;
	}

	public static implicit operator RendererList(RendererListHandle rendererList)
	{
		return default(RendererList);
	}

	public bool IsValid()
	{
		return false;
	}
}
