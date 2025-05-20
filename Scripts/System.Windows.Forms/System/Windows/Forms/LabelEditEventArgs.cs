namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.BeforeLabelEdit" /> and <see cref="E:System.Windows.Forms.ListView.AfterLabelEdit" /> events.</summary>
public class LabelEditEventArgs : EventArgs
{
	private int item;

	private string label;

	private bool cancelEdit;

	/// <summary>Gets or sets a value indicating whether changes made to the label of the <see cref="T:System.Windows.Forms.ListViewItem" /> should be canceled.</summary>
	/// <returns>
	///   <see langword="true" /> if the edit operation of the label for the <see cref="T:System.Windows.Forms.ListViewItem" /> should be canceled; otherwise <see langword="false" />.</returns>
	public bool CancelEdit
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the zero-based index of the <see cref="T:System.Windows.Forms.ListViewItem" /> containing the label to edit.</summary>
	/// <returns>The zero-based index of the <see cref="T:System.Windows.Forms.ListViewItem" />.</returns>
	public int Item => 0;

	/// <summary>Gets the new text assigned to the label of the <see cref="T:System.Windows.Forms.ListViewItem" />.</summary>
	/// <returns>The new text to associate with the <see cref="T:System.Windows.Forms.ListViewItem" /> or <see langword="null" /> if the text is unchanged.</returns>
	public string Label => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.LabelEditEventArgs" /> class with the specified index to the <see cref="T:System.Windows.Forms.ListViewItem" /> to edit.</summary>
	/// <param name="item">The zero-based index of the <see cref="T:System.Windows.Forms.ListViewItem" />, containing the label to edit.</param>
	public LabelEditEventArgs(int item)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.LabelEditEventArgs" /> class with the specified index to the <see cref="T:System.Windows.Forms.ListViewItem" /> being edited and the new text for the label of the <see cref="T:System.Windows.Forms.ListViewItem" />.</summary>
	/// <param name="item">The zero-based index of the <see cref="T:System.Windows.Forms.ListViewItem" />, containing the label to edit.</param>
	/// <param name="label">The new text assigned to the label of the <see cref="T:System.Windows.Forms.ListViewItem" />.</param>
	public LabelEditEventArgs(int item, string label)
	{
	}

	internal void SetLabel(string label)
	{
	}
}
