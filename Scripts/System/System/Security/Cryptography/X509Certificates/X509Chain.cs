namespace System.Security.Cryptography.X509Certificates;

/// <summary>Represents a chain-building engine for <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> certificates.</summary>
public class X509Chain : IDisposable
{
	private X509ChainImpl impl;

	internal X509ChainImpl Impl => null;

	/// <summary>Gets a collection of <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" /> objects.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" /> object.</returns>
	public X509ChainElementCollection ChainElements => null;

	/// <summary>Gets or sets the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" /> to use when building an X.509 certificate chain.</summary>
	/// <returns>The <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" /> object associated with this X.509 chain.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value being set for this property is <see langword="null" />.</exception>
	public X509ChainPolicy ChainPolicy => null;

	/// <summary>Gets the status of each element in an <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> object.</summary>
	/// <returns>An array of <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainStatus" /> objects.</returns>
	public X509ChainStatus[] ChainStatus => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> class.</summary>
	public X509Chain()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> class specifying a value that indicates whether the machine context should be used.</summary>
	/// <param name="useMachineContext">
	///   <see langword="true" /> to use the machine context; <see langword="false" /> to use the current user context.</param>
	public X509Chain(bool useMachineContext)
	{
	}

	internal X509Chain(X509ChainImpl impl)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> class using an <see cref="T:System.IntPtr" /> handle to an X.509 chain.</summary>
	/// <param name="chainContext">An <see cref="T:System.IntPtr" /> handle to an X.509 chain.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="chainContext" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The <paramref name="chainContext" /> parameter points to an invalid context.</exception>
	[System.MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
	public X509Chain(IntPtr chainContext)
	{
	}

	/// <summary>Builds an X.509 chain using the policy specified in <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" />.</summary>
	/// <param name="certificate">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object.</param>
	/// <returns>
	///   <see langword="true" /> if the X.509 certificate is valid; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="certificate" /> is not a valid certificate or is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The <paramref name="certificate" /> is unreadable.</exception>
	[System.MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	public bool Build(X509Certificate2 certificate)
	{
		return false;
	}

	/// <summary>Clears the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> object.</summary>
	public void Reset()
	{
	}

	/// <summary>Creates an <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> object after querying for the mapping defined in the CryptoConfig file, and maps the chain to that mapping.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> object.</returns>
	public static X509Chain Create()
	{
		return null;
	}

	/// <summary>Releases all of the resources used by this <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by this <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />, and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	~X509Chain()
	{
	}
}
