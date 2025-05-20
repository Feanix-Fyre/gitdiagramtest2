namespace System.Security.Cryptography;

/// <summary>Performs symmetric encryption and decryption using the Cryptographic Application Programming Interfaces (CAPI) implementation of the Advanced Encryption Standard (AES) algorithm. </summary>
public sealed class AesCryptoServiceProvider : Aes
{
	public override byte[] IV
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the symmetric key that is used for encryption and decryption.</summary>
	/// <returns>The symmetric key that is used for encryption and decryption.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value for the key is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The size of the key is invalid.</exception>
	public override byte[] Key
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the size, in bits, of the secret key. </summary>
	/// <returns>The size, in bits, of the key.</returns>
	public override int KeySize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override int FeedbackSize => 0;

	public override CipherMode Mode
	{
		get
		{
			return default(CipherMode);
		}
		set
		{
		}
	}

	public override PaddingMode Padding
	{
		get
		{
			return default(PaddingMode);
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AesCryptoServiceProvider" /> class. </summary>
	/// <exception cref="T:System.PlatformNotSupportedException">There is no supported key size for the current platform.</exception>
	public AesCryptoServiceProvider()
	{
	}

	/// <summary>Generates a random initialization vector (IV) to use for the algorithm.</summary>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The initialization vector (IV) could not be generated. </exception>
	public override void GenerateIV()
	{
	}

	/// <summary>Generates a random key to use for the algorithm. </summary>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key could not be generated.</exception>
	public override void GenerateKey()
	{
	}

	/// <summary>Creates a symmetric AES decryptor object using the specified key and initialization vector (IV).</summary>
	/// <param name="key">The secret key to use for the symmetric algorithm.</param>
	/// <param name="iv">The initialization vector to use for the symmetric algorithm.</param>
	/// <returns>A symmetric AES decryptor object.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="key" /> or <paramref name="iv" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="key" /> is invalid.</exception>
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
	{
		return null;
	}

	/// <summary>Creates a symmetric encryptor object using the specified key and initialization vector (IV).</summary>
	/// <param name="key">The secret key to use for the symmetric algorithm.</param>
	/// <param name="iv">The initialization vector to use for the symmetric algorithm.</param>
	/// <returns>A symmetric AES encryptor object.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="key" /> or <paramref name="iv" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="key" /> is invalid.</exception>
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
	{
		return null;
	}

	/// <summary>Creates a symmetric AES decryptor object using the current key and initialization vector (IV).</summary>
	/// <returns>A symmetric AES decryptor object.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The current key is invalid or missing.</exception>
	public override ICryptoTransform CreateDecryptor()
	{
		return null;
	}

	/// <summary>Creates a symmetric AES encryptor object using the current key and initialization vector (IV).</summary>
	/// <returns>A symmetric AES encryptor object.</returns>
	public override ICryptoTransform CreateEncryptor()
	{
		return null;
	}

	protected override void Dispose(bool disposing)
	{
	}
}
