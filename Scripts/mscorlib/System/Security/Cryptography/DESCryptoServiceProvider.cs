using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Defines a wrapper object to access the cryptographic service provider (CSP) version of the Data Encryption Standard (<see cref="T:System.Security.Cryptography.DES" />) algorithm. This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class DESCryptoServiceProvider : DES
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DESCryptoServiceProvider" /> class.</summary>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The Data Encryption Standard (<see cref="T:System.Security.Cryptography.DES" />) cryptographic service provider is not available.</exception>
	public DESCryptoServiceProvider()
	{
	}

	/// <summary>Creates a symmetric Data Encryption Standard (<see cref="T:System.Security.Cryptography.DES" />) encryptor object with the specified key (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
	/// <param name="rgbKey">The secret key to use for the symmetric algorithm.</param>
	/// <param name="rgbIV">The initialization vector to use for the symmetric algorithm.</param>
	/// <returns>A symmetric <see cref="T:System.Security.Cryptography.DES" /> encryptor object.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> property is <see cref="F:System.Security.Cryptography.CipherMode.OFB" />.  
	///  -or-  
	///  The value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> property is <see cref="F:System.Security.Cryptography.CipherMode.CFB" /> and the value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.FeedbackSize" /> property is not 8.  
	///  -or-  
	///  An invalid key size was used.  
	///  -or-  
	///  The algorithm key size was not available.</exception>
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return null;
	}

	/// <summary>Creates a symmetric Data Encryption Standard (<see cref="T:System.Security.Cryptography.DES" />) decryptor object with the specified key (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
	/// <param name="rgbKey">The secret key to use for the symmetric algorithm.</param>
	/// <param name="rgbIV">The initialization vector to use for the symmetric algorithm.</param>
	/// <returns>A symmetric <see cref="T:System.Security.Cryptography.DES" /> decryptor object.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> property is <see cref="F:System.Security.Cryptography.CipherMode.OFB" />.  
	///  -or-  
	///  The value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> property is <see cref="F:System.Security.Cryptography.CipherMode.CFB" /> and the value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.FeedbackSize" /> property is not 8.  
	///  -or-  
	///  An invalid key size was used.  
	///  -or-  
	///  The algorithm key size was not available.</exception>
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return null;
	}

	/// <summary>Generates a random key (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) to be used for the algorithm.</summary>
	public override void GenerateKey()
	{
	}

	/// <summary>Generates a random initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />) to use for the algorithm.</summary>
	public override void GenerateIV()
	{
	}
}
