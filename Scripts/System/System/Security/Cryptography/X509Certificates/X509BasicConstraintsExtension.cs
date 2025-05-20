namespace System.Security.Cryptography.X509Certificates;

/// <summary>Defines the constraints set on a certificate. This class cannot be inherited.</summary>
public sealed class X509BasicConstraintsExtension : X509Extension
{
	internal const string oid = "2.5.29.19";

	internal const string friendlyName = "Basic Constraints";

	private bool _certificateAuthority;

	private bool _hasPathLengthConstraint;

	private int _pathLengthConstraint;

	private AsnDecodeStatus _status;

	/// <summary>Gets a value indicating whether a certificate is a certificate authority (CA) certificate.</summary>
	/// <returns>
	///   <see langword="true" /> if the certificate is a certificate authority (CA) certificate, otherwise, <see langword="false" />.</returns>
	public bool CertificateAuthority => false;

	/// <summary>Gets a value indicating whether a certificate has a restriction on the number of path levels it allows.</summary>
	/// <returns>
	///   <see langword="true" /> if the certificate has a restriction on the number of path levels it allows, otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The extension cannot be decoded.</exception>
	public bool HasPathLengthConstraint => false;

	/// <summary>Gets the number of levels allowed in a certificate's path.</summary>
	/// <returns>An integer indicating the number of levels allowed in a certificate's path.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The extension cannot be decoded.</exception>
	public int PathLengthConstraint => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension" /> class.</summary>
	public X509BasicConstraintsExtension()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension" /> class using an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object and a value that identifies whether the extension is critical.</summary>
	/// <param name="encodedBasicConstraints">The encoded data to use to create the extension.</param>
	/// <param name="critical">
	///   <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
	public X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension" /> class. Parameters specify a value that indicates whether a certificate is a certificate authority (CA) certificate, a value that indicates whether the certificate has a restriction on the number of path levels it allows, the number of levels allowed in a certificate's path, and a value that indicates whether the extension is critical.</summary>
	/// <param name="certificateAuthority">
	///   <see langword="true" /> if the certificate is a certificate authority (CA) certificate; otherwise, <see langword="false" />.</param>
	/// <param name="hasPathLengthConstraint">
	///   <see langword="true" /> if the certificate has a restriction on the number of path levels it allows; otherwise, <see langword="false" />.</param>
	/// <param name="pathLengthConstraint">The number of levels allowed in a certificate's path.</param>
	/// <param name="critical">
	///   <see langword="true" /> if the extension is critical; otherwise, <see langword="false" />.</param>
	public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509BasicConstraintsExtension" /> class using an <see cref="T:System.Security.Cryptography.AsnEncodedData" /> object.</summary>
	/// <param name="asnEncodedData">The encoded data to use to create the extension.</param>
	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
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
