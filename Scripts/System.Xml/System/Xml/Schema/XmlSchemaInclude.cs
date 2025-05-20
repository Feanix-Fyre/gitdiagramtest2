namespace System.Xml.Schema;

/// <summary>Represents the <see langword="include" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class is used to include declarations and definitions from an external schema. The included declarations and definitions are then available for processing in the containing schema.</summary>
public class XmlSchemaInclude : XmlSchemaExternal
{
	private XmlSchemaAnnotation annotation;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaInclude" /> class.</summary>
	public XmlSchemaInclude()
	{
	}

	internal override void AddAnnotation(XmlSchemaAnnotation annotation)
	{
	}
}
