using System.Collections;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable
{
	private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private MessageDictionary _methodDictionary;

		private IDictionaryEnumerator _hashtableEnum;

		private int _posMethod;

		public object Current => null;

		public DictionaryEntry Entry => default(DictionaryEntry);

		public object Key => null;

		public object Value => null;

		public DictionaryEnumerator(MessageDictionary methodDictionary)
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

	private IDictionary _internalProperties;

	protected IMethodMessage _message;

	private string[] _methodKeys;

	private bool _ownProperties;

	internal IDictionary InternalDictionary => null;

	public string[] MethodKeys
	{
		set
		{
		}
	}

	public bool IsFixedSize => false;

	public bool IsReadOnly => false;

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

	public ICollection Keys => null;

	public ICollection Values => null;

	public int Count => 0;

	public bool IsSynchronized => false;

	public object SyncRoot => null;

	public MessageDictionary(IMethodMessage message)
	{
	}

	internal bool HasUserData()
	{
		return false;
	}

	protected virtual IDictionary AllocInternalProperties()
	{
		return null;
	}

	public IDictionary GetInternalProperties()
	{
		return null;
	}

	private bool IsOverridenKey(string key)
	{
		return false;
	}

	protected virtual object GetMethodProperty(string key)
	{
		return null;
	}

	protected virtual void SetMethodProperty(string key, object value)
	{
	}

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

	public void Remove(object key)
	{
	}

	public void CopyTo(Array array, int index)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}
}
