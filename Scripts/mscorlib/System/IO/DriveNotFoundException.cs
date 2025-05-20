using System.Runtime.Serialization;

namespace System.IO;

/// <summary>The exception that is thrown when trying to access a drive or share that is not available.</summary>
[Serializable]
public class DriveNotFoundException : IOException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.IO.DriveNotFoundException" /> class with its message string set to a system-supplied message and its HRESULT set to COR_E_DIRECTORYNOTFOUND.</summary>
	public DriveNotFoundException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.DriveNotFoundException" /> class with the specified message string and the HRESULT set to COR_E_DIRECTORYNOTFOUND.</summary>
	/// <param name="message">A <see cref="T:System.String" /> object that describes the error. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
	public DriveNotFoundException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.DriveNotFoundException" /> class with the specified serialization and context information.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the serialized object data about the exception being thrown.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination of the exception being thrown.</param>
	protected DriveNotFoundException(SerializationInfo info, StreamingContext context)
	{
	}
}
