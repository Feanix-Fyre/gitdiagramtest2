namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ToolBar.ButtonClick" /> event.</summary>
public class ToolBarButtonClickEventArgs : EventArgs
{
	private ToolBarButton button;

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.ToolBarButton" /> that was clicked.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ToolBarButton" /> that was clicked.</returns>
	public ToolBarButton Button => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolBarButtonClickEventArgs" /> class.</summary>
	/// <param name="button">The <see cref="T:System.Windows.Forms.ToolBarButton" /> that was clicked.</param>
	public ToolBarButtonClickEventArgs(ToolBarButton button)
	{
	}
}
