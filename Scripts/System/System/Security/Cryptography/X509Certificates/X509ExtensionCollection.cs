using System.Collections;

namespace System.Security.Cryptography.X509Certificates;

/// <summary>Represents a collection of <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> objects. This class cannot be inherited.</summary>
public sealed class X509ExtensionCollection : ICollection, IEnumerable
{
	private static byte[] Empty;

	private ArrayList _list;

	/// <summary>Gets the number of <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> objects in a <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</summary>
	/// <returns>An integer representing the number of <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> objects in the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</returns>
	public int Count => 0;

	/// <summary>Gets a value indicating whether the collection is guaranteed to be thread safe.</summary>
	/// <returns>
	///   <see langword="true" /> if the collection is thread safe; otherwise, <see langword="false" />.</returns>
	public bool IsSynchronized => false;

	/// <summary>Gets an object that you can use to synchronize access to the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</summary>
	/// <returns>An object that you can use to synchronize access to the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</returns>
	public object SyncRoot => null;

	/// <summary>Gets the first <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> object whose value or friendly name is specified by an object identifier (OID).</summary>
	/// <param name="oid">The object identifier (OID) of the extension to retrieve.</param>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> object.</returns>
	public X509Extension this[string oid] => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> class.</summary>
	public X509ExtensionCollection()
	{
	}

	/// <summary>Adds an <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> object to an <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</summary>
	/// <param name="extension">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> object to add to the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</param>
	/// <returns>The index at which the <paramref name="extension" /> parameter was added.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value of the <paramref name="extension" /> parameter is <see langword="null" />.</exception>
	public int Add(X509Extension extension)
	{
		return 0;
	}

	/// <summary>Copies the collection into an array starting at the specified index.</summary>
	/// <param name="array">An array of <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> objects.</param>
	/// <param name="index">The location in the array at which copying starts.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> is a zero-length string or contains an invalid value.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="index" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> specifies a value that is not in the range of the array.</exception>
	void ICollection.CopyTo(Array array, int index)
	{
	}

	/// <summary>Returns an enumerator that can iterate through an <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator" /> object to use to iterate through the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</returns>
	public X509ExtensionEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an enumerator that can iterate through an <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object to use to iterate through the <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
