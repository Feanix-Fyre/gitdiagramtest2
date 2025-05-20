namespace System.Security.Cryptography;

/// <summary>Implements a cryptographic Random Number Generator (RNG) using the implementation provided by the cryptographic service provider (CSP). This class cannot be inherited.</summary>
public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
{
	private static object _lock;

	private IntPtr _handle;

	static RNGCryptoServiceProvider()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RNGCryptoServiceProvider" /> class.</summary>
	public RNGCryptoServiceProvider()
	{
	}

	private void Check()
	{
	}

	private static bool RngOpen()
	{
		return false;
	}

	private unsafe static IntPtr RngInitialize(byte* seed, IntPtr seed_length)
	{
		return (IntPtr)0;
	}

	private unsafe static IntPtr RngGetBytes(IntPtr handle, byte* data, IntPtr data_length)
	{
		return (IntPtr)0;
	}

	private static void RngClose(IntPtr handle)
	{
	}

	/// <summary>Fills an array of bytes with a cryptographically strong sequence of random values.</summary>
	/// <param name="data">The array to fill with a cryptographically strong sequence of random values.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="data" /> is <see langword="null" />.</exception>
	public override void GetBytes(byte[] data)
	{
	}

	~RNGCryptoServiceProvider()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
