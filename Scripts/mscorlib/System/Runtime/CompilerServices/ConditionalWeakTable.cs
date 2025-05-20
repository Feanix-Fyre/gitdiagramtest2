using System.Collections;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices;

/// <summary>Enables compilers to dynamically attach object fields to managed objects.</summary>
/// <typeparam name="TKey">The reference type to which the field is attached.</typeparam>
/// <typeparam name="TValue">The field's type. This must be a reference type.</typeparam>
public sealed class ConditionalWeakTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TKey : class where TValue : class
{
	/// <summary>Represents a method that creates a non-default value to add as part of a key/value pair to a <see cref="T:System.Runtime.CompilerServices.ConditionalWeakTable`2" /> object.</summary>
	/// <param name="key">The key that belongs to the value to create.</param>
	/// <typeparam name="TKey" />
	/// <typeparam name="TValue" />
	/// <returns>An instance of a reference type that represents the value to attach to the specified key.</returns>
	public delegate TValue CreateValueCallback(TKey key);

	private sealed class Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
	{
		private ConditionalWeakTable<TKey, TValue> _table;

		private int _currentIndex;

		private KeyValuePair<TKey, TValue> _current;

		public KeyValuePair<TKey, TValue> Current => default(KeyValuePair<TKey, TValue>);

		object IEnumerator.Current => null;

		public Enumerator(ConditionalWeakTable<TKey, TValue> table)
		{
		}

		~Enumerator()
		{
		}

		public void Dispose()
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

	private const int INITIAL_SIZE = 13;

	private const float LOAD_FACTOR = 0.7f;

	private const float COMPACT_FACTOR = 0.5f;

	private const float EXPAND_FACTOR = 1.1f;

	private Ephemeron[] data;

	private object _lock;

	private int size;

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.ConditionalWeakTable`2" /> class.</summary>
	public ConditionalWeakTable()
	{
	}

	/// <summary>Ensures that resources are freed and other cleanup operations are performed when the garbage collector reclaims the <see cref="T:System.Runtime.CompilerServices.ConditionalWeakTable`2" /> object.</summary>
	~ConditionalWeakTable()
	{
	}

	private void RehashWithoutResize()
	{
	}

	private void RecomputeSize()
	{
	}

	private void Rehash()
	{
	}

	/// <summary>Adds a key to the table.</summary>
	/// <param name="key">The key to add. <paramref name="key" /> represents the object to which the property is attached.</param>
	/// <param name="value">The key's property value.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="key" /> already exists.</exception>
	public void Add(TKey key, TValue value)
	{
	}

	/// <summary>Removes a key and its value from the table.</summary>
	/// <param name="key">The key to remove.</param>
	/// <returns>
	///   <see langword="true" /> if the key is found and removed; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public bool Remove(TKey key)
	{
		return false;
	}

	/// <summary>Gets the value of the specified key.</summary>
	/// <param name="key">The key that represents an object with an attached property.</param>
	/// <param name="value">When this method returns, contains the attached property value. If <paramref name="key" /> is not found, <paramref name="value" /> contains the default value.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="key" /> is found; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public bool TryGetValue(TKey key, out TValue value)
	{
		value = null;
		return false;
	}

	/// <summary>Atomically searches for a specified key in the table and returns the corresponding value. If the key does not exist in the table, the method invokes a callback method to create a value that is bound to the specified key.</summary>
	/// <param name="key">The key to search for. <paramref name="key" /> represents the object to which the property is attached.</param>
	/// <param name="createValueCallback">A delegate to a method that can create a value for the given <paramref name="key" />. It has a single parameter of type TKey, and returns a value of type TValue.</param>
	/// <returns>The value attached to <paramref name="key" />, if <paramref name="key" /> already exists in the table; otherwise, the new value returned by the <paramref name="createValueCallback" /> delegate.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> or <paramref name="createValueCallback" /> is <see langword="null" />.</exception>
	public TValue GetValue(TKey key, CreateValueCallback createValueCallback)
	{
		return null;
	}

	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
