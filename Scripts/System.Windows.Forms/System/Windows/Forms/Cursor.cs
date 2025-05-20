using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Runtime.Serialization;

namespace System.Windows.Forms;

/// <summary>Represents the image used to paint the mouse pointer.</summary>
[Serializable]
[TypeConverter(typeof(CursorConverter))]
[Editor("System.Drawing.Design.CursorEditor, System.Drawing.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
public sealed class Cursor : IDisposable, ISerializable
{
	private struct CursorDir
	{
		internal ushort idReserved;

		internal ushort idType;

		internal ushort idCount;

		internal CursorEntry[] idEntries;
	}

	private struct CursorEntry
	{
		internal byte width;

		internal byte height;

		internal byte colorCount;

		internal byte reserved;

		internal ushort xHotspot;

		internal ushort yHotspot;

		internal ushort bitCount;

		internal uint sizeInBytes;

		internal uint fileOffset;
	}

	private struct CursorInfoHeader
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

	private struct CursorImage
	{
		internal CursorInfoHeader cursorHeader;

		internal uint[] cursorColors;

		internal byte[] cursorXOR;

		internal byte[] cursorAND;
	}

	private CursorDir cursor_dir;

	private CursorImage[] cursor_data;

	private int id;

	internal IntPtr handle;

	private Size size;

	private Bitmap shape;

	private Bitmap mask;

	private Bitmap cursor;

	internal string name;

	private StdCursor std_cursor;

	/// <summary>Gets or sets the cursor's position.</summary>
	/// <returns>A <see cref="T:System.Drawing.Point" /> that represents the cursor's position in screen coordinates.</returns>
	public static Point Position
	{
		get
		{
			return default(Point);
		}
		set
		{
		}
	}

	/// <summary>Gets the handle of the cursor.</summary>
	/// <returns>An <see cref="T:System.IntPtr" /> that represents the cursor's handle.</returns>
	/// <exception cref="T:System.Exception">The handle value is <see cref="F:System.IntPtr.Zero" />.</exception>
	public IntPtr Handle => (IntPtr)0;

	internal Cursor(StdCursor cursor)
	{
	}

	private Cursor(SerializationInfo info, StreamingContext context)
	{
	}

	private Cursor()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Cursor" /> class from the specified Windows handle.</summary>
	/// <param name="handle">An <see cref="T:System.IntPtr" /> that represents the Windows handle of the cursor to create.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="handle" /> is <see cref="F:System.IntPtr.Zero" />.</exception>
	public Cursor(IntPtr handle)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Cursor" /> class from the specified data stream.</summary>
	/// <param name="stream">The data stream to load the <see cref="T:System.Windows.Forms.Cursor" /> from.</param>
	public Cursor(Stream stream)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Cursor" /> class from the specified resource with the specified resource type.</summary>
	/// <param name="type">The resource <see cref="T:System.Type" />.</param>
	/// <param name="resource">The name of the resource.</param>
	public Cursor(Type type, string resource)
	{
	}

	/// <summary>Serializes the object.</summary>
	/// <param name="si">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> class.</param>
	void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
	{
	}

	private void CreateCursor(Stream stream)
	{
	}

	/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
	~Cursor()
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Windows.Forms.Cursor" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Returns a value indicating whether this cursor is equal to the specified <see cref="T:System.Windows.Forms.Cursor" />.</summary>
	/// <param name="obj">The <see cref="T:System.Windows.Forms.Cursor" /> to compare.</param>
	/// <returns>
	///   <see langword="true" /> if this cursor is equal to the specified <see cref="T:System.Windows.Forms.Cursor" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Retrieves the hash code for the current <see cref="T:System.Windows.Forms.Cursor" />.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Windows.Forms.Cursor" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Retrieves a human readable string representing this <see cref="T:System.Windows.Forms.Cursor" />.</summary>
	/// <returns>A <see cref="T:System.String" /> that represents this <see cref="T:System.Windows.Forms.Cursor" />.</returns>
	public override string ToString()
	{
		return null;
	}

	private void InitFromStream(Stream stream)
	{
	}

	private Bitmap ToBitmap(bool xor, bool transparent)
	{
		return null;
	}

	/// <summary>Returns a value indicating whether two instances of the <see cref="T:System.Windows.Forms.Cursor" /> class are not equal.</summary>
	/// <param name="left">A <see cref="T:System.Windows.Forms.Cursor" /> to compare.</param>
	/// <param name="right">A <see cref="T:System.Windows.Forms.Cursor" /> to compare.</param>
	/// <returns>
	///   <see langword="true" /> if two instances of the <see cref="T:System.Windows.Forms.Cursor" /> class are not equal; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(Cursor left, Cursor right)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether two instances of the <see cref="T:System.Windows.Forms.Cursor" /> class are equal.</summary>
	/// <param name="left">A <see cref="T:System.Windows.Forms.Cursor" /> to compare.</param>
	/// <param name="right">A <see cref="T:System.Windows.Forms.Cursor" /> to compare.</param>
	/// <returns>
	///   <see langword="true" /> if two instances of the <see cref="T:System.Windows.Forms.Cursor" /> class are equal; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(Cursor left, Cursor right)
	{
		return false;
	}
}
