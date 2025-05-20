using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when an attempt is made to access an unloaded application domain.</summary>
[Serializable]
public class AppDomainUnloadedException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.AppDomainUnloadedException" /> class.</summary>
	public AppDomainUnloadedException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.AppDomainUnloadedException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected AppDomainUnloadedException(SerializationInfo info, StreamingContext context)
	{
	}
}
