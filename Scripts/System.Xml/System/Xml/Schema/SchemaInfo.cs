using System.Collections.Generic;

namespace System.Xml.Schema;

internal class SchemaInfo : IDtdInfo
{
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls;

	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls;

	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities;

	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities;

	private XmlQualifiedName docTypeName;

	private string internalDtdSubset;

	private bool hasNonCDataAttributes;

	private bool hasDefaultAttributes;

	private Dictionary<string, bool> targetNamespaces;

	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls;

	private int errorCount;

	private SchemaType schemaType;

	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType;

	private Dictionary<string, SchemaNotation> notations;

	public XmlQualifiedName DocTypeName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string InternalDtdSubset
	{
		set
		{
		}
	}

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls => null;

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls => null;

	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities => null;

	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities => null;

	internal SchemaType SchemaType
	{
		get
		{
			return default(SchemaType);
		}
		set
		{
		}
	}

	internal Dictionary<string, bool> TargetNamespaces => null;

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType => null;

	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls => null;

	internal Dictionary<string, SchemaNotation> Notations => null;

	internal int ErrorCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	bool IDtdInfo.HasDefaultAttributes => false;

	bool IDtdInfo.HasNonCDataAttributes => false;

	XmlQualifiedName IDtdInfo.Name => null;

	string IDtdInfo.InternalDtdSubset => null;

	internal SchemaInfo()
	{
	}

	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname)
	{
		return null;
	}

	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname)
	{
		return null;
	}

	internal XmlSchemaElement GetElement(XmlQualifiedName qname)
	{
		return null;
	}

	internal bool HasSchema(string ns)
	{
		return false;
	}

	internal bool Contains(string ns)
	{
		return false;
	}

	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname)
	{
		return null;
	}

	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState)
	{
		attributeMatchState = default(AttributeMatchState);
		return null;
	}

	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip)
	{
		return null;
	}

	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler)
	{
	}

	internal void Finish()
	{
	}

	IDtdAttributeListInfo IDtdInfo.LookupAttributeList(string prefix, string localName)
	{
		return null;
	}

	IDtdEntityInfo IDtdInfo.LookupEntity(string name)
	{
		return null;
	}
}
