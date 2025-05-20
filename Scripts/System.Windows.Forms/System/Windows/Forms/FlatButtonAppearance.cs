using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides properties that specify the appearance of <see cref="T:System.Windows.Forms.Button" /> controls whose <see cref="T:System.Windows.Forms.FlatStyle" /> is <see cref="F:System.Windows.Forms.FlatStyle.Flat" />.</summary>
[TypeConverter(typeof(FlatButtonAppearanceConverter))]
public class FlatButtonAppearance
{
	private Color borderColor;

	private int borderSize;

	private Color checkedBackColor;

	private Color mouseDownBackColor;

	private Color mouseOverBackColor;

	private ButtonBase owner;

	/// <summary>Gets or sets the color of the border around the button.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> structure representing the color of the border around the button.</returns>
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DefaultValue(typeof(Color), null)]
	[NotifyParentProperty(true)]
	[Browsable(true)]
	public Color BorderColor => default(Color);

	/// <summary>Gets or sets a value that specifies the size, in pixels, of the border around the button.</summary>
	/// <returns>An <see cref="T:System.Int32" /> representing the size, in pixels, of the border around the button.</returns>
	[Browsable(true)]
	[DefaultValue(1)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[NotifyParentProperty(true)]
	public int BorderSize => 0;

	/// <summary>Gets or sets the color of the client area of the button when the button is checked and the mouse pointer is outside the bounds of the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> structure representing the color of the client area of the button.</returns>
	[DefaultValue(typeof(Color), null)]
	[NotifyParentProperty(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	public Color CheckedBackColor => default(Color);

	/// <summary>Gets or sets the color of the client area of the button when the mouse is pressed within the bounds of the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> structure representing the color of the client area of the button.</returns>
	[Browsable(true)]
	[NotifyParentProperty(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DefaultValue(typeof(Color), null)]
	public Color MouseDownBackColor => default(Color);

	/// <summary>Gets or sets the color of the client area of the button when the mouse pointer is within the bounds of the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> structure representing the color of the client area of the button.</returns>
	[NotifyParentProperty(true)]
	[DefaultValue(typeof(Color), null)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	public Color MouseOverBackColor => default(Color);

	internal FlatButtonAppearance(ButtonBase owner)
	{
	}
}
