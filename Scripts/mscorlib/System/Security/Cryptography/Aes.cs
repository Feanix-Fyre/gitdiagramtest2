using System.Runtime.CompilerServices;

namespace System.Security.Cryptography;

/// <summary>Represents the abstract base class from which all implementations of the Advanced Encryption Standard (AES) must inherit.</summary>
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public abstract class Aes : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes;

	private static KeySizes[] s_legalKeySizes;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Aes" /> class.</summary>
	protected Aes()
	{
	}
}
