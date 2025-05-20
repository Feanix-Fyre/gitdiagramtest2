using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Computes a Hash-based Message Authentication Code (HMAC) using the <see cref="T:System.Security.Cryptography.SHA512" /> hash function.</summary>
[ComVisible(true)]
public class HMACSHA512 : HMAC
{
	private bool m_useLegacyBlockSize;

	private int BlockSize => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMACSHA512" /> class with a randomly generated key.</summary>
	public HMACSHA512()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMACSHA512" /> class with the specified key data.</summary>
	/// <param name="key">The secret key for <see cref="T:System.Security.Cryptography.HMACSHA512" /> encryption. The key can be any length. However, the recommended size is 128 bytes. If the key is more than 128 bytes long, it is hashed (using SHA-512) to derive a 128-byte key. If it is less than 128 bytes long, it is padded to 128 bytes.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="key" /> parameter is <see langword="null" />.</exception>
	public HMACSHA512(byte[] key)
	{
	}
}
