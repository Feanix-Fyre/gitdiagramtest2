using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

internal sealed class TreeDataController<T>
{
	[CompilerGenerated]
	private sealed class _003CGetAllItemIds_003Ed__13 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<int> rootIds;

		public IEnumerable<int> _003C_003E3__rootIds;

		public TreeDataController<T> _003C_003E4__this;

		private IEnumerator<int> _003CcurrentIterator_003E5__1;

		private bool _003ChasNext_003E5__2;

		private int _003CcurrentItemId_003E5__3;

		int IEnumerator<int>.Current
		{
			[DebuggerHidden]
			get
			{
				return 0;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGetAllItemIds_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetItemIds_003Ed__9 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<TreeViewItemData<T>> items;

		public IEnumerable<TreeViewItemData<T>> _003C_003E3__items;

		private IEnumerator<TreeViewItemData<T>> _003C_003Es__1;

		private TreeViewItemData<T> _003Citem_003E5__2;

		int IEnumerator<int>.Current
		{
			[DebuggerHidden]
			get
			{
				return 0;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGetItemIds_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private TreeData<T> m_TreeData;

	private Stack<IEnumerator<int>> m_IteratorStack;

	public void SetRootItems(IList<TreeViewItemData<T>> rootItems)
	{
	}

	public T GetDataForId(int id)
	{
		return default(T);
	}

	public int GetParentId(int id)
	{
		return 0;
	}

	public bool HasChildren(int id)
	{
		return false;
	}

	[IteratorStateMachine(typeof(TreeDataController<>._003CGetItemIds_003Ed__9))]
	private static IEnumerable<int> GetItemIds(IEnumerable<TreeViewItemData<T>> items)
	{
		return null;
	}

	public IEnumerable<int> GetChildrenIds(int id)
	{
		return null;
	}

	public void Move(int id, int newParentId, int childIndex = -1)
	{
	}

	public bool IsChildOf(int childId, int id)
	{
		return false;
	}

	[IteratorStateMachine(typeof(TreeDataController<>._003CGetAllItemIds_003Ed__13))]
	public IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null)
	{
		return null;
	}
}
