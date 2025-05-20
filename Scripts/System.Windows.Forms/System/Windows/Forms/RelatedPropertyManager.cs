using System.ComponentModel;

namespace System.Windows.Forms;

internal class RelatedPropertyManager : PropertyManager
{
	private BindingManagerBase parent;

	public RelatedPropertyManager(BindingManagerBase parent, string property_name)
	{
	}

	private void parent_PositionChanged(object sender, EventArgs args)
	{
	}

	public override PropertyDescriptorCollection GetItemProperties()
	{
		return null;
	}
}
