using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when there is insufficient execution stack available to allow most methods to execute.</summary>
[Serializable]
public sealed class InsufficientExecutionStackException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.InsufficientExecutionStackException" /> class.</summary>
	public InsufficientExecutionStackException()
	{
	}

	internal InsufficientExecutionStackException(SerializationInfo info, StreamingContext context)
	{
	}
}
