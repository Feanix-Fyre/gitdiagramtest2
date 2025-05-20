using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when an attempt to unload an application domain fails.</summary>
[Serializable]
public class CannotUnloadAppDomainException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.CannotUnloadAppDomainException" /> class.</summary>
	public CannotUnloadAppDomainException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.CannotUnloadAppDomainException" /> class with a specified error message.</summary>
	/// <param name="message">A <see cref="T:System.String" /> that describes the error.</param>
	public CannotUnloadAppDomainException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.CannotUnloadAppDomainException" /> class from serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context)
	{
	}
}
