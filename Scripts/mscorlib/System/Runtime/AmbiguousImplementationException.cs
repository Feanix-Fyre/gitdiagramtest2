using System.Runtime.Serialization;

namespace System.Runtime;

[Serializable]
public sealed class AmbiguousImplementationException : Exception
{
	public AmbiguousImplementationException()
	{
	}

	public AmbiguousImplementationException(string message)
	{
	}

	private AmbiguousImplementationException(SerializationInfo info, StreamingContext context)
	{
	}
}
