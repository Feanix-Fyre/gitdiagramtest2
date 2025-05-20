namespace System.Xml.Schema;

/// <summary>Returns detailed information related to the <see langword="ValidationEventHandler" />.</summary>
public class ValidationEventArgs : EventArgs
{
	private XmlSchemaException ex;

	private XmlSeverityType severity;

	/// <summary>Gets the severity of the validation event.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSeverityType" /> value representing the severity of the validation event.</returns>
	public XmlSeverityType Severity => default(XmlSeverityType);

	/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaException" /> associated with the validation event.</summary>
	/// <returns>The <see langword="XmlSchemaException" /> associated with the validation event.</returns>
	public XmlSchemaException Exception => null;

	internal ValidationEventArgs(XmlSchemaException ex)
	{
	}

	internal ValidationEventArgs(XmlSchemaException ex, XmlSeverityType severity)
	{
	}
}
