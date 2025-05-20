using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Represents a shortcut menu. Although <see cref="T:System.Windows.Forms.ContextMenuStrip" /> replaces and adds functionality to the <see cref="T:System.Windows.Forms.ContextMenu" /> control of previous versions, <see cref="T:System.Windows.Forms.ContextMenu" /> is retained for both backward compatibility and future use if you choose.</summary>
[DefaultEvent("Popup")]
public class ContextMenu : Menu
{
	private RightToLeft right_to_left;

	private Control src_control;

	private static object CollapseEvent;

	/// <summary>Gets the control that is displaying the shortcut menu.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Control" /> that represents the control that is displaying the shortcut menu. If no control has displayed the shortcut menu, the property returns <see langword="null" />.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Control SourceControl => null;

	/// <summary>Occurs before the shortcut menu is displayed.</summary>
	public event EventHandler Popup
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ContextMenu" /> class with no menu items specified.</summary>
	public ContextMenu()
		: base(null)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ContextMenu" /> class with a specified set of <see cref="T:System.Windows.Forms.MenuItem" /> objects.</summary>
	/// <param name="menuItems">An array of <see cref="T:System.Windows.Forms.MenuItem" /> objects that represent the menu items to add to the shortcut menu.</param>
	public ContextMenu(MenuItem[] menuItems)
		: base(null)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ContextMenu.Collapse" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected internal virtual void OnCollapse(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ContextMenu.Popup" /> event</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected internal virtual void OnPopup(EventArgs e)
	{
	}

	/// <summary>Displays the shortcut menu at the specified position.</summary>
	/// <param name="control">A <see cref="T:System.Windows.Forms.Control" /> that specifies the control with which this shortcut menu is associated.</param>
	/// <param name="pos">A <see cref="T:System.Drawing.Point" /> that specifies the coordinates at which to display the menu. These coordinates are specified relative to the client coordinates of the control specified in the <paramref name="control" /> parameter.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="control" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The handle of the control does not exist or the control is not visible.</exception>
	public void Show(Control control, Point pos)
	{
	}
}
