using System.Globalization;

namespace System.ComponentModel;

/// <summary>Provides a type converter to convert single-precision, floating point number objects to and from various other representations.</summary>
public class SingleConverter : BaseNumberConverter
{
	internal override bool AllowHex => false;

	internal override Type TargetType => null;

	internal override object FromString(string value, int radix)
	{
		return null;
	}

	internal override object FromString(string value, NumberFormatInfo formatInfo)
	{
		return null;
	}

	internal override string ToString(object value, NumberFormatInfo formatInfo)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.SingleConverter" /> class.</summary>
	public SingleConverter()
	{
	}
}
