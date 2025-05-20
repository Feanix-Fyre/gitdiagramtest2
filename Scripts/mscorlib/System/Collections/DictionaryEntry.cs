namespace System.Collections;

/// <summary>Defines a dictionary key/value pair that can be set or retrieved.</summary>
[Serializable]
public struct DictionaryEntry
{
	private object _key;

	private object _value;

	/// <summary>Gets or sets the key in the key/value pair.</summary>
	/// <returns>The key in the key/value pair.</returns>
	public object Key => null;

	/// <summary>Gets or sets the value in the key/value pair.</summary>
	/// <returns>The value in the key/value pair.</returns>
	public object Value => null;

	/// <summary>Initializes an instance of the <see cref="T:System.Collections.DictionaryEntry" /> type with the specified key and value.</summary>
	/// <param name="key">The object defined in each key/value pair.</param>
	/// <param name="value">The definition associated with <paramref name="key" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" /> and the .NET Framework version is 1.0 or 1.1.</exception>
	public DictionaryEntry(object key, object value)
	{
		_key = null;
		_value = null;
	}
}
