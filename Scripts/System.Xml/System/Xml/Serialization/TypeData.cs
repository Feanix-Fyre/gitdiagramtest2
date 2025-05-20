using System.Reflection;
using System.Xml.Schema;

namespace System.Xml.Serialization;

internal class TypeData
{
	private Type type;

	private string elementName;

	private SchemaTypes sType;

	private Type listItemType;

	private string typeName;

	private string fullTypeName;

	private TypeData listItemTypeData;

	private TypeData mappedType;

	private XmlSchemaPatternFacet facet;

	private MethodInfo typeConvertor;

	private bool hasPublicConstructor;

	private bool nullableOverride;

	private static string[] keywords;

	public string TypeName => null;

	public string XmlType => null;

	public Type Type => null;

	public string FullTypeName => null;

	public SchemaTypes SchemaType => default(SchemaTypes);

	public bool IsListType => false;

	public bool IsComplexType => false;

	public bool IsValueType => false;

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

	public TypeData ListItemTypeData => null;

	public Type ListItemType => null;

	public bool IsXsdType => false;

	public bool HasPublicConstructor => false;

	public TypeData(Type type, string elementName, bool isPrimitive)
	{
	}

	public TypeData(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet)
	{
	}

	private void LookupTypeConvertor()
	{
	}

	internal void ConvertForAssignment(ref object value)
	{
	}

	public static PropertyInfo GetIndexerProperty(Type collectionType)
	{
		return null;
	}

	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType)
	{
		return null;
	}

	internal static Type GetGenericListItemType(Type type)
	{
		return null;
	}
}
