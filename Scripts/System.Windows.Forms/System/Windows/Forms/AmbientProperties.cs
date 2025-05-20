using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides ambient property values to top-level controls.</summary>
public sealed class AmbientProperties
{
	private Color fore_color;

	private Color back_color;

	private Font font;

	private Cursor cursor;

	/// <summary>Gets or sets the ambient background color of an object.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> value that represents the background color of an object.</returns>
	public Color BackColor => default(Color);

	/// <summary>Gets or sets the ambient cursor of an object.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Cursor" /> that represents the cursor of an object.</returns>
	public Cursor Cursor => null;

	/// <summary>Gets or sets the ambient font of an object.</summary>
	/// <returns>A <see cref="T:System.Drawing.Font" /> that represents the font used when displaying text within an object.</returns>
	public Font Font => null;

	/// <summary>Gets or sets the ambient foreground color of an object.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> value that represents the foreground color of an object.</returns>
	public Color ForeColor => default(Color);
}
