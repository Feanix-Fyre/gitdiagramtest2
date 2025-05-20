using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.ComponentModel;

/// <summary>Throws an exception for a Win32 error code.</summary>
[Serializable]
public class Win32Exception : ExternalException, ISerializable
{
	private readonly int nativeErrorCode;

	/// <summary>Gets the Win32 error code associated with this exception.</summary>
	/// <returns>The Win32 error code associated with this exception.</returns>
	public int NativeErrorCode => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the last Win32 error that occurred.</summary>
	public Win32Exception()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified error.</summary>
	/// <param name="error">The Win32 error code associated with this exception.</param>
	public Win32Exception(int error)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified error and the specified detailed description.</summary>
	/// <param name="error">The Win32 error code associated with this exception.</param>
	/// <param name="message">A detailed description of the error.</param>
	public Win32Exception(int error, string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified detailed description.</summary>
	/// <param name="message">A detailed description of the error.</param>
	public Win32Exception(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified detailed description and the specified exception.</summary>
	/// <param name="message">A detailed description of the error.</param>
	/// <param name="innerException">A reference to the inner exception that is the cause of this exception.</param>
	public Win32Exception(string message, Exception innerException)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified context and the serialization information.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> associated with this exception.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that represents the context of this exception.</param>
	protected Win32Exception(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name and line number at which this <see cref="T:System.ComponentModel.Win32Exception" /> occurred.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal static string GetErrorMessage(int error)
	{
		return null;
	}
}
