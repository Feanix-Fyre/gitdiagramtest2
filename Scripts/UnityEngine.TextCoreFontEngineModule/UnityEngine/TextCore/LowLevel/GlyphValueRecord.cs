using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel;

[Serializable]
[UsedByNativeCode]
public struct GlyphValueRecord : IEquatable<GlyphValueRecord>
{
	[SerializeField]
	[NativeName("xPlacement")]
	private float m_XPlacement;

	[SerializeField]
	[NativeName("yPlacement")]
	private float m_YPlacement;

	[SerializeField]
	[NativeName("xAdvance")]
	private float m_XAdvance;

	[SerializeField]
	[NativeName("yAdvance")]
	private float m_YAdvance;

	public float xPlacement
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float yPlacement
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float xAdvance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float yAdvance => 0f;

	public GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance)
	{
		m_XPlacement = 0f;
		m_YPlacement = 0f;
		m_XAdvance = 0f;
		m_YAdvance = 0f;
	}

	public static GlyphValueRecord operator +(GlyphValueRecord a, GlyphValueRecord b)
	{
		return default(GlyphValueRecord);
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(GlyphValueRecord other)
	{
		return false;
	}
}
