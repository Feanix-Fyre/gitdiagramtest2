using System.ComponentModel;
using System.Globalization;

namespace System.Windows.Forms;

internal class ListViewSubItemConverter : ExpandableObjectConverter
{
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return false;
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		return null;
	}
}
