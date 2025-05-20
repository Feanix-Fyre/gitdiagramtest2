using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/TextRendering/TextGenerator.h")]
[UsedByNativeCode]
public sealed class TextGenerator : IDisposable
{
	internal IntPtr m_Ptr;

	private string m_LastString;

	private TextGenerationSettings m_LastSettings;

	private bool m_HasGenerated;

	private TextGenerationError m_LastValid;

	private readonly List<UIVertex> m_Verts;

	private readonly List<UICharInfo> m_Characters;

	private readonly List<UILineInfo> m_Lines;

	private bool m_CachedVerts;

	private bool m_CachedCharacters;

	private bool m_CachedLines;

	public int characterCountVisible => 0;

	public IList<UIVertex> verts => null;

	public IList<UICharInfo> characters => null;

	public IList<UILineInfo> lines => null;

	public Rect rectExtents => default(Rect);

	public int characterCount => 0;

	public int lineCount => 0;

	public TextGenerator()
	{
	}

	public TextGenerator(int initialCapacity)
	{
	}

	~TextGenerator()
	{
	}

	void IDisposable.Dispose()
	{
	}

	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings)
	{
		return default(TextGenerationSettings);
	}

	public void Invalidate()
	{
	}

	public void GetCharacters(List<UICharInfo> characters)
	{
	}

	public void GetLines(List<UILineInfo> lines)
	{
	}

	public void GetVertices(List<UIVertex> vertices)
	{
	}

	public float GetPreferredWidth(string str, TextGenerationSettings settings)
	{
		return 0f;
	}

	public float GetPreferredHeight(string str, TextGenerationSettings settings)
	{
		return 0f;
	}

	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context)
	{
		return false;
	}

	public bool Populate(string str, TextGenerationSettings settings)
	{
		return false;
	}

	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings)
	{
		return default(TextGenerationError);
	}

	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings)
	{
		return default(TextGenerationError);
	}

	[NativeMethod(IsThreadSafe = true)]
	private static IntPtr Internal_Create()
	{
		return (IntPtr)0;
	}

	[NativeMethod(IsThreadSafe = true)]
	private static void Internal_Destroy(IntPtr ptr)
	{
	}

	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
	{
		error = default(uint);
		return false;
	}

	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error)
	{
		error = default(TextGenerationError);
		return false;
	}

	[NativeThrows]
	private void GetVerticesInternal(object vertices)
	{
	}

	[NativeThrows]
	private void GetCharactersInternal(object characters)
	{
	}

	[NativeThrows]
	private void GetLinesInternal(object lines)
	{
	}

	[SpecialName]
	private void get_rectExtents_Injected(out Rect ret)
	{
		ret = default(Rect);
	}

	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
	{
		error = default(uint);
		return false;
	}
}
