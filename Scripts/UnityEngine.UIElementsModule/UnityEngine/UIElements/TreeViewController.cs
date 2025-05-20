namespace UnityEngine.UIElements;

public abstract class TreeViewController : BaseTreeViewController
{
	protected TreeView treeView => null;

	protected override VisualElement MakeItem()
	{
		return null;
	}

	protected override void BindItem(VisualElement element, int index)
	{
	}

	protected override void UnbindItem(VisualElement element, int index)
	{
	}

	protected override void DestroyItem(VisualElement element)
	{
	}
}
