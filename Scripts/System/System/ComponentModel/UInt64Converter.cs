using System.Globalization;

namespace System.ComponentModel;

/// <summary>Provides a type converter to convert 64-bit unsigned integer objects to and from other representations.</summary>
public class UInt64Converter : BaseNumberConverter
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

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.UInt64Converter" /> class.</summary>
	public UInt64Converter()
	{
	}
}
