using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the abstract base class from which all implementations of asymmetric signature deformatters derive.</summary>
[ComVisible(true)]
public abstract class AsymmetricSignatureDeformatter
{
	/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.AsymmetricSignatureDeformatter" />.</summary>
	protected AsymmetricSignatureDeformatter()
	{
	}

	/// <summary>When overridden in a derived class, sets the public key to use for verifying the signature.</summary>
	/// <param name="key">The instance of an implementation of <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> that holds the public key.</param>
	public abstract void SetKey(AsymmetricAlgorithm key);

	/// <summary>When overridden in a derived class, sets the hash algorithm to use for verifying the signature.</summary>
	/// <param name="strName">The name of the hash algorithm to use for verifying the signature.</param>
	public abstract void SetHashAlgorithm(string strName);

	/// <summary>When overridden in a derived class, verifies the signature for the specified data.</summary>
	/// <param name="rgbHash">The data signed with <paramref name="rgbSignature" />.</param>
	/// <param name="rgbSignature">The signature to be verified for <paramref name="rgbHash" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="rgbSignature" /> matches the signature computed using the specified hash algorithm and key on <paramref name="rgbHash" />; otherwise, <see langword="false" />.</returns>
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
}
