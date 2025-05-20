using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="choice" /> element (compositor) from the XML Schema as specified by the World Wide Web Consortium (W3C). The <see langword="choice" /> allows only one of its children to appear in an instance. </summary>
public class XmlSchemaChoice : XmlSchemaGroupBase
{
	private XmlSchemaObjectCollection items;

	/// <summary>Gets the collection of the elements contained with the compositor (<see langword="choice" />): <see langword="XmlSchemaElement" />, <see langword="XmlSchemaGroupRef" />, <see langword="XmlSchemaChoice" />, <see langword="XmlSchemaSequence" />, or <see langword="XmlSchemaAny" />.</summary>
	/// <returns>The collection of elements contained within <see langword="XmlSchemaChoice" />.</returns>
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public override XmlSchemaObjectCollection Items => null;

	internal override bool IsEmpty => false;

	internal override void SetItems(XmlSchemaObjectCollection newItems)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaChoice" /> class.</summary>
	public XmlSchemaChoice()
	{
	}
}
