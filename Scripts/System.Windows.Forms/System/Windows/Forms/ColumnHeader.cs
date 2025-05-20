using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Displays a single column header in a <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
[ToolboxItem(false)]
[DesignTimeVisible(false)]
[TypeConverter(typeof(ColumnHeaderConverter))]
[DefaultProperty("Text")]
public class ColumnHeader : Component, ICloneable
{
	private StringFormat format;

	private string text;

	private HorizontalAlignment text_alignment;

	private int width;

	private int image_index;

	private string image_key;

	private string name;

	private int display_index;

	private Rectangle column_rect;

	private bool pressed;

	private ListView owner;

	private static object UIATextChangedEvent;

	internal bool Pressed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal int X
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int Y
	{
		set
		{
		}
	}

	internal int Wd => 0;

	internal int Ht => 0;

	internal Rectangle Rect
	{
		get
		{
			return default(Rectangle);
		}
		set
		{
		}
	}

	internal StringFormat Format => null;

	internal int InternalDisplayIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the index of the image displayed in the <see cref="T:System.Windows.Forms.ColumnHeader" />.</summary>
	/// <returns>The index of the image displayed in the <see cref="T:System.Windows.Forms.ColumnHeader" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <see cref="P:System.Windows.Forms.ColumnHeader.ImageIndex" /> is less than -1.</exception>
	[RefreshProperties(RefreshProperties.Repaint)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultValue(-1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[TypeConverter(typeof(ImageIndexConverter))]
	public int ImageIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the key of the image displayed in the column.</summary>
	/// <returns>The key of the image displayed in the column.</returns>
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(null)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[TypeConverter(typeof(ImageKeyConverter))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string ImageKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the location with the <see cref="T:System.Windows.Forms.ListView" /> control's <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" /> of this column.</summary>
	/// <returns>The zero-based index of the column header within the <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" /> of the <see cref="T:System.Windows.Forms.ListView" /> control it is contained in.</returns>
	[Browsable(false)]
	public int Index => 0;

	/// <summary>Gets or sets the text displayed in the column header.</summary>
	/// <returns>The text displayed in the column header.</returns>
	[Localizable(true)]
	public string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the horizontal alignment of the text displayed in the <see cref="T:System.Windows.Forms.ColumnHeader" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.HorizontalAlignment" /> values. The default is <see cref="F:System.Windows.Forms.HorizontalAlignment.Left" />.</returns>
	[Localizable(true)]
	[DefaultValue(HorizontalAlignment.Left)]
	public HorizontalAlignment TextAlign
	{
		get
		{
			return default(HorizontalAlignment);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the width of the column.</summary>
	/// <returns>The width of the column, in pixels.</returns>
	[Localizable(true)]
	[DefaultValue(60)]
	public int Width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ColumnHeader" /> class.</summary>
	public ColumnHeader()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ColumnHeader" /> class with the image specified.</summary>
	/// <param name="imageIndex">The index of the image to display in the <see cref="T:System.Windows.Forms.ColumnHeader" />.</param>
	public ColumnHeader(int imageIndex)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ColumnHeader" /> class with the image specified.</summary>
	/// <param name="imageKey">The key of the image to display in the <see cref="T:System.Windows.Forms.ColumnHeader" />.</param>
	public ColumnHeader(string imageKey)
	{
	}

	internal void CalcColumnHeader()
	{
	}

	internal void SetListView(ListView list_view)
	{
	}

	/// <summary>Creates an identical copy of the current <see cref="T:System.Windows.Forms.ColumnHeader" /> that is not attached to any list view control.</summary>
	/// <returns>An object representing a copy of this <see cref="T:System.Windows.Forms.ColumnHeader" /> object.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Returns a <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any. This method should not be overridden.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any, or <see langword="null" /> if the <see cref="T:System.ComponentModel.Component" /> is unnamed.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Disposes of the resources (other than memory) used by the <see cref="T:System.Windows.Forms.ColumnHeader" />.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	private void OnUIATextChanged()
	{
	}
}
