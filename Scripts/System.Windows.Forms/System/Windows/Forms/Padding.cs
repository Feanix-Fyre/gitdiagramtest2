using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Represents padding or margin information associated with a user interface (UI) element.</summary>
[Serializable]
[TypeConverter(typeof(PaddingConverter))]
public struct Padding
{
	private int _bottom;

	private int _left;

	private int _right;

	private int _top;

	private bool _all;

	/// <summary>Provides a <see cref="T:System.Windows.Forms.Padding" /> object with no padding.</summary>
	public static readonly Padding Empty;

	/// <summary>Gets or sets the padding value for all the edges.</summary>
	/// <returns>The padding, in pixels, for all edges if the same; otherwise, -1.</returns>
	[RefreshProperties(RefreshProperties.All)]
	public int All => 0;

	/// <summary>Gets or sets the padding value for the bottom edge.</summary>
	/// <returns>The padding, in pixels, for the bottom edge.</returns>
	[RefreshProperties(RefreshProperties.All)]
	public int Bottom
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the combined padding for the right and left edges.</summary>
	/// <returns>Gets the sum, in pixels, of the <see cref="P:System.Windows.Forms.Padding.Left" /> and <see cref="P:System.Windows.Forms.Padding.Right" /> padding values.</returns>
	[Browsable(false)]
	public int Horizontal => 0;

	/// <summary>Gets or sets the padding value for the left edge.</summary>
	/// <returns>The padding, in pixels, for the left edge.</returns>
	[RefreshProperties(RefreshProperties.All)]
	public int Left
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the padding value for the right edge.</summary>
	/// <returns>The padding, in pixels, for the right edge.</returns>
	[RefreshProperties(RefreshProperties.All)]
	public int Right
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the padding value for the top edge.</summary>
	/// <returns>The padding, in pixels, for the top edge.</returns>
	[RefreshProperties(RefreshProperties.All)]
	public int Top
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the combined padding for the top and bottom edges.</summary>
	/// <returns>Gets the sum, in pixels, of the <see cref="P:System.Windows.Forms.Padding.Top" /> and <see cref="P:System.Windows.Forms.Padding.Bottom" /> padding values.</returns>
	[Browsable(false)]
	public int Vertical => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Padding" /> class using the supplied padding size for all edges.</summary>
	/// <param name="all">The number of pixels to be used for padding for all edges.</param>
	public Padding(int all)
	{
		_bottom = 0;
		_left = 0;
		_right = 0;
		_top = 0;
		_all = false;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Padding" /> class using a separate padding size for each edge.</summary>
	/// <param name="left">The padding size, in pixels, for the left edge.</param>
	/// <param name="top">The padding size, in pixels, for the top edge.</param>
	/// <param name="right">The padding size, in pixels, for the right edge.</param>
	/// <param name="bottom">The padding size, in pixels, for the bottom edge.</param>
	public Padding(int left, int top, int right, int bottom)
	{
		_bottom = 0;
		_left = 0;
		_right = 0;
		_top = 0;
		_all = false;
	}

	/// <summary>Determines whether the value of the specified object is equivalent to the current <see cref="T:System.Windows.Forms.Padding" />.</summary>
	/// <param name="other">The object to compare to the current <see cref="T:System.Windows.Forms.Padding" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.Padding" /> objects are equivalent; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object other)
	{
		return false;
	}

	/// <summary>Generates a hash code for the current <see cref="T:System.Windows.Forms.Padding" />.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Windows.Forms.Padding" />.</summary>
	/// <returns>A <see cref="T:System.String" /> that represents the current <see cref="T:System.Windows.Forms.Padding" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Tests whether two specified <see cref="T:System.Windows.Forms.Padding" /> objects are not equivalent.</summary>
	/// <param name="p1">A <see cref="T:System.Windows.Forms.Padding" /> to test.</param>
	/// <param name="p2">A <see cref="T:System.Windows.Forms.Padding" /> to test.</param>
	/// <returns>
	///   <see langword="true" /> if the two <see cref="T:System.Windows.Forms.Padding" /> objects are different; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(Padding p1, Padding p2)
	{
		return false;
	}
}
