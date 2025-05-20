using System.Runtime.Serialization;

namespace System.Xml;

/// <summary>Returns detailed information about the last exception.</summary>
[Serializable]
public class XmlException : SystemException
{
	private string res;

	private string[] args;

	private int lineNumber;

	private int linePosition;

	[OptionalField]
	private string sourceUri;

	private string message;

	/// <summary>Gets the line number indicating where the error occurred.</summary>
	/// <returns>The line number indicating where the error occurred.</returns>
	public int LineNumber => 0;

	/// <summary>Gets the line position indicating where the error occurred.</summary>
	/// <returns>The line position indicating where the error occurred.</returns>
	public int LinePosition => 0;

	/// <summary>Gets a message describing the current exception.</summary>
	/// <returns>The error message that explains the reason for the exception.</returns>
	public override string Message => null;

	internal string ResString => null;

	/// <summary>Initializes a new instance of the <see langword="XmlException" /> class using the information in the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects.</summary>
	/// <param name="info">The <see langword="SerializationInfo" /> object containing all the properties of an <see langword="XmlException" />. </param>
	/// <param name="context">The <see langword="StreamingContext" /> object containing the context information. </param>
	protected XmlException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Streams all the <see langword="XmlException" /> properties into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class for the given <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
	/// <param name="info">The <see langword="SerializationInfo" /> object. </param>
	/// <param name="context">The <see langword="StreamingContext" /> object. </param>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Initializes a new instance of the <see langword="XmlException" /> class.</summary>
	public XmlException()
	{
	}

	/// <summary>Initializes a new instance of the <see langword="XmlException" /> class with a specified error message.</summary>
	/// <param name="message">The error description. </param>
	public XmlException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see langword="XmlException" /> class.</summary>
	/// <param name="message">The description of the error condition. </param>
	/// <param name="innerException">The <see cref="T:System.Exception" /> that threw the <see langword="XmlException" />, if any. This value can be <see langword="null" />. </param>
	public XmlException(string message, Exception innerException)
	{
	}

	/// <summary>Initializes a new instance of the <see langword="XmlException" /> class with the specified message, inner exception, line number, and line position.</summary>
	/// <param name="message">The error description. </param>
	/// <param name="innerException">The exception that is the cause of the current exception. This value can be <see langword="null" />. </param>
	/// <param name="lineNumber">The line number indicating where the error occurred. </param>
	/// <param name="linePosition">The line position indicating where the error occurred. </param>
	public XmlException(string message, Exception innerException, int lineNumber, int linePosition)
	{
	}

	internal XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri)
	{
	}

	internal XmlException(string res, string[] args)
	{
	}

	internal XmlException(string res, string arg)
	{
	}

	internal XmlException(string res, string arg, string sourceUri)
	{
	}

	internal XmlException(string res, string arg, IXmlLineInfo lineInfo)
	{
	}

	internal XmlException(string res, string[] args, IXmlLineInfo lineInfo)
	{
	}

	internal XmlException(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri)
	{
	}

	internal XmlException(string res, string arg, int lineNumber, int linePosition)
	{
	}

	internal XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri)
	{
	}

	internal XmlException(string res, string[] args, int lineNumber, int linePosition)
	{
	}

	internal XmlException(string res, string[] args, int lineNumber, int linePosition, string sourceUri)
	{
	}

	internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition)
	{
	}

	internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri)
	{
	}

	private static string FormatUserMessage(string message, int lineNumber, int linePosition)
	{
		return null;
	}

	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition)
	{
		return null;
	}

	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex)
	{
		return null;
	}

	internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex)
	{
		return null;
	}

	internal static string[] BuildCharExceptionArgs(char invChar, char nextChar)
	{
		return null;
	}
}
