using System.ComponentModel;
using System.Reflection;

namespace System.Windows.Forms;

[DefaultMember("Item")]
internal class RelatedCurrencyManager : CurrencyManager
{
	private BindingManagerBase parent;

	private PropertyDescriptor prop_desc;

	public RelatedCurrencyManager(BindingManagerBase parent, PropertyDescriptor prop_desc)
		: base(null)
	{
	}

	private void parent_PositionChanged(object sender, EventArgs args)
	{
	}
}
