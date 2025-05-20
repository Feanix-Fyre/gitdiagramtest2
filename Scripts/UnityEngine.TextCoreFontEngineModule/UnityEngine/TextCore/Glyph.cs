using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore;

[Serializable]
[StructLayout((LayoutKind)0)]
[UsedByNativeCode]
public class Glyph
{
	[NativeName("index")]
	[SerializeField]
	private uint m_Index;

	[NativeName("metrics")]
	[SerializeField]
	private GlyphMetrics m_Metrics;

	[NativeName("glyphRect")]
	[SerializeField]
	private GlyphRect m_GlyphRect;

	[NativeName("scale")]
	[SerializeField]
	private float m_Scale;

	[SerializeField]
	[NativeName("atlasIndex")]
	private int m_AtlasIndex;

	[SerializeField]
	[NativeName("type")]
	private GlyphClassDefinitionType m_ClassDefinitionType;

	public uint index
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public GlyphMetrics metrics
	{
		get
		{
			return default(GlyphMetrics);
		}
		set
		{
		}
	}

	public GlyphRect glyphRect
	{
		get
		{
			return default(GlyphRect);
		}
		set
		{
		}
	}

	public float scale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int atlasIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Glyph()
	{
	}

	internal Glyph(GlyphMarshallingStruct glyphStruct)
	{
	}

	public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex)
	{
	}
}
