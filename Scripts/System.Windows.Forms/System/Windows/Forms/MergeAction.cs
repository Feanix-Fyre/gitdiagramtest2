namespace System.Windows.Forms;

/// <summary>Specifies the kind of action to take if a match is found when combining menu items on a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
public enum MergeAction
{
	/// <summary>Appends the item to the end of the collection, ignoring match results.</summary>
	Append = 0,
	/// <summary>Inserts the item to the target's collection immediately preceding the matched item. A match of the end of the list results in the item being appended to the list. If there is no match or the match is at the beginning of the list, the item is inserted at the beginning of the collection.</summary>
	Insert = 1,
	/// <summary>Replaces the matched item with the source item. The original item's drop-down items do not become children of the incoming item.</summary>
	Replace = 2,
	/// <summary>Removes the matched item.</summary>
	Remove = 3,
	/// <summary>A match is required, but no action is taken. Use this for tree creation and successful access to nested layouts.</summary>
	MatchOnly = 4
}
