using System.Collections;

namespace System.Security.Cryptography.X509Certificates;

/// <summary>Represents a collection of <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" /> objects. This class cannot be inherited.</summary>
public sealed class X509ChainElementCollection : ICollection, IEnumerable
{
	private ArrayList _list;

	/// <summary>Gets the number of elements in the collection.</summary>
	/// <returns>An integer representing the number of elements in the collection.</returns>
	public int Count => 0;

	/// <summary>Gets a value indicating whether the collection of chain elements is synchronized.</summary>
	/// <returns>Always returns <see langword="false" />.</returns>
	public bool IsSynchronized => false;

	/// <summary>Gets the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" /> object at the specified index.</summary>
	/// <param name="index">An integer value.</param>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" /> object.</returns>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="index" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is greater than or equal to the length of the collection.</exception>
	public X509ChainElement this[int index] => null;

	/// <summary>Gets an object that can be used to synchronize access to an <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" /> object.</summary>
	/// <returns>A pointer reference to the current object.</returns>
	public object SyncRoot => null;

	internal X509ChainElementCollection()
	{
	}

	/// <summary>Copies an <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" /> object into an array, starting at the specified index.</summary>
	/// <param name="array">An array to copy the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" /> object to.</param>
	/// <param name="index">The index of <paramref name="array" /> at which to start copying.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The specified <paramref name="index" /> is less than zero, or greater than or equal to the length of the array.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> plus the current count is greater than the length of the array.</exception>
	void ICollection.CopyTo(Array array, int index)
	{
	}

	/// <summary>Gets an <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator" /> object that can be used to navigate through a collection of chain elements.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator" /> object.</returns>
	public X509ChainElementEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Gets an <see cref="T:System.Collections.IEnumerator" /> object that can be used to navigate a collection of chain elements.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	internal void Add(X509Certificate2 certificate)
	{
	}

	internal void Clear()
	{
	}

	internal bool Contains(X509Certificate2 certificate)
	{
		return false;
	}
}
