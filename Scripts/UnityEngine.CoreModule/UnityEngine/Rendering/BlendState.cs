using System;

namespace UnityEngine.Rendering;

public struct BlendState : IEquatable<BlendState>
{
	private RenderTargetBlendState m_BlendState0;

	private RenderTargetBlendState m_BlendState1;

	private RenderTargetBlendState m_BlendState2;

	private RenderTargetBlendState m_BlendState3;

	private RenderTargetBlendState m_BlendState4;

	private RenderTargetBlendState m_BlendState5;

	private RenderTargetBlendState m_BlendState6;

	private RenderTargetBlendState m_BlendState7;

	private byte m_SeparateMRTBlendStates;

	private byte m_AlphaToMask;

	private short m_Padding;

	public static BlendState defaultValue => default(BlendState);

	public RenderTargetBlendState blendState0
	{
		set
		{
		}
	}

	public BlendState(bool separateMRTBlend = false, bool alphaToMask = false)
	{
		m_BlendState0 = default(RenderTargetBlendState);
		m_BlendState1 = default(RenderTargetBlendState);
		m_BlendState2 = default(RenderTargetBlendState);
		m_BlendState3 = default(RenderTargetBlendState);
		m_BlendState4 = default(RenderTargetBlendState);
		m_BlendState5 = default(RenderTargetBlendState);
		m_BlendState6 = default(RenderTargetBlendState);
		m_BlendState7 = default(RenderTargetBlendState);
		m_SeparateMRTBlendStates = 0;
		m_AlphaToMask = 0;
		m_Padding = 0;
	}

	public bool Equals(BlendState other)
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
