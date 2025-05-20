using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.TextCore.Text;

namespace UnityEngine;

internal class TextEditingUtilities
{
	private TextSelectingUtilities m_TextSelectingUtility;

	private TextHandle m_TextHandle;

	private int m_CursorIndexSavedState;

	internal bool isCompositionActive;

	private bool m_UpdateImeWindowPosition;

	public bool multiline;

	private string m_Text;

	private static Dictionary<Event, TextEditOp> s_KeyEditOps;

	private bool hasSelection => false;

	internal bool revealCursor
	{
		set
		{
		}
	}

	private int cursorIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private int selectIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TextEditingUtilities(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text)
	{
	}

	public bool UpdateImeState()
	{
		return false;
	}

	public bool ShouldUpdateImeWindowPosition()
	{
		return false;
	}

	public void SetImeWindowPosition(Vector2 worldPosition)
	{
	}

	public string GeneratePreviewString(bool richText)
	{
		return null;
	}

	public void EnableCursorPreviewState()
	{
	}

	public void RestoreCursorState()
	{
	}

	[VisibleToOtherModules]
	internal bool HandleKeyEvent(Event e)
	{
		return false;
	}

	private void PerformOperation(TextEditOp operation)
	{
	}

	private static void MapKey(string key, TextEditOp action)
	{
	}

	private void InitKeyActions()
	{
	}

	public bool DeleteLineBack()
	{
		return false;
	}

	public bool DeleteWordBack()
	{
		return false;
	}

	public bool DeleteWordForward()
	{
		return false;
	}

	public bool Delete()
	{
		return false;
	}

	public bool Backspace()
	{
		return false;
	}

	public bool DeleteSelection()
	{
		return false;
	}

	public void ReplaceSelection(string replace)
	{
	}

	public void Insert(char c)
	{
	}

	public bool CanPaste()
	{
		return false;
	}

	public bool Cut()
	{
		return false;
	}

	public bool Paste()
	{
		return false;
	}

	private static string ReplaceNewlinesWithSpaces(string value)
	{
		return null;
	}

	internal void OnBlur()
	{
	}

	internal bool TouchScreenKeyboardShouldBeUsed()
	{
		return false;
	}
}
