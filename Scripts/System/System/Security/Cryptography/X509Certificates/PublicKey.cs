namespace System.Security.Cryptography.X509Certificates;

/// <summary>Represents a certificate's public key information. This class cannot be inherited.</summary>
public sealed class PublicKey
{
	private AsnEncodedData _keyValue;

	private AsnEncodedData _params;

	private Oid _oid;

	private static byte[] Empty;

	/// <summary>Gets the ASN.1-encoded representation of the public key value.</summary>
	/// <returns>The ASN.1-encoded representation of the public key value.</returns>
	public AsnEncodedData EncodedKeyValue => null;

	/// <summary>Gets the ASN.1-encoded representation of the public key parameters.</summary>
	/// <returns>The ASN.1-encoded representation of the public key parameters.</returns>
	public AsnEncodedData EncodedParameters => null;

	/// <summary>Gets an <see cref="T:System.Security.Cryptography.RSA" /> derived object or a <see cref="T:System.Security.Cryptography.DSA" /> derived object representing the public key.</summary>
	/// <returns>An <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object representing the public key.</returns>
	/// <exception cref="T:System.NotSupportedException">The key algorithm is not supported.</exception>
	public AsymmetricAlgorithm Key => null;

	/// <summary>Gets an object identifier (OID) object of the public key.</summary>
	/// <returns>An object identifier (OID) object of the public key.</returns>
	public Oid Oid => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.PublicKey" /> class using an object identifier (OID) object of the public key, an ASN.1-encoded representation of the public key parameters, and an ASN.1-encoded representation of the public key value.</summary>
	/// <param name="oid">An object identifier (OID) object that represents the public key.</param>
	/// <param name="parameters">An ASN.1-encoded representation of the public key parameters.</param>
	/// <param name="keyValue">An ASN.1-encoded representation of the public key value.</param>
	public PublicKey(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue)
	{
	}

	private static byte[] GetUnsignedBigInteger(byte[] integer)
	{
		return null;
	}

	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters)
	{
		return null;
	}

	internal static RSA DecodeRSA(byte[] rawPublicKey)
	{
		return null;
	}
}
