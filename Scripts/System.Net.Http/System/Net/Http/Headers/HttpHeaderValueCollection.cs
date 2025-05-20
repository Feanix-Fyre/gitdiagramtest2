using System.Collections;
using System.Collections.Generic;

namespace System.Net.Http.Headers;

/// <summary>Represents a collection of header values.</summary>
/// <typeparam name="T">The header collection type.</typeparam>
public sealed class HttpHeaderValueCollection<T> : ICollection<T>, IEnumerable<T>, IEnumerable where T : class
{
	private readonly List<T> list;

	private readonly HttpHeaders headers;

	private readonly HeaderInfo headerInfo;

	private List<string> invalidValues;

	/// <summary>Gets the number of headers in the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
	/// <returns>The number of headers in a collection</returns>
	public int Count => 0;

	internal List<string> InvalidValues => null;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> instance is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> instance is read-only; otherwise, <see langword="false" />.</returns>
	public bool IsReadOnly => false;

	internal HttpHeaderValueCollection(HttpHeaders headers, HeaderInfo headerInfo)
	{
	}

	/// <summary>Adds an entry to the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
	/// <param name="item">The item to add to the header collection.</param>
	public void Add(T item)
	{
	}

	internal void AddRange(List<T> values)
	{
	}

	internal void AddInvalidValue(string invalidValue)
	{
	}

	/// <summary>Removes all entries from the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
	public void Clear()
	{
	}

	/// <summary>Determines if the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> contains an item.</summary>
	/// <param name="item">The item to find to the header collection.</param>
	/// <returns>
	///   <see langword="true" /> if the entry is contained in the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> instance; otherwise, <see langword="false" /></returns>
	public bool Contains(T item)
	{
		return false;
	}

	/// <summary>Copies the entire <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	/// <summary>Removes the specified item from the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
	/// <param name="item">The item to remove.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="item" /> was removed from the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> instance; otherwise, <see langword="false" /></returns>
	public bool Remove(T item)
	{
		return false;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> object. object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
	/// <returns>An enumerator for the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> instance.</returns>
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
	/// <returns>An enumerator for the <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> instance.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	internal T Find(Predicate<T> predicate)
	{
		return null;
	}
}
