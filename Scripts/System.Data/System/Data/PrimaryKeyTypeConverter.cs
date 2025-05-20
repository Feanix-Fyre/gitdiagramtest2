using System.ComponentModel;
using System.Globalization;

namespace System.Data;

internal sealed class PrimaryKeyTypeConverter : ReferenceConverter
{
	public PrimaryKeyTypeConverter()
		: base(null)
	{
	}

	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return false;
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		return null;
	}
}
