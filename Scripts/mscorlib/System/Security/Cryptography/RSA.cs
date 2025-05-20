using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the base class from which all implementations of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm inherit.</summary>
[ComVisible(true)]
public abstract class RSA : AsymmetricAlgorithm
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSA" /> class.</summary>
	protected RSA()
	{
	}

	/// <summary>Creates an instance of the default implementation of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
	/// <returns>A new instance of the default implementation of <see cref="T:System.Security.Cryptography.RSA" />.</returns>
	public static RSA Create()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, encrypts the input data using the public key.</summary>
	/// <param name="rgb">The plain text to be encrypted.</param>
	/// <returns>The resulting encryption of the <paramref name="rgb" /> parameter as cipher text.</returns>
	/// <exception cref="T:System.NotSupportedException">This method call is not supported. This exception is thrown starting with the .NET Framework 4.6.</exception>
	public virtual byte[] EncryptValue(byte[] rgb)
	{
		return null;
	}

	/// <summary>Initializes an <see cref="T:System.Security.Cryptography.RSA" /> object from the key information from an XML string.</summary>
	/// <param name="xmlString">The XML string containing <see cref="T:System.Security.Cryptography.RSA" /> key information.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="xmlString" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The format of the <paramref name="xmlString" /> parameter is not valid.</exception>
	/// <exception cref="T:System.PlatformNotSupportedException">.NET Core only: This member is not supported.</exception>
	public override void FromXmlString(string xmlString)
	{
	}

	/// <summary>Creates and returns an XML string containing the key of the current <see cref="T:System.Security.Cryptography.RSA" /> object.</summary>
	/// <param name="includePrivateParameters">
	///   <see langword="true" /> to include a public and private RSA key; <see langword="false" /> to include only the public key.</param>
	/// <returns>An XML string containing the key of the current <see cref="T:System.Security.Cryptography.RSA" /> object.</returns>
	/// <exception cref="T:System.PlatformNotSupportedException">.NET Core only: This member is not supported.</exception>
	public override string ToXmlString(bool includePrivateParameters)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, exports the <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
	/// <param name="includePrivateParameters">
	///   <see langword="true" /> to include private parameters; otherwise, <see langword="false" />.</param>
	/// <returns>The parameters for <see cref="T:System.Security.Cryptography.RSA" />.</returns>
	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	/// <summary>When overridden in a derived class, imports the specified <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
	/// <param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.RSA" />.</param>
	public abstract void ImportParameters(RSAParameters parameters);
}
