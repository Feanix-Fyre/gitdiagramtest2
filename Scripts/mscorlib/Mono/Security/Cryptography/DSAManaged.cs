using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Mono.Math;

namespace Mono.Security.Cryptography;

internal class DSAManaged : DSA
{
	public delegate void KeyGeneratedEventHandler(object sender, EventArgs e);

	private bool keypairGenerated;

	private bool m_disposed;

	private BigInteger p;

	private BigInteger q;

	private BigInteger g;

	private BigInteger x;

	private BigInteger y;

	private BigInteger j;

	private BigInteger seed;

	private int counter;

	private bool j_missing;

	private RandomNumberGenerator rng;

	private RandomNumberGenerator Random => null;

	public override int KeySize => 0;

	public bool PublicOnly => false;

	public event KeyGeneratedEventHandler KeyGenerated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public DSAManaged(int dwKeySize)
	{
	}

	~DSAManaged()
	{
	}

	private void Generate()
	{
	}

	private void GenerateKeyPair()
	{
	}

	private void add(byte[] a, byte[] b, int value)
	{
	}

	private void GenerateParams(int keyLength)
	{
	}

	private byte[] NormalizeArray(byte[] array)
	{
		return null;
	}

	public override DSAParameters ExportParameters(bool includePrivateParameters)
	{
		return default(DSAParameters);
	}

	public override void ImportParameters(DSAParameters parameters)
	{
	}

	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
	{
		return false;
	}

	protected override void Dispose(bool disposing)
	{
	}
}
