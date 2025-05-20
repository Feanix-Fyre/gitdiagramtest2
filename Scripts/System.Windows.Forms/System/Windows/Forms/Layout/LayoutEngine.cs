namespace System.Windows.Forms.Layout;

/// <summary>Provides the base class for implementing layout engines.</summary>
public abstract class LayoutEngine
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Layout.LayoutEngine" /> class.</summary>
	protected LayoutEngine()
	{
	}

	/// <summary>Requests that the layout engine perform a layout operation.</summary>
	/// <param name="container">The container on which the layout engine will operate.</param>
	/// <param name="layoutEventArgs">An event argument from a <see cref="E:System.Windows.Forms.Control.Layout" /> event.</param>
	/// <returns>
	///   <see langword="true" /> if layout should be performed again by the parent of <paramref name="container" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="container" /> is not a type on which <see cref="T:System.Windows.Forms.Layout.LayoutEngine" /> can perform layout.</exception>
	public virtual bool Layout(object container, LayoutEventArgs layoutEventArgs)
	{
		return false;
	}
}
