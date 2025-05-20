namespace UnityEngine.UIElements;

internal class ReusableListViewItem : ReusableCollectionItem
{
	private VisualElement m_Container;

	private VisualElement m_DragHandle;

	private VisualElement m_ItemContainer;

	public override VisualElement rootElement => null;

	public void Init(VisualElement item, bool usesAnimatedDragger)
	{
	}

	protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger)
	{
	}

	public void UpdateDragHandle(bool needsDragHandle)
	{
	}

	public override void PreAttachElement()
	{
	}

	public override void DetachElement()
	{
	}

	public override void SetDragGhost(bool dragGhost)
	{
	}
}
