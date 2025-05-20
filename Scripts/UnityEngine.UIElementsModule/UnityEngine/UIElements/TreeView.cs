using System;

namespace UnityEngine.UIElements;

public class TreeView : BaseTreeView
{
	public new class UxmlFactory : UxmlFactory<TreeView, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseTreeView.UxmlTraits
	{
	}

	private Func<VisualElement> m_MakeItem;

	private Action<VisualElement, int> m_BindItem;

	public Func<VisualElement> makeItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<VisualElement, int> bindItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	public TreeView()
	{
	}

	public TreeView(Func<VisualElement> makeItem, Action<VisualElement, int> bindItem)
	{
	}
}
