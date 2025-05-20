using System.Runtime.Serialization;

namespace System.Resources;

/// <summary>The exception that is thrown if the main assembly does not contain the resources for the neutral culture, and an appropriate satellite assembly is missing.</summary>
[Serializable]
public class MissingManifestResourceException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingManifestResourceException" /> class with default properties.</summary>
	public MissingManifestResourceException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingManifestResourceException" /> class with the specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public MissingManifestResourceException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingManifestResourceException" /> class from serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination of the exception.</param>
	protected MissingManifestResourceException(SerializationInfo info, StreamingContext context)
	{
	}
}
