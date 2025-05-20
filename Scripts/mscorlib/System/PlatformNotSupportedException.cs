using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when a feature does not run on a particular platform.</summary>
[Serializable]
public class PlatformNotSupportedException : NotSupportedException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.PlatformNotSupportedException" /> class with default properties.</summary>
	public PlatformNotSupportedException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.PlatformNotSupportedException" /> class with a specified error message.</summary>
	/// <param name="message">The text message that explains the reason for the exception.</param>
	public PlatformNotSupportedException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.PlatformNotSupportedException" /> class with serialized data.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	protected PlatformNotSupportedException(SerializationInfo info, StreamingContext context)
	{
	}
}
