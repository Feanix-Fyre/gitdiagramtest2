using System.Runtime.Serialization;

namespace System.Security.Cryptography.X509Certificates;

/// <summary>Represents an X.509 certificate.</summary>
[Serializable]
public class X509Certificate2 : X509Certificate
{
	private byte[] lazyRawData;

	private Oid lazySignatureAlgorithm;

	private int lazyVersion;

	private X500DistinguishedName lazySubjectName;

	private X500DistinguishedName lazyIssuerName;

	private PublicKey lazyPublicKey;

	private AsymmetricAlgorithm lazyPrivateKey;

	private X509ExtensionCollection lazyExtensions;

	/// <summary>Gets a collection of <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" /> objects.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" /> object.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable.</exception>
	public X509ExtensionCollection Extensions => null;

	/// <summary>Gets a value that indicates whether an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object contains a private key.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object contains a private key; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate context is invalid.</exception>
	public bool HasPrivateKey => false;

	/// <summary>Gets or sets the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object that represents the private key associated with a certificate.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object, which is either an RSA or DSA cryptographic service provider.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key value is not an RSA or DSA key, or the key is unreadable.</exception>
	/// <exception cref="T:System.ArgumentNullException">The value being set for this property is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The key algorithm for this private key is not supported.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The X.509 keys do not match.</exception>
	/// <exception cref="T:System.ArgumentException">The cryptographic service provider key is <see langword="null" />.</exception>
	public AsymmetricAlgorithm PrivateKey => null;

	/// <summary>Gets the distinguished name of the certificate issuer.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X500DistinguishedName" /> object that contains the name of the certificate issuer.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate context is invalid.</exception>
	public X500DistinguishedName IssuerName => null;

	/// <summary>Gets the date in local time after which a certificate is no longer valid.</summary>
	/// <returns>A <see cref="T:System.DateTime" /> object that represents the expiration date for the certificate.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable.</exception>
	public DateTime NotAfter => default(DateTime);

	/// <summary>Gets the date in local time on which a certificate becomes valid.</summary>
	/// <returns>A <see cref="T:System.DateTime" /> object that represents the effective date of the certificate.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable.</exception>
	public DateTime NotBefore => default(DateTime);

	/// <summary>Gets a <see cref="P:System.Security.Cryptography.X509Certificates.X509Certificate2.PublicKey" /> object associated with a certificate.</summary>
	/// <returns>A <see cref="P:System.Security.Cryptography.X509Certificates.X509Certificate2.PublicKey" /> object.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key value is not an RSA or DSA key, or the key is unreadable.</exception>
	public PublicKey PublicKey => null;

	/// <summary>Gets the raw data of a certificate.</summary>
	/// <returns>The raw data of the certificate as a byte array.</returns>
	public byte[] RawData => null;

	/// <summary>Gets the serial number of a certificate as a big-endian hexadecimal string.</summary>
	/// <returns>The serial number of the certificate as a big-endian hexadecimal string.</returns>
	public string SerialNumber => null;

	/// <summary>Gets the algorithm used to create the signature of a certificate.</summary>
	/// <returns>The object identifier of the signature algorithm.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable.</exception>
	public Oid SignatureAlgorithm => null;

	/// <summary>Gets the subject distinguished name from a certificate.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X500DistinguishedName" /> object that represents the name of the certificate subject.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate context is invalid.</exception>
	public X500DistinguishedName SubjectName => null;

	/// <summary>Gets the thumbprint of a certificate.</summary>
	/// <returns>The thumbprint of the certificate.</returns>
	public string Thumbprint => null;

	/// <summary>Gets the X.509 format version of a certificate.</summary>
	/// <returns>The certificate format.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable.</exception>
	public int Version => 0;

	internal new X509Certificate2Impl Impl => null;

	/// <summary>Resets the state of an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object.</summary>
	public override void Reset()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> class.</summary>
	public X509Certificate2()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> class using information from a byte array.</summary>
	/// <param name="rawData">A byte array containing data from an X.509 certificate.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:  
	///
	/// The certificate file does not exist.  
	///
	/// The certificate is invalid.  
	///
	/// The certificate's password is incorrect.</exception>
	public X509Certificate2(byte[] rawData)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> class using a byte array and a password.</summary>
	/// <param name="rawData">A byte array containing data from an X.509 certificate.</param>
	/// <param name="password">The password required to access the X.509 certificate data.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:  
	///
	/// The certificate file does not exist.  
	///
	/// The certificate is invalid.  
	///
	/// The certificate's password is incorrect.</exception>
	public X509Certificate2(byte[] rawData, string password)
	{
	}

	internal X509Certificate2(X509Certificate2Impl impl)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> class using an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</summary>
	/// <param name="certificate">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:  
	///
	/// The certificate file does not exist.  
	///
	/// The certificate is invalid.  
	///
	/// The certificate's password is incorrect.</exception>
	public X509Certificate2(X509Certificate certificate)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> class using the specified serialization and stream context information.</summary>
	/// <param name="info">The serialization information required to deserialize the new <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</param>
	/// <param name="context">Contextual information about the source of the stream to be deserialized.</param>
	protected X509Certificate2(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Indicates the type of certificate contained in a byte array.</summary>
	/// <param name="rawData">A byte array containing data from an X.509 certificate.</param>
	/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" /> object.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="rawData" /> has a zero length or is <see langword="null" />.</exception>
	public static X509ContentType GetCertContentType(byte[] rawData)
	{
		return default(X509ContentType);
	}

	/// <summary>Gets the subject and issuer names from a certificate.</summary>
	/// <param name="nameType">The <see cref="T:System.Security.Cryptography.X509Certificates.X509NameType" /> value for the subject.</param>
	/// <param name="forIssuer">
	///   <see langword="true" /> to include the issuer name; otherwise, <see langword="false" />.</param>
	/// <returns>The name of the certificate.</returns>
	public string GetNameInfo(X509NameType nameType, bool forIssuer)
	{
		return null;
	}

	/// <summary>Displays an X.509 certificate in text format.</summary>
	/// <returns>The certificate information.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Displays an X.509 certificate in text format.</summary>
	/// <param name="verbose">
	///   <see langword="true" /> to display the public key, private key, extensions, and so forth; <see langword="false" /> to display information that is similar to the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> class, including thumbprint, serial number, subject and issuer names, and so on.</param>
	/// <returns>The certificate information.</returns>
	public override string ToString(bool verbose)
	{
		return null;
	}

	/// <summary>Performs a X.509 chain validation using basic validation policy.</summary>
	/// <returns>
	///   <see langword="true" /> if the validation succeeds; <see langword="false" /> if the validation fails.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate is unreadable.</exception>
	public bool Verify()
	{
		return false;
	}

	private static X509Extension CreateCustomExtensionIfAny(Oid oid)
	{
		return null;
	}
}
