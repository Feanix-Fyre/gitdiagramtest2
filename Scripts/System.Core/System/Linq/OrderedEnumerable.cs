using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Linq;

internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__1 : IEnumerator<TElement>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private TElement _003C_003E2__current;

		public OrderedEnumerable<TElement> _003C_003E4__this;

		private Buffer<TElement> _003Cbuffer_003E5__2;

		private int[] _003Cmap_003E5__3;

		private int _003Ci_003E5__4;

		TElement IEnumerator<TElement>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(TElement);
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
		public _003CGetEnumerator_003Ed__1(int _003C_003E1__state)
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
	}

	internal IEnumerable<TElement> source;

	[IteratorStateMachine(typeof(OrderedEnumerable<>._003CGetEnumerator_003Ed__1))]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	IOrderedEnumerable<TElement> IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
	{
		return null;
	}
}
internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement>
{
	internal OrderedEnumerable<TElement> parent;

	internal Func<TElement, TKey> keySelector;

	internal IComparer<TKey> comparer;

	internal bool descending;

	internal OrderedEnumerable(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
	{
	}

	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next)
	{
		return null;
	}
}
