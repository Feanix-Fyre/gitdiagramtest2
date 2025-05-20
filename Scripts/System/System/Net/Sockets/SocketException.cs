using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Net.Sockets;

/// <summary>The exception that is thrown when a socket error occurs.</summary>
[Serializable]
public class SocketException : Win32Exception
{
	[NonSerialized]
	private EndPoint m_EndPoint;

	/// <summary>Gets the error message that is associated with this exception.</summary>
	/// <returns>A string that contains the error message.</returns>
	public override string Message => null;

	/// <summary>Gets the error code that is associated with this exception.</summary>
	/// <returns>An integer error code that is associated with this exception.</returns>
	public SocketError SocketErrorCode => default(SocketError);

	private static int WSAGetLastError_icall()
	{
		return 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.SocketException" /> class with the last operating system error code.</summary>
	public SocketException()
	{
	}

	internal SocketException(int error, string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.SocketException" /> class with the specified error code.</summary>
	/// <param name="errorCode">The error code that indicates the error that occurred.</param>
	public SocketException(int errorCode)
	{
	}

	internal SocketException(SocketError socketError)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.SocketException" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
	/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance that contains the information that is required to serialize the new <see cref="T:System.Net.Sockets.SocketException" /> instance.</param>
	/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the source of the serialized stream that is associated with the new <see cref="T:System.Net.Sockets.SocketException" /> instance.</param>
	protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}
}
