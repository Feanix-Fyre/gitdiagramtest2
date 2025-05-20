namespace UnityEngine;

internal sealed class GUIGridSizer : GUILayoutEntry
{
	private readonly int m_Count;

	private readonly int m_XCount;

	private readonly float m_MinButtonWidth;

	private readonly float m_MaxButtonWidth;

	private readonly float m_MinButtonHeight;

	private readonly float m_MaxButtonHeight;

	private int rows => 0;

	public static Rect GetRect(GUIContent[] contents, int xCount, GUIStyle style, GUILayoutOption[] options)
	{
		return default(Rect);
	}

	private GUIGridSizer(GUIContent[] contents, int xCount, GUIStyle buttonStyle, GUILayoutOption[] options)
		: base(0f, 0f, 0f, 0f, null)
	{
	}
}
