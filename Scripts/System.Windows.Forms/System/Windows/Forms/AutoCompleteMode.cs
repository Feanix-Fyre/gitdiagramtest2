namespace System.Windows.Forms;

/// <summary>Specifies the mode for the automatic completion feature used in the <see cref="T:System.Windows.Forms.ComboBox" /> and <see cref="T:System.Windows.Forms.TextBox" /> controls.</summary>
public enum AutoCompleteMode
{
	/// <summary>Disables the automatic completion feature for the <see cref="T:System.Windows.Forms.ComboBox" /> and <see cref="T:System.Windows.Forms.TextBox" /> controls.</summary>
	None = 0,
	/// <summary>Displays the auxiliary drop-down list associated with the edit control. This drop-down is populated with one or more suggested completion strings.</summary>
	Suggest = 1,
	/// <summary>Appends the remainder of the most likely candidate string to the existing characters, highlighting the appended characters.</summary>
	Append = 2,
	/// <summary>Applies both <see langword="Suggest" /> and <see langword="Append" /> options.</summary>
	SuggestAppend = 3
}
