using System.Globalization;

namespace System.ComponentModel;

/// <summary>Provides a type converter to convert 16-bit signed integer objects to and from other representations.</summary>
public class Int16Converter : BaseNumberConverter
{
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

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Int16Converter" /> class.</summary>
	public Int16Converter()
	{
	}
}
