using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.ComponentModel.Design;

/// <summary>The exception that is thrown when an attempt to check out a file that is checked into a source code management program is canceled or fails.</summary>
[Serializable]
public class CheckoutException : ExternalException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.CheckoutException" /> class that specifies that the check out was canceled. This field is read-only.</summary>
	public static readonly CheckoutException Canceled;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.CheckoutException" /> class with no associated message or error code.</summary>
	public CheckoutException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.CheckoutException" /> class with the specified message and error code.</summary>
	/// <param name="message">A message describing the exception.</param>
	/// <param name="errorCode">The error code to pass.</param>
	public CheckoutException(string message, int errorCode)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.CheckoutException" /> class using the specified serialization data and context.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to be used for deserialization.</param>
	/// <param name="context">The destination to be used for deserialization.</param>
	protected CheckoutException(SerializationInfo info, StreamingContext context)
	{
	}
}
