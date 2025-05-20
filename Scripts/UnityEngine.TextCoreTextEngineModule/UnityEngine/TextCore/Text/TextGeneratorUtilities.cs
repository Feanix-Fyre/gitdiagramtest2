using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text;

internal static class TextGeneratorUtilities
{
	public static readonly Vector2 largePositiveVector2;

	public static readonly Vector2 largeNegativeVector2;

	public static bool Approximately(float a, float b)
	{
		return false;
	}

	public static Color32 HexCharsToColor(char[] hexChars, int tagCount)
	{
		return default(Color32);
	}

	public static Color32 HexCharsToColor(char[] hexChars, int startIndex, int length)
	{
		return default(Color32);
	}

	public static uint HexToInt(char hex)
	{
		return 0u;
	}

	public static float ConvertToFloat(char[] chars, int startIndex, int length)
	{
		return 0f;
	}

	public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex)
	{
		lastIndex = default(int);
		return 0f;
	}

	public static Vector2 PackUV(float x, float y, float scale)
	{
		return default(Vector2);
	}

	public static void ResizeInternalArray<T>(ref T[] array)
	{
	}

	public static void ResizeInternalArray<T>(ref T[] array, int size)
	{
	}

	internal static void InsertOpeningTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	internal static void InsertClosingTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	public static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		srcOffset = default(int);
		return false;
	}

	private static bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		srcOffset = default(int);
		return false;
	}

	public static void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	internal static void InsertOpeningStyleTag(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	internal static void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	private static void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings)
	{
	}

	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode)
	{
		return null;
	}

	public static int GetStyleHashCode(ref uint[] text, int index, out int closeIndex)
	{
		closeIndex = default(int);
		return 0;
	}

	public static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex)
	{
		closeIndex = default(int);
		return 0;
	}

	public static uint GetUTF16(uint[] text, int i)
	{
		return 0u;
	}

	public static uint GetUTF16(TextBackingContainer text, int i)
	{
		return 0u;
	}

	public static uint GetUTF32(uint[] text, int i)
	{
		return 0u;
	}

	public static uint GetUTF32(TextBackingContainer text, int i)
	{
		return 0u;
	}

	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
	}

	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo)
	{
	}

	public static void ResizeLineExtents(int size, TextInfo textInfo)
	{
	}

	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle)
	{
		return default(FontStyles);
	}

	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor)
	{
		return default(TextAlignment);
	}

	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
	{
		return 0u;
	}

	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex)
	{
		return 0;
	}

	public static int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex)
	{
		return 0;
	}

	public static char ToUpperASCIIFast(char c)
	{
		return '\0';
	}

	public static uint ToUpperASCIIFast(uint c)
	{
		return 0u;
	}

	public static char ToUpperFast(char c)
	{
		return '\0';
	}

	public static int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters)
	{
		return 0;
	}

	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode)
	{
		return false;
	}

	public static bool IsBaseGlyph(uint c)
	{
		return false;
	}

	public static Color MinAlpha(this Color c1, Color c2)
	{
		return default(Color);
	}

	internal static Color32 GammaToLinear(Color32 c)
	{
		return default(Color32);
	}

	private static byte GammaToLinear(byte value)
	{
		return 0;
	}

	public static bool IsValidUTF16(TextBackingContainer text, int index)
	{
		return false;
	}

	public static bool IsValidUTF32(TextBackingContainer text, int index)
	{
		return false;
	}

	internal static bool IsHangul(uint c)
	{
		return false;
	}

	internal static bool IsCJK(uint c)
	{
		return false;
	}
}
