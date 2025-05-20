using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq;

/// <summary>Represents a collection of keys each mapped to one or more values.</summary>
/// <typeparam name="TKey">The type of the keys in the <see cref="T:System.Linq.Lookup`2" />.</typeparam>
/// <typeparam name="TElement">The type of the elements of each <see cref="T:System.Collections.Generic.IEnumerable`1" /> value in the <see cref="T:System.Linq.Lookup`2" />.</typeparam>
[DefaultMember("Item")]
public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	internal class Grouping : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement>
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__7 : IEnumerator<TElement>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private TElement _003C_003E2__current;

			public Grouping _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CGetEnumerator_003Ed__7(int _003C_003E1__state)
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

		internal TKey key;

		internal int hashCode;

		internal TElement[] elements;

		internal int count;

		internal Grouping hashNext;

		internal Grouping next;

		public TKey Key => default(TKey);

		int ICollection<TElement>.Count => 0;

		bool ICollection<TElement>.IsReadOnly => false;

		TElement IList<TElement>.this[int index]
		{
			get
			{
				return default(TElement);
			}
			set
			{
			}
		}

		internal void Add(TElement element)
		{
		}

		[IteratorStateMachine(typeof(Lookup<, >.Grouping._003CGetEnumerator_003Ed__7))]
		public IEnumerator<TElement> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void ICollection<TElement>.Add(TElement item)
		{
		}

		void ICollection<TElement>.Clear()
		{
		}

		bool ICollection<TElement>.Contains(TElement item)
		{
			return false;
		}

		void ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex)
		{
		}

		bool ICollection<TElement>.Remove(TElement item)
		{
			return false;
		}

		int IList<TElement>.IndexOf(TElement item)
		{
			return 0;
		}

		void IList<TElement>.Insert(int index, TElement item)
		{
		}

		void IList<TElement>.RemoveAt(int index)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__12 : IEnumerator<IGrouping<TKey, TElement>>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private IGrouping<TKey, TElement> _003C_003E2__current;

		public Lookup<TKey, TElement> _003C_003E4__this;

		private Grouping _003Cg_003E5__2;

		IGrouping<TKey, TElement> IEnumerator<IGrouping<TKey, TElement>>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
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
		public _003CGetEnumerator_003Ed__12(int _003C_003E1__state)
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

	private IEqualityComparer<TKey> comparer;

	private Grouping[] groupings;

	private Grouping lastGrouping;

	private int count;

	internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
		return null;
	}

	private Lookup(IEqualityComparer<TKey> comparer)
	{
	}

	/// <summary>Returns a generic enumerator that iterates through the <see cref="T:System.Linq.Lookup`2" />.</summary>
	/// <returns>An enumerator for the <see cref="T:System.Linq.Lookup`2" />.</returns>
	[IteratorStateMachine(typeof(Lookup<, >._003CGetEnumerator_003Ed__12))]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Linq.Lookup`2" />. This class cannot be inherited.</summary>
	/// <returns>An enumerator for the <see cref="T:System.Linq.Lookup`2" />.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	internal int InternalGetHashCode(TKey key)
	{
		return 0;
	}

	internal Grouping GetGrouping(TKey key, bool create)
	{
		return null;
	}

	private void Resize()
	{
	}
}
