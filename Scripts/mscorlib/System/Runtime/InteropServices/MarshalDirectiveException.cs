using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

/// <summary>The exception that is thrown by the marshaler when it encounters a <see cref="T:System.Runtime.InteropServices.MarshalAsAttribute" /> it does not support.</summary>
[Serializable]
public class MarshalDirectiveException : SystemException
{
	/// <summary>Initializes a new instance of the <see langword="MarshalDirectiveException" /> class with default properties.</summary>
	public MarshalDirectiveException()
	{
	}

	/// <summary>Initializes a new instance of the <see langword="MarshalDirectiveException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that specifies the reason for the exception.</param>
	public MarshalDirectiveException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see langword="MarshalDirectiveException" /> class from serialization data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	protected MarshalDirectiveException(SerializationInfo info, StreamingContext context)
	{
	}
}
