using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA1" /> hash for the input data using the managed library.</summary>
[ComVisible(true)]
public class SHA1Managed : SHA1
{
	private byte[] _buffer;

	private long _count;

	private uint[] _stateSHA1;

	private uint[] _expandedBuffer;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.SHA1Managed" /> class.</summary>
	/// <exception cref="T:System.InvalidOperationException">This class is not compliant with the FIPS algorithm.</exception>
	public SHA1Managed()
	{
	}

	/// <summary>Initializes an instance of <see cref="T:System.Security.Cryptography.SHA1Managed" />.</summary>
	public override void Initialize()
	{
	}

	/// <summary>Routes data written to the object into the <see cref="T:System.Security.Cryptography.SHA1Managed" /> hash algorithm for computing the hash.</summary>
	/// <param name="rgb">The input data.</param>
	/// <param name="ibStart">The offset into the byte array from which to begin using data.</param>
	/// <param name="cbSize">The number of bytes in the array to use as data.</param>
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
	{
	}

	/// <summary>Returns the computed <see cref="T:System.Security.Cryptography.SHA1" /> hash value after all data has been written to the object.</summary>
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

	private unsafe static void SHAExpand(uint* x)
	{
	}
}
