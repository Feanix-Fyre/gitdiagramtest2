using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the abstract class from which all implementations of Hash-based Message Authentication Code (HMAC) must derive.</summary>
[ComVisible(true)]
public abstract class HMAC : KeyedHashAlgorithm
{
	private int blockSizeValue;

	internal string m_hashName;

	internal HashAlgorithm m_hash1;

	internal HashAlgorithm m_hash2;

	private byte[] m_inner;

	private byte[] m_outer;

	private bool m_hashing;

	/// <summary>Gets or sets the block size to use in the hash value.</summary>
	/// <returns>The block size to use in the hash value.</returns>
	protected int BlockSizeValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the key to use in the hash algorithm.</summary>
	/// <returns>The key to use in the hash algorithm.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An attempt is made to change the <see cref="P:System.Security.Cryptography.HMAC.Key" /> property after hashing has begun.</exception>
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

	private void UpdateIOPadBuffers()
	{
	}

	internal void InitializeKey(byte[] key)
	{
	}

	/// <summary>Creates an instance of the default implementation of a Hash-based Message Authentication Code (HMAC).</summary>
	/// <returns>A new SHA-1 instance, unless the default settings have been changed by using the &lt;cryptoClass&gt; element.</returns>
	public static HMAC Create()
	{
		return null;
	}

	/// <summary>Initializes an instance of the default implementation of <see cref="T:System.Security.Cryptography.HMAC" />.</summary>
	public override void Initialize()
	{
	}

	/// <summary>When overridden in a derived class, routes data written to the object into the default <see cref="T:System.Security.Cryptography.HMAC" /> hash algorithm for computing the hash value.</summary>
	/// <param name="rgb">The input data.</param>
	/// <param name="ib">The offset into the byte array from which to begin using data.</param>
	/// <param name="cb">The number of bytes in the array to use as data.</param>
	protected override void HashCore(byte[] rgb, int ib, int cb)
	{
	}

	/// <summary>When overridden in a derived class, finalizes the hash computation after the last data is processed by the cryptographic stream object.</summary>
	/// <returns>The computed hash code in a byte array.</returns>
	protected override byte[] HashFinal()
	{
		return null;
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.HMAC" /> class when a key change is legitimate and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMAC" /> class.</summary>
	protected HMAC()
	{
	}
}
