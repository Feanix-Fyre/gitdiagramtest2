namespace System.ComponentModel.Design;

/// <summary>Defines identifiers for the standard set of commands that are available to most applications.</summary>
public class StandardCommands
{
	private static class ShellGuids
	{
		internal static readonly Guid VSStandardCommandSet97;

		internal static readonly Guid guidDsdCmdId;

		internal static readonly Guid SID_SOleComponentUIManager;

		internal static readonly Guid GUID_VSTASKCATEGORY_DATADESIGNER;

		internal static readonly Guid GUID_PropertyBrowserToolWindow;
	}

	private static readonly Guid s_standardCommandSet;

	private static readonly Guid s_ndpCommandSet;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the AlignBottom command. This field is read-only.</summary>
	public static readonly CommandID AlignBottom;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the AlignHorizontalCenters command. This field is read-only.</summary>
	public static readonly CommandID AlignHorizontalCenters;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the AlignLeft command. This field is read-only.</summary>
	public static readonly CommandID AlignLeft;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the AlignRight command. This field is read-only.</summary>
	public static readonly CommandID AlignRight;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the AlignToGrid command. This field is read-only.</summary>
	public static readonly CommandID AlignToGrid;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the AlignTop command. This field is read-only.</summary>
	public static readonly CommandID AlignTop;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the AlignVerticalCenters command. This field is read-only.</summary>
	public static readonly CommandID AlignVerticalCenters;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the ArrangeBottom command. This field is read-only.</summary>
	public static readonly CommandID ArrangeBottom;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the ArrangeRight command. This field is read-only.</summary>
	public static readonly CommandID ArrangeRight;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the BringForward command. This field is read-only.</summary>
	public static readonly CommandID BringForward;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the BringToFront command. This field is read-only.</summary>
	public static readonly CommandID BringToFront;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the CenterHorizontally command. This field is read-only.</summary>
	public static readonly CommandID CenterHorizontally;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the CenterVertically command. This field is read-only.</summary>
	public static readonly CommandID CenterVertically;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the ViewCode command. This field is read-only.</summary>
	public static readonly CommandID ViewCode;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the Document Outline command. This field is read-only.</summary>
	public static readonly CommandID DocumentOutline;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the Copy command. This field is read-only.</summary>
	public static readonly CommandID Copy;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the Cut command. This field is read-only.</summary>
	public static readonly CommandID Cut;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the Delete command. This field is read-only.</summary>
	public static readonly CommandID Delete;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the Group command. This field is read-only.</summary>
	public static readonly CommandID Group;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the HorizSpaceConcatenate command. This field is read-only.</summary>
	public static readonly CommandID HorizSpaceConcatenate;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the HorizSpaceDecrease command. This field is read-only.</summary>
	public static readonly CommandID HorizSpaceDecrease;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the HorizSpaceIncrease command. This field is read-only.</summary>
	public static readonly CommandID HorizSpaceIncrease;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the HorizSpaceMakeEqual command. This field is read-only.</summary>
	public static readonly CommandID HorizSpaceMakeEqual;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the Paste command. This field is read-only.</summary>
	public static readonly CommandID Paste;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the Properties command. This field is read-only.</summary>
	public static readonly CommandID Properties;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the Redo command. This field is read-only.</summary>
	public static readonly CommandID Redo;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the MultiLevelRedo command. This field is read-only.</summary>
	public static readonly CommandID MultiLevelRedo;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the SelectAll command. This field is read-only.</summary>
	public static readonly CommandID SelectAll;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the SendBackward command. This field is read-only.</summary>
	public static readonly CommandID SendBackward;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the SendToBack command. This field is read-only.</summary>
	public static readonly CommandID SendToBack;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the SizeToControl command. This field is read-only.</summary>
	public static readonly CommandID SizeToControl;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the SizeToControlHeight command. This field is read-only.</summary>
	public static readonly CommandID SizeToControlHeight;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the SizeToControlWidth command. This field is read-only.</summary>
	public static readonly CommandID SizeToControlWidth;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the SizeToFit command. This field is read-only.</summary>
	public static readonly CommandID SizeToFit;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the SizeToGrid command. This field is read-only.</summary>
	public static readonly CommandID SizeToGrid;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the SnapToGrid command. This field is read-only.</summary>
	public static readonly CommandID SnapToGrid;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the TabOrder command. This field is read-only.</summary>
	public static readonly CommandID TabOrder;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the Undo command. This field is read-only.</summary>
	public static readonly CommandID Undo;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the MultiLevelUndo command. This field is read-only.</summary>
	public static readonly CommandID MultiLevelUndo;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the Ungroup command. This field is read-only.</summary>
	public static readonly CommandID Ungroup;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the VertSpaceConcatenate command. This field is read-only.</summary>
	public static readonly CommandID VertSpaceConcatenate;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the VertSpaceDecrease command. This field is read-only.</summary>
	public static readonly CommandID VertSpaceDecrease;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the VertSpaceIncrease command. This field is read-only.</summary>
	public static readonly CommandID VertSpaceIncrease;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the VertSpaceMakeEqual command. This field is read-only.</summary>
	public static readonly CommandID VertSpaceMakeEqual;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the ShowGrid command. This field is read-only.</summary>
	public static readonly CommandID ShowGrid;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the ViewGrid command. This field is read-only.</summary>
	public static readonly CommandID ViewGrid;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the Replace command. This field is read-only.</summary>
	public static readonly CommandID Replace;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the PropertiesWindow command. This field is read-only.</summary>
	public static readonly CommandID PropertiesWindow;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the LockControls command. This field is read-only.</summary>
	public static readonly CommandID LockControls;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the F1Help command. This field is read-only.</summary>
	public static readonly CommandID F1Help;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the ArrangeIcons command. This field is read-only.</summary>
	public static readonly CommandID ArrangeIcons;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the LineupIcons command. This field is read-only.</summary>
	public static readonly CommandID LineupIcons;

	/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> for the ShowLargeIcons command. This field is read-only.</summary>
	public static readonly CommandID ShowLargeIcons;

	/// <summary>Gets the first of a set of verbs. This field is read-only.</summary>
	public static readonly CommandID VerbFirst;

	/// <summary>Gets the last of a set of verbs. This field is read-only.</summary>
	public static readonly CommandID VerbLast;
}
