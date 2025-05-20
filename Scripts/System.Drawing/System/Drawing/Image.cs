using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Drawing;

/// <summary>An abstract base class that provides functionality for the <see cref="T:System.Drawing.Bitmap" /> and <see cref="T:System.Drawing.Imaging.Metafile" /> descended classes.</summary>
[Serializable]
[ComVisible(true)]
[Editor("System.Drawing.Design.ImageEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
[TypeConverter(typeof(ImageConverter))]
[ImmutableObject(true)]
public abstract class Image : MarshalByRefObject, IDisposable, ICloneable, ISerializable
{
	internal IntPtr nativeObject;

	internal Stream stream;

	/// <summary>Gets an array of GUIDs that represent the dimensions of frames within this <see cref="T:System.Drawing.Image" />.</summary>
	/// <returns>An array of GUIDs that specify the dimensions of frames within this <see cref="T:System.Drawing.Image" /> from most significant to least significant.</returns>
	[Browsable(false)]
	public Guid[] FrameDimensionsList => null;

	/// <summary>Gets the height, in pixels, of this <see cref="T:System.Drawing.Image" />.</summary>
	/// <returns>The height, in pixels, of this <see cref="T:System.Drawing.Image" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DefaultValue(false)]
	public int Height => 0;

	/// <summary>Gets or sets the color palette used for this <see cref="T:System.Drawing.Image" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Imaging.ColorPalette" /> that represents the color palette used for this <see cref="T:System.Drawing.Image" />.</returns>
	[Browsable(false)]
	public ColorPalette Palette
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the pixel format for this <see cref="T:System.Drawing.Image" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Imaging.PixelFormat" /> that represents the pixel format for this <see cref="T:System.Drawing.Image" />.</returns>
	public PixelFormat PixelFormat => default(PixelFormat);

	/// <summary>Gets the file format of this <see cref="T:System.Drawing.Image" />.</summary>
	/// <returns>The <see cref="T:System.Drawing.Imaging.ImageFormat" /> that represents the file format of this <see cref="T:System.Drawing.Image" />.</returns>
	public ImageFormat RawFormat => null;

	/// <summary>Gets the width and height, in pixels, of this image.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> structure that represents the width and height, in pixels, of this image.</returns>
	public Size Size => default(Size);

	/// <summary>Gets the width, in pixels, of this <see cref="T:System.Drawing.Image" />.</summary>
	/// <returns>The width, in pixels, of this <see cref="T:System.Drawing.Image" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DefaultValue(false)]
	public int Width => 0;

	internal IntPtr NativeObject => (IntPtr)0;

	internal IntPtr nativeImage => (IntPtr)0;

	internal Image()
	{
	}

	internal Image(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
	/// <param name="si">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data.</param>
	/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
	{
	}

	/// <summary>Creates a <see cref="T:System.Drawing.Bitmap" /> from a handle to a GDI bitmap.</summary>
	/// <param name="hbitmap">The GDI bitmap handle from which to create the <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <returns>The <see cref="T:System.Drawing.Bitmap" /> this method creates.</returns>
	public static Bitmap FromHbitmap(IntPtr hbitmap)
	{
		return null;
	}

	/// <summary>Creates a <see cref="T:System.Drawing.Bitmap" /> from a handle to a GDI bitmap and a handle to a GDI palette.</summary>
	/// <param name="hbitmap">The GDI bitmap handle from which to create the <see cref="T:System.Drawing.Bitmap" />.</param>
	/// <param name="hpalette">A handle to a GDI palette used to define the bitmap colors if the bitmap specified in the <paramref name="hbitmap" /> parameter is not a device-independent bitmap (DIB).</param>
	/// <returns>The <see cref="T:System.Drawing.Bitmap" /> this method creates.</returns>
	public static Bitmap FromHbitmap(IntPtr hbitmap, IntPtr hpalette)
	{
		return null;
	}

	/// <summary>Creates an <see cref="T:System.Drawing.Image" /> from the specified data stream.</summary>
	/// <param name="stream">A <see cref="T:System.IO.Stream" /> that contains the data for this <see cref="T:System.Drawing.Image" />.</param>
	/// <returns>The <see cref="T:System.Drawing.Image" /> this method creates.</returns>
	/// <exception cref="T:System.ArgumentException">The stream does not have a valid image format  
	///  -or-  
	///  <paramref name="stream" /> is <see langword="null" />.</exception>
	public static Image FromStream(Stream stream)
	{
		return null;
	}

	internal static Image LoadFromStream(Stream stream, bool keepAlive)
	{
		return null;
	}

	internal static Image CreateFromHandle(IntPtr handle)
	{
		return null;
	}

	internal static IntPtr InitFromStream(Stream stream)
	{
		return (IntPtr)0;
	}

	/// <summary>Returns the number of frames of the specified dimension.</summary>
	/// <param name="dimension">A <see cref="T:System.Drawing.Imaging.FrameDimension" /> that specifies the identity of the dimension type.</param>
	/// <returns>The number of frames in the specified dimension.</returns>
	public int GetFrameCount(FrameDimension dimension)
	{
		return 0;
	}

	/// <summary>Gets the specified property item from this <see cref="T:System.Drawing.Image" />.</summary>
	/// <param name="propid">The ID of the property item to get.</param>
	/// <returns>The <see cref="T:System.Drawing.Imaging.PropertyItem" /> this method gets.</returns>
	/// <exception cref="T:System.ArgumentException">The image format of this image does not support property items.</exception>
	public PropertyItem GetPropertyItem(int propid)
	{
		return null;
	}

	/// <summary>Rotates, flips, or rotates and flips the <see cref="T:System.Drawing.Image" />.</summary>
	/// <param name="rotateFlipType">A <see cref="T:System.Drawing.RotateFlipType" /> member that specifies the type of rotation and flip to apply to the image.</param>
	public void RotateFlip(RotateFlipType rotateFlipType)
	{
	}

	internal ImageCodecInfo findEncoderForFormat(ImageFormat format)
	{
		return null;
	}

	/// <summary>Saves this image to the specified stream in the specified format.</summary>
	/// <param name="stream">The <see cref="T:System.IO.Stream" /> where the image will be saved.</param>
	/// <param name="format">An <see cref="T:System.Drawing.Imaging.ImageFormat" /> that specifies the format of the saved image.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> or <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The image was saved with the wrong image format</exception>
	public void Save(Stream stream, ImageFormat format)
	{
	}

	/// <summary>Saves this image to the specified stream, with the specified encoder and image encoder parameters.</summary>
	/// <param name="stream">The <see cref="T:System.IO.Stream" /> where the image will be saved.</param>
	/// <param name="encoder">The <see cref="T:System.Drawing.Imaging.ImageCodecInfo" /> for this <see cref="T:System.Drawing.Image" />.</param>
	/// <param name="encoderParams">An <see cref="T:System.Drawing.Imaging.EncoderParameters" /> that specifies parameters used by the image encoder.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stream" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.InteropServices.ExternalException">The image was saved with the wrong image format.</exception>
	public void Save(Stream stream, ImageCodecInfo encoder, EncoderParameters encoderParams)
	{
	}

	/// <summary>Selects the frame specified by the dimension and index.</summary>
	/// <param name="dimension">A <see cref="T:System.Drawing.Imaging.FrameDimension" /> that specifies the identity of the dimension type.</param>
	/// <param name="frameIndex">The index of the active frame.</param>
	/// <returns>Always returns 0.</returns>
	public int SelectActiveFrame(FrameDimension dimension, int frameIndex)
	{
		return 0;
	}

	internal ColorPalette retrieveGDIPalette()
	{
		return null;
	}

	internal void storeGDIPalette(ColorPalette palette)
	{
	}

	/// <summary>Releases all resources used by this <see cref="T:System.Drawing.Image" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
	~Image()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Drawing.Image" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Creates an exact copy of this <see cref="T:System.Drawing.Image" />.</summary>
	/// <returns>The <see cref="T:System.Drawing.Image" /> this method creates, cast as an object.</returns>
	public object Clone()
	{
		return null;
	}

	private object CloneFromStream()
	{
		return null;
	}
}
