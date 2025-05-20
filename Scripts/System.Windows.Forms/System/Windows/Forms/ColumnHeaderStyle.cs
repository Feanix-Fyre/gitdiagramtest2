namespace System.Windows.Forms;

/// <summary>Specifies the styles of the column headers in a <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
public enum ColumnHeaderStyle
{
	/// <summary>The column header is not displayed in report view.</summary>
	None = 0,
	/// <summary>The column headers do not respond to the click of a mouse.</summary>
	Nonclickable = 1,
	/// <summary>The column headers function like buttons and can carry out an action, such as sorting, when clicked.</summary>
	Clickable = 2
}
