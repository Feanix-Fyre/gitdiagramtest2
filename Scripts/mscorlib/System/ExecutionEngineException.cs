using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when there is an internal error in the execution engine of the common language runtime. This class cannot be inherited.</summary>
[Serializable]
[Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
public sealed class ExecutionEngineException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.ExecutionEngineException" /> class.</summary>
	public ExecutionEngineException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ExecutionEngineException" /> class with a specified error message.</summary>
	/// <param name="message">The message that describes the error.</param>
	public ExecutionEngineException(string message)
	{
	}

	internal ExecutionEngineException(SerializationInfo info, StreamingContext context)
	{
	}
}
