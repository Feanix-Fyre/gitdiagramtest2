using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

/// <summary>The exception that is thrown when an unrecognized HRESULT is returned from a COM method call.</summary>
[Serializable]
public class COMException : ExternalException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.COMException" /> class with default values.</summary>
	public COMException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.COMException" /> class with a specified message and error code.</summary>
	/// <param name="message">The message that indicates the reason the exception occurred.</param>
	/// <param name="errorCode">The error code (HRESULT) value associated with this exception.</param>
	public COMException(string message, int errorCode)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.COMException" /> class from serialization data.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that supplies the contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	protected COMException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Converts the contents of the exception to a string.</summary>
	/// <returns>A string containing the <see cref="P:System.Exception.HResult" />, <see cref="P:System.Exception.Message" />, <see cref="P:System.Exception.InnerException" />, and <see cref="P:System.Exception.StackTrace" /> properties of the exception.</returns>
	public override string ToString()
	{
		return null;
	}
}
