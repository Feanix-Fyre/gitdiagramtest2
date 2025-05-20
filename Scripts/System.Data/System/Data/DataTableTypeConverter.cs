using System.ComponentModel;

namespace System.Data;

internal sealed class DataTableTypeConverter : ReferenceConverter
{
	public DataTableTypeConverter()
		: base(null)
	{
	}

	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return false;
	}
}
