namespace System.Drawing;

/// <summary>Describes the interior of a graphics shape composed of rectangles and paths. This class cannot be inherited.</summary>
public sealed class Region : MarshalByRefObject, IDisposable
{
	private IntPtr nativeRegion;

	internal IntPtr NativeObject => (IntPtr)0;

	/// <summary>Initializes a new <see cref="T:System.Drawing.Region" />.</summary>
	public Region()
	{
	}

	internal Region(IntPtr native)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Region" /> from the specified <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="rect">A <see cref="T:System.Drawing.Rectangle" /> structure that defines the interior of the new <see cref="T:System.Drawing.Region" />.</param>
	public Region(Rectangle rect)
	{
	}

	/// <summary>Updates this <see cref="T:System.Drawing.Region" /> to the union of itself and the specified <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="rect">The <see cref="T:System.Drawing.Rectangle" /> structure to unite with this <see cref="T:System.Drawing.Region" />.</param>
	public void Union(Rectangle rect)
	{
	}

	/// <summary>Updates this <see cref="T:System.Drawing.Region" /> to the intersection of itself with the specified <see cref="T:System.Drawing.Region" />.</summary>
	/// <param name="region">The <see cref="T:System.Drawing.Region" /> to intersect with this <see cref="T:System.Drawing.Region" />.</param>
	public void Intersect(Region region)
	{
	}

	/// <summary>Updates this <see cref="T:System.Drawing.Region" /> to contain only the portion of its interior that does not intersect with the specified <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="rect">The <see cref="T:System.Drawing.Rectangle" /> structure to exclude from this <see cref="T:System.Drawing.Region" />.</param>
	public void Exclude(Rectangle rect)
	{
	}

	/// <summary>Gets a <see cref="T:System.Drawing.RectangleF" /> structure that represents a rectangle that bounds this <see cref="T:System.Drawing.Region" /> on the drawing surface of a <see cref="T:System.Drawing.Graphics" /> object.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> on which this <see cref="T:System.Drawing.Region" /> is drawn.</param>
	/// <returns>A <see cref="T:System.Drawing.RectangleF" /> structure that represents the bounding rectangle for this <see cref="T:System.Drawing.Region" /> on the specified drawing surface.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="g" /> is <see langword="null" />.</exception>
	public RectangleF GetBounds(Graphics g)
	{
		return default(RectangleF);
	}

	/// <summary>Tests whether this <see cref="T:System.Drawing.Region" /> has an infinite interior on the specified drawing surface.</summary>
	/// <param name="g">A <see cref="T:System.Drawing.Graphics" /> that represents a drawing surface.</param>
	/// <returns>
	///   <see langword="true" /> if the interior of this <see cref="T:System.Drawing.Region" /> is infinite when the transformation associated with <paramref name="g" /> is applied; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="g" /> is <see langword="null" />.</exception>
	public bool IsInfinite(Graphics g)
	{
		return false;
	}

	/// <summary>Initializes this <see cref="T:System.Drawing.Region" /> to an empty interior.</summary>
	public void MakeEmpty()
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Region" /> from a handle to the specified existing GDI region.</summary>
	/// <param name="hrgn">A handle to an existing <see cref="T:System.Drawing.Region" />.</param>
	/// <returns>The new <see cref="T:System.Drawing.Region" />.</returns>
	public static Region FromHrgn(IntPtr hrgn)
	{
		return null;
	}

	/// <summary>Returns a Windows handle to this <see cref="T:System.Drawing.Region" /> in the specified graphics context.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> on which this <see cref="T:System.Drawing.Region" /> is drawn.</param>
	/// <returns>A Windows handle to this <see cref="T:System.Drawing.Region" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="g" /> is <see langword="null" />.</exception>
	public IntPtr GetHrgn(Graphics g)
	{
		return (IntPtr)0;
	}

	/// <summary>Releases all resources used by this <see cref="T:System.Drawing.Region" />.</summary>
	public void Dispose()
	{
	}

	private void DisposeHandle()
	{
	}

	/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
	~Region()
	{
	}
}
