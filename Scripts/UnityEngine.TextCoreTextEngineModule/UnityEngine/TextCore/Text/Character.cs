using System;

namespace UnityEngine.TextCore.Text;

[Serializable]
public class Character : TextElement
{
	public Character()
	{
	}

	public Character(uint unicode, FontAsset fontAsset, Glyph glyph)
	{
	}

	internal Character(uint unicode, uint glyphIndex)
	{
	}
}
