using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Represents the menu structure of a form. Although <see cref="T:System.Windows.Forms.MenuStrip" /> replaces and adds functionality to the <see cref="T:System.Windows.Forms.MainMenu" /> control of previous versions, <see cref="T:System.Windows.Forms.MainMenu" /> is retained for both backward compatibility and future use if you choose.</summary>
[ToolboxItemFilter("System.Windows.Forms.MainMenu", ToolboxItemFilterType.Allow)]
public class MainMenu : Menu
{
	private RightToLeft right_to_left;

	private Form form;

	private static object CollapseEvent;

	internal event PaintEventHandler Paint
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.MainMenu" /> class without any specified menu items.</summary>
	public MainMenu()
		: base(null)
	{
	}

	/// <summary>Creates a new <see cref="T:System.Windows.Forms.MainMenu" /> that is a duplicate of the current <see cref="T:System.Windows.Forms.MainMenu" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.MainMenu" /> that represents the cloned menu.</returns>
	public virtual MainMenu CloneMenu()
	{
		return null;
	}

	/// <summary>Disposes of the resources, other than memory, used by the <see cref="T:System.Windows.Forms.MainMenu" />.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Gets the <see cref="T:System.Windows.Forms.Form" /> that contains this control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Form" /> that is the container for this control. Returns <see langword="null" /> if the <see cref="T:System.Windows.Forms.MainMenu" /> is not currently hosted on a form.</returns>
	public Form GetForm()
	{
		return null;
	}

	/// <summary>Returns a string that represents the <see cref="T:System.Windows.Forms.MainMenu" />.</summary>
	/// <returns>A string that represents the current <see cref="T:System.Windows.Forms.MainMenu" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.MainMenu.Collapse" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected internal virtual void OnCollapse(EventArgs e)
	{
	}

	internal void Draw()
	{
	}

	internal void Draw(Rectangle rect)
	{
	}

	internal void Draw(PaintEventArgs pe, Rectangle rect)
	{
	}

	internal override void InvalidateItem(MenuItem item)
	{
	}

	internal void SetForm(Form form)
	{
	}

	internal override void OnMenuChanged(EventArgs e)
	{
	}

	internal void OnMouseDown(object window, MouseEventArgs args)
	{
	}

	internal void OnMouseMove(object window, MouseEventArgs e)
	{
	}
}
