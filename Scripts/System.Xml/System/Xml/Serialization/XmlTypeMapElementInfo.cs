using System.Xml.Schema;

namespace System.Xml.Serialization;

internal class XmlTypeMapElementInfo
{
	private string _elementName;

	private string _namespace;

	private XmlSchemaForm _form;

	private XmlTypeMapMember _member;

	private object _choiceValue;

	private bool _isNullable;

	private int _nestingLevel;

	private XmlTypeMapping _mappedType;

	private TypeData _type;

	private bool _wrappedElement;

	private int _explicitOrder;

	public TypeData TypeData => null;

	public object ChoiceValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string ElementName
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

	public string DataTypeNamespace => null;

	public string DataTypeName => null;

	public XmlSchemaForm Form
	{
		get
		{
			return default(XmlSchemaForm);
		}
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

	public bool IsNullable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public XmlTypeMapMember Member => null;

	public int NestingLevel
	{
		set
		{
		}
	}

	public bool MultiReferenceType => false;

	public bool WrappedElement
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsTextElement
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsUnnamedAnyElement
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int ExplicitOrder
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public XmlTypeMapElementInfo(XmlTypeMapMember member, TypeData type)
	{
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
