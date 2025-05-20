using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Net.NetworkInformation;

/// <summary>The exception that is thrown when an error occurs while retrieving network information.</summary>
[Serializable]
public class NetworkInformationException : Win32Exception
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInformationException" /> class.</summary>
	public NetworkInformationException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInformationException" /> class with the specified error code.</summary>
	/// <param name="errorCode">A <see langword="Win32" /> error code.</param>
	public NetworkInformationException(int errorCode)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInformationException" /> class with serialized data.</summary>
	/// <param name="serializationInfo">A SerializationInfo object that contains the serialized exception data.</param>
	/// <param name="streamingContext">A StreamingContext that contains contextual information about the serialized exception.</param>
	protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}
}
