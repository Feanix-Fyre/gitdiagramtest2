using System.Runtime.InteropServices;

namespace System.Drawing.Imaging;

/// <summary>Contains information about how bitmap and metafile colors are manipulated during rendering.</summary>
[StructLayout((LayoutKind)0)]
public sealed class ImageAttributes : ICloneable, IDisposable
{
	internal IntPtr nativeImageAttributes;

	internal void SetNativeImageAttributes(IntPtr handle)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Imaging.ImageAttributes" /> class.</summary>
	public ImageAttributes()
	{
	}

	internal ImageAttributes(IntPtr newNativeImageAttributes)
	{
	}

	/// <summary>Releases all resources used by this <see cref="T:System.Drawing.Imaging.ImageAttributes" /> object.</summary>
	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
	~ImageAttributes()
	{
	}

	/// <summary>Creates an exact copy of this <see cref="T:System.Drawing.Imaging.ImageAttributes" /> object.</summary>
	/// <returns>The <see cref="T:System.Drawing.Imaging.ImageAttributes" /> object this class creates, cast as an object.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Sets the color-adjustment matrix for the default category.</summary>
	/// <param name="newColorMatrix">The color-adjustment matrix.</param>
	public void SetColorMatrix(ColorMatrix newColorMatrix)
	{
	}

	/// <summary>Sets the color-adjustment matrix for a specified category.</summary>
	/// <param name="newColorMatrix">The color-adjustment matrix.</param>
	/// <param name="mode">An element of <see cref="T:System.Drawing.Imaging.ColorMatrixFlag" /> that specifies the type of image and color that will be affected by the color-adjustment matrix.</param>
	/// <param name="type">An element of <see cref="T:System.Drawing.Imaging.ColorAdjustType" /> that specifies the category for which the color-adjustment matrix is set.</param>
	public void SetColorMatrix(ColorMatrix newColorMatrix, ColorMatrixFlag mode, ColorAdjustType type)
	{
	}

	/// <summary>Sets the color key for the default category.</summary>
	/// <param name="colorLow">The low color-key value.</param>
	/// <param name="colorHigh">The high color-key value.</param>
	public void SetColorKey(Color colorLow, Color colorHigh)
	{
	}

	/// <summary>Sets the color key (transparency range) for a specified category.</summary>
	/// <param name="colorLow">The low color-key value.</param>
	/// <param name="colorHigh">The high color-key value.</param>
	/// <param name="type">An element of <see cref="T:System.Drawing.Imaging.ColorAdjustType" /> that specifies the category for which the color key is set.</param>
	public void SetColorKey(Color colorLow, Color colorHigh, ColorAdjustType type)
	{
	}
}
