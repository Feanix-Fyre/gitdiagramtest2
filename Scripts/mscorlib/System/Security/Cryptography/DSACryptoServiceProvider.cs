using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography;

/// <summary>Defines a wrapper object to access the cryptographic service provider (CSP) implementation of the <see cref="T:System.Security.Cryptography.DSA" /> algorithm. This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class DSACryptoServiceProvider : DSA
{
	private KeyPairPersistence store;

	private bool persistKey;

	private bool persisted;

	private bool privateKeyExportable;

	private bool m_disposed;

	private DSAManaged dsa;

	private static bool useMachineKeyStore;

	/// <summary>Gets the size of the key used by the asymmetric algorithm in bits.</summary>
	/// <returns>The size of the key used by the asymmetric algorithm.</returns>
	public override int KeySize => 0;

	/// <summary>Gets a value that indicates whether the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object contains only a public key.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object contains only a public key; otherwise, <see langword="false" />.</returns>
	[ComVisible(false)]
	public bool PublicOnly => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class.</summary>
	public DSACryptoServiceProvider()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class with the specified key size.</summary>
	/// <param name="dwKeySize">The size of the key for the asymmetric algorithm in bits.</param>
	public DSACryptoServiceProvider(int dwKeySize)
	{
	}

	private void Common(int dwKeySize, bool parameters)
	{
	}

	~DSACryptoServiceProvider()
	{
	}

	/// <summary>Exports the <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
	/// <param name="includePrivateParameters">
	///   <see langword="true" /> to include private parameters; otherwise, <see langword="false" />.</param>
	/// <returns>The parameters for <see cref="T:System.Security.Cryptography.DSA" />.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key cannot be exported.</exception>
	public override DSAParameters ExportParameters(bool includePrivateParameters)
	{
		return default(DSAParameters);
	}

	/// <summary>Imports the specified <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
	/// <param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.DSA" />.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.  
	///  -or-  
	///  The <paramref name="parameters" /> parameter has missing fields.</exception>
	public override void ImportParameters(DSAParameters parameters)
	{
	}

	/// <summary>Verifies the <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</summary>
	/// <param name="rgbHash">The data signed with <paramref name="rgbSignature" />.</param>
	/// <param name="rgbSignature">The signature to be verified for <paramref name="rgbData" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="rgbSignature" /> matches the signature computed using the specified hash algorithm and key on <paramref name="rgbHash" />; otherwise, <see langword="false" />.</returns>
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
	{
		return false;
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void OnKeyGenerated(object sender, EventArgs e)
	{
	}
}
