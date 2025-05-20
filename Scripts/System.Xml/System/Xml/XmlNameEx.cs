using System.Xml.Schema;

namespace System.Xml;

internal sealed class XmlNameEx : XmlName
{
	private byte flags;

	private XmlSchemaSimpleType memberType;

	private XmlSchemaType schemaType;

	private object decl;

	public override XmlSchemaValidity Validity => default(XmlSchemaValidity);

	public override bool IsDefault => false;

	public override bool IsNil => false;

	public override XmlSchemaSimpleType MemberType => null;

	public override XmlSchemaType SchemaType => null;

	public override XmlSchemaElement SchemaElement => null;

	public override XmlSchemaAttribute SchemaAttribute => null;

	internal XmlNameEx(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
		: base(null, null, null, 0, null, null)
	{
	}

	public void SetValidity(XmlSchemaValidity value)
	{
	}

	public void SetIsDefault(bool value)
	{
	}

	public void SetIsNil(bool value)
	{
	}

	public override bool Equals(IXmlSchemaInfo schemaInfo)
	{
		return false;
	}
}
