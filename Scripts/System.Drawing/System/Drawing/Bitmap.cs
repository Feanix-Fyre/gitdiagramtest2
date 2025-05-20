using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Drawing;

/// <summary>Encapsulates a GDI+ bitmap, which consists of the pixel data for a graphics image and its attributes. A <see cref="T:System.Drawing.Bitmap" /> is an object used to work with images defined by pixel data.</summary>
[Serializable]
[Editor("System.Drawing.Design.BitmapEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
[ComVisible(true)]
public sealed class Bitmap : Image
{
	private Bitmap()
	{
	}

	internal Bitmap(IntPtr ptr)
	{
	}

	internal Bitmap(IntPtr ptr, Stream stream)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Bitmap" /> class with the specified size.</summary>
	/// <param name="width">The width, in pixels, of the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="height">The height, in pixels, of the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <exception cref="T:System.Exception">The operation failed.</exception>
	public Bitmap(int width, int height)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Bitmap" /> class with the specified size and with the resolution of the specified <see cref="T:System.Drawing.Graphics" /> object.</summary>
	/// <param name="width">The width, in pixels, of the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="height">The height, in pixels, of the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> object that specifies the resolution for the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="g" /> is <see langword="null" />.</exception>
	public Bitmap(int width, int height, Graphics g)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Bitmap" /> class with the specified size and format.</summary>
	/// <param name="width">The width, in pixels, of the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="height">The height, in pixels, of the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="format">The pixel format for the new <see cref="T:System.Drawing.Bitmap" />. This must specify a value that begins with Format.</param>
	/// <exception cref="T:System.ArgumentException">A <see cref="T:System.Drawing.Imaging.PixelFormat" /> value is specified whose name does not start with Format. For example, specifying <see cref="F:System.Drawing.Imaging.PixelFormat.Gdi" /> will cause an <see cref="T:System.ArgumentException" />, but <see cref="F:System.Drawing.Imaging.PixelFormat.Format48bppRgb" /> will not.</exception>
	public Bitmap(int width, int height, PixelFormat format)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Bitmap" /> class from the specified existing image.</summary>
	/// <param name="original">The <see cref="T:System.Drawing.Image" /> from which to create the new <see cref="T:System.Drawing.Bitmap" />.</param>
	public Bitmap(Image original)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Bitmap" /> class from the specified data stream.</summary>
	/// <param name="stream">The data stream used to load the image.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="stream" /> does not contain image data or is <see langword="null" />.  
	/// -or-  
	/// <paramref name="stream" /> contains a PNG image file with a single dimension greater than 65,535 pixels.</exception>
	public Bitmap(Stream stream)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Bitmap" /> class from the specified existing image, scaled to the specified size.</summary>
	/// <param name="original">The <see cref="T:System.Drawing.Image" /> from which to create the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="newSize">The <see cref="T:System.Drawing.Size" /> structure that represent the size of the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <exception cref="T:System.Exception">The operation failed.</exception>
	public Bitmap(Image original, Size newSize)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Bitmap" /> class from the specified data stream.</summary>
	/// <param name="stream">The data stream used to load the image.</param>
	/// <param name="useIcm">
	///   <see langword="true" /> to use color correction for this <see cref="T:System.Drawing.Bitmap" />; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="stream" /> does not contain image data or is <see langword="null" />.  
	/// -or-  
	/// <paramref name="stream" /> contains a PNG image file with a single dimension greater than 65,535 pixels.</exception>
	public Bitmap(Stream stream, bool useIcm)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Bitmap" /> class from the specified existing image, scaled to the specified size.</summary>
	/// <param name="original">The <see cref="T:System.Drawing.Image" /> from which to create the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="width">The width, in pixels, of the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="height">The height, in pixels, of the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <exception cref="T:System.Exception">The operation failed.</exception>
	public Bitmap(Image original, int width, int height)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Bitmap" /> class with the specified size, pixel format, and pixel data.</summary>
	/// <param name="width">The width, in pixels, of the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="height">The height, in pixels, of the new <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="stride">Integer that specifies the byte offset between the beginning of one scan line and the next. This is usually (but not necessarily) the number of bytes in the pixel format (for example, 2 for 16 bits per pixel) multiplied by the width of the bitmap. The value passed to this parameter must be a multiple of four.</param>
	/// <param name="format">The pixel format for the new <see cref="T:System.Drawing.Bitmap" />. This must specify a value that begins with Format.</param>
	/// <param name="scan0">Pointer to an array of bytes that contains the pixel data.</param>
	/// <exception cref="T:System.ArgumentException">A <see cref="T:System.Drawing.Imaging.PixelFormat" /> value is specified whose name does not start with Format. For example, specifying <see cref="F:System.Drawing.Imaging.PixelFormat.Gdi" /> will cause an <see cref="T:System.ArgumentException" />, but <see cref="F:System.Drawing.Imaging.PixelFormat.Format48bppRgb" /> will not.</exception>
	public Bitmap(int width, int height, int stride, PixelFormat format, IntPtr scan0)
	{
	}

	private Bitmap(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Gets the color of the specified pixel in this <see cref="T:System.Drawing.Bitmap" />.</summary>
	/// <param name="x">The x-coordinate of the pixel to retrieve.</param>
	/// <param name="y">The y-coordinate of the pixel to retrieve.</param>
	/// <returns>A <see cref="T:System.Drawing.Color" /> structure that represents the color of the specified pixel.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="x" /> is less than 0, or greater than or equal to <see cref="P:System.Drawing.Image.Width" />.  
	/// -or-  
	/// <paramref name="y" /> is less than 0, or greater than or equal to <see cref="P:System.Drawing.Image.Height" />.</exception>
	/// <exception cref="T:System.Exception">The operation failed.</exception>
	public Color GetPixel(int x, int y)
	{
		return default(Color);
	}

	/// <summary>Sets the color of the specified pixel in this <see cref="T:System.Drawing.Bitmap" />.</summary>
	/// <param name="x">The x-coordinate of the pixel to set.</param>
	/// <param name="y">The y-coordinate of the pixel to set.</param>
	/// <param name="color">A <see cref="T:System.Drawing.Color" /> structure that represents the color to assign to the specified pixel.</param>
	/// <exception cref="T:System.Exception">The operation failed.</exception>
	public void SetPixel(int x, int y, Color color)
	{
	}

	/// <summary>Creates a <see cref="T:System.Drawing.Bitmap" /> from a Windows handle to an icon.</summary>
	/// <param name="hicon">A handle to an icon.</param>
	/// <returns>The <see cref="T:System.Drawing.Bitmap" /> that this method creates.</returns>
	public static Bitmap FromHicon(IntPtr hicon)
	{
		return null;
	}

	/// <summary>Creates a GDI bitmap object from this <see cref="T:System.Drawing.Bitmap" />.</summary>
	/// <returns>A handle to the GDI bitmap object that this method creates.</returns>
	/// <exception cref="T:System.ArgumentException">The height or width of the bitmap is greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	/// <exception cref="T:System.Exception">The operation failed.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IntPtr GetHbitmap()
	{
		return (IntPtr)0;
	}

	/// <summary>Creates a GDI bitmap object from this <see cref="T:System.Drawing.Bitmap" />.</summary>
	/// <param name="background">A <see cref="T:System.Drawing.Color" /> structure that specifies the background color. This parameter is ignored if the bitmap is totally opaque.</param>
	/// <returns>A handle to the GDI bitmap object that this method creates.</returns>
	/// <exception cref="T:System.ArgumentException">The height or width of the bitmap is greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	/// <exception cref="T:System.Exception">The operation failed.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IntPtr GetHbitmap(Color background)
	{
		return (IntPtr)0;
	}

	/// <summary>Locks a <see cref="T:System.Drawing.Bitmap" /> into system memory.</summary>
	/// <param name="rect">A <see cref="T:System.Drawing.Rectangle" /> structure that specifies the portion of the <see cref="T:System.Drawing.Bitmap" /> to lock.</param>
	/// <param name="flags">An <see cref="T:System.Drawing.Imaging.ImageLockMode" /> enumeration that specifies the access level (read/write) for the <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="format">A <see cref="T:System.Drawing.Imaging.PixelFormat" /> enumeration that specifies the data format of this <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <returns>A <see cref="T:System.Drawing.Imaging.BitmapData" /> that contains information about this lock operation.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Drawing.Imaging.PixelFormat" /> is not a specific bits-per-pixel value.  
	///  -or-  
	///  The incorrect <see cref="T:System.Drawing.Imaging.PixelFormat" /> is passed in for a bitmap.</exception>
	/// <exception cref="T:System.Exception">The operation failed.</exception>
	public BitmapData LockBits(Rectangle rect, ImageLockMode flags, PixelFormat format)
	{
		return null;
	}

	/// <summary>Locks a <see cref="T:System.Drawing.Bitmap" /> into system memory</summary>
	/// <param name="rect">A rectangle structure that specifies the portion of the <see cref="T:System.Drawing.Bitmap" /> to lock.</param>
	/// <param name="flags">One of the <see cref="T:System.Drawing.Imaging.ImageLockMode" /> values that specifies the access level (read/write) for the <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="format">One of the <see cref="T:System.Drawing.Imaging.PixelFormat" /> values that specifies the data format of the <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="bitmapData">A <see cref="T:System.Drawing.Imaging.BitmapData" /> that contains information about the lock operation.</param>
	/// <returns>A <see cref="T:System.Drawing.Imaging.BitmapData" /> that contains information about the lock operation.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <see cref="T:System.Drawing.Imaging.PixelFormat" /> value is not a specific bits-per-pixel value.  
	/// -or-  
	/// The incorrect <see cref="T:System.Drawing.Imaging.PixelFormat" /> is passed in for a bitmap.</exception>
	/// <exception cref="T:System.Exception">The operation failed.</exception>
	public BitmapData LockBits(Rectangle rect, ImageLockMode flags, PixelFormat format, BitmapData bitmapData)
	{
		return null;
	}

	/// <summary>Makes the specified color transparent for this <see cref="T:System.Drawing.Bitmap" />.</summary>
	/// <param name="transparentColor">The <see cref="T:System.Drawing.Color" /> structure that represents the color to make transparent.</param>
	/// <exception cref="T:System.InvalidOperationException">The image format of the <see cref="T:System.Drawing.Bitmap" /> is an icon format.</exception>
	/// <exception cref="T:System.Exception">The operation failed.</exception>
	public void MakeTransparent(Color transparentColor)
	{
	}

	/// <summary>Unlocks this <see cref="T:System.Drawing.Bitmap" /> from system memory.</summary>
	/// <param name="bitmapdata">A <see cref="T:System.Drawing.Imaging.BitmapData" /> that specifies information about the lock operation.</param>
	/// <exception cref="T:System.Exception">The operation failed.</exception>
	public void UnlockBits(BitmapData bitmapdata)
	{
	}
}
