using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Verifies an <see cref="T:System.Security.Cryptography.RSA" /> PKCS #1 version 1.5 signature.</summary>
[ComVisible(true)]
public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
{
	private RSA rsa;

	private string hashName;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAPKCS1SignatureDeformatter" /> class.</summary>
	public RSAPKCS1SignatureDeformatter()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAPKCS1SignatureDeformatter" /> class with the specified key.</summary>
	/// <param name="key">The instance of <see cref="T:System.Security.Cryptography.RSA" /> that holds the public key.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key)
	{
	}

	/// <summary>Sets the hash algorithm to use for verifying the signature.</summary>
	/// <param name="strName">The name of the hash algorithm to use for verifying the signature.</param>
	public override void SetHashAlgorithm(string strName)
	{
	}

	/// <summary>Sets the public key to use for verifying the signature.</summary>
	/// <param name="key">The instance of <see cref="T:System.Security.Cryptography.RSA" /> that holds the public key.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public override void SetKey(AsymmetricAlgorithm key)
	{
	}

	/// <summary>Verifies the <see cref="T:System.Security.Cryptography.RSA" /> PKCS#1 signature for the specified data.</summary>
	/// <param name="rgbHash">The data signed with <paramref name="rgbSignature" />.</param>
	/// <param name="rgbSignature">The signature to be verified for <paramref name="rgbHash" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="rgbSignature" /> matches the signature computed using the specified hash algorithm and key on <paramref name="rgbHash" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The key is <see langword="null" />.  
	///  -or-  
	///  The hash algorithm is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is <see langword="null" />.  
	///  -or-  
	///  The <paramref name="rgbSignature" /> parameter is <see langword="null" />.</exception>
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
	{
		return false;
	}
}
