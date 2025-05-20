using System;

namespace UnityEngine.TextCore.Text;

[Serializable]
public abstract class TextElement
{
	[SerializeField]
	protected TextElementType m_ElementType;

	[SerializeField]
	internal uint m_Unicode;

	internal TextAsset m_TextAsset;

	internal Glyph m_Glyph;

	[SerializeField]
	internal uint m_GlyphIndex;

	[SerializeField]
	internal float m_Scale;

	public TextElementType elementType => default(TextElementType);

	public uint unicode
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public TextAsset textAsset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Glyph glyph
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint glyphIndex
	{
		get
		{
			return 0u;
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
}
