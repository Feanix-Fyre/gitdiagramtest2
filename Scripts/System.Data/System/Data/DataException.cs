using System.Runtime.Serialization;

namespace System.Data;

/// <summary>Represents the exception that is thrown when errors are generated using ADO.NET components.</summary>
[Serializable]
public class DataException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataException" /> class with the specified serialization information and context.</summary>
	/// <param name="info">The data necessary to serialize or deserialize an object.</param>
	/// <param name="context">Description of the source and destination of the specified serialized stream.</param>
	protected DataException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataException" /> class. This is the default constructor.</summary>
	public DataException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataException" /> class with the specified string.</summary>
	/// <param name="s">The string to display when the exception is thrown.</param>
	public DataException(string s)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataException" /> class with the specified string and inner exception.</summary>
	/// <param name="s">The string to display when the exception is thrown.</param>
	/// <param name="innerException">A reference to an inner exception.</param>
	public DataException(string s, Exception innerException)
	{
	}
}
