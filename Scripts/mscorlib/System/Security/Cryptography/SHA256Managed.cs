using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA256" /> hash for the input data using the managed library.</summary>
[ComVisible(true)]
public class SHA256Managed : SHA256
{
	private byte[] _buffer;

	private long _count;

	private uint[] _stateSHA256;

	private uint[] _W;

	private static readonly uint[] _K;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.SHA256Managed" /> class using the managed library.</summary>
	/// <exception cref="T:System.InvalidOperationException">The Federal Information Processing Standards (FIPS) security setting is enabled. This implementation is not part of the Windows Platform FIPS-validated cryptographic algorithms.</exception>
	public SHA256Managed()
	{
	}

	/// <summary>Initializes an instance of <see cref="T:System.Security.Cryptography.SHA256Managed" />.</summary>
	public override void Initialize()
	{
	}

	/// <summary>When overridden in a derived class, routes data written to the object into the <see cref="T:System.Security.Cryptography.SHA256" /> hash algorithm for computing the hash.</summary>
	/// <param name="rgb">The input data.</param>
	/// <param name="ibStart">The offset into the byte array from which to begin using data.</param>
	/// <param name="cbSize">The number of bytes in the array to use as data.</param>
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
	{
	}

	/// <summary>When overridden in a derived class, finalizes the hash computation after the last data is processed by the cryptographic stream object.</summary>
	/// <returns>The computed hash code.</returns>
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

	private unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
	{
	}

	private static uint RotateRight(uint x, int n)
	{
		return 0u;
	}

	private static uint Ch(uint x, uint y, uint z)
	{
		return 0u;
	}

	private static uint Maj(uint x, uint y, uint z)
	{
		return 0u;
	}

	private static uint sigma_0(uint x)
	{
		return 0u;
	}

	private static uint sigma_1(uint x)
	{
		return 0u;
	}

	private static uint Sigma_0(uint x)
	{
		return 0u;
	}

	private static uint Sigma_1(uint x)
	{
		return 0u;
	}

	private unsafe static void SHA256Expand(uint* x)
	{
	}
}
