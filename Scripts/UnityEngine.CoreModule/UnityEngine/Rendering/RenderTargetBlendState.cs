using System;

namespace UnityEngine.Rendering;

public struct RenderTargetBlendState : IEquatable<RenderTargetBlendState>
{
	private byte m_WriteMask;

	private byte m_SourceColorBlendMode;

	private byte m_DestinationColorBlendMode;

	private byte m_SourceAlphaBlendMode;

	private byte m_DestinationAlphaBlendMode;

	private byte m_ColorBlendOperation;

	private byte m_AlphaBlendOperation;

	private byte m_Padding;

	public static RenderTargetBlendState defaultValue => default(RenderTargetBlendState);

	public RenderTargetBlendState(ColorWriteMask writeMask = ColorWriteMask.All, BlendMode sourceColorBlendMode = BlendMode.One, BlendMode destinationColorBlendMode = BlendMode.Zero, BlendMode sourceAlphaBlendMode = BlendMode.One, BlendMode destinationAlphaBlendMode = BlendMode.Zero, BlendOp colorBlendOperation = BlendOp.Add, BlendOp alphaBlendOperation = BlendOp.Add)
	{
		m_WriteMask = 0;
		m_SourceColorBlendMode = 0;
		m_DestinationColorBlendMode = 0;
		m_SourceAlphaBlendMode = 0;
		m_DestinationAlphaBlendMode = 0;
		m_ColorBlendOperation = 0;
		m_AlphaBlendOperation = 0;
		m_Padding = 0;
	}

	public bool Equals(RenderTargetBlendState other)
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
