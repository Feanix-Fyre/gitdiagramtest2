namespace UnityEngine.TextCore.Text;

internal class TextHandle
{
	private Vector2 m_PreferredSize;

	private TextInfo m_TextInfo;

	private static TextInfo m_LayoutTextInfo;

	private int m_PreviousGenerationSettingsHash;

	protected TextGenerationSettings textGenerationSettings;

	protected static TextGenerationSettings s_LayoutSettings;

	private bool isDirty;

	internal TextInfo textInfo => null;

	internal static TextInfo layoutTextInfo => null;

	public bool IsDirty()
	{
		return false;
	}

	public Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = true)
	{
		return default(Vector2);
	}

	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = false, bool inverseYAxis = true)
	{
		return default(Vector2);
	}

	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = true)
	{
		return 0;
	}

	public int LineDownCharacterPosition(int originalPos)
	{
		return 0;
	}

	public int LineUpCharacterPosition(int originalPos)
	{
		return 0;
	}

	public int FindNearestLine(Vector2 position)
	{
		return 0;
	}

	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly)
	{
		return 0;
	}

	public int FindIntersectingLink(Vector3 position, bool inverseYAxis = true)
	{
		return 0;
	}

	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		return false;
	}

	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point)
	{
		return 0f;
	}

	public int GetLineNumber(int index)
	{
		return 0;
	}

	public float GetLineHeight(int lineNumber)
	{
		return 0f;
	}

	public float GetLineHeightFromCharacterIndex(int index)
	{
		return 0f;
	}

	public float GetCharacterHeightFromIndex(int index)
	{
		return 0f;
	}

	public bool IsElided()
	{
		return false;
	}

	public string Substring(int startIndex, int length)
	{
		return null;
	}

	public int IndexOf(char value, int startIndex)
	{
		return 0;
	}

	public int LastIndexOf(char value, int startIndex)
	{
		return 0;
	}

	protected float ComputeTextWidth(TextGenerationSettings tgs)
	{
		return 0f;
	}

	protected float ComputeTextHeight(TextGenerationSettings tgs)
	{
		return 0f;
	}

	protected void UpdatePreferredValues(TextGenerationSettings tgs)
	{
	}

	protected TextInfo Update(TextGenerationSettings tgs)
	{
		return null;
	}
}
