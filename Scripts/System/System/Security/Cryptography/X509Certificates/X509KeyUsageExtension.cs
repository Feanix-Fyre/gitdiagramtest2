namespace System.Security.Cryptography.X509Certificates;

/// <summary>Defines the usage of a key contained within an X.509 certificate.  This class cannot be inherited.</summary>
public sealed class X509KeyUsageExtension : X509Extension
{
	internal const string oid = "2.5.29.15";

	internal const string friendlyName = "Key Usage";

	internal const X509KeyUsageFlags all = X509KeyUsageFlags.EncipherOnly | X509KeyUsageFlags.CrlSign | X509KeyUsageFlags.KeyCertSign | X509KeyUsageFlags.KeyAgreement | X509KeyUsageFlags.DataEncipherment | X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.DecipherOnly;

	private X509KeyUsageFlags _keyUsages;

	private AsnDecodeStatus _status;

	/// <summary>Gets the key usage flag associated with the certificate.</summary>
	/// <returns>One of the <see cref="P:System.Security.Cryptography.X509Certificates.X509KeyUsageExtension.KeyUsages" /> values.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The extension cannot be decoded.</exception>
	public X509KeyUsageFlags KeyUsages => default(X509KeyUsageFlags);

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509KeyUsageExtension" /> class.</summary>
	public X509KeyUsageExtension()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509KeyUsageExtension" /> class using an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object and a value that identifies whether the extension is critical.</summary>
	/// <param name="encodedKeyUsage">The encoded data to use to create the extension.</param>
	/// <param name="critical">
	///   <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
	public X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509KeyUsageExtension" /> class using the specified <see cref="T:System.Security.Cryptography.X509Certificates.X509KeyUsageFlags" /> value and a value that identifies whether the extension is critical.</summary>
	/// <param name="keyUsages">One of the <see cref="T:System.Security.Cryptography.X509Certificates.X509KeyUsageFlags" /> values that describes how to use the key.</param>
	/// <param name="critical">
	///   <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
	public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509KeyUsageExtension" /> class using an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object.</summary>
	/// <param name="asnEncodedData">The encoded data to use to create the extension.</param>
	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
	}

	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags)
	{
		return default(X509KeyUsageFlags);
	}

	internal AsnDecodeStatus Decode(byte[] extension)
	{
		return default(AsnDecodeStatus);
	}

	internal byte[] Encode()
	{
		return null;
	}

	internal override string ToString(bool multiLine)
	{
		return null;
	}
}
