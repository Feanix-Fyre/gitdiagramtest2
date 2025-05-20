using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions.Interpreter;

internal class HybridReferenceDictionary<TKey, TValue> where TKey : class
{
	[CompilerGenerated]
	private sealed class _003CGetEnumeratorWorker_003Ed__7 : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private KeyValuePair<TKey, TValue> _003C_003E2__current;

		public HybridReferenceDictionary<TKey, TValue> _003C_003E4__this;

		private int _003Ci_003E5__2;

		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
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
		public _003CGetEnumeratorWorker_003Ed__7(int _003C_003E1__state)
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

	private KeyValuePair<TKey, TValue>[] _keysAndValues;

	private Dictionary<TKey, TValue> _dict;

	public TValue this[TKey key]
	{
		get
		{
			return default(TValue);
		}
		set
		{
		}
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		value = default(TValue);
		return false;
	}

	public void Remove(TKey key)
	{
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[IteratorStateMachine(typeof(HybridReferenceDictionary<, >._003CGetEnumeratorWorker_003Ed__7))]
	private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker()
	{
		return null;
	}
}
