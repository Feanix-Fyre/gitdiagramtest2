namespace UnityEngine.TextCore.Text;

internal struct TextElementInfo
{
	public char character;

	public int index;

	public TextElementType elementType;

	public int stringLength;

	public TextElement textElement;

	public Glyph alternativeGlyph;

	public FontAsset fontAsset;

	public SpriteAsset spriteAsset;

	public int spriteIndex;

	public Material material;

	public int materialReferenceIndex;

	public bool isUsingAlternateTypeface;

	public float pointSize;

	public int lineNumber;

	public int pageNumber;

	public int vertexIndex;

	public TextVertex vertexTopLeft;

	public TextVertex vertexBottomLeft;

	public TextVertex vertexTopRight;

	public TextVertex vertexBottomRight;

	public Vector3 topLeft;

	public Vector3 bottomLeft;

	public Vector3 topRight;

	public Vector3 bottomRight;

	public float origin;

	public float ascender;

	public float baseLine;

	public float descender;

	internal float adjustedAscender;

	internal float adjustedDescender;

	internal float adjustedHorizontalAdvance;

	public float xAdvance;

	public float aspectRatio;

	public float scale;

	public Color32 color;

	public Color32 underlineColor;

	public int underlineVertexIndex;

	public Color32 strikethroughColor;

	public int strikethroughVertexIndex;

	public Color32 highlightColor;

	public HighlightState highlightState;

	public FontStyles style;

	public bool isVisible;

	public override string ToString()
	{
		return null;
	}
}
