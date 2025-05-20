namespace System.Drawing;

/// <summary>Specifies how to trim characters from a string that does not completely fit into a layout shape.</summary>
public enum StringTrimming
{
	/// <summary>Specifies no trimming.</summary>
	None = 0,
	/// <summary>Specifies that the text is trimmed to the nearest character.</summary>
	Character = 1,
	/// <summary>Specifies that text is trimmed to the nearest word.</summary>
	Word = 2,
	/// <summary>Specifies that the text is trimmed to the nearest character, and an ellipsis is inserted at the end of a trimmed line.</summary>
	EllipsisCharacter = 3,
	/// <summary>Specifies that text is trimmed to the nearest word, and an ellipsis is inserted at the end of a trimmed line.</summary>
	EllipsisWord = 4,
	/// <summary>The center is removed from trimmed lines and replaced by an ellipsis. The algorithm keeps as much of the last slash-delimited segment of the line as possible.</summary>
	EllipsisPath = 5
}
