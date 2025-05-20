using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the abstract class from which all implementations of keyed hash algorithms must derive.</summary>
[ComVisible(true)]
public abstract class KeyedHashAlgorithm : HashAlgorithm
{
	/// <summary>The key to use in the hash algorithm.</summary>
	protected byte[] KeyValue;

	/// <summary>Gets or sets the key to use in the hash algorithm.</summary>
	/// <returns>The key to use in the hash algorithm.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An attempt was made to change the <see cref="P:System.Security.Cryptography.KeyedHashAlgorithm.Key" /> property after hashing has begun.</exception>
	public virtual byte[] Key
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.KeyedHashAlgorithm" /> class.</summary>
	protected KeyedHashAlgorithm()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.KeyedHashAlgorithm" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}
}
