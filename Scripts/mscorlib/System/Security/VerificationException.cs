using System.Runtime.Serialization;

namespace System.Security;

/// <summary>The exception that is thrown when the security policy requires code to be type safe and the verification process is unable to verify that the code is type safe.</summary>
[Serializable]
public class VerificationException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Security.VerificationException" /> class with default properties.</summary>
	public VerificationException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.VerificationException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected VerificationException(SerializationInfo info, StreamingContext context)
	{
	}
}
