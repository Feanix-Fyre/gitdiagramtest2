namespace System.Drawing;

/// <summary>Specifies the fonts used to display text in Windows display elements.</summary>
public sealed class SystemFonts
{
	/// <summary>Gets the default font that applications can use for dialog boxes and forms.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Font" /> of the system. The value returned will vary depending on the user's operating system and the local culture setting of their system.</returns>
	public static Font DefaultFont => null;

	/// <summary>Gets a <see cref="T:System.Drawing.Font" /> that is used for icon titles.</summary>
	/// <returns>A <see cref="T:System.Drawing.Font" /> that is used for icon titles.</returns>
	public static Font IconTitleFont => null;
}
