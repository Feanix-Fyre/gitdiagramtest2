using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when there is an attempt to divide an integral or <see cref="T:System.Decimal" /> value by zero.</summary>
[Serializable]
public class DivideByZeroException : ArithmeticException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.DivideByZeroException" /> class.</summary>
	public DivideByZeroException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DivideByZeroException" /> class with a specified error message.</summary>
	/// <param name="message">A <see cref="T:System.String" /> that describes the error.</param>
	public DivideByZeroException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DivideByZeroException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected DivideByZeroException(SerializationInfo info, StreamingContext context)
	{
	}
}
