using System.Runtime.Serialization;

namespace System.Security;

/// <summary>The exception that is thrown when there is a syntax error in XML parsing. This class cannot be inherited.</summary>
[Serializable]
public sealed class XmlSyntaxException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Security.XmlSyntaxException" /> class with default properties.</summary>
	public XmlSyntaxException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.XmlSyntaxException" /> class with the line number where the exception was detected.</summary>
	/// <param name="lineNumber">The line number of the XML stream where the XML syntax error was detected.</param>
	public XmlSyntaxException(int lineNumber)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.XmlSyntaxException" /> class with a specified error message and the line number where the exception was detected.</summary>
	/// <param name="lineNumber">The line number of the XML stream where the XML syntax error was detected.</param>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public XmlSyntaxException(int lineNumber, string message)
	{
	}

	private XmlSyntaxException(SerializationInfo info, StreamingContext context)
	{
	}
}
