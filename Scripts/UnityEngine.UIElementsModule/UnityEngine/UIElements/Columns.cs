using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public class Columns : ICollection<Column>, IEnumerable<Column>, IEnumerable
{
	public enum StretchMode
	{
		Grow = 0,
		GrowAndFill = 1
	}

	internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> where T : Columns, new()
	{
	}

	internal class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : Columns
	{
		private readonly UxmlStringAttributeDescription m_PrimaryColumnName;

		private readonly UxmlEnumAttributeDescription<StretchMode> m_StretchMode;

		private readonly UxmlBoolAttributeDescription m_Reorderable;

		private readonly UxmlBoolAttributeDescription m_Resizable;

		private readonly UxmlBoolAttributeDescription m_ResizePreview;

		private readonly UxmlObjectListAttributeDescription<Column> m_Columns;

		public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	private IList<Column> m_Columns;

	private List<Column> m_DisplayColumns;

	private List<Column> m_VisibleColumns;

	private bool m_VisibleColumnsDirty;

	private StretchMode m_StretchMode;

	private bool m_Reorderable;

	private bool m_Resizable;

	private bool m_ResizePreview;

	private string m_PrimaryColumnName;

	public string primaryColumnName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool reorderable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool resizable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool resizePreview
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal IEnumerable<Column> displayList => null;

	internal IEnumerable<Column> visibleList => null;

	public StretchMode stretchMode
	{
		get
		{
			return default(StretchMode);
		}
		set
		{
		}
	}

	public int Count => 0;

	public bool IsReadOnly => false;

	public Column this[int index] => null;

	public Column this[string name] => null;

	internal event Action<ColumnsDataType> changed
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

	internal event Action<Column, int> columnAdded
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

	internal event Action<Column> columnRemoved
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

	internal event Action<Column, ColumnDataType> columnChanged
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

	internal event Action<Column> columnResized
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

	internal event Action<Column, int, int> columnReordered
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

	public bool IsPrimary(Column column)
	{
		return false;
	}

	public IEnumerator<Column> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Add(Column item)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(Column item)
	{
		return false;
	}

	public bool Contains(string name)
	{
		return false;
	}

	public void CopyTo(Column[] array, int arrayIndex)
	{
	}

	public bool Remove(Column column)
	{
		return false;
	}

	private void OnColumnChanged(Column column, ColumnDataType type)
	{
	}

	private void OnColumnResized(Column column)
	{
	}

	public int IndexOf(Column column)
	{
		return 0;
	}

	public void Insert(int index, Column column)
	{
	}

	public void ReorderDisplay(int from, int to)
	{
	}

	private void InitOrderColumns()
	{
	}

	private void DirtyVisibleColumns()
	{
	}

	private void UpdateVisibleColumns()
	{
	}

	private void NotifyChange(ColumnsDataType type)
	{
	}
}
