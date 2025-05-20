using System.Runtime.Serialization;

namespace System.Data;

/// <summary>Represents the exception that is thrown when the <see cref="P:System.Data.DataColumn.Expression" /> property of a <see cref="T:System.Data.DataColumn" /> cannot be evaluated.</summary>
[Serializable]
public class EvaluateException : InvalidExpressionException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.EvaluateException" /> class with the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and the <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
	/// <param name="info">The data needed to serialize or deserialize an object.</param>
	/// <param name="context">The source and destination of a particular serialized stream.</param>
	protected EvaluateException(SerializationInfo info, StreamingContext context)
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.EvaluateException" /> class.</summary>
	public EvaluateException()
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.EvaluateException" /> class with the specified string.</summary>
	/// <param name="s">The string to display when the exception is thrown.</param>
	public EvaluateException(string s)
		: base(null, default(StreamingContext))
	{
	}
}
