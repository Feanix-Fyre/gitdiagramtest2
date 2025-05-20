namespace UnityEngine.UIElements;

internal class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem
{
	public override VisualElement rootElement => null;

	public override void Init(VisualElement item)
	{
	}

	public void Init(VisualElement container, Columns columns)
	{
	}
}
