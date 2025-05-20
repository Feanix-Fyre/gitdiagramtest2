using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when a DLL specified in a DLL import cannot be found.</summary>
[Serializable]
public class DllNotFoundException : TypeLoadException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.DllNotFoundException" /> class with default properties.</summary>
	public DllNotFoundException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DllNotFoundException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public DllNotFoundException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DllNotFoundException" /> class with serialized data.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	protected DllNotFoundException(SerializationInfo info, StreamingContext context)
	{
	}
}
