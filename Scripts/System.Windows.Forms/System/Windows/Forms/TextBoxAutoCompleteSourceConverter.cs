using System.ComponentModel;

namespace System.Windows.Forms;

internal class TextBoxAutoCompleteSourceConverter : EnumConverter
{
	public TextBoxAutoCompleteSourceConverter(Type type)
		: base(null)
	{
	}

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		return null;
	}
}
