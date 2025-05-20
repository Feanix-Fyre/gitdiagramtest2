using System.Xml.Schema;

namespace System.Xml.Serialization;

internal class XmlTypeMapMemberAttribute : XmlTypeMapMember
{
	private string _attributeName;

	private string _namespace;

	private XmlSchemaForm _form;

	private XmlTypeMapping _mappedType;

	public string AttributeName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	public XmlSchemaForm Form
	{
		set
		{
		}
	}

	public XmlTypeMapping MappedType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
