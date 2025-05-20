using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when the value of an argument is outside the allowable range of values as defined by the invoked method.</summary>
[Serializable]
public class ArgumentOutOfRangeException : ArgumentException
{
	private object _actualValue;

	/// <summary>Gets the error message and the string representation of the invalid argument value, or only the error message if the argument value is null.</summary>
	/// <returns>The text message for this exception. The value of this property takes one of two forms, as follows.  
	///   Condition  
	///
	///   Value  
	///
	///   The <paramref name="actualValue" /> is <see langword="null" />.  
	///
	///   The <paramref name="message" /> string passed to the constructor.  
	///
	///   The <paramref name="actualValue" /> is not <see langword="null" />.  
	///
	///   The <paramref name="message" /> string appended with the string representation of the invalid argument value.</returns>
	public override string Message => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentOutOfRangeException" /> class.</summary>
	public ArgumentOutOfRangeException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentOutOfRangeException" /> class with the name of the parameter that causes this exception.</summary>
	/// <param name="paramName">The name of the parameter that causes this exception.</param>
	public ArgumentOutOfRangeException(string paramName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentOutOfRangeException" /> class with the name of the parameter that causes this exception and a specified error message.</summary>
	/// <param name="paramName">The name of the parameter that caused the exception.</param>
	/// <param name="message">The message that describes the error.</param>
	public ArgumentOutOfRangeException(string paramName, string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentOutOfRangeException" /> class with the parameter name, the value of the argument, and a specified error message.</summary>
	/// <param name="paramName">The name of the parameter that caused the exception.</param>
	/// <param name="actualValue">The value of the argument that causes this exception.</param>
	/// <param name="message">The message that describes the error.</param>
	public ArgumentOutOfRangeException(string paramName, object actualValue, string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentOutOfRangeException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">An object that describes the source or destination of the serialized data.</param>
	protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the invalid argument value and additional exception information.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">An object that describes the source or destination of the serialized data.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> object is <see langword="null" />.</exception>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
