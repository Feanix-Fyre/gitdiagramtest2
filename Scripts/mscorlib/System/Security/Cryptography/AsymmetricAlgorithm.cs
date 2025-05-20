using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the abstract base class from which all implementations of asymmetric algorithms must inherit.</summary>
[ComVisible(true)]
public abstract class AsymmetricAlgorithm : IDisposable
{
	/// <summary>Represents the size, in bits, of the key modulus used by the asymmetric algorithm.</summary>
	protected int KeySizeValue;

	/// <summary>Specifies the key sizes that are supported by the asymmetric algorithm.</summary>
	protected KeySizes[] LegalKeySizesValue;

	/// <summary>Gets or sets the size, in bits, of the key modulus used by the asymmetric algorithm.</summary>
	/// <returns>The size, in bits, of the key modulus used by the asymmetric algorithm.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key modulus size is invalid.</exception>
	public virtual int KeySize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> class.</summary>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">The implementation of the derived class is not valid.</exception>
	protected AsymmetricAlgorithm()
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> class.</summary>
	public void Clear()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> class and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>When overridden in a derived class, reconstructs an <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object from an XML string. Otherwise, throws a <see cref="T:System.NotImplementedException" />.</summary>
	/// <param name="xmlString">The XML string to use to reconstruct the <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object.</param>
	public virtual void FromXmlString(string xmlString)
	{
	}

	/// <summary>When overridden in a derived class, creates and returns an XML string representation of the current <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object. Otherwise, throws a <see cref="T:System.NotImplementedException" />.</summary>
	/// <param name="includePrivateParameters">
	///   <see langword="true" /> to include private parameters; otherwise, <see langword="false" />.</param>
	/// <returns>An XML string encoding of the current <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> object.</returns>
	public virtual string ToXmlString(bool includePrivateParameters)
	{
		return null;
	}
}
