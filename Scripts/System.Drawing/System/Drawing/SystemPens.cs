namespace System.Drawing;

/// <summary>Each property of the <see cref="T:System.Drawing.SystemPens" /> class is a <see cref="T:System.Drawing.Pen" /> that is the color of a Windows display element and that has a width of 1 pixel.</summary>
public sealed class SystemPens
{
	private static Pen control;

	private static Pen control_dark;

	private static Pen control_dark_dark;

	private static Pen control_light;

	private static Pen control_light_light;

	private static Pen control_text;

	private static Pen window_frame;

	/// <summary>Gets a <see cref="T:System.Drawing.Pen" /> that is the face color of a 3-D element.</summary>
	/// <returns>A <see cref="T:System.Drawing.Pen" /> that is the face color of a 3-D element.</returns>
	public static Pen Control => null;

	/// <summary>Gets a <see cref="T:System.Drawing.Pen" /> that is the shadow color of a 3-D element.</summary>
	/// <returns>A <see cref="T:System.Drawing.Pen" /> that is the shadow color of a 3-D element.</returns>
	public static Pen ControlDark => null;

	/// <summary>Gets a <see cref="T:System.Drawing.Pen" /> that is the dark shadow color of a 3-D element.</summary>
	/// <returns>A <see cref="T:System.Drawing.Pen" /> that is the dark shadow color of a 3-D element.</returns>
	public static Pen ControlDarkDark => null;

	/// <summary>Gets a <see cref="T:System.Drawing.Pen" /> that is the light color of a 3-D element.</summary>
	/// <returns>A <see cref="T:System.Drawing.Pen" /> that is the light color of a 3-D element.</returns>
	public static Pen ControlLight => null;

	/// <summary>Gets a <see cref="T:System.Drawing.Pen" /> that is the highlight color of a 3-D element.</summary>
	/// <returns>A <see cref="T:System.Drawing.Pen" /> that is the highlight color of a 3-D element.</returns>
	public static Pen ControlLightLight => null;

	/// <summary>Gets a <see cref="T:System.Drawing.Pen" /> that is the color of text in a 3-D element.</summary>
	/// <returns>A <see cref="T:System.Drawing.Pen" /> that is the color of text in a 3-D element.</returns>
	public static Pen ControlText => null;

	/// <summary>Gets a <see cref="T:System.Drawing.Pen" /> that is the color of a window frame.</summary>
	/// <returns>A <see cref="T:System.Drawing.Pen" /> that is the color of a window frame.</returns>
	public static Pen WindowFrame => null;
}
