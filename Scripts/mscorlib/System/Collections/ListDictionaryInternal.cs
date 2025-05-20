namespace System.Collections;

[Serializable]
internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable
{
	private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private ListDictionaryInternal list;

		private DictionaryNode current;

		private int version;

		private bool start;

		public object Current => null;

		public DictionaryEntry Entry => default(DictionaryEntry);

		public object Key => null;

		public object Value => null;

		public NodeEnumerator(ListDictionaryInternal list)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	private class NodeKeyValueCollection : ICollection, IEnumerable
	{
		private class NodeKeyValueEnumerator : IEnumerator
		{
			private ListDictionaryInternal list;

			private DictionaryNode current;

			private int version;

			private bool isKeys;

			private bool start;

			public object Current => null;

			public NodeKeyValueEnumerator(ListDictionaryInternal list, bool isKeys)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		private ListDictionaryInternal list;

		private bool isKeys;

		int ICollection.Count => 0;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public NodeKeyValueCollection(ListDictionaryInternal list, bool isKeys)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Serializable]
	private class DictionaryNode
	{
		public object key;

		public object value;

		public DictionaryNode next;
	}

	private DictionaryNode head;

	private int version;

	private int count;

	[NonSerialized]
	private object _syncRoot;

	public object this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Count => 0;

	public ICollection Keys => null;

	public bool IsReadOnly => false;

	public bool IsFixedSize => false;

	public bool IsSynchronized => false;

	public object SyncRoot => null;

	public ICollection Values => null;

	public void Add(object key, object value)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(object key)
	{
		return false;
	}

	public void CopyTo(Array array, int index)
	{
	}

	public IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Remove(object key)
	{
	}
}
