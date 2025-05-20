namespace System.Security.Cryptography;

/// <summary>Provides methods for encrypting and decrypting data. This class cannot be inherited.</summary>
public static class ProtectedData
{
	private static readonly byte[] s_nonEmpty;

	/// <summary>Encrypts the data in a specified byte array and returns a byte array that contains the encrypted data.</summary>
	/// <param name="userData">A byte array that contains data to encrypt.</param>
	/// <param name="optionalEntropy">An optional additional byte array used to increase the complexity of the encryption, or <see langword="null" /> for no additional complexity.</param>
	/// <param name="scope">One of the enumeration values that specifies the scope of encryption.</param>
	/// <returns>A byte array representing the encrypted data.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="userData" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The encryption failed.</exception>
	/// <exception cref="T:System.NotSupportedException">The operating system does not support this method.</exception>
	/// <exception cref="T:System.OutOfMemoryException">The system ran out of memory while encrypting the data.</exception>
	public static byte[] Protect(byte[] userData, byte[] optionalEntropy, DataProtectionScope scope)
	{
		return null;
	}

	/// <summary>Decrypts the data in a specified byte array and returns a byte array that contains the decrypted data.</summary>
	/// <param name="encryptedData">A byte array containing data encrypted using the <see cref="M:System.Security.Cryptography.ProtectedData.Protect(System.Byte[],System.Byte[],System.Security.Cryptography.DataProtectionScope)" /> method.</param>
	/// <param name="optionalEntropy">An optional additional byte array that was used to encrypt the data, or <see langword="null" /> if the additional byte array was not used.</param>
	/// <param name="scope">One of the enumeration values that specifies the scope of data protection that was used to encrypt the data.</param>
	/// <returns>A byte array representing the decrypted data.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="encryptedData" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The decryption failed.</exception>
	/// <exception cref="T:System.NotSupportedException">The operating system does not support this method.</exception>
	/// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
	public static byte[] Unprotect(byte[] encryptedData, byte[] optionalEntropy, DataProtectionScope scope)
	{
		return null;
	}

	private static byte[] ProtectOrUnprotect(byte[] inputData, byte[] optionalEntropy, DataProtectionScope scope, bool protect)
	{
		return null;
	}

	private static bool ErrorMayBeCausedByUnloadedProfile(int errorCode)
	{
		return false;
	}
}
