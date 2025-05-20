namespace System.Security.Cryptography.X509Certificates;

/// <summary>Defines a string that identifies a certificate's subject key identifier (SKI). This class cannot be inherited.</summary>
public sealed class X509SubjectKeyIdentifierExtension : X509Extension
{
	internal const string oid = "2.5.29.14";

	internal const string friendlyName = "Subject Key Identifier";

	private byte[] _subjectKeyIdentifier;

	private string _ski;

	private AsnDecodeStatus _status;

	/// <summary>Gets a string that represents the subject key identifier (SKI) for a certificate.</summary>
	/// <returns>A string, encoded in hexadecimal format, that represents the subject key identifier (SKI).</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The extension cannot be decoded.</exception>
	public string SubjectKeyIdentifier => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" /> class.</summary>
	public X509SubjectKeyIdentifierExtension()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" /> class using encoded data and a value that identifies whether the extension is critical.</summary>
	/// <param name="encodedSubjectKeyIdentifier">The <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object to use to create the extension.</param>
	/// <param name="critical">
	///   <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
	public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" /> class using a byte array and a value that identifies whether the extension is critical.</summary>
	/// <param name="subjectKeyIdentifier">A byte array that represents data to use to create the extension.</param>
	/// <param name="critical">
	///   <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
	public X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" /> class using a string and a value that identifies whether the extension is critical.</summary>
	/// <param name="subjectKeyIdentifier">A string, encoded in hexadecimal format, that represents the subject key identifier (SKI) for a certificate.</param>
	/// <param name="critical">
	///   <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
	public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" /> class using a public key and a value indicating whether the extension is critical.</summary>
	/// <param name="key">A <see cref="T:System.Security.Cryptography.X509Certificates.PublicKey" /> object to create a subject key identifier (SKI) from.</param>
	/// <param name="critical">
	///   <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
	public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" /> class using a public key, a hash algorithm identifier, and a value indicating whether the extension is critical.</summary>
	/// <param name="key">A <see cref="T:System.Security.Cryptography.X509Certificates.PublicKey" /> object to create a subject key identifier (SKI) from.</param>
	/// <param name="algorithm">One of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm" /> values that identifies which hash algorithm to use.</param>
	/// <param name="critical">
	///   <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
	public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical)
	{
	}

	/// <summary>Creates a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension" /> class by copying information from encoded data.</summary>
	/// <param name="asnEncodedData">The <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object to use to create the extension.</param>
	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
	}

	internal static byte FromHexChar(char c)
	{
		return 0;
	}

	internal static byte FromHexChars(char c1, char c2)
	{
		return 0;
	}

	internal static byte[] FromHex(string hex)
	{
		return null;
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
