using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public abstract class CollectionViewController : IDisposable
{
	private BaseVerticalCollectionView m_View;

	private IList m_ItemsSource;

	public virtual IList itemsSource
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected BaseVerticalCollectionView view => null;

	public event Action itemsSourceChanged
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

	public event Action<int, int> itemIndexChanged
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

	protected void SetItemsSourceWithoutNotify(IList source)
	{
	}

	public void SetView(BaseVerticalCollectionView collectionView)
	{
	}

	protected virtual void PrepareView()
	{
	}

	public virtual void Dispose()
	{
	}

	public virtual int GetItemsCount()
	{
		return 0;
	}

	internal virtual int GetItemsMinCount()
	{
		return 0;
	}

	public virtual int GetIndexForId(int id)
	{
		return 0;
	}

	public virtual int GetIdForIndex(int index)
	{
		return 0;
	}

	public virtual object GetItemForIndex(int index)
	{
		return null;
	}

	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem)
	{
	}

	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
	{
	}

	internal virtual void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index)
	{
	}

	internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem)
	{
	}

	protected abstract VisualElement MakeItem();

	protected abstract void BindItem(VisualElement element, int index);

	protected abstract void UnbindItem(VisualElement element, int index);

	protected abstract void DestroyItem(VisualElement element);

	protected void RaiseItemsSourceChanged()
	{
	}

	protected void RaiseItemIndexChanged(int srcIndex, int dstIndex)
	{
	}
}
