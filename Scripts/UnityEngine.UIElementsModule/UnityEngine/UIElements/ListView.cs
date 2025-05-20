using System;

namespace UnityEngine.UIElements;

public class ListView : BaseListView
{
	public new class UxmlFactory : UxmlFactory<ListView, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseListView.UxmlTraits
	{
	}

	private Func<VisualElement> m_MakeItem;

	private Action<VisualElement, int> m_BindItem;

	public Func<VisualElement> makeItem => null;

	public Action<VisualElement, int> bindItem => null;

	public Action<VisualElement, int> unbindItem { get; }

	public Action<VisualElement> destroyItem { get; }

	internal override bool HasValidDataAndBindings()
	{
		return false;
	}

	protected override CollectionViewController CreateViewController()
	{
		return null;
	}
}
