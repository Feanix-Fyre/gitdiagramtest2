namespace System.Security.Cryptography;

/// <summary>Represents the base class from which all implementations of cryptographic hash algorithms must derive.</summary>
public abstract class HashAlgorithm : IDisposable, ICryptoTransform
{
	private bool _disposed;

	/// <summary>Represents the size, in bits, of the computed hash code.</summary>
	protected int HashSizeValue;

	/// <summary>Represents the value of the computed hash code.</summary>
	protected internal byte[] HashValue;

	/// <summary>Represents the state of the hash computation.</summary>
	protected int State;

	/// <summary>Gets the size, in bits, of the computed hash code.</summary>
	/// <returns>The size, in bits, of the computed hash code.</returns>
	public virtual int HashSize => 0;

	/// <summary>Gets the value of the computed hash code.</summary>
	/// <returns>The current value of the computed hash code.</returns>
	/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">
	///   <see cref="F:System.Security.Cryptography.HashAlgorithm.HashValue" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
	public virtual byte[] Hash => null;

	/// <summary>When overridden in a derived class, gets the input block size.</summary>
	/// <returns>The input block size.</returns>
	public virtual int InputBlockSize => 0;

	/// <summary>When overridden in a derived class, gets the output block size.</summary>
	/// <returns>The output block size.</returns>
	public virtual int OutputBlockSize => 0;

	/// <summary>When overridden in a derived class, gets a value indicating whether multiple blocks can be transformed.</summary>
	/// <returns>
	///   <see langword="true" /> if multiple blocks can be transformed; otherwise, <see langword="false" />.</returns>
	public virtual bool CanTransformMultipleBlocks => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> class.</summary>
	protected HashAlgorithm()
	{
	}

	/// <summary>Creates an instance of the specified implementation of a hash algorithm.</summary>
	/// <param name="hashName">The hash algorithm implementation to use. The following table shows the valid values for the <paramref name="hashName" /> parameter and the algorithms they map to.  
	///   Parameter value  
	///
	///   Implements  
	///
	///   SHA  
	///
	///  <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" /> SHA1  
	///
	///  <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" /> System.Security.Cryptography.SHA1  
	///
	///  <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" /> System.Security.Cryptography.HashAlgorithm  
	///
	///  <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" /> MD5  
	///
	///  <see cref="T:System.Security.Cryptography.MD5CryptoServiceProvider" /> System.Security.Cryptography.MD5  
	///
	///  <see cref="T:System.Security.Cryptography.MD5CryptoServiceProvider" /> SHA256  
	///
	///  <see cref="T:System.Security.Cryptography.SHA256Managed" /> SHA-256  
	///
	///  <see cref="T:System.Security.Cryptography.SHA256Managed" /> System.Security.Cryptography.SHA256  
	///
	///  <see cref="T:System.Security.Cryptography.SHA256Managed" /> SHA384  
	///
	///  <see cref="T:System.Security.Cryptography.SHA384Managed" /> SHA-384  
	///
	///  <see cref="T:System.Security.Cryptography.SHA384Managed" /> System.Security.Cryptography.SHA384  
	///
	///  <see cref="T:System.Security.Cryptography.SHA384Managed" /> SHA512  
	///
	///  <see cref="T:System.Security.Cryptography.SHA512Managed" /> SHA-512  
	///
	///  <see cref="T:System.Security.Cryptography.SHA512Managed" /> System.Security.Cryptography.SHA512  
	///
	///  <see cref="T:System.Security.Cryptography.SHA512Managed" /></param>
	/// <returns>A new instance of the specified hash algorithm, or <see langword="null" /> if <paramref name="hashName" /> is not a valid hash algorithm.</returns>
	public static HashAlgorithm Create(string hashName)
	{
		return null;
	}

	/// <summary>Computes the hash value for the specified byte array.</summary>
	/// <param name="buffer">The input to compute the hash code for.</param>
	/// <returns>The computed hash code.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
	public byte[] ComputeHash(byte[] buffer)
	{
		return null;
	}

	/// <summary>Computes the hash value for the specified region of the specified byte array.</summary>
	/// <param name="buffer">The input to compute the hash code for.</param>
	/// <param name="offset">The offset into the byte array from which to begin using data.</param>
	/// <param name="count">The number of bytes in the array to use as data.</param>
	/// <returns>The computed hash code.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="count" /> is an invalid value.  
	/// -or-  
	/// <paramref name="buffer" /> length is invalid.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is out of range. This parameter requires a non-negative number.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
	public byte[] ComputeHash(byte[] buffer, int offset, int count)
	{
		return null;
	}

	private byte[] CaptureHashCodeAndReinitialize()
	{
		return null;
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> class.</summary>
	public void Clear()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Computes the hash value for the specified region of the input byte array and copies the specified region of the input byte array to the specified region of the output byte array.</summary>
	/// <param name="inputBuffer">The input to compute the hash code for.</param>
	/// <param name="inputOffset">The offset into the input byte array from which to begin using data.</param>
	/// <param name="inputCount">The number of bytes in the input byte array to use as data.</param>
	/// <param name="outputBuffer">A copy of the part of the input array used to compute the hash code.</param>
	/// <param name="outputOffset">The offset into the output byte array from which to begin writing data.</param>
	/// <returns>The number of bytes written.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="inputCount" /> uses an invalid value.  
	/// -or-  
	/// <paramref name="inputBuffer" /> has an invalid length.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="inputBuffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="inputOffset" /> is out of range. This parameter requires a non-negative number.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		return 0;
	}

	/// <summary>Computes the hash value for the specified region of the specified byte array.</summary>
	/// <param name="inputBuffer">The input to compute the hash code for.</param>
	/// <param name="inputOffset">The offset into the byte array from which to begin using data.</param>
	/// <param name="inputCount">The number of bytes in the byte array to use as data.</param>
	/// <returns>An array that is a copy of the part of the input that is hashed.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="inputCount" /> uses an invalid value.  
	/// -or-  
	/// <paramref name="inputBuffer" /> has an invalid offset length.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="inputBuffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="inputOffset" /> is out of range. This parameter requires a non-negative number.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		return null;
	}

	private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
	}

	/// <summary>When overridden in a derived class, routes data written to the object into the hash algorithm for computing the hash.</summary>
	/// <param name="array">The input to compute the hash code for.</param>
	/// <param name="ibStart">The offset into the byte array from which to begin using data.</param>
	/// <param name="cbSize">The number of bytes in the byte array to use as data.</param>
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	/// <summary>When overridden in a derived class, finalizes the hash computation after the last data is processed by the cryptographic stream object.</summary>
	/// <returns>The computed hash code.</returns>
	protected abstract byte[] HashFinal();

	/// <summary>Initializes an implementation of the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> class.</summary>
	public abstract void Initialize();
}
