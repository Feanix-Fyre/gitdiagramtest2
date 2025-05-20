using System.Collections;

namespace System.Xml.Schema;

internal sealed class Preprocessor : BaseProcessor
{
	private string Xmlns;

	private string NsXsi;

	private string targetNamespace;

	private XmlSchema rootSchema;

	private XmlSchema currentSchema;

	private XmlSchemaForm elementFormDefault;

	private XmlSchemaForm attributeFormDefault;

	private XmlSchemaDerivationMethod blockDefault;

	private XmlSchemaDerivationMethod finalDefault;

	private Hashtable schemaLocations;

	private Hashtable chameleonSchemas;

	private Hashtable referenceNamespaces;

	private Hashtable processedExternals;

	private SortedList lockList;

	private XmlReaderSettings readerSettings;

	private XmlSchema rootSchemaForRedefine;

	private ArrayList redefinedList;

	private static XmlSchema builtInSchemaForXmlNS;

	private XmlResolver xmlResolver;

	internal XmlResolver XmlResolver
	{
		set
		{
		}
	}

	internal XmlReaderSettings ReaderSettings
	{
		set
		{
		}
	}

	internal Hashtable SchemaLocations
	{
		set
		{
		}
	}

	internal Hashtable ChameleonSchemas
	{
		set
		{
		}
	}

	internal XmlSchema RootSchema => null;

	public Preprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
		: base(null, null, null)
	{
	}

	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals)
	{
		return false;
	}

	private void Cleanup(XmlSchema schema)
	{
	}

	private void CleanupRedefine(XmlSchemaExternal include)
	{
	}

	private void BuildSchemaList(XmlSchema schema)
	{
	}

	private void LoadExternals(XmlSchema schema)
	{
	}

	internal static XmlSchema GetBuildInSchema()
	{
		return null;
	}

	private void BuildRefNamespaces(XmlSchema schema)
	{
	}

	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject)
	{
	}

	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports)
	{
	}

	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema)
	{
	}

	private void PreprocessRedefine(RedefineEntry redefineEntry)
	{
	}

	private void GetIncludedSet(XmlSchema schema, ArrayList includesList)
	{
	}

	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject)
	{
		return null;
	}

	private void SetSchemaDefaults(XmlSchema schema)
	{
	}

	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined)
	{
		return 0;
	}

	private void CheckRefinedGroup(XmlSchemaGroup group)
	{
	}

	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
	{
	}

	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype)
	{
	}

	private void CheckRefinedComplexType(XmlSchemaComplexType ctype)
	{
	}

	private void PreprocessAttribute(XmlSchemaAttribute attribute)
	{
	}

	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute)
	{
	}

	private void PreprocessAttributeContent(XmlSchemaAttribute attribute)
	{
	}

	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup)
	{
	}

	private void PreprocessElement(XmlSchemaElement element)
	{
	}

	private void PreprocessLocalElement(XmlSchemaElement element)
	{
	}

	private void PreprocessElementContent(XmlSchemaElement element)
	{
	}

	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint)
	{
	}

	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local)
	{
	}

	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local)
	{
	}

	private void PreprocessGroup(XmlSchemaGroup group)
	{
	}

	private void PreprocessNotation(XmlSchemaNotation notation)
	{
	}

	private void PreprocessParticle(XmlSchemaParticle particle)
	{
	}

	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent)
	{
	}

	private void ValidateIdAttribute(XmlSchemaObject xso)
	{
	}

	private void ValidateNameAttribute(XmlSchemaObject xso)
	{
	}

	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value)
	{
	}

	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location)
	{
		return null;
	}

	private object GetSchemaEntity(Uri ruri)
	{
		return null;
	}

	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema)
	{
		return null;
	}

	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent)
	{
	}

	private void PreprocessAnnotation(XmlSchemaObject schemaObject)
	{
	}

	private void PreprocessAnnotation(XmlSchemaAnnotation annotation)
	{
	}
}
