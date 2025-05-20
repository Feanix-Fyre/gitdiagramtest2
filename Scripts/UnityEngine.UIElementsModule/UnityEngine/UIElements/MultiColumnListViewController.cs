using System.Collections.Generic;
using UnityEngine.UIElements.Internal;

namespace UnityEngine.UIElements;

public class MultiColumnListViewController : BaseListViewController
{
	private MultiColumnController m_ColumnController;

	public MultiColumnController columnController => null;

	internal MultiColumnCollectionHeader header => null;

	public MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
	{
	}

	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem)
	{
	}

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

	protected override void PrepareView()
	{
	}

	public override void Dispose()
	{
	}

	private void UpdateReorderClassList()
	{
	}
}
