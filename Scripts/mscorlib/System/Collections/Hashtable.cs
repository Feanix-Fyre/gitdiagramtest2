using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;

namespace System.Collections;

/// <summary>Represents a collection of key/value pairs that are organized based on the hash code of the key.</summary>
[Serializable]
[DebuggerTypeProxy(typeof(HashtableDebugView))]
[DebuggerDisplay("Count = {Count}")]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable
{
	private struct bucket
	{
		public object key;

		public object val;

		public int hash_coll;
	}

	[Serializable]
	private class KeyCollection : ICollection, IEnumerable
	{
		private Hashtable _hashtable;

		public virtual bool IsSynchronized => false;

		public virtual object SyncRoot => null;

		public virtual int Count => 0;

		internal KeyCollection(Hashtable hashtable)
		{
		}

		public virtual void CopyTo(Array array, int arrayIndex)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Serializable]
	private class ValueCollection : ICollection, IEnumerable
	{
		private Hashtable _hashtable;

		public virtual bool IsSynchronized => false;

		public virtual object SyncRoot => null;

		public virtual int Count => 0;

		internal ValueCollection(Hashtable hashtable)
		{
		}

		public virtual void CopyTo(Array array, int arrayIndex)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Serializable]
	private class SyncHashtable : Hashtable, IEnumerable
	{
		protected Hashtable _table;

		public override int Count => 0;

		public override bool IsReadOnly => false;

		public override bool IsFixedSize => false;

		public override bool IsSynchronized => false;

		public override object this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override object SyncRoot => null;

		public override ICollection Keys => null;

		public override ICollection Values => null;

		internal SyncHashtable(Hashtable table)
			: base(trash: false)
		{
		}

		internal SyncHashtable(SerializationInfo info, StreamingContext context)
			: base(trash: false)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public override void Add(object key, object value)
		{
		}

		public override void Clear()
		{
		}

		public override bool Contains(object key)
		{
			return false;
		}

		public override bool ContainsKey(object key)
		{
			return false;
		}

		public override void CopyTo(Array array, int arrayIndex)
		{
		}

		public override object Clone()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public override IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		public override void Remove(object key)
		{
		}

		public override void OnDeserialization(object sender)
		{
		}
	}

	[Serializable]
	private class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
	{
		private Hashtable _hashtable;

		private int _bucket;

		private int _version;

		private bool _current;

		private int _getObjectRetType;

		private object _currentKey;

		private object _currentValue;

		public virtual object Key => null;

		public virtual DictionaryEntry Entry => default(DictionaryEntry);

		public virtual object Current => null;

		public virtual object Value => null;

		internal HashtableEnumerator(Hashtable hashtable, int getObjRetType)
		{
		}

		public object Clone()
		{
			return null;
		}

		public virtual bool MoveNext()
		{
			return false;
		}

		public virtual void Reset()
		{
		}
	}

	internal class HashtableDebugView
	{
	}

	internal const int HashPrime = 101;

	private const int InitialSize = 3;

	private const string LoadFactorName = "LoadFactor";

	private const string VersionName = "Version";

	private const string ComparerName = "Comparer";

	private const string HashCodeProviderName = "HashCodeProvider";

	private const string HashSizeName = "HashSize";

	private const string KeysName = "Keys";

	private const string ValuesName = "Values";

	private const string KeyComparerName = "KeyComparer";

	private bucket[] _buckets;

	private int _count;

	private int _occupancy;

	private int _loadsize;

	private float _loadFactor;

	private int _version;

	private bool _isWriterInProgress;

	private ICollection _keys;

	private ICollection _values;

	private IEqualityComparer _keycomparer;

	private object _syncRoot;

	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable;

	private static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable => null;

	/// <summary>Gets or sets the value associated with the specified key.</summary>
	/// <param name="key">The key whose value to get or set.</param>
	/// <returns>The value associated with the specified key. If the specified key is not found, attempting to get it returns <see langword="null" />, and attempting to set it creates a new element using the specified key.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Collections.Hashtable" /> is read-only.  
	///  -or-  
	///  The property is set, <paramref name="key" /> does not exist in the collection, and the <see cref="T:System.Collections.Hashtable" /> has a fixed size.</exception>
	public virtual object this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Hashtable" /> is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.Hashtable" /> is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsReadOnly => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Hashtable" /> has a fixed size.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.Hashtable" /> has a fixed size; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsFixedSize => false;

	/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Hashtable" /> is synchronized (thread safe).</summary>
	/// <returns>
	///   <see langword="true" /> if access to the <see cref="T:System.Collections.Hashtable" /> is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsSynchronized => false;

	/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Hashtable" />.</returns>
	public virtual ICollection Keys => null;

	/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Hashtable" />.</returns>
	public virtual ICollection Values => null;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Hashtable" />.</returns>
	public virtual object SyncRoot => null;

	/// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Hashtable" />.</returns>
	public virtual int Count => 0;

	internal Hashtable(bool trash)
	{
	}

	/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the default initial capacity, load factor, hash code provider, and comparer.</summary>
	public Hashtable()
	{
	}

	/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, and the default load factor, hash code provider, and comparer.</summary>
	/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.</exception>
	public Hashtable(int capacity)
	{
	}

	/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity and load factor, and the default hash code provider and comparer.</summary>
	/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain.</param>
	/// <param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.  
	/// -or-  
	/// <paramref name="loadFactor" /> is less than 0.1.  
	/// -or-  
	/// <paramref name="loadFactor" /> is greater than 1.0.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="capacity" /> is causing an overflow.</exception>
	public Hashtable(int capacity, float loadFactor)
	{
	}

	/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, load factor, and <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
	/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain.</param>
	/// <param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets.</param>
	/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" />.  
	///  -or-  
	///  <see langword="null" /> to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.  
	/// -or-  
	/// <paramref name="loadFactor" /> is less than 0.1.  
	/// -or-  
	/// <paramref name="loadFactor" /> is greater than 1.0.</exception>
	public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer)
	{
	}

	/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the default initial capacity and load factor, and the specified hash code provider and comparer.</summary>
	/// <param name="hcp">The <see cref="T:System.Collections.IHashCodeProvider" /> object that supplies the hash codes for all keys in the <see cref="T:System.Collections.Hashtable" /> object.  
	///  -or-  
	///  <see langword="null" /> to use the default hash code provider, which is each key's implementation of <see cref="M:System.Object.GetHashCode" />.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> object to use to determine whether two keys are equal.  
	///  -or-  
	///  <see langword="null" /> to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />.</param>
	[Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
	public Hashtable(IHashCodeProvider hcp, IComparer comparer)
	{
	}

	/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the default initial capacity and load factor, and the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
	/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" /> object.  
	///  -or-  
	///  <see langword="null" /> to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />.</param>
	public Hashtable(IEqualityComparer equalityComparer)
	{
	}

	/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity and <see cref="T:System.Collections.IEqualityComparer" />, and the default load factor.</summary>
	/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain.</param>
	/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" />.  
	///  -or-  
	///  <see langword="null" /> to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.</exception>
	public Hashtable(int capacity, IEqualityComparer equalityComparer)
	{
	}

	/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, load factor, hash code provider, and comparer.</summary>
	/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain.</param>
	/// <param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets.</param>
	/// <param name="hcp">The <see cref="T:System.Collections.IHashCodeProvider" /> object that supplies the hash codes for all keys in the <see cref="T:System.Collections.Hashtable" />.  
	///  -or-  
	///  <see langword="null" /> to use the default hash code provider, which is each key's implementation of <see cref="M:System.Object.GetHashCode" />.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> object to use to determine whether two keys are equal.  
	///  -or-  
	///  <see langword="null" /> to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.  
	/// -or-  
	/// <paramref name="loadFactor" /> is less than 0.1.  
	/// -or-  
	/// <paramref name="loadFactor" /> is greater than 1.0.</exception>
	[Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
	public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
	{
	}

	/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class that is serializable using the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Hashtable" /> object.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Hashtable" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	protected Hashtable(SerializationInfo info, StreamingContext context)
	{
	}

	private uint InitHash(object key, int hashsize, out uint seed, out uint incr)
	{
		seed = default(uint);
		incr = default(uint);
		return 0u;
	}

	/// <summary>Adds an element with the specified key and value into the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. The value can be <see langword="null" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Hashtable" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Hashtable" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.Hashtable" /> has a fixed size.</exception>
	public virtual void Add(object key, object value)
	{
	}

	/// <summary>Removes all elements from the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Hashtable" /> is read-only.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public virtual void Clear()
	{
	}

	/// <summary>Creates a shallow copy of the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <returns>A shallow copy of the <see cref="T:System.Collections.Hashtable" />.</returns>
	public virtual object Clone()
	{
		return null;
	}

	/// <summary>Determines whether the <see cref="T:System.Collections.Hashtable" /> contains a specific key.</summary>
	/// <param name="key">The key to locate in the <see cref="T:System.Collections.Hashtable" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.Hashtable" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public virtual bool Contains(object key)
	{
		return false;
	}

	/// <summary>Determines whether the <see cref="T:System.Collections.Hashtable" /> contains a specific key.</summary>
	/// <param name="key">The key to locate in the <see cref="T:System.Collections.Hashtable" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.Hashtable" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public virtual bool ContainsKey(object key)
	{
		return false;
	}

	private void CopyKeys(Array array, int arrayIndex)
	{
	}

	private void CopyEntries(Array array, int arrayIndex)
	{
	}

	/// <summary>Copies the <see cref="T:System.Collections.Hashtable" /> elements to a one-dimensional <see cref="T:System.Array" /> instance at the specified index.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.Hashtable" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="arrayIndex" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in the source <see cref="T:System.Collections.Hashtable" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Hashtable" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	public virtual void CopyTo(Array array, int arrayIndex)
	{
	}

	private void CopyValues(Array array, int arrayIndex)
	{
	}

	private void expand()
	{
	}

	private void rehash()
	{
	}

	private void UpdateVersion()
	{
	}

	private void rehash(int newsize)
	{
	}

	/// <summary>Returns an enumerator that iterates through a collection.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> that iterates through the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.Hashtable" />.</returns>
	public virtual IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns the hash code for the specified key.</summary>
	/// <param name="key">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
	/// <returns>The hash code for <paramref name="key" />.</returns>
	/// <exception cref="T:System.NullReferenceException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	protected virtual int GetHash(object key)
	{
		return 0;
	}

	/// <summary>Compares a specific <see cref="T:System.Object" /> with a specific key in the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <param name="item">The <see cref="T:System.Object" /> to compare with <paramref name="key" />.</param>
	/// <param name="key">The key in the <see cref="T:System.Collections.Hashtable" /> to compare with <paramref name="item" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="item" /> and <paramref name="key" /> are equal; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="item" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="key" /> is <see langword="null" />.</exception>
	protected virtual bool KeyEquals(object item, object key)
	{
		return false;
	}

	private void Insert(object key, object nvalue, bool add)
	{
	}

	private void putEntry(bucket[] newBuckets, object key, object nvalue, int hashcode)
	{
	}

	/// <summary>Removes the element with the specified key from the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Hashtable" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.Hashtable" /> has a fixed size.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public virtual void Remove(object key)
	{
	}

	/// <summary>Returns a synchronized (thread-safe) wrapper for the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <param name="table">The <see cref="T:System.Collections.Hashtable" /> to synchronize.</param>
	/// <returns>A synchronized (thread-safe) wrapper for the <see cref="T:System.Collections.Hashtable" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="table" /> is <see langword="null" />.</exception>
	public static Hashtable Synchronized(Hashtable table)
	{
		return null;
	}

	/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.Collections.Hashtable" />.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Hashtable" />.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Hashtable" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The collection was modified.</exception>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
	/// <param name="sender">The source of the deserialization event.</param>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Hashtable" /> is invalid.</exception>
	public virtual void OnDeserialization(object sender)
	{
	}
}
