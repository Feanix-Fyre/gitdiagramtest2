using System.Collections.Generic;

namespace UnityEngine.UIElements;

public readonly struct TreeViewItemData<T>
{
	private readonly T m_Data;

	private readonly IList<TreeViewItemData<T>> m_Children;

	public int id { get; }

	public T data => default(T);

	public IEnumerable<TreeViewItemData<T>> children => null;

	public bool hasChildren => false;

	internal void InsertChild(TreeViewItemData<T> child, int index)
	{
	}

	internal void RemoveChild(int childId)
	{
	}

	internal int GetChildIndex(int itemId)
	{
		return 0;
	}

	internal void ReplaceChild(TreeViewItemData<T> newChild)
	{
	}
}
