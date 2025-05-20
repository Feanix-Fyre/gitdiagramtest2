using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when a program contains invalid Microsoft intermediate language (MSIL) or metadata. Generally this indicates a bug in the compiler that generated the program.</summary>
[Serializable]
public sealed class InvalidProgramException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.InvalidProgramException" /> class with default properties.</summary>
	public InvalidProgramException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.InvalidProgramException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public InvalidProgramException(string message)
	{
	}

	internal InvalidProgramException(SerializationInfo info, StreamingContext context)
	{
	}
}
