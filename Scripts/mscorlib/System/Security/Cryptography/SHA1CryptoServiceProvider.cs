using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA1" /> hash value for the input data using the implementation provided by the cryptographic service provider (CSP). This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class SHA1CryptoServiceProvider : SHA1
{
	private SHA1Internal sha;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" /> class.</summary>
	public SHA1CryptoServiceProvider()
	{
	}

	~SHA1CryptoServiceProvider()
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

	/// <summary>Initializes an instance of <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" />.</summary>
	public override void Initialize()
	{
	}
}
