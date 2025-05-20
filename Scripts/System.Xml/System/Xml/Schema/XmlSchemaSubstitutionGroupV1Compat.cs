using System.Xml.Serialization;

namespace System.Xml.Schema;

internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup
{
	private XmlSchemaChoice choice;

	[XmlIgnore]
	internal XmlSchemaChoice Choice => null;
}
