using System.Runtime.Serialization;

namespace System.Threading;

/// <summary>The exception that is thrown when the <see cref="Overload:System.Threading.Semaphore.Release" /> method is called on a semaphore whose count is already at the maximum.</summary>
[Serializable]
public class SemaphoreFullException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.SemaphoreFullException" /> class with default values.</summary>
	public SemaphoreFullException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.SemaphoreFullException" /> class with serialized data.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination.</param>
	protected SemaphoreFullException(SerializationInfo info, StreamingContext context)
	{
	}
}
