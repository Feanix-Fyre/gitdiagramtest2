using System.Collections;

namespace System.Windows.Forms;

internal class UndoManager
{
	internal enum ActionType
	{
		Typing = 0,
		InsertString = 1,
		DeleteString = 2,
		UserActionBegin = 3,
		UserActionEnd = 4
	}

	internal class Action
	{
		internal ActionType type;

		internal int line_no;

		internal int pos;

		internal object data;
	}

	private Document document;

	private Stack undo_actions;

	private Stack redo_actions;

	private bool locked;

	internal bool CanUndo => false;

	internal UndoManager(Document document)
	{
	}

	internal bool Undo()
	{
		return false;
	}

	public void BeginUserAction(string name)
	{
	}

	public void EndUserAction()
	{
	}

	public void RecordDeleteString(Line start_line, int start_pos, Line end_line, int end_pos)
	{
	}

	public void RecordInsertString(Line line, int pos, string str)
	{
	}

	public void RecordTyping(Line line, int pos, char ch)
	{
	}

	public Line Duplicate(Line start_line, int start_pos, Line end_line, int end_pos)
	{
		return null;
	}

	internal void Insert(Line line, int pos, Line insert, bool select)
	{
	}
}
