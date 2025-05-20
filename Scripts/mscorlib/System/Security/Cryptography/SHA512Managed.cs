using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA512" /> hash algorithm for the input data using the managed library.</summary>
[ComVisible(true)]
public class SHA512Managed : SHA512
{
	private byte[] _buffer;

	private ulong _count;

	private ulong[] _stateSHA512;

	private ulong[] _W;

	private static readonly ulong[] _K;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.SHA512Managed" /> class.</summary>
	/// <exception cref="T:System.InvalidOperationException">The Federal Information Processing Standards (FIPS) security setting is enabled. This implementation is not part of the Windows Platform FIPS-validated cryptographic algorithms.</exception>
	public SHA512Managed()
	{
	}

	/// <summary>Initializes an instance of the <see cref="T:System.Security.Cryptography.SHA512Managed" /> class using the managed library.</summary>
	public override void Initialize()
	{
	}

	/// <summary>When overridden in a derived class, routes data written to the object into the <see cref="T:System.Security.Cryptography.SHA512Managed" /> hash algorithm for computing the hash.</summary>
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

	private unsafe static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block)
	{
	}

	private static ulong RotateRight(ulong x, int n)
	{
		return 0uL;
	}

	private static ulong Ch(ulong x, ulong y, ulong z)
	{
		return 0uL;
	}

	private static ulong Maj(ulong x, ulong y, ulong z)
	{
		return 0uL;
	}

	private static ulong Sigma_0(ulong x)
	{
		return 0uL;
	}

	private static ulong Sigma_1(ulong x)
	{
		return 0uL;
	}

	private static ulong sigma_0(ulong x)
	{
		return 0uL;
	}

	private static ulong sigma_1(ulong x)
	{
		return 0uL;
	}

	private unsafe static void SHA512Expand(ulong* x)
	{
	}
}
