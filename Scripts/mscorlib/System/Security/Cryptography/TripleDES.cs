using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the base class for Triple Data Encryption Standard algorithms from which all <see cref="T:System.Security.Cryptography.TripleDES" /> implementations must derive.</summary>
[ComVisible(true)]
public abstract class TripleDES : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes;

	private static KeySizes[] s_legalKeySizes;

	/// <summary>Gets or sets the secret key for the <see cref="T:System.Security.Cryptography.TripleDES" /> algorithm.</summary>
	/// <returns>The secret key for the <see cref="T:System.Security.Cryptography.TripleDES" /> algorithm.</returns>
	/// <exception cref="T:System.ArgumentNullException">An attempt was made to set the key to <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An attempt was made to set a key whose length is invalid.  
	///  -or-  
	///  An attempt was made to set a weak key (see <see cref="M:System.Security.Cryptography.TripleDES.IsWeakKey(System.Byte[])" />).</exception>
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

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.TripleDES" /> class.</summary>
	protected TripleDES()
	{
	}

	/// <summary>Creates an instance of a cryptographic object to perform the <see cref="T:System.Security.Cryptography.TripleDES" /> algorithm.</summary>
	/// <returns>An instance of a cryptographic object.</returns>
	public static TripleDES Create()
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

	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count)
	{
		return false;
	}

	private static bool IsLegalKeySize(byte[] rgbKey)
	{
		return false;
	}
}
