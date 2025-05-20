using System.Runtime.Serialization;

namespace System.Resources;

/// <summary>The exception that is thrown when the satellite assembly for the resources of the default culture is missing.</summary>
[Serializable]
public class MissingSatelliteAssemblyException : SystemException
{
	private string _cultureName;

	/// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> class with default properties.</summary>
	public MissingSatelliteAssemblyException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> class with a specified error message and the name of a neutral culture.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="cultureName">The name of the neutral culture.</param>
	public MissingSatelliteAssemblyException(string message, string cultureName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> class from serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination of the exception.</param>
	protected MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context)
	{
	}
}
