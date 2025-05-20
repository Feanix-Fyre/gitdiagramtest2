using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="all" /> element (compositor).</summary>
public class XmlSchemaAll : XmlSchemaGroupBase
{
	private XmlSchemaObjectCollection items;

	/// <summary>Gets the collection of <see langword="XmlSchemaElement" /> elements contained within the <see langword="all" /> compositor.</summary>
	/// <returns>The collection of elements contained in <see langword="XmlSchemaAll" />.</returns>
	[XmlElement("element", typeof(XmlSchemaElement))]
	public override XmlSchemaObjectCollection Items => null;

	internal override bool IsEmpty => false;

	internal override void SetItems(XmlSchemaObjectCollection newItems)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaAll" /> class.</summary>
	public XmlSchemaAll()
	{
	}
}
