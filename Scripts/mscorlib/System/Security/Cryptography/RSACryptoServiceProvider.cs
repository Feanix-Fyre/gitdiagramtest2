using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography;

/// <summary>Performs asymmetric encryption and decryption using the implementation of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm provided by the cryptographic service provider (CSP). This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class RSACryptoServiceProvider : RSA
{
	private static CspProviderFlags s_UseMachineKeyStore;

	private KeyPairPersistence store;

	private bool persistKey;

	private bool persisted;

	private bool privateKeyExportable;

	private bool m_disposed;

	private RSAManaged rsa;

	/// <summary>Gets or sets a value indicating whether the key should be persisted in the computer's key store instead of the user profile store.</summary>
	/// <returns>
	///   <see langword="true" /> if the key should be persisted in the computer key store; otherwise, <see langword="false" />.</returns>
	public static bool UseMachineKeyStore => false;

	/// <summary>Gets the size of the current key.</summary>
	/// <returns>The size of the key in bits.</returns>
	public override int KeySize => 0;

	/// <summary>Gets a value that indicates whether the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object contains only a public key.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object contains only a public key; otherwise, <see langword="false" />.</returns>
	[ComVisible(false)]
	public bool PublicOnly => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class using the default key.</summary>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.</exception>
	public RSACryptoServiceProvider()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified parameters.</summary>
	/// <param name="parameters">The parameters to be passed to the cryptographic service provider (CSP).</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The CSP cannot be acquired.</exception>
	public RSACryptoServiceProvider(CspParameters parameters)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified key size.</summary>
	/// <param name="dwKeySize">The size of the key to use in bits.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.</exception>
	public RSACryptoServiceProvider(int dwKeySize)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified key size and parameters.</summary>
	/// <param name="dwKeySize">The size of the key to use in bits.</param>
	/// <param name="parameters">The parameters to be passed to the cryptographic service provider (CSP).</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The CSP cannot be acquired.  
	///  -or-  
	///  The key cannot be created.</exception>
	public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
	{
	}

	private void Common(int dwKeySize, bool parameters)
	{
	}

	private void Common(CspParameters p)
	{
	}

	~RSACryptoServiceProvider()
	{
	}

	/// <summary>This method is not supported in the current version.</summary>
	/// <param name="rgb">The data to be encrypted.</param>
	/// <returns>The encrypted data.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported in the current version.</exception>
	public override byte[] EncryptValue(byte[] rgb)
	{
		return null;
	}

	/// <summary>Exports the <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
	/// <param name="includePrivateParameters">
	///   <see langword="true" /> to include private parameters; otherwise, <see langword="false" />.</param>
	/// <returns>The parameters for <see cref="T:System.Security.Cryptography.RSA" />.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key cannot be exported.</exception>
	public override RSAParameters ExportParameters(bool includePrivateParameters)
	{
		return default(RSAParameters);
	}

	/// <summary>Imports the specified <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
	/// <param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.RSA" />.</param>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.  
	///  -or-  
	///  The <paramref name="parameters" /> parameter has missing fields.</exception>
	public override void ImportParameters(RSAParameters parameters)
	{
	}

	private string GetHashNameFromOID(string oid)
	{
		return null;
	}

	/// <summary>Verifies that a digital signature is valid by determining the hash value in the signature using the provided public key and comparing it to the provided hash value.</summary>
	/// <param name="rgbHash">The hash value of the signed data.</param>
	/// <param name="str">The hash algorithm identifier (OID) used to create the hash value of the data.</param>
	/// <param name="rgbSignature">The signature data to be verified.</param>
	/// <returns>
	///   <see langword="true" /> if the signature is valid; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is <see langword="null" />.  
	///  -or-  
	///  The <paramref name="rgbSignature" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.  
	///  -or-  
	///  The signature cannot be verified.</exception>
	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
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
