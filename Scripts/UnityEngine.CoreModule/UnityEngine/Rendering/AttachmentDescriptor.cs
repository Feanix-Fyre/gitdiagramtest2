using System;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

public struct AttachmentDescriptor : IEquatable<AttachmentDescriptor>
{
	private RenderBufferLoadAction m_LoadAction;

	private RenderBufferStoreAction m_StoreAction;

	private GraphicsFormat m_Format;

	private RenderTargetIdentifier m_LoadStoreTarget;

	private RenderTargetIdentifier m_ResolveTarget;

	private Color m_ClearColor;

	private float m_ClearDepth;

	private uint m_ClearStencil;

	public RenderBufferLoadAction loadAction
	{
		set
		{
		}
	}

	public RenderBufferStoreAction storeAction
	{
		set
		{
		}
	}

	public GraphicsFormat graphicsFormat => default(GraphicsFormat);

	public RenderTargetIdentifier loadStoreTarget
	{
		get
		{
			return default(RenderTargetIdentifier);
		}
		set
		{
		}
	}

	public void ConfigureTarget(RenderTargetIdentifier target, bool loadExistingContents, bool storeResults)
	{
	}

	public void ConfigureResolveTarget(RenderTargetIdentifier target)
	{
	}

	public void ConfigureClear(Color clearColor, float clearDepth = 1f, uint clearStencil = 0u)
	{
	}

	public AttachmentDescriptor(GraphicsFormat format)
	{
		m_LoadAction = default(RenderBufferLoadAction);
		m_StoreAction = default(RenderBufferStoreAction);
		m_Format = default(GraphicsFormat);
		m_LoadStoreTarget = default(RenderTargetIdentifier);
		m_ResolveTarget = default(RenderTargetIdentifier);
		m_ClearColor = default(Color);
		m_ClearDepth = 0f;
		m_ClearStencil = 0u;
	}

	public bool Equals(AttachmentDescriptor other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator !=(AttachmentDescriptor left, AttachmentDescriptor right)
	{
		return false;
	}
}
