using System.Runtime.InteropServices;

namespace System.Drawing.Imaging;

/// <summary>Specifies the attributes of a bitmap image. The <see cref="T:System.Drawing.Imaging.BitmapData" /> class is used by the <see cref="Overload:System.Drawing.Bitmap.LockBits" /> and <see cref="M:System.Drawing.Bitmap.UnlockBits(System.Drawing.Imaging.BitmapData)" /> methods of the <see cref="T:System.Drawing.Bitmap" /> class. Not inheritable.</summary>
[StructLayout((LayoutKind)0)]
public sealed class BitmapData
{
	private int width;

	private int height;

	private int stride;

	private PixelFormat pixel_format;

	private IntPtr scan0;

	private int reserved;

	private IntPtr palette;

	private int property_count;

	private IntPtr property;

	private float dpi_horz;

	private float dpi_vert;

	private int image_flags;

	private int left;

	private int top;

	private int x;

	private int y;

	private int transparent;

	/// <summary>Gets or sets the pixel height of the <see cref="T:System.Drawing.Bitmap" /> object. Also sometimes referred to as the number of scan lines.</summary>
	/// <returns>The pixel height of the <see cref="T:System.Drawing.Bitmap" /> object.</returns>
	public int Height => 0;

	/// <summary>Gets or sets the pixel width of the <see cref="T:System.Drawing.Bitmap" /> object. This can also be thought of as the number of pixels in one scan line.</summary>
	/// <returns>The pixel width of the <see cref="T:System.Drawing.Bitmap" /> object.</returns>
	public int Width => 0;

	/// <summary>Gets or sets the address of the first pixel data in the bitmap. This can also be thought of as the first scan line in the bitmap.</summary>
	/// <returns>The address of the first pixel data in the bitmap.</returns>
	public IntPtr Scan0 => (IntPtr)0;

	/// <summary>Gets or sets the stride width (also called scan width) of the <see cref="T:System.Drawing.Bitmap" /> object.</summary>
	/// <returns>The stride width, in bytes, of the <see cref="T:System.Drawing.Bitmap" /> object.</returns>
	public int Stride => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Imaging.BitmapData" /> class.</summary>
	public BitmapData()
	{
	}
}
