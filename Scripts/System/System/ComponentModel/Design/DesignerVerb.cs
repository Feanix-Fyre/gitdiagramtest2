namespace System.ComponentModel.Design;

/// <summary>Represents a verb that can be invoked from a designer.</summary>
public class DesignerVerb : MenuCommand
{
	/// <summary>Gets the text description for the verb command on the menu.</summary>
	/// <returns>A description for the verb command.</returns>
	public string Text => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.DesignerVerb" /> class.</summary>
	/// <param name="text">The text of the menu command that is shown to the user.</param>
	/// <param name="handler">The event handler that performs the actions of the verb.</param>
	public DesignerVerb(string text, EventHandler handler)
		: base(null, null)
	{
	}

	/// <summary>Overrides <see cref="M:System.Object.ToString" />.</summary>
	/// <returns>The verb's text, or an empty string ("") if the text field is empty.</returns>
	public override string ToString()
	{
		return null;
	}
}
