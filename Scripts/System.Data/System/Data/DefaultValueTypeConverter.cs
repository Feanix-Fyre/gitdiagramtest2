using System.ComponentModel;
using System.Globalization;

namespace System.Data;

internal sealed class DefaultValueTypeConverter : StringConverter
{
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		return null;
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		return null;
	}
}
