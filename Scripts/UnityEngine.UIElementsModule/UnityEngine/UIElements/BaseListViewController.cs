using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public abstract class BaseListViewController : CollectionViewController
{
	protected BaseListView baseListView => null;

	public event Action itemsSourceSizeChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<IEnumerable<int>> itemsAdded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<IEnumerable<int>> itemsRemoved
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem)
	{
	}

	internal void PostInitRegistration(ReusableListViewItem listItem)
	{
	}

	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
	{
	}

	public virtual bool NeedsDragHandle(int index)
	{
		return false;
	}

	public virtual void AddItems(int itemCount)
	{
	}

	public virtual void Move(int index, int newIndex)
	{
	}

	public virtual void RemoveItem(int index)
	{
	}

	public virtual void RemoveItems(List<int> indices)
	{
	}

	internal virtual void RemoveItems(int itemCount)
	{
	}

	public virtual void ClearItems()
	{
	}

	protected void RaiseOnSizeChanged()
	{
	}

	protected void RaiseItemsAdded(IEnumerable<int> indices)
	{
	}

	protected void RaiseItemsRemoved(IEnumerable<int> indices)
	{
	}

	private static Array AddToArray(Array source, int itemCount)
	{
		return null;
	}

	private static Array RemoveFromArray(Array source, List<int> indicesToRemove)
	{
		return null;
	}

	private void Swap(int lhs, int rhs)
	{
	}

	private void EnsureItemSourceCanBeResized()
	{
	}
}
