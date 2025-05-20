namespace System.Drawing.Imaging;

/// <summary>Defines an array of colors that make up a color palette. The colors are 32-bit ARGB colors. Not inheritable.</summary>
public sealed class ColorPalette
{
	private int _flags;

	private Color[] _entries;

	/// <summary>Gets an array of <see cref="T:System.Drawing.Color" /> structures.</summary>
	/// <returns>The array of <see cref="T:System.Drawing.Color" /> structure that make up this <see cref="T:System.Drawing.Imaging.ColorPalette" />.</returns>
	public Color[] Entries => null;

	internal ColorPalette()
	{
	}

	internal void ConvertFromMemory(IntPtr memory)
	{
	}

	internal IntPtr ConvertToMemory()
	{
		return (IntPtr)0;
	}
}
