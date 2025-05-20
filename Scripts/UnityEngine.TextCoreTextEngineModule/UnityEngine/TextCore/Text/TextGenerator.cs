using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.TextCore.Text;

internal class TextGenerator
{
	public delegate void MissingCharacterEventCallback(uint unicode, int stringIndex, TextInfo text, FontAsset fontAsset);

	protected struct SpecialCharacter
	{
		public Character character;

		public FontAsset fontAsset;

		public Material material;

		public int materialIndex;

		public SpecialCharacter(Character character, int materialIndex)
		{
			this.character = null;
			fontAsset = null;
			material = null;
			this.materialIndex = 0;
		}
	}

	private static TextGenerator s_TextGenerator;

	private TextBackingContainer m_TextBackingArray;

	internal TextProcessingElement[] m_TextProcessingArray;

	internal int m_InternalTextProcessingArraySize;

	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction;

	private char[] m_HtmlTag;

	internal HighlightState m_HighlightState;

	protected bool m_IsIgnoringAlignment;

	protected static bool m_IsTextTruncated;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static MissingCharacterEventCallback OnMissingCharacter;

	private Vector3[] m_RectTransformCorners;

	private float m_MarginWidth;

	private float m_MarginHeight;

	private float m_PreferredWidth;

	private float m_PreferredHeight;

	private FontAsset m_CurrentFontAsset;

	private Material m_CurrentMaterial;

	private int m_CurrentMaterialIndex;

	private TextProcessingStack<MaterialReference> m_MaterialReferenceStack;

	private float m_Padding;

	private SpriteAsset m_CurrentSpriteAsset;

	private int m_TotalCharacterCount;

	private float m_FontSize;

	private float m_FontScaleMultiplier;

	private float m_CurrentFontSize;

	private TextProcessingStack<float> m_SizeStack;

	protected TextProcessingStack<int>[] m_TextStyleStacks;

	protected int m_TextStyleStackDepth;

	private FontStyles m_FontStyleInternal;

	private FontStyleStack m_FontStyleStack;

	private TextFontWeight m_FontWeightInternal;

	private TextProcessingStack<TextFontWeight> m_FontWeightStack;

	private TextAlignment m_LineJustification;

	private TextProcessingStack<TextAlignment> m_LineJustificationStack;

	private float m_BaselineOffset;

	private TextProcessingStack<float> m_BaselineOffsetStack;

	private Color32 m_FontColor32;

	private Color32 m_HtmlColor;

	private Color32 m_UnderlineColor;

	private Color32 m_StrikethroughColor;

	private TextProcessingStack<Color32> m_ColorStack;

	private TextProcessingStack<Color32> m_UnderlineColorStack;

	private TextProcessingStack<Color32> m_StrikethroughColorStack;

	private TextProcessingStack<Color32> m_HighlightColorStack;

	private TextProcessingStack<HighlightState> m_HighlightStateStack;

	private TextProcessingStack<int> m_ItalicAngleStack;

	private TextColorGradient m_ColorGradientPreset;

	private TextProcessingStack<TextColorGradient> m_ColorGradientStack;

	private bool m_ColorGradientPresetIsTinted;

	private TextProcessingStack<int> m_ActionStack;

	private float m_LineOffset;

	private float m_LineHeight;

	private bool m_IsDrivenLineSpacing;

	private float m_CSpacing;

	private float m_MonoSpacing;

	private float m_XAdvance;

	private float m_TagLineIndent;

	private float m_TagIndent;

	private TextProcessingStack<float> m_IndentStack;

	private bool m_TagNoParsing;

	private int m_CharacterCount;

	private int m_FirstCharacterOfLine;

	private int m_LastCharacterOfLine;

	private int m_FirstVisibleCharacterOfLine;

	private int m_LastVisibleCharacterOfLine;

	private float m_MaxLineAscender;

	private float m_MaxLineDescender;

	private int m_LineNumber;

	private int m_LineVisibleCharacterCount;

	private int m_LineVisibleSpaceCount;

	private int m_FirstOverflowCharacterIndex;

	private int m_PageNumber;

	private float m_MarginLeft;

	private float m_MarginRight;

	private float m_Width;

	private Extents m_MeshExtents;

	private float m_MaxCapHeight;

	private float m_MaxAscender;

	private float m_MaxDescender;

	private bool m_IsNewPage;

	private bool m_IsNonBreakingSpace;

	private WordWrapState m_SavedWordWrapState;

	private WordWrapState m_SavedLineState;

	private WordWrapState m_SavedEllipsisState;

	private WordWrapState m_SavedLastValidState;

	private WordWrapState m_SavedSoftLineBreakState;

	private TextElementType m_TextElementType;

	private bool m_isTextLayoutPhase;

	private int m_SpriteIndex;

	private Color32 m_SpriteColor;

	private TextElement m_CachedTextElement;

	private Color32 m_HighlightColor;

	private float m_CharWidthAdjDelta;

	private float m_MaxFontSize;

	private float m_MinFontSize;

	private int m_AutoSizeIterationCount;

	private int m_AutoSizeMaxIterationCount;

	private bool m_IsAutoSizePointSizeSet;

	private float m_StartOfLineAscender;

	private float m_LineSpacingDelta;

	private MaterialReference[] m_MaterialReferences;

	private int m_SpriteCount;

	private TextProcessingStack<int> m_StyleStack;

	private TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack;

	private int m_SpriteAnimationId;

	private int m_ItalicAngle;

	private Vector3 m_FXScale;

	private Quaternion m_FXRotation;

	private int m_LastBaseGlyphIndex;

	private float m_PageAscender;

	private RichTextTagAttribute[] m_XmlAttribute;

	private float[] m_AttributeParameterValues;

	private Dictionary<int, int> m_MaterialReferenceIndexLookup;

	private bool m_IsCalculatingPreferredValues;

	private SpriteAsset m_DefaultSpriteAsset;

	private bool m_TintSprite;

	protected SpecialCharacter m_Ellipsis;

	protected SpecialCharacter m_Underline;

	private TextElementInfo[] m_InternalTextElementInfo;

	public static bool isTextTruncated => false;

	private static TextGenerator GetTextGenerator()
	{
		return null;
	}

	public static void GenerateText(TextGenerationSettings settings, TextInfo textInfo)
	{
	}

	public static Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo)
	{
		return default(Vector2);
	}

	private void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	private void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo)
	{
	}

	protected int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo)
	{
		return 0;
	}

	protected bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		endIndex = default(int);
		return false;
	}

	private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	private static void ClearMesh(bool updateMesh, TextInfo textInfo)
	{
	}

	internal int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		return 0;
	}

	internal TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface)
	{
		isUsingAlternativeTypeface = default(bool);
		return null;
	}

	private void ComputeMarginSize(Rect rect, Vector4 margins)
	{
	}

	protected void GetSpecialCharacters(TextGenerationSettings generationSettings)
	{
	}

	protected void GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings)
	{
	}

	protected void GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings)
	{
	}

	private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		return default(Vector2);
	}

	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingMode textWrapMode, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		return default(Vector2);
	}

	private void PopulateTextBackingArray(string sourceText)
	{
	}

	private void PopulateTextBackingArray(string sourceText, int start, int length)
	{
	}

	private void PopulateTextProcessingArray(TextGenerationSettings generationSettings)
	{
	}

	private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	protected void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo)
	{
	}

	private void ClearMarkupTagAttributes()
	{
	}
}
