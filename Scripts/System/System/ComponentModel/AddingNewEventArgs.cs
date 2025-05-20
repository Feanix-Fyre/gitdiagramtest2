namespace System.ComponentModel;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.BindingSource.AddingNew" /> event.</summary>
public class AddingNewEventArgs : EventArgs
{
	/// <summary>Gets or sets the object to be added to the binding list.</summary>
	/// <returns>The <see cref="T:System.Object" /> to be added as a new item to the associated collection.</returns>
	public object NewObject { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AddingNewEventArgs" /> class using no parameters.</summary>
	public AddingNewEventArgs()
	{
	}
}
