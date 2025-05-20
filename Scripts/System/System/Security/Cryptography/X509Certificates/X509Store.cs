using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates;

/// <summary>Represents an X.509 store, which is a physical store where certificates are persisted and managed. This class cannot be inherited.</summary>
public sealed class X509Store : IDisposable
{
	private string _name;

	private StoreLocation _location;

	private X509Certificate2Collection list;

	private OpenFlags _flags;

	private Mono.Security.X509.X509Store store;

	/// <summary>Returns a collection of certificates located in an X.509 certificate store.</summary>
	/// <returns>A collection of certificates.</returns>
	public X509Certificate2Collection Certificates => null;

	private X509Stores Factory => null;

	internal Mono.Security.X509.X509Store Store => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> class using the specified <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" /> and <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" /> values.</summary>
	/// <param name="storeName">One of the enumeration values that specifies the name of the X.509 certificate store.</param>
	/// <param name="storeLocation">One of the enumeration values that specifies the location of the X.509 certificate store.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="storeLocation" /> is not a valid location or <paramref name="storeName" /> is not a valid name.</exception>
	public X509Store(StoreName storeName, StoreLocation storeLocation)
	{
	}

	/// <summary>Closes an X.509 certificate store.</summary>
	public void Close()
	{
	}

	/// <summary>Releases the resources used by this <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Opens an X.509 certificate store or creates a new store, depending on <see cref="T:System.Security.Cryptography.X509Certificates.OpenFlags" /> flag settings.</summary>
	/// <param name="flags">A bitwise combination of enumeration values that specifies the way to open the X.509 certificate store.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The store is unreadable.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentException">The store contains invalid values.</exception>
	public void Open(OpenFlags flags)
	{
	}
}
