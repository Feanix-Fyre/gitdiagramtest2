using System.ComponentModel;

namespace System.Windows.Forms;

internal class ListViewGroupConverter : TypeConverter
{
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return false;
	}

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		return null;
	}
}
