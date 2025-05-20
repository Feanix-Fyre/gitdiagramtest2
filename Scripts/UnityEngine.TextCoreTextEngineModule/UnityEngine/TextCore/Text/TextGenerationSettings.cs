using System;

namespace UnityEngine.TextCore.Text;

internal class TextGenerationSettings : IEquatable<TextGenerationSettings>
{
	public string text;

	public Rect screenRect;

	public Vector4 margins;

	public float scale;

	public FontAsset fontAsset;

	public Material material;

	public SpriteAsset spriteAsset;

	public TextStyleSheet styleSheet;

	public FontStyles fontStyle;

	public TextSettings textSettings;

	public TextAlignment textAlignment;

	public TextOverflowMode overflowMode;

	public bool wordWrap;

	public float wordWrappingRatio;

	public Color color;

	public TextColorGradient fontColorGradient;

	public TextColorGradient fontColorGradientPreset;

	public bool tintSprites;

	public bool overrideRichTextColors;

	public bool shouldConvertToLinearSpace;

	public float fontSize;

	public bool autoSize;

	public float fontSizeMin;

	public float fontSizeMax;

	public bool enableKerning;

	public bool richText;

	public bool isRightToLeft;

	public float extraPadding;

	public bool parseControlCharacters;

	public bool isOrthographic;

	public bool tagNoParsing;

	public float characterSpacing;

	public float wordSpacing;

	public float lineSpacing;

	public float paragraphSpacing;

	public float lineSpacingMax;

	public TextWrappingMode textWrappingMode;

	public int maxVisibleCharacters;

	public int maxVisibleWords;

	public int maxVisibleLines;

	public int firstVisibleCharacter;

	public bool useMaxVisibleDescender;

	public TextFontWeight fontWeight;

	public int pageToDisplay;

	public TextureMapping horizontalMapping;

	public TextureMapping verticalMapping;

	public float uvLineOffset;

	public VertexSortingOrder geometrySortingOrder;

	public bool inverseYAxis;

	public float charWidthMaxAdj;

	internal TextInputSource inputSource;

	public bool Equals(TextGenerationSettings other)
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

	public static bool operator ==(TextGenerationSettings left, TextGenerationSettings right)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
