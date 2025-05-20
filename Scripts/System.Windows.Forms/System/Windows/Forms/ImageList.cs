using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;

namespace System.Windows.Forms;

/// <summary>Provides methods to manage a collection of <see cref="T:System.Drawing.Image" /> objects. This class cannot be inherited.</summary>
[Designer("System.Windows.Forms.Design.ImageListDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItemFilter("System.Windows.Forms")]
[DesignerSerializer("System.Windows.Forms.Design.ImageListCodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[TypeConverter(typeof(ImageListConverter))]
[DefaultProperty("Images")]
public sealed class ImageList : Component
{
	/// <summary>Encapsulates the collection of <see cref="T:System.Drawing.Image" /> objects in an <see cref="T:System.Windows.Forms.ImageList" />.</summary>
	[Editor("System.Windows.Forms.Design.ImageCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public sealed class ImageCollection : ICollection, IEnumerable, IList
	{
		private static class IndexedColorDepths
		{
			internal static readonly ColorPalette Palette4Bit;

			internal static readonly ColorPalette Palette8Bit;

			private static readonly int[] squares;

			static IndexedColorDepths()
			{
			}

			internal static int GetNearestColor(Color[] palette, int color)
			{
				return 0;
			}
		}

		[Flags]
		private enum ItemFlags
		{
			None = 0,
			UseTransparentColor = 1,
			ImageStrip = 2
		}

		private sealed class ImageListItem
		{
			internal readonly object Image;

			internal readonly ItemFlags Flags;

			internal readonly Color TransparentColor;

			internal readonly int ImageCount;

			internal ImageListItem(Image value)
			{
			}

			internal ImageListItem(Image value, Color transparentColor)
			{
			}
		}

		private ColorDepth colorDepth;

		private Size imageSize;

		private Color transparentColor;

		private ArrayList list;

		private ArrayList keys;

		private int count;

		private bool handleCreated;

		private int lastKeyIndex;

		private readonly ImageList owner;

		private EventHandler Changed;

		/// <summary>Gets or sets an image in an existing <see cref="T:System.Windows.Forms.ImageList.ImageCollection" />.</summary>
		/// <param name="index">The zero-based index of the image to get or set.</param>
		/// <returns>The image in the list specified by the index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The index is less than 0 or greater than or equal to <see cref="P:System.Windows.Forms.ImageList.ImageCollection.Count" />.</exception>
		/// <exception cref="T:System.Exception">The attempt to replace the image failed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The image to be assigned is <see langword="null" /> or not a bitmap.</exception>
		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Windows.Forms.ImageList.ImageCollection" /> has a fixed size.</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>The object used to synchronize the <see cref="T:System.Windows.Forms.ImageList.ImageCollection" />.</returns>
		object ICollection.SyncRoot => null;

		internal ColorDepth ColorDepth
		{
			set
			{
			}
		}

		internal Size ImageSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		internal Color TransparentColor
		{
			set
			{
			}
		}

		/// <summary>Gets the number of images currently in the list.</summary>
		/// <returns>The number of images in the list. The default is 0.</returns>
		[Browsable(false)]
		public int Count => 0;

		/// <summary>Gets a value indicating whether the list is read-only.</summary>
		/// <returns>Always <see langword="false" />.</returns>
		public bool IsReadOnly => false;

		/// <summary>Gets or sets an <see cref="T:System.Drawing.Image" /> at the specified index within the collection.</summary>
		/// <param name="index">The index of the image to get or set.</param>
		/// <returns>The image in the list specified by <paramref name="index" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The index is less than 0 or greater than or equal to <see cref="P:System.Windows.Forms.ImageList.ImageCollection.Count" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="image" /> is not a <see cref="T:System.Drawing.Bitmap" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The image to be assigned is <see langword="null" /> or not a <see cref="T:System.Drawing.Bitmap" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The image cannot be added to the list.</exception>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Image this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets an <see cref="T:System.Drawing.Image" /> with the specified key from the collection.</summary>
		/// <param name="key">The name of the image to retrieve from the collection.</param>
		/// <returns>The <see cref="T:System.Drawing.Image" /> with the specified key.</returns>
		public Image this[string key] => null;

		internal ImageCollection(ImageList owner)
		{
		}

		/// <summary>Adds the specified image to the <see cref="T:System.Windows.Forms.ImageList" />.</summary>
		/// <param name="value">The image to add to the list.</param>
		/// <returns>The index of the newly added image, or -1 if the image could not be added.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is not a <see cref="T:System.Drawing.Bitmap" />.</exception>
		int IList.Add(object value)
		{
			return 0;
		}

		/// <summary>Implements the <see cref="M:System.Collections.IList.Contains(System.Object)" /> method. Throws a <see cref="T:System.NotSupportedException" /> in all cases.</summary>
		/// <param name="image">The image to locate in the <see cref="T:System.Windows.Forms.ImageList.ImageCollection" />.</param>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		bool IList.Contains(object image)
		{
			return false;
		}

		/// <summary>Implements the <see cref="M:System.Collections.IList.IndexOf(System.Object)" /> method. Throws a <see cref="T:System.NotSupportedException" /> in all cases.</summary>
		/// <param name="image">The image to find in the list.</param>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		int IList.IndexOf(object image)
		{
			return 0;
		}

		/// <summary>Implements the <see cref="M:System.Collections.IList.Insert(System.Int32,System.Object)" /> method. Throws a <see cref="T:System.NotSupportedException" /> in all cases.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The object to insert into the collection.</param>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		void IList.Insert(int index, object value)
		{
		}

		/// <summary>Implements the <see cref="M:System.Collections.IList.Remove(System.Object)" />. Throws a <see cref="T:System.NotSupportedException" /> in all cases.</summary>
		/// <param name="image">The object to add to the <see cref="T:System.Windows.Forms.ImageList.ImageCollection" />.</param>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		void IList.Remove(object image)
		{
		}

		/// <summary>Copies the items in this collection to a compatible one-dimensional array, starting at the specified index of the target array.</summary>
		/// <param name="dest">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from the collection. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in the <see cref="T:System.Array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="dest" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="dest" /> is multidimensional.  
		/// -or-  
		/// The number of elements in the <see cref="T:System.Windows.Forms.ComboBox.ObjectCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination array.</exception>
		/// <exception cref="T:System.InvalidCastException">The type of the <see cref="T:System.Windows.Forms.ComboBox.ObjectCollection" /> cannot be cast automatically to the type of the destination array.</exception>
		void ICollection.CopyTo(Array dest, int index)
		{
		}

		private static bool CompareKeys(string key1, string key2)
		{
			return false;
		}

		private int AddItem(string key, ImageListItem item)
		{
			return 0;
		}

		private int AddItemInternal(ImageListItem item)
		{
			return 0;
		}

		private void CreateHandle()
		{
		}

		private Image CreateImage(Image value, Color transparentColor)
		{
			return null;
		}

		private void RecreateHandle()
		{
		}

		private void ReduceColorDepth(Bitmap bitmap)
		{
		}

		internal void DestroyHandle()
		{
		}

		internal Image GetImage(int index)
		{
			return null;
		}

		/// <summary>Adds the specified image to the <see cref="T:System.Windows.Forms.ImageList" />.</summary>
		/// <param name="value">A <see cref="T:System.Drawing.Bitmap" /> of the image to add to the list.</param>
		/// <exception cref="T:System.ArgumentNullException">The image being added is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The image being added is not a <see cref="T:System.Drawing.Bitmap" />.</exception>
		public void Add(Image value)
		{
		}

		/// <summary>Adds the specified image to the <see cref="T:System.Windows.Forms.ImageList" />, using the specified color to generate the mask.</summary>
		/// <param name="value">A <see cref="T:System.Drawing.Bitmap" /> of the image to add to the list.</param>
		/// <param name="transparentColor">The <see cref="T:System.Drawing.Color" /> to mask this image.</param>
		/// <returns>The index of the newly added image, or -1 if the image cannot be added.</returns>
		/// <exception cref="T:System.ArgumentNullException">The image being added is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The image being added is not a <see cref="T:System.Drawing.Bitmap" />.</exception>
		public int Add(Image value, Color transparentColor)
		{
			return 0;
		}

		/// <summary>Adds an image with the specified key to the end of the collection.</summary>
		/// <param name="key">The name of the image.</param>
		/// <param name="image">The <see cref="T:System.Drawing.Image" /> to add to the collection.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="image" /> is <see langword="null" />.</exception>
		public void Add(string key, Image image)
		{
		}

		/// <summary>Removes all the images and masks from the <see cref="T:System.Windows.Forms.ImageList" />.</summary>
		public void Clear()
		{
		}

		/// <summary>Not supported. The <see cref="M:System.Collections.IList.Contains(System.Object)" /> method indicates whether a specified object is contained in the list.</summary>
		/// <param name="image">The <see cref="T:System.Drawing.Image" /> to find in the list.</param>
		/// <returns>
		///   <see langword="true" /> if the image is found in the list; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Contains(Image image)
		{
			return false;
		}

		/// <summary>Returns an enumerator that can be used to iterate through the item collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the item collection.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Not supported. The <see cref="M:System.Collections.IList.IndexOf(System.Object)" /> method returns the index of a specified object in the list.</summary>
		/// <param name="image">The <see cref="T:System.Drawing.Image" /> to find in the list.</param>
		/// <returns>The index of the image in the list.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int IndexOf(Image image)
		{
			return 0;
		}

		/// <summary>Determines the index of the first occurrence of an image with the specified key in the collection.</summary>
		/// <param name="key">The key of the image to retrieve the index for.</param>
		/// <returns>The zero-based index of the first occurrence of an image with the specified key in the collection, if found; otherwise, -1.</returns>
		public int IndexOfKey(string key)
		{
			return 0;
		}

		/// <summary>Not supported. The <see cref="M:System.Collections.IList.Remove(System.Object)" /> method removes a specified object from the list.</summary>
		/// <param name="image">The <see cref="T:System.Drawing.Image" /> to remove from the list.</param>
		/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Remove(Image image)
		{
		}

		/// <summary>Removes an image from the list.</summary>
		/// <param name="index">The index of the image to remove.</param>
		/// <exception cref="T:System.InvalidOperationException">The image cannot be removed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The index value was less than 0.  
		///  -or-  
		///  The index value is greater than or equal to the <see cref="P:System.Windows.Forms.ImageList.ImageCollection.Count" /> of images.</exception>
		public void RemoveAt(int index)
		{
		}
	}

	private static readonly Size DefaultImageSize;

	private static readonly Color DefaultTransparentColor;

	private readonly ImageCollection images;

	private static object RecreateHandleEvent;

	/// <summary>Gets the color depth of the image list.</summary>
	/// <returns>The number of available colors for the image. In the .NET Framework version 1.0, the default is <see cref="F:System.Windows.Forms.ColorDepth.Depth4Bit" />. In the .NET Framework version 1.1 or later, the default is <see cref="F:System.Windows.Forms.ColorDepth.Depth8Bit" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The color depth is not a valid <see cref="T:System.Windows.Forms.ColorDepth" /> enumeration value.</exception>
	public ColorDepth ColorDepth
	{
		set
		{
		}
	}

	/// <summary>Gets the <see cref="T:System.Windows.Forms.ImageList.ImageCollection" /> for this image list.</summary>
	/// <returns>The collection of images.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MergableProperty(false)]
	[DefaultValue(null)]
	public ImageCollection Images => null;

	/// <summary>Gets or sets the size of the images in the image list.</summary>
	/// <returns>The <see cref="T:System.Drawing.Size" /> that defines the height and width, in pixels, of the images in the list. The default size is 16 by 16. The maximum size is 256 by 256.</returns>
	/// <exception cref="T:System.ArgumentException">The value assigned is equal to <see cref="P:System.Drawing.Size.IsEmpty" />.  
	///  -or-  
	///  The value of the height or width is less than or equal to 0.  
	///  -or-  
	///  The value of the height or width is greater than 256.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The new size has a dimension less than 0 or greater than 256.</exception>
	[Localizable(true)]
	public Size ImageSize
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the color to treat as transparent.</summary>
	/// <returns>One of the <see cref="T:System.Drawing.Color" /> values. The default is <see langword="Transparent" />.</returns>
	public Color TransparentColor
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ImageList" /> class with default values for <see cref="P:System.Windows.Forms.ImageList.ColorDepth" />, <see cref="P:System.Windows.Forms.ImageList.ImageSize" />, and <see cref="P:System.Windows.Forms.ImageList.TransparentColor" />.</summary>
	public ImageList()
	{
	}

	private void OnRecreateHandle()
	{
	}

	/// <summary>Draws the image indicated by the specified index on the specified <see cref="T:System.Drawing.Graphics" /> at the given location.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="pt">The location defined by a <see cref="T:System.Drawing.Point" /> at which to draw the image.</param>
	/// <param name="index">The index of the image in the <see cref="T:System.Windows.Forms.ImageList" /> to draw.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The index is less than 0.  
	///  -or-  
	///  The index is greater than or equal to the count of images in the image list.</exception>
	public void Draw(Graphics g, Point pt, int index)
	{
	}

	/// <summary>Draws the image indicated by the given index on the specified <see cref="T:System.Drawing.Graphics" /> at the specified location.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="x">The horizontal position at which to draw the image.</param>
	/// <param name="y">The vertical position at which to draw the image.</param>
	/// <param name="index">The index of the image in the <see cref="T:System.Windows.Forms.ImageList" /> to draw.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The index is less than 0.  
	///  -or-  
	///  The index is greater than or equal to the count of images in the image list.</exception>
	public void Draw(Graphics g, int x, int y, int index)
	{
	}

	/// <summary>Draws the image indicated by the given index on the specified <see cref="T:System.Drawing.Graphics" /> using the specified location and size.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="x">The horizontal position at which to draw the image.</param>
	/// <param name="y">The vertical position at which to draw the image.</param>
	/// <param name="width">The width, in pixels, of the destination image.</param>
	/// <param name="height">The height, in pixels, of the destination image.</param>
	/// <param name="index">The index of the image in the <see cref="T:System.Windows.Forms.ImageList" /> to draw.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The index is less than 0.  
	///  -or-  
	///  The index is greater than or equal to the count of images in the image list.</exception>
	public void Draw(Graphics g, int x, int y, int width, int height, int index)
	{
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Windows.Forms.ImageList" />.</summary>
	/// <returns>A string that represents the current <see cref="T:System.Windows.Forms.ImageList" />.</returns>
	public override string ToString()
	{
		return null;
	}

	protected override void Dispose(bool disposing)
	{
	}
}
