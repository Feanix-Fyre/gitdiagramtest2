namespace System.Drawing.Imaging;

/// <summary>Encapsulates a metadata property to be included in an image file. Not inheritable.</summary>
public sealed class PropertyItem
{
	private int _id;

	private int _len;

	private short _type;

	private byte[] _value;

	/// <summary>Gets or sets the ID of the property.</summary>
	/// <returns>The integer that represents the ID of the property.</returns>
	public int Id
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the length (in bytes) of the <see cref="P:System.Drawing.Imaging.PropertyItem.Value" /> property.</summary>
	/// <returns>An integer that represents the length (in bytes) of the <see cref="P:System.Drawing.Imaging.PropertyItem.Value" /> byte array.</returns>
	public int Len
	{
		set
		{
		}
	}

	/// <summary>Gets or sets an integer that defines the type of data contained in the <see cref="P:System.Drawing.Imaging.PropertyItem.Value" /> property.</summary>
	/// <returns>An integer that defines the type of data contained in <see cref="P:System.Drawing.Imaging.PropertyItem.Value" />.</returns>
	public short Type
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the value of the property item.</summary>
	/// <returns>A byte array that represents the value of the property item.</returns>
	public byte[] Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal PropertyItem()
	{
	}
}
