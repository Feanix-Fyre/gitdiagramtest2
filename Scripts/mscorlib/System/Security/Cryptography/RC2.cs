using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the base class from which all implementations of the <see cref="T:System.Security.Cryptography.RC2" /> algorithm must derive.</summary>
[ComVisible(true)]
public abstract class RC2 : SymmetricAlgorithm
{
	/// <summary>Represents the effective size of the secret key used by the <see cref="T:System.Security.Cryptography.RC2" /> algorithm in bits.</summary>
	protected int EffectiveKeySizeValue;

	private static KeySizes[] s_legalBlockSizes;

	private static KeySizes[] s_legalKeySizes;

	/// <summary>Gets or sets the effective size of the secret key used by the <see cref="T:System.Security.Cryptography.RC2" /> algorithm in bits.</summary>
	/// <returns>The effective key size used by the <see cref="T:System.Security.Cryptography.RC2" /> algorithm.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The effective key size is invalid.</exception>
	public virtual int EffectiveKeySize => 0;

	/// <summary>Gets or sets the size of the secret key used by the <see cref="T:System.Security.Cryptography.RC2" /> algorithm in bits.</summary>
	/// <returns>The size of the secret key used by the <see cref="T:System.Security.Cryptography.RC2" /> algorithm.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The value for the RC2 key size is less than the effective key size value.</exception>
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

	/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.RC2" />.</summary>
	protected RC2()
	{
	}
}
