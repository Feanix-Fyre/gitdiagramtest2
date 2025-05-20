namespace System.Drawing.Imaging;

/// <summary>Provides properties that get the frame dimensions of an image. Not inheritable.</summary>
public sealed class FrameDimension
{
	private static FrameDimension s_time;

	private static FrameDimension s_resolution;

	private static FrameDimension s_page;

	private Guid _guid;

	/// <summary>Gets a globally unique identifier (GUID) that represents this <see cref="T:System.Drawing.Imaging.FrameDimension" /> object.</summary>
	/// <returns>A <see langword="Guid" /> structure that contains a GUID that represents this <see cref="T:System.Drawing.Imaging.FrameDimension" /> object.</returns>
	public Guid Guid => default(Guid);

	/// <summary>Gets the time dimension.</summary>
	/// <returns>The time dimension.</returns>
	public static FrameDimension Time => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Imaging.FrameDimension" /> class using the specified <see langword="Guid" /> structure.</summary>
	/// <param name="guid">A <see langword="Guid" /> structure that contains a GUID for this <see cref="T:System.Drawing.Imaging.FrameDimension" /> object.</param>
	public FrameDimension(Guid guid)
	{
	}

	/// <summary>Returns a value that indicates whether the specified object is a <see cref="T:System.Drawing.Imaging.FrameDimension" /> equivalent to this <see cref="T:System.Drawing.Imaging.FrameDimension" /> object.</summary>
	/// <param name="o">The object to test.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="o" /> is a <see cref="T:System.Drawing.Imaging.FrameDimension" /> equivalent to this <see cref="T:System.Drawing.Imaging.FrameDimension" /> object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object o)
	{
		return false;
	}

	/// <summary>Returns a hash code for this <see cref="T:System.Drawing.Imaging.FrameDimension" /> object.</summary>
	/// <returns>The hash code of this <see cref="T:System.Drawing.Imaging.FrameDimension" /> object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Converts this <see cref="T:System.Drawing.Imaging.FrameDimension" /> object to a human-readable string.</summary>
	/// <returns>A string that represents this <see cref="T:System.Drawing.Imaging.FrameDimension" /> object.</returns>
	public override string ToString()
	{
		return null;
	}
}
