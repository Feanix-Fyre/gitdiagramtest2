using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Drawing;

/// <summary>Represents a Windows icon, which is a small bitmap image that is used to represent an object. Icons can be thought of as transparent bitmaps, although their size is determined by the system.</summary>
[Serializable]
[Editor("System.Drawing.Design.IconEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
[TypeConverter(typeof(IconConverter))]
public sealed class Icon : MarshalByRefObject, ISerializable, ICloneable, IDisposable
{
	internal struct IconDirEntry
	{
		internal byte width;

		internal byte height;

		internal byte colorCount;

		internal byte reserved;

		internal ushort planes;

		internal ushort bitCount;

		internal uint bytesInRes;

		internal uint imageOffset;

		internal bool ignore;
	}

	internal struct IconDir
	{
		internal ushort idReserved;

		internal ushort idType;

		internal ushort idCount;

		internal IconDirEntry[] idEntries;
	}

	internal struct BitmapInfoHeader
	{
		internal uint biSize;

		internal int biWidth;

		internal int biHeight;

		internal ushort biPlanes;

		internal ushort biBitCount;

		internal uint biCompression;

		internal uint biSizeImage;

		internal int biXPelsPerMeter;

		internal int biYPelsPerMeter;

		internal uint biClrUsed;

		internal uint biClrImportant;
	}

	[StructLayout((LayoutKind)0)]
	internal abstract class ImageData
	{
	}

	[StructLayout((LayoutKind)0)]
	internal class IconImage : ImageData
	{
		internal BitmapInfoHeader iconHeader;

		internal uint[] iconColors;

		internal byte[] iconXOR;

		internal byte[] iconAND;
	}

	[StructLayout((LayoutKind)0)]
	internal class IconDump : ImageData
	{
		internal byte[] data;
	}

	private Size iconSize;

	private IntPtr handle;

	private IconDir iconDir;

	private ushort id;

	private ImageData[] imageData;

	private bool undisposable;

	private bool disposed;

	private Bitmap bitmap;

	/// <summary>Gets the Windows handle for this <see cref="T:System.Drawing.Icon" />. This is not a copy of the handle; do not free it.</summary>
	/// <returns>The Windows handle for the icon.</returns>
	[Browsable(false)]
	public IntPtr Handle => (IntPtr)0;

	/// <summary>Gets the height of this <see cref="T:System.Drawing.Icon" />.</summary>
	/// <returns>The height of this <see cref="T:System.Drawing.Icon" />.</returns>
	[Browsable(false)]
	public int Height => 0;

	/// <summary>Gets the size of this <see cref="T:System.Drawing.Icon" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> structure that specifies the width and height of this <see cref="T:System.Drawing.Icon" />.</returns>
	public Size Size => default(Size);

	/// <summary>Gets the width of this <see cref="T:System.Drawing.Icon" />.</summary>
	/// <returns>The width of this <see cref="T:System.Drawing.Icon" />.</returns>
	[Browsable(false)]
	public int Width => 0;

	private Icon()
	{
	}

	private Icon(IntPtr handle)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class and attempts to find a version of the icon that matches the requested size.</summary>
	/// <param name="original">The <see cref="T:System.Drawing.Icon" /> from which to load the newly sized icon.</param>
	/// <param name="size">A <see cref="T:System.Drawing.Size" /> structure that specifies the height and width of the new <see cref="T:System.Drawing.Icon" />.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="original" /> parameter is <see langword="null" />.</exception>
	public Icon(Icon original, Size size)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class from the specified data stream.</summary>
	/// <param name="stream">The data stream from which to load the <see cref="T:System.Drawing.Icon" />.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="stream" /> parameter is <see langword="null" />.</exception>
	public Icon(Stream stream)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Icon" /> class from the specified data stream and with the specified width and height.</summary>
	/// <param name="stream">The data stream from which to load the icon.</param>
	/// <param name="width">The width, in pixels, of the icon.</param>
	/// <param name="height">The height, in pixels, of the icon.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="stream" /> parameter is <see langword="null" />.</exception>
	public Icon(Stream stream, int width, int height)
	{
	}

	private Icon(SerializationInfo info, StreamingContext context)
	{
	}

	internal Icon(string resourceName, bool undisposable)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data that is required to serialize the target object.</summary>
	/// <param name="si">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data.</param>
	/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
	{
	}

	/// <summary>Releases all resources used by this <see cref="T:System.Drawing.Icon" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Clones the <see cref="T:System.Drawing.Icon" />, creating a duplicate image.</summary>
	/// <returns>An object that can be cast to an <see cref="T:System.Drawing.Icon" />.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Creates a GDI+ <see cref="T:System.Drawing.Icon" /> from the specified Windows handle to an icon (<see langword="HICON" />).</summary>
	/// <param name="handle">A Windows handle to an icon.</param>
	/// <returns>The <see cref="T:System.Drawing.Icon" /> this method creates.</returns>
	public static Icon FromHandle(IntPtr handle)
	{
		return null;
	}

	private void SaveIconImage(BinaryWriter writer, IconImage ii)
	{
	}

	private void SaveIconDump(BinaryWriter writer, IconDump id)
	{
	}

	private void SaveIconDirEntry(BinaryWriter writer, IconDirEntry ide, uint offset)
	{
	}

	private void SaveAll(BinaryWriter writer)
	{
	}

	private void SaveBestSingleIcon(BinaryWriter writer, int width, int height)
	{
	}

	private void SaveBitmapAsIcon(BinaryWriter writer)
	{
	}

	private void Save(Stream outputStream, int width, int height)
	{
	}

	/// <summary>Saves this <see cref="T:System.Drawing.Icon" /> to the specified output <see cref="T:System.IO.Stream" />.</summary>
	/// <param name="outputStream">The <see cref="T:System.IO.Stream" /> to save to.</param>
	public void Save(Stream outputStream)
	{
	}

	internal Bitmap BuildBitmapOnWin32()
	{
		return null;
	}

	internal Bitmap GetInternalBitmap()
	{
		return null;
	}

	/// <summary>Converts this <see cref="T:System.Drawing.Icon" /> to a GDI+ <see cref="T:System.Drawing.Bitmap" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Bitmap" /> that represents the converted <see cref="T:System.Drawing.Icon" />.</returns>
	public Bitmap ToBitmap()
	{
		return null;
	}

	/// <summary>Gets a human-readable string that describes the <see cref="T:System.Drawing.Icon" />.</summary>
	/// <returns>A string that describes the <see cref="T:System.Drawing.Icon" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
	~Icon()
	{
	}

	private void InitFromStreamWithSize(Stream stream, int width, int height)
	{
	}
}
