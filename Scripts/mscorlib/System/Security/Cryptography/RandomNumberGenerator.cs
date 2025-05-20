using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

/// <summary>Represents the abstract class from which all implementations of cryptographic random number generators derive.</summary>
[ComVisible(true)]
public abstract class RandomNumberGenerator : IDisposable
{
	/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.RandomNumberGenerator" />.</summary>
	protected RandomNumberGenerator()
	{
	}

	/// <summary>Creates an instance of the default implementation of a cryptographic random number generator that can be used to generate random data.</summary>
	/// <returns>A new instance of a cryptographic random number generator.</returns>
	public static RandomNumberGenerator Create()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, releases all resources used by the current instance of the <see cref="T:System.Security.Cryptography.RandomNumberGenerator" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>When overridden in a derived class, releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.RandomNumberGenerator" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>When overridden in a derived class, fills an array of bytes with a cryptographically strong random sequence of values.</summary>
	/// <param name="data">The array to fill with cryptographically strong random bytes.</param>
	public abstract void GetBytes(byte[] data);
}
