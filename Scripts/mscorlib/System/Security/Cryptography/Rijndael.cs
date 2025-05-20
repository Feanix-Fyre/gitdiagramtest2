using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the base class from which all implementations of the <see cref="T:System.Security.Cryptography.Rijndael" /> symmetric encryption algorithm must inherit.</summary>
[ComVisible(true)]
public abstract class Rijndael : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes;

	private static KeySizes[] s_legalKeySizes;

	/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.Rijndael" />.</summary>
	protected Rijndael()
	{
	}
}
