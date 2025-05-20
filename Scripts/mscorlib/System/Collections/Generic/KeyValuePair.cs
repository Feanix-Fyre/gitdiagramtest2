namespace System.Collections.Generic;

public static class KeyValuePair
{
	internal static string PairToString(object key, object value)
	{
		return null;
	}
}
/// <summary>Defines a key/value pair that can be set or retrieved.</summary>
/// <typeparam name="TKey">The type of the key.</typeparam>
/// <typeparam name="TValue">The type of the value.</typeparam>
[Serializable]
public readonly struct KeyValuePair<TKey, TValue>
{
	private readonly TKey key;

	private readonly TValue value;

	/// <summary>Gets the key in the key/value pair.</summary>
	/// <returns>A <typeparamref name="TKey" /> that is the key of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />.</returns>
	public TKey Key => default(TKey);

	/// <summary>Gets the value in the key/value pair.</summary>
	/// <returns>A <typeparamref name="TValue" /> that is the value of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />.</returns>
	public TValue Value => default(TValue);

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.KeyValuePair`2" /> structure with the specified key and value.</summary>
	/// <param name="key">The object defined in each key/value pair.</param>
	/// <param name="value">The definition associated with <paramref name="key" />.</param>
	public KeyValuePair(TKey key, TValue value)
	{
		this.key = default(TKey);
		this.value = default(TValue);
	}

	/// <summary>Returns a string representation of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />, using the string representations of the key and value.</summary>
	/// <returns>A string representation of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />, which includes the string representations of the key and value.</returns>
	public override string ToString()
	{
		return null;
	}

	public void Deconstruct(out TKey key, out TValue value)
	{
		key = default(TKey);
		value = default(TValue);
	}
}
