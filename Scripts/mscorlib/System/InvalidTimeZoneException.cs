using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when time zone information is invalid.</summary>
[Serializable]
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public class InvalidTimeZoneException : Exception
{
	/// <summary>Initializes a new instance of the <see cref="T:System.InvalidTimeZoneException" /> class with a system-supplied message.</summary>
	public InvalidTimeZoneException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.InvalidTimeZoneException" /> class with the specified message string.</summary>
	/// <param name="message">A string that describes the exception.</param>
	public InvalidTimeZoneException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.InvalidTimeZoneException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="message">A string that describes the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public InvalidTimeZoneException(string message, Exception innerException)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.InvalidTimeZoneException" /> class from serialized data.</summary>
	/// <param name="info">The object that contains the serialized data.</param>
	/// <param name="context">The stream that contains the serialized data.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.  
	///  -or-  
	///  The <paramref name="context" /> parameter is <see langword="null" />.</exception>
	protected InvalidTimeZoneException(SerializationInfo info, StreamingContext context)
	{
	}
}
