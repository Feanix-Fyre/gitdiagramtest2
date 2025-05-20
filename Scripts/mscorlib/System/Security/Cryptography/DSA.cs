using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the abstract base class from which all implementations of the Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) must inherit.</summary>
[ComVisible(true)]
public abstract class DSA : AsymmetricAlgorithm
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSA" /> class.</summary>
	protected DSA()
	{
	}

	/// <summary>Creates the default cryptographic object used to perform the asymmetric algorithm.</summary>
	/// <returns>A cryptographic object used to perform the asymmetric algorithm.</returns>
	public static DSA Create()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, verifies the <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</summary>
	/// <param name="rgbHash">The hash of the data signed with <paramref name="rgbSignature" />.</param>
	/// <param name="rgbSignature">The signature to be verified for rgbData.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="rgbSignature" /> matches the signature computed using the specified hash algorithm and key on <paramref name="rgbHash" />; otherwise, <see langword="false" />.</returns>
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	/// <summary>Reconstructs a <see cref="T:System.Security.Cryptography.DSA" /> object from an XML string.</summary>
	/// <param name="xmlString">The XML string to use to reconstruct the <see cref="T:System.Security.Cryptography.DSA" /> object.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="xmlString" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The format of the <paramref name="xmlString" /> parameter is not valid.</exception>
	public override void FromXmlString(string xmlString)
	{
	}

	/// <summary>Creates and returns an XML string representation of the current <see cref="T:System.Security.Cryptography.DSA" /> object.</summary>
	/// <param name="includePrivateParameters">
	///   <see langword="true" /> to include private parameters; otherwise, <see langword="false" />.</param>
	/// <returns>An XML string encoding of the current <see cref="T:System.Security.Cryptography.DSA" /> object.</returns>
	public override string ToXmlString(bool includePrivateParameters)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, exports the <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
	/// <param name="includePrivateParameters">
	///   <see langword="true" /> to include private parameters; otherwise, <see langword="false" />.</param>
	/// <returns>The parameters for <see cref="T:System.Security.Cryptography.DSA" />.</returns>
	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	/// <summary>When overridden in a derived class, imports the specified <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
	/// <param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.DSA" />.</param>
	public abstract void ImportParameters(DSAParameters parameters);
}
