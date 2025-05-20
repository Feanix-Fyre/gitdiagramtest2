using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Computes a Message Authentication Code (MAC) using <see cref="T:System.Security.Cryptography.TripleDES" /> for the input data <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary>
[ComVisible(true)]
public class MACTripleDES : KeyedHashAlgorithm
{
	private ICryptoTransform m_encryptor;

	private CryptoStream _cs;

	private TailStream _ts;

	private int m_bytesPerBlock;

	private TripleDES des;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.MACTripleDES" /> class.</summary>
	public MACTripleDES()
	{
	}

	/// <summary>Initializes an instance of <see cref="T:System.Security.Cryptography.MACTripleDES" />.</summary>
	public override void Initialize()
	{
	}

	/// <summary>Routes data written to the object into the <see cref="T:System.Security.Cryptography.TripleDES" /> encryptor for computing the Message Authentication Code (MAC).</summary>
	/// <param name="rgbData">The input data.</param>
	/// <param name="ibStart">The offset into the byte array from which to begin using data.</param>
	/// <param name="cbSize">The number of bytes in the array to use as data.</param>
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize)
	{
	}

	/// <summary>Returns the computed Message Authentication Code (MAC) after all data is written to the object.</summary>
	/// <returns>The computed MAC.</returns>
	protected override byte[] HashFinal()
	{
		return null;
	}

	/// <summary>Releases the resources used by the <see cref="T:System.Security.Cryptography.MACTripleDES" /> instance.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> if the method is called from an <see cref="M:System.IDisposable.Dispose" /> implementation; otherwise, <see langword="false" />.</param>
	protected override void Dispose(bool disposing)
	{
	}
}
