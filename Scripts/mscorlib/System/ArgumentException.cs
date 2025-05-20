using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when one of the arguments provided to a method is not valid.</summary>
[Serializable]
public class ArgumentException : SystemException
{
	private string _paramName;

	/// <summary>Gets the error message and the parameter name, or only the error message if no parameter name is set.</summary>
	/// <returns>A text string describing the details of the exception. The value of this property takes one of two forms:  
	///   Condition  
	///
	///   Value  
	///
	///   The <paramref name="paramName" /> is a null reference (<see langword="Nothing" /> in Visual Basic) or of zero length.  
	///
	///   The <paramref name="message" /> string passed to the constructor.  
	///
	///   The <paramref name="paramName" /> is not null reference (<see langword="Nothing" /> in Visual Basic) and it has a length greater than zero.  
	///
	///   The <paramref name="message" /> string appended with the name of the invalid parameter.</returns>
	public override string Message => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class.</summary>
	public ArgumentException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public ArgumentException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
	public ArgumentException(string message, Exception innerException)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class with a specified error message, the parameter name, and a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
	public ArgumentException(string message, string paramName, Exception innerException)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class with a specified error message and the name of the parameter that causes this exception.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	public ArgumentException(string message, string paramName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected ArgumentException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the parameter name and additional exception information.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> object is a null reference (<see langword="Nothing" /> in Visual Basic).</exception>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
