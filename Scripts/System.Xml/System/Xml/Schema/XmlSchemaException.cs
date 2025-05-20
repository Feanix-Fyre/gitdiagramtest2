using System.Runtime.Serialization;

namespace System.Xml.Schema;

/// <summary>Returns detailed information about the schema exception.</summary>
[Serializable]
public class XmlSchemaException : SystemException
{
	private string res;

	private string[] args;

	private string sourceUri;

	private int lineNumber;

	private int linePosition;

	[NonSerialized]
	private XmlSchemaObject sourceSchemaObject;

	private string message;

	internal string GetRes => null;

	internal string[] Args => null;

	/// <summary>Gets the Uniform Resource Identifier (URI) location of the schema that caused the exception.</summary>
	/// <returns>The URI location of the schema that caused the exception.</returns>
	public string SourceUri => null;

	/// <summary>Gets the line number indicating where the error occurred.</summary>
	/// <returns>The line number indicating where the error occurred.</returns>
	public int LineNumber => 0;

	/// <summary>Gets the line position indicating where the error occurred.</summary>
	/// <returns>The line position indicating where the error occurred.</returns>
	public int LinePosition => 0;

	/// <summary>The <see langword="XmlSchemaObject" /> that produced the <see langword="XmlSchemaException" />.</summary>
	/// <returns>A valid object instance represents a structural validation error in the XML Schema Object Model (SOM).</returns>
	public XmlSchemaObject SourceSchemaObject => null;

	/// <summary>Gets the description of the error condition of this exception.</summary>
	/// <returns>The description of the error condition of this exception.</returns>
	public override string Message => null;

	/// <summary>Constructs a new <see langword="XmlSchemaException" /> object with the given <see langword="SerializationInfo" /> and <see langword="StreamingContext" /> information that contains all the properties of the <see langword="XmlSchemaException" />.</summary>
	/// <param name="info">SerializationInfo.</param>
	/// <param name="context">StreamingContext.</param>
	protected XmlSchemaException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Streams all the <see langword="XmlSchemaException" /> properties into the <see langword="SerializationInfo" /> class for the given <see langword="StreamingContext" />.</summary>
	/// <param name="info">The <see langword="SerializationInfo" />. </param>
	/// <param name="context">The <see langword="StreamingContext" /> information. </param>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaException" /> class.</summary>
	public XmlSchemaException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaException" /> class with the exception message specified.</summary>
	/// <param name="message">A <see langword="string" /> description of the error condition.</param>
	public XmlSchemaException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaException" /> class with the exception message and original <see cref="T:System.Exception" /> object that caused this exception specified.</summary>
	/// <param name="message">A <see langword="string" /> description of the error condition.</param>
	/// <param name="innerException">The original T:System.Exception object that caused this exception.</param>
	public XmlSchemaException(string message, Exception innerException)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaException" /> class with the exception message specified, and the original <see cref="T:System.Exception" /> object, line number, and line position of the XML that cause this exception specified.</summary>
	/// <param name="message">A <see langword="string" /> description of the error condition.</param>
	/// <param name="innerException">The original T:System.Exception object that caused this exception.</param>
	/// <param name="lineNumber">The line number of the XML that caused this exception.</param>
	/// <param name="linePosition">The line position of the XML that caused this exception.</param>
	public XmlSchemaException(string message, Exception innerException, int lineNumber, int linePosition)
	{
	}

	internal XmlSchemaException(string res, string[] args)
	{
	}

	internal XmlSchemaException(string res, string arg)
	{
	}

	internal XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition)
	{
	}

	internal XmlSchemaException(string res, string sourceUri, int lineNumber, int linePosition)
	{
	}

	internal XmlSchemaException(string res, string[] args, string sourceUri, int lineNumber, int linePosition)
	{
	}

	internal XmlSchemaException(string res, XmlSchemaObject source)
	{
	}

	internal XmlSchemaException(string res, string arg, XmlSchemaObject source)
	{
	}

	internal XmlSchemaException(string res, string[] args, XmlSchemaObject source)
	{
	}

	internal XmlSchemaException(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source)
	{
	}

	internal static string CreateMessage(string res, string[] args)
	{
		return null;
	}

	internal void SetSource(string sourceUri, int lineNumber, int linePosition)
	{
	}

	internal void SetSchemaObject(XmlSchemaObject source)
	{
	}

	internal void SetSource(XmlSchemaObject source)
	{
	}
}
