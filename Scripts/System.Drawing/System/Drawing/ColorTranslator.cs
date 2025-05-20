namespace System.Drawing;

/// <summary>Translates colors to and from GDI+ <see cref="T:System.Drawing.Color" /> structures. This class cannot be inherited.</summary>
public sealed class ColorTranslator
{
	/// <summary>Translates the specified <see cref="T:System.Drawing.Color" /> structure to a Windows color.</summary>
	/// <param name="c">The <see cref="T:System.Drawing.Color" /> structure to translate.</param>
	/// <returns>The Windows color value.</returns>
	public static int ToWin32(Color c)
	{
		return 0;
	}
}
