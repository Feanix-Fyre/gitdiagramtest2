namespace System.Collections.Specialized;

/// <summary>Implements a hash table with the key and the value strongly typed to be strings rather than objects.</summary>
[Serializable]
public class StringDictionary : IEnumerable
{
	internal Hashtable contents;

	/// <summary>Gets the number of key/value pairs in the <see cref="T:System.Collections.Specialized.StringDictionary" />.</summary>
	/// <returns>The number of key/value pairs in the <see cref="T:System.Collections.Specialized.StringDictionary" />.  
	///  Retrieving the value of this property is an O(1) operation.</returns>
	public virtual int Count => 0;

	/// <summary>Gets or sets the value associated with the specified key.</summary>
	/// <param name="key">The key whose value to get or set.</param>
	/// <returns>The value associated with the specified key. If the specified key is not found, Get returns <see langword="null" />, and Set creates a new entry with the specified key.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public virtual string this[string key] => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.StringDictionary" /> class.</summary>
	public StringDictionary()
	{
	}

	/// <summary>Adds an entry with the specified key and value into the <see cref="T:System.Collections.Specialized.StringDictionary" />.</summary>
	/// <param name="key">The key of the entry to add.</param>
	/// <param name="value">The value of the entry to add. The value can be <see langword="null" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">An entry with the same key already exists in the <see cref="T:System.Collections.Specialized.StringDictionary" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.StringDictionary" /> is read-only.</exception>
	public virtual void Add(string key, string value)
	{
	}

	/// <summary>Removes all entries from the <see cref="T:System.Collections.Specialized.StringDictionary" />.</summary>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.StringDictionary" /> is read-only.</exception>
	public virtual void Clear()
	{
	}

	/// <summary>Determines if the <see cref="T:System.Collections.Specialized.StringDictionary" /> contains a specific key.</summary>
	/// <param name="key">The key to locate in the <see cref="T:System.Collections.Specialized.StringDictionary" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.Specialized.StringDictionary" /> contains an entry with the specified key; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The key is <see langword="null" />.</exception>
	public virtual bool ContainsKey(string key)
	{
		return false;
	}

	/// <summary>Returns an enumerator that iterates through the string dictionary.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that iterates through the string dictionary.</returns>
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Removes the entry with the specified key from the string dictionary.</summary>
	/// <param name="key">The key of the entry to remove.</param>
	/// <exception cref="T:System.ArgumentNullException">The key is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.StringDictionary" /> is read-only.</exception>
	public virtual void Remove(string key)
	{
	}
}
