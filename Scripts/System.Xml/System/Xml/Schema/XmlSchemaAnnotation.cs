using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="annotation" /> element.</summary>
public class XmlSchemaAnnotation : XmlSchemaObject
{
	private string id;

	private XmlSchemaObjectCollection items;

	private XmlAttribute[] moreAttributes;

	/// <summary>Gets or sets the string id.</summary>
	/// <returns>The string id. The default is <see langword="String.Empty" />.Optional.</returns>
	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the <see langword="Items" /> collection that is used to store the <see langword="appinfo" /> and <see langword="documentation" /> child elements.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" /> of <see langword="appinfo" /> and <see langword="documentation" /> child elements.</returns>
	[XmlElement("appinfo", typeof(XmlSchemaAppInfo))]
	[XmlElement("documentation", typeof(XmlSchemaDocumentation))]
	public XmlSchemaObjectCollection Items => null;

	[XmlIgnore]
	internal override string IdAttribute
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaAnnotation" /> class.</summary>
	public XmlSchemaAnnotation()
	{
	}
}
