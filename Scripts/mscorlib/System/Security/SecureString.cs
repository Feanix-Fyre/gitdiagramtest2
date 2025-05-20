namespace System.Security;

/// <summary>Represents text that should be kept confidential, such as by deleting it from computer memory when no longer needed. This class cannot be inherited.</summary>
[MonoTODO("work in progress - encryption is missing")]
public sealed class SecureString : IDisposable
{
	private int length;

	private bool disposed;

	private byte[] data;

	/// <summary>Gets the number of characters in the current secure string.</summary>
	/// <returns>The number of <see cref="T:System.Char" /> objects in this secure string.</returns>
	/// <exception cref="T:System.ObjectDisposedException">This secure string has already been disposed.</exception>
	public int Length => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecureString" /> class.</summary>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error occurred while protecting or unprotecting the value of this instance.</exception>
	/// <exception cref="T:System.NotSupportedException">This operation is not supported on this platform.</exception>
	public SecureString()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecureString" /> class from a subarray of <see cref="T:System.Char" /> objects.  
	///  This constructor is not CLS-compliant. The CLS-compliant alternative is <see cref="M:System.Security.SecureString.#ctor" />.</summary>
	/// <param name="value">A pointer to an array of <see cref="T:System.Char" /> objects.</param>
	/// <param name="length">The number of elements of <paramref name="value" /> to include in the new instance.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="length" /> is less than zero or greater than 65,536.</exception>
	/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error occurred while protecting or unprotecting the value of this secure string.</exception>
	/// <exception cref="T:System.NotSupportedException">This operation is not supported on this platform.</exception>
	[CLSCompliant(false)]
	public unsafe SecureString(char* value, int length)
	{
	}

	/// <summary>Releases all resources used by the current <see cref="T:System.Security.SecureString" /> object.</summary>
	public void Dispose()
	{
	}

	private void Encrypt()
	{
	}

	private void Decrypt()
	{
	}

	private void Alloc(int length, bool realloc)
	{
	}

	internal byte[] GetBuffer()
	{
		return null;
	}
}
