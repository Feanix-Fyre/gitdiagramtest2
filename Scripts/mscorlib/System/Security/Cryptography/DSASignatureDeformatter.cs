using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Verifies a Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) PKCS#1 v1.5 signature.</summary>
[ComVisible(true)]
public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
{
	private DSA _dsaKey;

	private string _oid;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSASignatureDeformatter" /> class.</summary>
	public DSASignatureDeformatter()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSASignatureDeformatter" /> class with the specified key.</summary>
	/// <param name="key">The instance of Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) that holds the key.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public DSASignatureDeformatter(AsymmetricAlgorithm key)
	{
	}

	/// <summary>Specifies the key to be used for the Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) signature deformatter.</summary>
	/// <param name="key">The instance of <see cref="T:System.Security.Cryptography.DSA" /> that holds the key.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public override void SetKey(AsymmetricAlgorithm key)
	{
	}

	/// <summary>Specifies the hash algorithm for the Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) signature deformatter.</summary>
	/// <param name="strName">The name of the hash algorithm to use for the signature deformatter.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The <paramref name="strName" /> parameter does not map to the <see cref="T:System.Security.Cryptography.SHA1" /> hash algorithm.</exception>
	public override void SetHashAlgorithm(string strName)
	{
	}

	/// <summary>Verifies the Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) signature on the data.</summary>
	/// <param name="rgbHash">The data signed with <paramref name="rgbSignature" />.</param>
	/// <param name="rgbSignature">The signature to be verified for <paramref name="rgbHash" />.</param>
	/// <returns>
	///   <see langword="true" /> if the signature is valid for the data; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="rgbHash" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="rgbSignature" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The DSA key is missing.</exception>
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
	{
		return false;
	}
}
