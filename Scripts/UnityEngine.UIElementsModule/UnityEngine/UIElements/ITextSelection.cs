namespace UnityEngine.UIElements;

public interface ITextSelection
{
	bool isSelectable { get; set; }

	Color cursorColor { get; set; }

	int cursorIndex { get; set; }

	bool doubleClickSelectsWord { get; }

	int selectIndex { get; set; }

	Color selectionColor { get; set; }

	bool tripleClickSelectsLine { get; }

	internal bool selectAllOnFocus { get; set; }

	internal bool selectAllOnMouseUp { get; set; }

	Vector2 cursorPosition { get; }

	internal float lineHeightAtCursorPosition { get; }

	internal float cursorWidth { get; }

	bool HasSelection();

	void SelectAll();

	void SelectNone();
}
