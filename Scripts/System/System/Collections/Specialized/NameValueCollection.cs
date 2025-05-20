using System.Runtime.Serialization;

namespace System.Collections.Specialized;

/// <summary>Represents a collection of associated <see cref="T:System.String" /> keys and <see cref="T:System.String" /> values that can be accessed either with the key or with the index.</summary>
[Serializable]
public class NameValueCollection : NameObjectCollectionBase
{
	private string[] _all;

	private string[] _allKeys;

	/// <summary>Gets or sets the entry with the specified key in the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
	/// <param name="name">The <see cref="T:System.String" /> key of the entry to locate. The key can be <see langword="null" />.</param>
	/// <returns>A <see cref="T:System.String" /> that contains the comma-separated list of values associated with the specified key, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only and the operation attempts to modify the collection.</exception>
	public string this[string name]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the entry at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
	/// <param name="index">The zero-based index of the entry to locate in the collection.</param>
	/// <returns>A <see cref="T:System.String" /> that contains the comma-separated list of values at the specified index of the collection.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the valid range of indexes for the collection.</exception>
	public string this[int index] => null;

	/// <summary>Gets all the keys in the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
	/// <returns>A <see cref="T:System.String" /> array that contains all the keys of the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</returns>
	public virtual string[] AllKeys => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameValueCollection" /> class that is empty, has the default initial capacity and uses the default case-insensitive hash code provider and the default case-insensitive comparer.</summary>
	public NameValueCollection()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameValueCollection" /> class that is empty, has the default initial capacity, and uses the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
	/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object to use to determine whether two keys are equal and to generate hash codes for the keys in the collection.</param>
	public NameValueCollection(IEqualityComparer equalityComparer)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameValueCollection" /> class that is empty, has the specified initial capacity, and uses the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
	/// <param name="capacity">The initial number of entries that the <see cref="T:System.Collections.Specialized.NameValueCollection" /> object can contain.</param>
	/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object to use to determine whether two keys are equal and to generate hash codes for the keys in the collection.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.</exception>
	public NameValueCollection(int capacity, IEqualityComparer equalityComparer)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.NameValueCollection" /> class that is serializable and uses the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the new <see cref="T:System.Collections.Specialized.NameValueCollection" /> instance.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the new <see cref="T:System.Collections.Specialized.NameValueCollection" /> instance.</param>
	protected NameValueCollection(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Resets the cached arrays of the collection to <see langword="null" />.</summary>
	protected void InvalidateCachedArrays()
	{
	}

	private static string GetAsOneString(ArrayList list)
	{
		return null;
	}

	private static string[] GetAsStringArray(ArrayList list)
	{
		return null;
	}

	/// <summary>Adds an entry with the specified name and value to the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
	/// <param name="name">The <see cref="T:System.String" /> key of the entry to add. The key can be <see langword="null" />.</param>
	/// <param name="value">The <see cref="T:System.String" /> value of the entry to add. The value can be <see langword="null" />.</param>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	public virtual void Add(string name, string value)
	{
	}

	/// <summary>Gets the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" /> combined into one comma-separated list.</summary>
	/// <param name="name">The <see cref="T:System.String" /> key of the entry that contains the values to get. The key can be <see langword="null" />.</param>
	/// <returns>A <see cref="T:System.String" /> that contains a comma-separated list of the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, <see langword="null" />.</returns>
	public virtual string Get(string name)
	{
		return null;
	}

	/// <summary>Gets the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
	/// <param name="name">The <see cref="T:System.String" /> key of the entry that contains the values to get. The key can be <see langword="null" />.</param>
	/// <returns>A <see cref="T:System.String" /> array that contains the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, <see langword="null" />.</returns>
	public virtual string[] GetValues(string name)
	{
		return null;
	}

	/// <summary>Sets the value of an entry in the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
	/// <param name="name">The <see cref="T:System.String" /> key of the entry to add the new value to. The key can be <see langword="null" />.</param>
	/// <param name="value">The <see cref="T:System.Object" /> that represents the new value to add to the specified entry. The value can be <see langword="null" />.</param>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	public virtual void Set(string name, string value)
	{
	}

	/// <summary>Removes the entries with the specified key from the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
	/// <param name="name">The <see cref="T:System.String" /> key of the entry to remove. The key can be <see langword="null" />.</param>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	public virtual void Remove(string name)
	{
	}

	/// <summary>Gets the values at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" /> combined into one comma-separated list.</summary>
	/// <param name="index">The zero-based index of the entry that contains the values to get from the collection.</param>
	/// <returns>A <see cref="T:System.String" /> that contains a comma-separated list of the values at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the valid range of indexes for the collection.</exception>
	public virtual string Get(int index)
	{
		return null;
	}

	/// <summary>Gets the values at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
	/// <param name="index">The zero-based index of the entry that contains the values to get from the collection.</param>
	/// <returns>A <see cref="T:System.String" /> array that contains the values at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the valid range of indexes for the collection.</exception>
	public virtual string[] GetValues(int index)
	{
		return null;
	}

	/// <summary>Gets the key at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
	/// <param name="index">The zero-based index of the key to get from the collection.</param>
	/// <returns>A <see cref="T:System.String" /> that contains the key at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the valid range of indexes for the collection.</exception>
	public virtual string GetKey(int index)
	{
		return null;
	}

	internal NameValueCollection(DBNull dummy)
	{
	}
}
