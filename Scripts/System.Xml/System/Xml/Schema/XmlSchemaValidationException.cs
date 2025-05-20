using System.Runtime.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the exception thrown when XML Schema Definition Language (XSD) schema validation errors and warnings are encountered in an XML document being validated. </summary>
[Serializable]
public class XmlSchemaValidationException : XmlSchemaException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaValidationException" /> class with the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects specified.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object.</param>
	protected XmlSchemaValidationException(SerializationInfo info, StreamingContext context)
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Constructs a new <see cref="T:System.Xml.Schema.XmlSchemaValidationException" /> object with the given <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> information that contains all the properties of the <see cref="T:System.Xml.Schema.XmlSchemaValidationException" />.</summary>
	/// <param name="info">
	///       <see cref="T:System.Runtime.Serialization.SerializationInfo" />
	///     </param>
	/// <param name="context">
	///       <see cref="T:System.Runtime.Serialization.StreamingContext" />
	///     </param>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaValidationException" /> class.</summary>
	public XmlSchemaValidationException()
		: base(null, default(StreamingContext))
	{
	}

	internal XmlSchemaValidationException(string res, string arg, string sourceUri, int lineNumber, int linePosition)
		: base(null, default(StreamingContext))
	{
	}

	internal XmlSchemaValidationException(string res, string[] args, string sourceUri, int lineNumber, int linePosition)
		: base(null, default(StreamingContext))
	{
	}

	internal XmlSchemaValidationException(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition)
		: base(null, default(StreamingContext))
	{
	}
}
