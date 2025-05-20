namespace UnityEngine.UIElements;

internal class ReusableMultiColumnListViewItem : ReusableListViewItem
{
	public override VisualElement rootElement => null;

	public override void Init(VisualElement item)
	{
	}

	public void Init(VisualElement container, Columns columns, bool usesAnimatedDrag)
	{
	}
}
