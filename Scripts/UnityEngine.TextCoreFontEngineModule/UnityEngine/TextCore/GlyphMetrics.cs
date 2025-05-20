using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore;

[Serializable]
[UsedByNativeCode]
public struct GlyphMetrics : IEquatable<GlyphMetrics>
{
	[SerializeField]
	[NativeName("width")]
	private float m_Width;

	[NativeName("height")]
	[SerializeField]
	private float m_Height;

	[NativeName("horizontalBearingX")]
	[SerializeField]
	private float m_HorizontalBearingX;

	[NativeName("horizontalBearingY")]
	[SerializeField]
	private float m_HorizontalBearingY;

	[NativeName("horizontalAdvance")]
	[SerializeField]
	private float m_HorizontalAdvance;

	public float width => 0f;

	public float height => 0f;

	public float horizontalBearingX => 0f;

	public float horizontalBearingY => 0f;

	public float horizontalAdvance => 0f;

	public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance)
	{
		m_Width = 0f;
		m_Height = 0f;
		m_HorizontalBearingX = 0f;
		m_HorizontalBearingY = 0f;
		m_HorizontalAdvance = 0f;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(GlyphMetrics other)
	{
		return false;
	}
}
