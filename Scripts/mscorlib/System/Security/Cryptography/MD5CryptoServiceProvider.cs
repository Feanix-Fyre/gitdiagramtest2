using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Computes the <see cref="T:System.Security.Cryptography.MD5" /> hash value for the input data using the implementation provided by the cryptographic service provider (CSP). This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class MD5CryptoServiceProvider : MD5
{
	private uint[] _H;

	private uint[] buff;

	private ulong count;

	private byte[] _ProcessingBuffer;

	private int _ProcessingBufferCount;

	private static readonly uint[] K;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.MD5CryptoServiceProvider" /> class.</summary>
	/// <exception cref="T:System.InvalidOperationException">A FIPS-compliant algorithm policy is not being used.</exception>
	public MD5CryptoServiceProvider()
	{
	}

	~MD5CryptoServiceProvider()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
	{
	}

	protected override byte[] HashFinal()
	{
		return null;
	}

	/// <summary>Initializes an instance of <see cref="T:System.Security.Cryptography.MD5CryptoServiceProvider" />.</summary>
	public override void Initialize()
	{
	}

	private void ProcessBlock(byte[] inputBuffer, int inputOffset)
	{
	}

	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
	}

	internal void AddLength(ulong length, byte[] buffer, int position)
	{
	}
}
