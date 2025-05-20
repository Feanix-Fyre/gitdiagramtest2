using System;

namespace UnityEngine.Rendering;

public struct RenderStateBlock : IEquatable<RenderStateBlock>
{
	private BlendState m_BlendState;

	private RasterState m_RasterState;

	private DepthState m_DepthState;

	private StencilState m_StencilState;

	private int m_StencilReference;

	private RenderStateMask m_Mask;

	public BlendState blendState
	{
		set
		{
		}
	}

	public RasterState rasterState
	{
		set
		{
		}
	}

	public DepthState depthState
	{
		get
		{
			return default(DepthState);
		}
		set
		{
		}
	}

	public StencilState stencilState
	{
		get
		{
			return default(StencilState);
		}
		set
		{
		}
	}

	public int stencilReference
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public RenderStateMask mask
	{
		get
		{
			return default(RenderStateMask);
		}
		set
		{
		}
	}

	public RenderStateBlock(RenderStateMask mask)
	{
		m_BlendState = default(BlendState);
		m_RasterState = default(RasterState);
		m_DepthState = default(DepthState);
		m_StencilState = default(StencilState);
		m_StencilReference = 0;
		m_Mask = default(RenderStateMask);
	}

	public bool Equals(RenderStateBlock other)
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
}
