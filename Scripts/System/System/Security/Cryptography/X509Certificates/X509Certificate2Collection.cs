namespace System.Security.Cryptography.X509Certificates;

/// <summary>Represents a collection of <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> objects. This class cannot be inherited.</summary>
public class X509Certificate2Collection : X509CertificateCollection
{
	private static string[] newline_split;

	/// <summary>Gets or sets the element at the specified index.</summary>
	/// <param name="index">The zero-based index of the element to get or set.</param>
	/// <returns>The element at the specified index.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is equal to or greater than the <see cref="P:System.Collections.CollectionBase.Count" /> property.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="index" /> is <see langword="null" />.</exception>
	public new X509Certificate2 this[int index] => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> class without any <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> information.</summary>
	public X509Certificate2Collection()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> class using the specified certificate collection.</summary>
	/// <param name="certificates">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</param>
	public X509Certificate2Collection(X509Certificate2Collection certificates)
	{
	}

	/// <summary>Adds an object to the end of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
	/// <param name="certificate">An X.509 certificate represented as an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object.</param>
	/// <returns>The <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> index at which the <paramref name="certificate" /> has been added.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="certificate" /> is <see langword="null" />.</exception>
	public int Add(X509Certificate2 certificate)
	{
		return 0;
	}

	/// <summary>Adds multiple <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> objects in an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object to another <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</summary>
	/// <param name="certificates">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="certificates" /> is <see langword="null" />.</exception>
	[System.MonoTODO("Method isn't transactional (like documented)")]
	public void AddRange(X509Certificate2Collection certificates)
	{
	}

	/// <summary>Determines whether the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object contains a specific certificate.</summary>
	/// <param name="certificate">The <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object to locate in the collection.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> contains the specified <paramref name="certificate" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="certificate" /> is <see langword="null" />.</exception>
	public bool Contains(X509Certificate2 certificate)
	{
		return false;
	}

	private string GetKeyIdentifier(X509Certificate2 x)
	{
		return null;
	}

	/// <summary>Searches an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object using the search criteria specified by the <see cref="T:System.Security.Cryptography.X509Certificates.X509FindType" /> enumeration and the <paramref name="findValue" /> object.</summary>
	/// <param name="findType">One of the <see cref="T:System.Security.Cryptography.X509Certificates.X509FindType" /> values.</param>
	/// <param name="findValue">The search criteria as an object.</param>
	/// <param name="validOnly">
	///   <see langword="true" /> to allow only valid certificates to be returned from the search; otherwise, <see langword="false" />.</param>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">
	///   <paramref name="findType" /> is invalid.</exception>
	[System.MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly)
	{
		return null;
	}

	/// <summary>Returns an enumerator that can iterate through a <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator" /> object that can iterate through the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
	public new X509Certificate2Enumerator GetEnumerator()
	{
		return null;
	}
}
