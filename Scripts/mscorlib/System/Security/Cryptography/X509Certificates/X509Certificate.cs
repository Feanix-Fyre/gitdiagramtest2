using System.Runtime.Serialization;

namespace System.Security.Cryptography.X509Certificates;

/// <summary>Provides methods that help you use X.509 v.3 certificates.</summary>
[Serializable]
public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable
{
	private X509CertificateImpl impl;

	private byte[] lazyCertHash;

	private byte[] lazySerialNumber;

	private string lazyIssuer;

	private string lazySubject;

	private string lazyKeyAlgorithm;

	private byte[] lazyKeyAlgorithmParameters;

	private byte[] lazyPublicKey;

	private DateTime lazyNotBefore;

	private DateTime lazyNotAfter;

	/// <summary>Gets the name of the certificate authority that issued the X.509v3 certificate.</summary>
	/// <returns>The name of the certificate authority that issued the X.509v3 certificate.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate handle is invalid.</exception>
	public string Issuer => null;

	/// <summary>Gets the subject distinguished name from the certificate.</summary>
	/// <returns>The subject distinguished name from the certificate.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate handle is invalid.</exception>
	public string Subject => null;

	internal X509CertificateImpl Impl => null;

	internal bool IsValid => false;

	/// <summary>Resets the state of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object.</summary>
	public virtual void Reset()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class.</summary>
	public X509Certificate()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class defined from a sequence of bytes representing an X.509v3 certificate.</summary>
	/// <param name="data">A byte array containing data from an X.509 certificate.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:  
	///
	/// The certificate file does not exist.  
	///
	/// The certificate is invalid.  
	///
	/// The certificate's password is incorrect.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="rawData" /> parameter is <see langword="null" />.  
	///  -or-  
	///  The length of the <paramref name="rawData" /> parameter is 0.</exception>
	public X509Certificate(byte[] data)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using a byte array and a password.</summary>
	/// <param name="rawData">A byte array containing data from an X.509 certificate.</param>
	/// <param name="password">The password required to access the X.509 certificate data.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:  
	///
	/// The certificate file does not exist.  
	///
	/// The certificate is invalid.  
	///
	/// The certificate's password is incorrect.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="rawData" /> parameter is <see langword="null" />.  
	///  -or-  
	///  The length of the <paramref name="rawData" /> parameter is 0.</exception>
	public X509Certificate(byte[] rawData, string password)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using a byte array, a password, and a key storage flag.</summary>
	/// <param name="rawData">A byte array containing data from an X.509 certificate.</param>
	/// <param name="password">The password required to access the X.509 certificate data.</param>
	/// <param name="keyStorageFlags">A bitwise combination of the enumeration values that control where and how to import the certificate.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:  
	///
	/// The certificate file does not exist.  
	///
	/// The certificate is invalid.  
	///
	/// The certificate's password is incorrect.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="rawData" /> parameter is <see langword="null" />.  
	///  -or-  
	///  The length of the <paramref name="rawData" /> parameter is 0.</exception>
	public X509Certificate(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
	{
	}

	internal X509Certificate(X509CertificateImpl impl)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using another <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class.</summary>
	/// <param name="cert">A <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class from which to initialize this class.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:  
	///
	/// The certificate file does not exist.  
	///
	/// The certificate is invalid.  
	///
	/// The certificate's password is incorrect.</exception>
	/// <exception cref="T:System.ArgumentNullException">The value of the <paramref name="cert" /> parameter is <see langword="null" />.</exception>
	public X509Certificate(X509Certificate cert)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object and a <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that describes serialization information.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that describes how serialization should be performed.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:  
	///
	/// The certificate file does not exist.  
	///
	/// The certificate is invalid.  
	///
	/// The certificate's password is incorrect.</exception>
	public X509Certificate(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Gets serialization information with all the data needed to recreate an instance of the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</summary>
	/// <param name="info">The object to populate with serialization information.</param>
	/// <param name="context">The destination context of the serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary>
	/// <param name="sender">The source of the deserialization event.</param>
	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	/// <summary>Releases all resources used by the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases all of the unmanaged resources used by this <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Compares two <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> objects for equality.</summary>
	/// <param name="obj">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object to compare to the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object is equal to the object specified by the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Compares two <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> objects for equality.</summary>
	/// <param name="other">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object to compare to the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object is equal to the object specified by the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
	public virtual bool Equals(X509Certificate other)
	{
		return false;
	}

	/// <summary>Exports the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object to a byte array in a format described by one of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" /> values, and using the specified password.</summary>
	/// <param name="contentType">One of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" /> values that describes how to format the output data.</param>
	/// <param name="password">The password required to access the X.509 certificate data.</param>
	/// <returns>An array of bytes that represents the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">A value other than <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Cert" />, <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.SerializedCert" />, or <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Pkcs12" /> was passed to the <paramref name="contentType" /> parameter.  
	///  -or-  
	///  The certificate could not be exported.</exception>
	public virtual byte[] Export(X509ContentType contentType, string password)
	{
		return null;
	}

	/// <summary>Returns the hash value for the X.509v3 certificate as an array of bytes.</summary>
	/// <returns>The hash value for the X.509 certificate.</returns>
	public virtual byte[] GetCertHash()
	{
		return null;
	}

	/// <summary>Returns the SHA1 hash value for the X.509v3 certificate as a hexadecimal string.</summary>
	/// <returns>The hexadecimal string representation of the X.509 certificate hash value.</returns>
	public virtual string GetCertHashString()
	{
		return null;
	}

	private byte[] GetRawCertHash()
	{
		return null;
	}

	/// <summary>Returns the raw data for the entire X.509v3 certificate as an array of bytes.</summary>
	/// <returns>A byte array containing the X.509 certificate data.</returns>
	public virtual byte[] GetRawCertData()
	{
		return null;
	}

	/// <summary>Returns the hash code for the X.509v3 certificate as an integer.</summary>
	/// <returns>The hash code for the X.509 certificate as an integer.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns the key algorithm information for this X.509v3 certificate as a string.</summary>
	/// <returns>The key algorithm information for this X.509 certificate as a string.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate context is invalid.</exception>
	public virtual string GetKeyAlgorithm()
	{
		return null;
	}

	/// <summary>Returns the key algorithm parameters for the X.509v3 certificate as an array of bytes.</summary>
	/// <returns>The key algorithm parameters for the X.509 certificate as an array of bytes.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate context is invalid.</exception>
	public virtual byte[] GetKeyAlgorithmParameters()
	{
		return null;
	}

	/// <summary>Returns the public key for the X.509v3 certificate as an array of bytes.</summary>
	/// <returns>The public key for the X.509 certificate as an array of bytes.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate context is invalid.</exception>
	public virtual byte[] GetPublicKey()
	{
		return null;
	}

	/// <summary>Returns the serial number of the X.509v3 certificate as an array of bytes in little-endian order.</summary>
	/// <returns>The serial number of the X.509 certificate as an array of bytes in little-endian order.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The certificate context is invalid.</exception>
	public virtual byte[] GetSerialNumber()
	{
		return null;
	}

	/// <summary>Returns the serial number of the X.509v3 certificate as a little-endian hexadecimal string .</summary>
	/// <returns>The serial number of the X.509 certificate as a little-endian hexadecimal string.</returns>
	public virtual string GetSerialNumberString()
	{
		return null;
	}

	private byte[] GetRawSerialNumber()
	{
		return null;
	}

	/// <summary>Returns a string representation of the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</summary>
	/// <returns>A string representation of the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Returns a string representation of the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object, with extra information, if specified.</summary>
	/// <param name="fVerbose">
	///   <see langword="true" /> to produce the verbose form of the string representation; otherwise, <see langword="false" />.</param>
	/// <returns>A string representation of the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</returns>
	public virtual string ToString(bool fVerbose)
	{
		return null;
	}

	internal DateTime GetNotAfter()
	{
		return default(DateTime);
	}

	internal DateTime GetNotBefore()
	{
		return default(DateTime);
	}

	/// <summary>Converts the specified date and time to a string.</summary>
	/// <param name="date">The date and time to convert.</param>
	/// <returns>A string representation of the value of the <see cref="T:System.DateTime" /> object.</returns>
	protected static string FormatDate(DateTime date)
	{
		return null;
	}

	internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags)
	{
	}

	private void VerifyContentType(X509ContentType contentType)
	{
	}

	internal void ImportHandle(X509CertificateImpl impl)
	{
	}

	internal void ThrowIfInvalid()
	{
	}
}
