using UnityEngine.Scripting;

namespace UnityEngine;

public class TextEditor
{
	public enum DblClickSnapping : byte
	{
		WORDS = 0,
		PARAGRAPHS = 1
	}

	public TouchScreenKeyboard keyboardOnScreen;

	public int controlID;

	public GUIStyle style;

	public bool multiline;

	public bool hasHorizontalCursorPos;

	public bool isPasswordField;

	public Vector2 scrollOffset;

	private GUIContent m_Content;

	private int m_CursorIndex;

	private int m_SelectIndex;

	private bool m_RevealCursor;

	private bool m_MouseDragSelectsWholeWords;

	private int m_DblClickInitPos;

	private DblClickSnapping m_DblClickSnap;

	private bool m_bJustSelected;

	private int m_iAltCursorPos;

	[RequiredByNativeCode]
	public TextEditor()
	{
	}
}
