namespace System.Drawing;

/// <summary>Allows you to specify an icon to represent a control in a container, such as the Microsoft Visual Studio Form Designer.</summary>
[AttributeUsage(AttributeTargets.Class)]
public class ToolboxBitmapAttribute : Attribute
{
	private Image smallImage;

	private Image bigImage;

	/// <summary>A <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> object that has its small image and its large image set to <see langword="null" />.</summary>
	public static readonly ToolboxBitmapAttribute Default;

	private ToolboxBitmapAttribute()
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> object with an image from a specified file.</summary>
	/// <param name="imageFile">The name of a file that contains a 16 by 16 bitmap.</param>
	public ToolboxBitmapAttribute(string imageFile)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> object based on a 16 by 16 bitmap that is embedded as a resource in a specified assembly.</summary>
	/// <param name="t">A <see cref="T:System.Type" /> whose defining assembly is searched for the bitmap resource.</param>
	/// <param name="name">The name of the embedded bitmap resource.</param>
	public ToolboxBitmapAttribute(Type t, string name)
	{
	}

	/// <summary>Indicates whether the specified object is a <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> object and is identical to this <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> object.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to test.</param>
	/// <returns>This method returns <see langword="true" /> if <paramref name="value" /> is both a <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> object and is identical to this <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> object.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Gets a hash code for this <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> object.</summary>
	/// <returns>The hash code for this <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns an <see cref="T:System.Drawing.Image" /> object based on a bitmap resource that is embedded in an assembly.</summary>
	/// <param name="t">This method searches for an embedded bitmap resource in the assembly that defines the type specified by the t parameter. For example, if you pass typeof(ControlA) to the t parameter, then this method searches the assembly that defines ControlA.</param>
	/// <param name="imageName">The name of the embedded bitmap resource.</param>
	/// <param name="large">Specifies whether this method returns a large image (true) or a small image (false). The small image is 16 by 16, and the large image is 32 x 32.</param>
	/// <returns>An <see cref="T:System.Drawing.Image" /> object based on the retrieved bitmap.</returns>
	public static Image GetImageFromResource(Type t, string imageName, bool large)
	{
		return null;
	}
}
