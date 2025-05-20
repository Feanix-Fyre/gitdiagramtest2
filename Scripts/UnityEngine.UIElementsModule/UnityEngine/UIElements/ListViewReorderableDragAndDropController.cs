namespace UnityEngine.UIElements;

internal class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	protected readonly BaseListView m_ListView;

	public ListViewReorderableDragAndDropController(BaseListView view)
		: base(null)
	{
	}

	public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
	{
		return default(DragVisualMode);
	}

	public override void OnDrop(IListDragAndDropArgs args)
	{
	}
}
