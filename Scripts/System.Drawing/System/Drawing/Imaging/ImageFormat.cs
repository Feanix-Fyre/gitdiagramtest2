using System.ComponentModel;

namespace System.Drawing.Imaging;

/// <summary>Specifies the file format of the image. Not inheritable.</summary>
[TypeConverter(typeof(ImageFormatConverter))]
public sealed class ImageFormat
{
	private Guid guid;

	private string name;

	private static object locker;

	private static ImageFormat BmpImageFormat;

	private static ImageFormat EmfImageFormat;

	private static ImageFormat ExifImageFormat;

	private static ImageFormat GifImageFormat;

	private static ImageFormat TiffImageFormat;

	private static ImageFormat PngImageFormat;

	private static ImageFormat MemoryBmpImageFormat;

	private static ImageFormat IconImageFormat;

	private static ImageFormat JpegImageFormat;

	private static ImageFormat WmfImageFormat;

	/// <summary>Gets a <see cref="T:System.Guid" /> structure that represents this <see cref="T:System.Drawing.Imaging.ImageFormat" /> object.</summary>
	/// <returns>A <see cref="T:System.Guid" /> structure that represents this <see cref="T:System.Drawing.Imaging.ImageFormat" /> object.</returns>
	public Guid Guid => default(Guid);

	/// <summary>Gets the bitmap (BMP) image format.</summary>
	/// <returns>An <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that indicates the bitmap image format.</returns>
	public static ImageFormat Bmp => null;

	/// <summary>Gets the enhanced metafile (EMF) image format.</summary>
	/// <returns>An <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that indicates the enhanced metafile image format.</returns>
	public static ImageFormat Emf => null;

	/// <summary>Gets the Exchangeable Image File (Exif) format.</summary>
	/// <returns>An <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that indicates the Exif format.</returns>
	public static ImageFormat Exif => null;

	/// <summary>Gets the Graphics Interchange Format (GIF) image format.</summary>
	/// <returns>An <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that indicates the GIF image format.</returns>
	public static ImageFormat Gif => null;

	/// <summary>Gets the Windows icon image format.</summary>
	/// <returns>An <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that indicates the Windows icon image format.</returns>
	public static ImageFormat Icon => null;

	/// <summary>Gets the Joint Photographic Experts Group (JPEG) image format.</summary>
	/// <returns>An <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that indicates the JPEG image format.</returns>
	public static ImageFormat Jpeg => null;

	/// <summary>Gets the format of a bitmap in memory.</summary>
	/// <returns>An <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that indicates the format of a bitmap in memory.</returns>
	public static ImageFormat MemoryBmp => null;

	/// <summary>Gets the W3C Portable Network Graphics (PNG) image format.</summary>
	/// <returns>An <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that indicates the PNG image format.</returns>
	public static ImageFormat Png => null;

	/// <summary>Gets the Tagged Image File Format (TIFF) image format.</summary>
	/// <returns>An <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that indicates the TIFF image format.</returns>
	public static ImageFormat Tiff => null;

	/// <summary>Gets the Windows metafile (WMF) image format.</summary>
	/// <returns>An <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that indicates the Windows metafile image format.</returns>
	public static ImageFormat Wmf => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Imaging.ImageFormat" /> class by using the specified <see cref="T:System.Guid" /> structure.</summary>
	/// <param name="guid">The <see cref="T:System.Guid" /> structure that specifies a particular image format.</param>
	public ImageFormat(Guid guid)
	{
	}

	private ImageFormat(string name, string guid)
	{
	}

	/// <summary>Returns a value that indicates whether the specified object is an <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that is equivalent to this <see cref="T:System.Drawing.Imaging.ImageFormat" /> object.</summary>
	/// <param name="o">The object to test.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="o" /> is an <see cref="T:System.Drawing.Imaging.ImageFormat" /> object that is equivalent to this <see cref="T:System.Drawing.Imaging.ImageFormat" /> object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object o)
	{
		return false;
	}

	/// <summary>Returns a hash code value that represents this object.</summary>
	/// <returns>A hash code that represents this object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Converts this <see cref="T:System.Drawing.Imaging.ImageFormat" /> object to a human-readable string.</summary>
	/// <returns>A string that represents this <see cref="T:System.Drawing.Imaging.ImageFormat" /> object.</returns>
	public override string ToString()
	{
		return null;
	}
}
