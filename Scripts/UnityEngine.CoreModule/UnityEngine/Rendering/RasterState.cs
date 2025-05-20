using System;

namespace UnityEngine.Rendering;

public struct RasterState : IEquatable<RasterState>
{
	public static readonly RasterState defaultValue;

	private CullMode m_CullingMode;

	private int m_OffsetUnits;

	private float m_OffsetFactor;

	private byte m_DepthClip;

	private byte m_Conservative;

	private byte m_Padding1;

	private byte m_Padding2;

	public RasterState(CullMode cullingMode = CullMode.Back, int offsetUnits = 0, float offsetFactor = 0f, bool depthClip = true)
	{
		m_CullingMode = default(CullMode);
		m_OffsetUnits = 0;
		m_OffsetFactor = 0f;
		m_DepthClip = 0;
		m_Conservative = 0;
		m_Padding1 = 0;
		m_Padding2 = 0;
	}

	public bool Equals(RasterState other)
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
