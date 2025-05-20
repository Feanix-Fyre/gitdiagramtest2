using System.Collections;

namespace System.Xml.Serialization;

/// <summary>Contains a mapping of one type to another.</summary>
public class XmlTypeMapping : XmlMapping
{
	private string xmlType;

	private string xmlTypeNamespace;

	private TypeData type;

	private XmlTypeMapping baseMap;

	private bool multiReferenceType;

	private bool includeInSchema;

	private bool isNullable;

	private bool isAny;

	private ArrayList _derivedTypes;

	/// <summary>The fully qualified type name that includes the namespace (or namespaces) and type.</summary>
	/// <returns>The fully qualified type name.</returns>
	public string TypeFullName => null;

	internal TypeData TypeData => null;

	internal string XmlType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string XmlTypeNamespace
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool HasXmlTypeNamespace => false;

	internal ArrayList DerivedTypes => null;

	internal bool MultiReferenceType => false;

	internal XmlTypeMapping BaseMap
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool IncludeInSchema
	{
		set
		{
		}
	}

	internal bool IsNullable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool IsAny
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal XmlTypeMapping(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace)
		: base(null, null)
	{
	}

	internal XmlTypeMapping GetRealTypeMap(Type objectType)
	{
		return null;
	}

	internal XmlTypeMapping GetRealElementMap(string name, string ens)
	{
		return null;
	}

	internal void UpdateRoot(XmlQualifiedName qname)
	{
	}
}
