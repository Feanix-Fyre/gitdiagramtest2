using System.ComponentModel;

namespace System.Windows.Forms;

internal class ImageListConverter : ComponentConverter
{
	public ImageListConverter()
		: base(null)
	{
	}

	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return false;
	}
}
