using System.ComponentModel;
using System.Globalization;

namespace System.Windows.Forms;

internal class FlatButtonAppearanceConverter : ExpandableObjectConverter
{
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		return null;
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return false;
	}
}
