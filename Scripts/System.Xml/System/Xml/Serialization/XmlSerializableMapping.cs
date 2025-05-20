using System.Xml.Schema;

namespace System.Xml.Serialization;

internal class XmlSerializableMapping : XmlTypeMapping
{
	private XmlSchema _schema;

	private XmlSchemaComplexType _schemaType;

	private XmlQualifiedName _schemaTypeName;

	internal XmlSerializableMapping(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace)
		: base(null, null, null, null, null)
	{
	}
}
