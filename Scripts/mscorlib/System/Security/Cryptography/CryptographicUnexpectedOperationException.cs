using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Cryptography;

/// <summary>The exception that is thrown when an unexpected operation occurs during a cryptographic operation.</summary>
[Serializable]
[ComVisible(true)]
public class CryptographicUnexpectedOperationException : CryptographicException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException" /> class with default properties.</summary>
	public CryptographicUnexpectedOperationException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public CryptographicUnexpectedOperationException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected CryptographicUnexpectedOperationException(SerializationInfo info, StreamingContext context)
	{
	}
}
