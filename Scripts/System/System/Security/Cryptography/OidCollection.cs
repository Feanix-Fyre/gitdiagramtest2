using System.Collections;
using System.Collections.Generic;

namespace System.Security.Cryptography;

/// <summary>Represents a collection of <see cref="T:System.Security.Cryptography.Oid" /> objects. This class cannot be inherited.</summary>
public sealed class OidCollection : ICollection, IEnumerable
{
	private readonly List<Oid> _list;

	/// <summary>Gets an <see cref="T:System.Security.Cryptography.Oid" /> object from the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
	/// <param name="index">The location of the <see cref="T:System.Security.Cryptography.Oid" /> object in the collection.</param>
	/// <returns>An <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
	public Oid this[int index] => null;

	/// <summary>Gets the number of <see cref="T:System.Security.Cryptography.Oid" /> objects in a collection.</summary>
	/// <returns>The number of <see cref="T:System.Security.Cryptography.Oid" /> objects in a collection.</returns>
	public int Count => 0;

	/// <summary>Gets a value that indicates whether access to the <see cref="T:System.Security.Cryptography.OidCollection" /> object is thread safe.</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	public bool IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
	/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</returns>
	public object SyncRoot => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.OidCollection" /> class.</summary>
	public OidCollection()
	{
	}

	/// <summary>Adds an <see cref="T:System.Security.Cryptography.Oid" /> object to the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
	/// <param name="oid">The <see cref="T:System.Security.Cryptography.Oid" /> object to add to the collection.</param>
	/// <returns>The index of the added <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
	public int Add(Oid oid)
	{
		return 0;
	}

	/// <summary>Returns an <see cref="T:System.Security.Cryptography.OidEnumerator" /> object that can be used to navigate the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.OidEnumerator" /> object.</returns>
	public OidEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an <see cref="T:System.Security.Cryptography.OidEnumerator" /> object that can be used to navigate the <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.OidEnumerator" /> object that can be used to navigate the collection.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	/// <summary>Copies the <see cref="T:System.Security.Cryptography.OidCollection" /> object into an array.</summary>
	/// <param name="array">The array to copy the <see cref="T:System.Security.Cryptography.OidCollection" /> object to.</param>
	/// <param name="index">The location where the copy operation starts.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> cannot be a multidimensional array.  
	/// -or-  
	/// The length of <paramref name="array" /> is an invalid offset length.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="index" /> is out range.</exception>
	void ICollection.CopyTo(Array array, int index)
	{
	}
}
