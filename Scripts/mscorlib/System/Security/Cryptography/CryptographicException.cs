using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Cryptography;

/// <summary>The exception that is thrown when an error occurs during a cryptographic operation.</summary>
[Serializable]
[ComVisible(true)]
public class CryptographicException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with default properties.</summary>
	public CryptographicException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public CryptographicException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with a specified error message in the specified format.</summary>
	/// <param name="format">The format used to output the error message.</param>
	/// <param name="insert">The error message that explains the reason for the exception.</param>
	public CryptographicException(string format, string insert)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
	public CryptographicException(string message, Exception inner)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with the specified <see langword="HRESULT" /> error code.</summary>
	/// <param name="hr">The <see langword="HRESULT" /> error code.</param>
	public CryptographicException(int hr)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected CryptographicException(SerializationInfo info, StreamingContext context)
	{
	}
}
