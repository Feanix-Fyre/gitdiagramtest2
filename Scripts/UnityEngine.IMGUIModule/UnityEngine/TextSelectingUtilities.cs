using System;
using System.Collections.Generic;
using UnityEngine.TextCore.Text;

namespace UnityEngine;

internal class TextSelectingUtilities
{
	private enum CharacterType
	{
		LetterLike = 0,
		Symbol = 1,
		Symbol2 = 2,
		WhiteSpace = 3,
		NewLine = 4
	}

	private enum Direction
	{
		Forward = 0,
		Backward = 1
	}

	public TextEditor.DblClickSnapping dblClickSnap;

	public int iAltCursorPos;

	public bool hasHorizontalCursorPos;

	private bool m_bJustSelected;

	private bool m_MouseDragSelectsWholeWords;

	private int m_DblClickInitPosStart;

	private int m_DblClickInitPosEnd;

	private TextHandle m_TextHandle;

	private const int kMoveDownHeight = 5;

	private const char kNewLineChar = '\n';

	private bool m_RevealCursor;

	private int m_CursorIndex;

	internal int m_SelectIndex;

	private static Dictionary<Event, TextSelectOp> s_KeySelectOps;

	internal Action OnCursorIndexChange;

	internal Action OnSelectIndexChange;

	internal Action OnRevealCursorChange;

	public bool hasSelection => false;

	public bool revealCursor
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private int m_CharacterCount => 0;

	private int characterCount => 0;

	private TextElementInfo[] m_TextElementInfos => null;

	public int cursorIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int selectIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string selectedText => null;

	internal void SetCursorIndexWithoutNotify(int index)
	{
	}

	internal void SetSelectIndexWithoutNotify(int index)
	{
	}

	public TextSelectingUtilities(TextHandle textHandle)
	{
	}

	internal bool HandleKeyEvent(Event e)
	{
		return false;
	}

	private bool PerformOperation(TextSelectOp operation)
	{
		return false;
	}

	private static void MapKey(string key, TextSelectOp action)
	{
	}

	private void InitKeyActions()
	{
	}

	public void ClearCursorPos()
	{
	}

	public void OnFocus(bool selectAll = true)
	{
	}

	public void SelectAll()
	{
	}

	public void SelectNone()
	{
	}

	public void SelectLeft()
	{
	}

	public void SelectRight()
	{
	}

	public void SelectUp()
	{
	}

	public void SelectDown()
	{
	}

	public void SelectTextEnd()
	{
	}

	public void SelectTextStart()
	{
	}

	public void SelectToStartOfNextWord()
	{
	}

	public void SelectToEndOfPreviousWord()
	{
	}

	public void SelectWordRight()
	{
	}

	public void SelectWordLeft()
	{
	}

	public void SelectGraphicalLineStart()
	{
	}

	public void SelectGraphicalLineEnd()
	{
	}

	public void SelectParagraphForward()
	{
	}

	public void SelectParagraphBackward()
	{
	}

	public void SelectCurrentWord()
	{
	}

	public void SelectCurrentParagraph()
	{
	}

	public void MoveRight()
	{
	}

	public void MoveLeft()
	{
	}

	public void MoveUp()
	{
	}

	public void MoveDown()
	{
	}

	public void MoveLineStart()
	{
	}

	public void MoveLineEnd()
	{
	}

	public void MoveGraphicalLineStart()
	{
	}

	public void MoveGraphicalLineEnd()
	{
	}

	public void MoveTextStart()
	{
	}

	public void MoveTextEnd()
	{
	}

	public void MoveParagraphForward()
	{
	}

	public void MoveParagraphBackward()
	{
	}

	public void MoveWordRight()
	{
	}

	public void MoveToStartOfNextWord()
	{
	}

	public void MoveToEndOfPreviousWord()
	{
	}

	public void MoveWordLeft()
	{
	}

	public void MouseDragSelectsWholeWords(bool on)
	{
	}

	public void ExpandSelectGraphicalLineStart()
	{
	}

	public void ExpandSelectGraphicalLineEnd()
	{
	}

	public void DblClickSnap(TextEditor.DblClickSnapping snapping)
	{
	}

	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift)
	{
	}

	public void SelectToPosition(Vector2 cursorPosition)
	{
	}

	private int FindNextSeperator(int startPos)
	{
		return 0;
	}

	private int FindPrevSeperator(int startPos)
	{
		return 0;
	}

	public int FindStartOfNextWord(int p)
	{
		return 0;
	}

	public int FindEndOfPreviousWord(int p)
	{
		return 0;
	}

	private int FindEndOfClassification(int p, Direction dir)
	{
		return 0;
	}

	private int ClampTextIndex(int index)
	{
		return 0;
	}

	internal int EnsureValidCodePointIndex(int index)
	{
		return 0;
	}

	private bool IsValidCodePointIndex(int index)
	{
		return false;
	}

	private int IndexOfEndOfLine(int startIndex)
	{
		return 0;
	}

	public int PreviousCodePointIndex(int index)
	{
		return 0;
	}

	public int NextCodePointIndex(int index)
	{
		return 0;
	}

	private int GetGraphicalLineStart(int p)
	{
		return 0;
	}

	private int GetGraphicalLineEnd(int p)
	{
		return 0;
	}

	public void Copy()
	{
	}

	private CharacterType ClassifyChar(int index)
	{
		return default(CharacterType);
	}
}
