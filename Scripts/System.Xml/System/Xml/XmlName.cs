using System.Xml.Schema;

namespace System.Xml;

internal class XmlName : IXmlSchemaInfo
{
	private string prefix;

	private string localName;

	private string ns;

	private string name;

	private int hashCode;

	internal XmlDocument ownerDoc;

	internal XmlName next;

	public string LocalName => null;

	public string NamespaceURI => null;

	public string Prefix => null;

	public int HashCode => 0;

	public XmlDocument OwnerDocument => null;

	public string Name => null;

	public virtual XmlSchemaValidity Validity => default(XmlSchemaValidity);

	public virtual bool IsDefault => false;

	public virtual bool IsNil => false;

	public virtual XmlSchemaSimpleType MemberType => null;

	public virtual XmlSchemaType SchemaType => null;

	public virtual XmlSchemaElement SchemaElement => null;

	public virtual XmlSchemaAttribute SchemaAttribute => null;

	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
	{
		return null;
	}

	internal XmlName(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next)
	{
	}

	public virtual bool Equals(IXmlSchemaInfo schemaInfo)
	{
		return false;
	}

	public static int GetHashCode(string name)
	{
		return 0;
	}
}
