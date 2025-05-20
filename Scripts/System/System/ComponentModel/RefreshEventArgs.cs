namespace System.ComponentModel;

/// <summary>Provides data for the <see cref="E:System.ComponentModel.TypeDescriptor.Refreshed" /> event.</summary>
public class RefreshEventArgs : EventArgs
{
	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.RefreshEventArgs" /> class with the component that has changed.</summary>
	/// <param name="componentChanged">The component that changed.</param>
	public RefreshEventArgs(object componentChanged)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.RefreshEventArgs" /> class with the type of component that has changed.</summary>
	/// <param name="typeChanged">The <see cref="T:System.Type" /> that changed.</param>
	public RefreshEventArgs(Type typeChanged)
	{
	}
}
