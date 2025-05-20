using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="import" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class is used to import schema components from other schemas.</summary>
public class XmlSchemaImport : XmlSchemaExternal
{
	private string ns;

	private XmlSchemaAnnotation annotation;

	/// <summary>Gets or sets the target namespace for the imported schema as a Uniform Resource Identifier (URI) reference.</summary>
	/// <returns>The target namespace for the imported schema as a URI reference.Optional.</returns>
	[XmlAttribute("namespace", DataType = "anyURI")]
	public string Namespace
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaImport" /> class.</summary>
	public XmlSchemaImport()
	{
	}

	internal override void AddAnnotation(XmlSchemaAnnotation annotation)
	{
	}
}
