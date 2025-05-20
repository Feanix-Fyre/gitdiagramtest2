using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Computes the <see cref="T:System.Security.Cryptography.RIPEMD160" /> hash for the input data using the managed library.</summary>
[ComVisible(true)]
public class RIPEMD160Managed : RIPEMD160
{
	private byte[] _buffer;

	private long _count;

	private uint[] _stateMD160;

	private uint[] _blockDWords;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RIPEMD160" /> class.</summary>
	/// <exception cref="T:System.InvalidOperationException">The policy is not compliant with the FIPS algorithm.</exception>
	public RIPEMD160Managed()
	{
	}

	/// <summary>Initializes an instance of the <see cref="T:System.Security.Cryptography.RIPEMD160Managed" /> class using the managed library.</summary>
	public override void Initialize()
	{
	}

	/// <summary>When overridden in a derived class, routes data written to the object into the <see cref="T:System.Security.Cryptography.RIPEMD160" /> hash algorithm for computing the hash.</summary>
	/// <param name="rgb">The input data.</param>
	/// <param name="ibStart">The offset into the byte array from which to begin using data.</param>
	/// <param name="cbSize">The number of bytes in the array to use as data.</param>
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
	{
	}

	/// <summary>When overridden in a derived class, finalizes the hash computation after the last data is processed by the cryptographic stream object.</summary>
	/// <returns>The computed hash code in a byte array.</returns>
	protected override byte[] HashFinal()
	{
		return null;
	}

	private void InitializeState()
	{
	}

	private void _HashData(byte[] partIn, int ibStart, int cbSize)
	{
	}

	private byte[] _EndHash()
	{
		return null;
	}

	private unsafe static void MDTransform(uint* blockDWords, uint* state, byte* block)
	{
	}

	private static uint F(uint x, uint y, uint z)
	{
		return 0u;
	}

	private static uint G(uint x, uint y, uint z)
	{
		return 0u;
	}

	private static uint H(uint x, uint y, uint z)
	{
		return 0u;
	}

	private static uint I(uint x, uint y, uint z)
	{
		return 0u;
	}

	private static uint J(uint x, uint y, uint z)
	{
		return 0u;
	}
}
