using System.Runtime.Serialization;

namespace System.Xml.XPath;

/// <summary>Provides the exception thrown when an error occurs while processing an XPath expression. </summary>
[Serializable]
public class XPathException : SystemException
{
	private string res;

	private string[] args;

	private string message;

	/// <summary>Gets the description of the error condition for this exception.</summary>
	/// <returns>The <see langword="string" /> description of the error condition for this exception.</returns>
	public override string Message => null;

	/// <summary>Uses the information in the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects to initialize a new instance of the <see cref="T:System.Xml.XPath.XPathException" /> class.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains all the properties of an <see cref="T:System.Xml.XPath.XPathException" />. </param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object. </param>
	protected XPathException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Streams all the <see cref="T:System.Xml.XPath.XPathException" /> properties into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class for the specified <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object.</param>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XPath.XPathException" /> class.</summary>
	public XPathException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XPath.XPathException" /> class using the specified exception message and <see cref="T:System.Exception" /> object.</summary>
	/// <param name="message">The description of the error condition. </param>
	/// <param name="innerException">The <see cref="T:System.Exception" /> that threw the <see cref="T:System.Xml.XPath.XPathException" />, if any. This value can be <see langword="null" />. </param>
	public XPathException(string message, Exception innerException)
	{
	}

	internal static XPathException Create(string res)
	{
		return null;
	}

	internal static XPathException Create(string res, string arg)
	{
		return null;
	}

	internal static XPathException Create(string res, string arg, string arg2)
	{
		return null;
	}

	internal static XPathException Create(string res, string arg, Exception innerException)
	{
		return null;
	}

	private XPathException(string res, string[] args)
	{
	}

	private XPathException(string res, string[] args, Exception inner)
	{
	}

	private static string CreateMessage(string res, string[] args)
	{
		return null;
	}
}
