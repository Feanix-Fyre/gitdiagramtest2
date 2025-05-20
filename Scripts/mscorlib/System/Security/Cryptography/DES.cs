using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the base class for the Data Encryption Standard (DES) algorithm from which all <see cref="T:System.Security.Cryptography.DES" /> implementations must derive.</summary>
[ComVisible(true)]
public abstract class DES : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes;

	private static KeySizes[] s_legalKeySizes;

	/// <summary>Gets or sets the secret key for the Data Encryption Standard (<see cref="T:System.Security.Cryptography.DES" />) algorithm.</summary>
	/// <returns>The secret key for the <see cref="T:System.Security.Cryptography.DES" /> algorithm.</returns>
	/// <exception cref="T:System.ArgumentNullException">An attempt was made to set the key to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">An attempt was made to set a key whose length is not equal to <see cref="F:System.Security.Cryptography.SymmetricAlgorithm.BlockSizeValue" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An attempt was made to set a weak key (see <see cref="M:System.Security.Cryptography.DES.IsWeakKey(System.Byte[])" />) or a semi-weak key (see <see cref="M:System.Security.Cryptography.DES.IsSemiWeakKey(System.Byte[])" />).</exception>
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

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DES" /> class.</summary>
	protected DES()
	{
	}

	/// <summary>Creates an instance of a cryptographic object to perform the Data Encryption Standard (<see cref="T:System.Security.Cryptography.DES" />) algorithm.</summary>
	/// <returns>A cryptographic object.</returns>
	public static DES Create()
	{
		return null;
	}

	/// <summary>Determines whether the specified key is weak.</summary>
	/// <param name="rgbKey">The secret key to test for weakness.</param>
	/// <returns>
	///   <see langword="true" /> if the key is weak; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The size of the <paramref name="rgbKey" /> parameter is not valid.</exception>
	public static bool IsWeakKey(byte[] rgbKey)
	{
		return false;
	}

	/// <summary>Determines whether the specified key is semi-weak.</summary>
	/// <param name="rgbKey">The secret key to test for semi-weakness.</param>
	/// <returns>
	///   <see langword="true" /> if the key is semi-weak; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The size of the <paramref name="rgbKey" /> parameter is not valid.</exception>
	public static bool IsSemiWeakKey(byte[] rgbKey)
	{
		return false;
	}

	private static bool IsLegalKeySize(byte[] rgbKey)
	{
		return false;
	}

	private static ulong QuadWordFromBigEndian(byte[] block)
	{
		return 0uL;
	}
}
