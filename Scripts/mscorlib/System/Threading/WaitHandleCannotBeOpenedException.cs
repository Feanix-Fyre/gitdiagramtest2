using System.Runtime.Serialization;

namespace System.Threading;

/// <summary>The exception that is thrown when an attempt is made to open a system mutex, semaphore, or event wait handle that does not exist.</summary>
[Serializable]
public class WaitHandleCannotBeOpenedException : ApplicationException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.WaitHandleCannotBeOpenedException" /> class with default values.</summary>
	public WaitHandleCannotBeOpenedException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.WaitHandleCannotBeOpenedException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public WaitHandleCannotBeOpenedException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.WaitHandleCannotBeOpenedException" /> class with serialized data.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination.</param>
	protected WaitHandleCannotBeOpenedException(SerializationInfo info, StreamingContext context)
	{
	}
}
