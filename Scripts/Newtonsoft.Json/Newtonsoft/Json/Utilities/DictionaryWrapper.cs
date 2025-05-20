using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities;

internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection where TKey : notnull where TValue : notnull
{
	private readonly struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator, IEnumerator where TEnumeratorKey : notnull where TEnumeratorValue : notnull
	{
		private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

		public DictionaryEntry Entry => default(DictionaryEntry);

		public object Key => null;

		public object? Value => null;

		public object Current => null;

		public DictionaryEnumerator(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
		{
			_e = null;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	private readonly IDictionary? _dictionary;

	private readonly IDictionary<TKey, TValue>? _genericDictionary;

	private readonly IReadOnlyDictionary<TKey, TValue>? _readOnlyDictionary;

	private object? _syncRoot;

	internal IDictionary<TKey, TValue> GenericDictionary => null;

	public ICollection<TKey> Keys => null;

	public ICollection<TValue> Values => null;

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

	public int Count => 0;

	public bool IsReadOnly => false;

	object? IDictionary.this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	bool IDictionary.IsFixedSize => false;

	ICollection IDictionary.Keys => null;

	ICollection IDictionary.Values => null;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => null;

	public object UnderlyingDictionary => null;

	public DictionaryWrapper(IDictionary dictionary)
	{
	}

	public DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
	{
	}

	public DictionaryWrapper(IReadOnlyDictionary<TKey, TValue> dictionary)
	{
	}

	public void Add(TKey key, TValue value)
	{
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	public bool TryGetValue(TKey key, out TValue? value)
	{
		value = default(TValue);
		return false;
	}

	public void Add(KeyValuePair<TKey, TValue> item)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		return false;
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
	}

	public bool Remove(KeyValuePair<TKey, TValue> item)
	{
		return false;
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	void IDictionary.Add(object key, object? value)
	{
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return null;
	}

	bool IDictionary.Contains(object key)
	{
		return false;
	}

	public void Remove(object key)
	{
	}

	void ICollection.CopyTo(Array array, int index)
	{
	}
}
