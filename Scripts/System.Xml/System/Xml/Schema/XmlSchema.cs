using System.Collections;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>An in-memory representation of an XML Schema, as specified in the World Wide Web Consortium (W3C) XML Schema Part 1: Structures and XML Schema Part 2: Datatypes specifications.</summary>
[XmlRoot("schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
public class XmlSchema : XmlSchemaObject
{
	private XmlSchemaForm attributeFormDefault;

	private XmlSchemaForm elementFormDefault;

	private XmlSchemaDerivationMethod blockDefault;

	private XmlSchemaDerivationMethod finalDefault;

	private string targetNs;

	private string version;

	private XmlSchemaObjectCollection includes;

	private XmlSchemaObjectCollection items;

	private string id;

	private XmlAttribute[] moreAttributes;

	private bool isCompiled;

	private bool isCompiledBySet;

	private bool isPreprocessed;

	private bool isRedefined;

	private int errorCount;

	private XmlSchemaObjectTable attributes;

	private XmlSchemaObjectTable attributeGroups;

	private XmlSchemaObjectTable elements;

	private XmlSchemaObjectTable types;

	private XmlSchemaObjectTable groups;

	private XmlSchemaObjectTable notations;

	private XmlSchemaObjectTable identityConstraints;

	private static int globalIdCounter;

	private ArrayList importedSchemas;

	private ArrayList importedNamespaces;

	private int schemaId;

	private Uri baseUri;

	private bool isChameleon;

	private Hashtable ids;

	private XmlDocument document;

	/// <summary>Gets or sets the form for attributes declared in the target namespace of the schema.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaForm" /> value that indicates if attributes from the target namespace are required to be qualified with the namespace prefix. The default is <see cref="F:System.Xml.Schema.XmlSchemaForm.None" />.</returns>
	[DefaultValue(XmlSchemaForm.None)]
	[XmlAttribute("attributeFormDefault")]
	public XmlSchemaForm AttributeFormDefault
	{
		get
		{
			return default(XmlSchemaForm);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see langword="blockDefault" /> attribute which sets the default value of the <see langword="block" /> attribute on element and complex types in the <see langword="targetNamespace" /> of the schema.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> value representing the different methods for preventing derivation. The default value is <see langword="XmlSchemaDerivationMethod.None" />.</returns>
	[DefaultValue(XmlSchemaDerivationMethod.None)]
	[XmlAttribute("blockDefault")]
	public XmlSchemaDerivationMethod BlockDefault
	{
		get
		{
			return default(XmlSchemaDerivationMethod);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see langword="finalDefault" /> attribute which sets the default value of the <see langword="final" /> attribute on elements and complex types in the target namespace of the schema.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> value representing the different methods for preventing derivation. The default value is <see langword="XmlSchemaDerivationMethod.None" />.</returns>
	[DefaultValue(XmlSchemaDerivationMethod.None)]
	[XmlAttribute("finalDefault")]
	public XmlSchemaDerivationMethod FinalDefault
	{
		get
		{
			return default(XmlSchemaDerivationMethod);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the form for elements declared in the target namespace of the schema.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaForm" /> value that indicates if elements from the target namespace are required to be qualified with the namespace prefix. The default is <see cref="F:System.Xml.Schema.XmlSchemaForm.None" />.</returns>
	[XmlAttribute("elementFormDefault")]
	[DefaultValue(XmlSchemaForm.None)]
	public XmlSchemaForm ElementFormDefault
	{
		get
		{
			return default(XmlSchemaForm);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the Uniform Resource Identifier (URI) of the schema target namespace.</summary>
	/// <returns>The schema target namespace.</returns>
	[XmlAttribute("targetNamespace", DataType = "anyURI")]
	public string TargetNamespace
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the version of the schema.</summary>
	/// <returns>The version of the schema. The default value is <see langword="String.Empty" />.</returns>
	[XmlAttribute("version", DataType = "token")]
	public string Version
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of included and imported schemas.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" /> of the included and imported schemas.</returns>
	[XmlElement("redefine", typeof(XmlSchemaRedefine))]
	[XmlElement("include", typeof(XmlSchemaInclude))]
	[XmlElement("import", typeof(XmlSchemaImport))]
	public XmlSchemaObjectCollection Includes => null;

	/// <summary>Gets the collection of schema elements in the schema and is used to add new element types at the <see langword="schema" /> element level.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" /> of schema elements in the schema.</returns>
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("notation", typeof(XmlSchemaNotation))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Items => null;

	[XmlIgnore]
	internal bool IsCompiledBySet
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal bool IsPreprocessed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal bool IsRedefined
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the post-schema-compilation value for all the attributes in the schema.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> collection of all the attributes in the schema.</returns>
	[XmlIgnore]
	public XmlSchemaObjectTable Attributes => null;

	/// <summary>Gets the post-schema-compilation value of all the global attribute groups in the schema.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> collection of all the global attribute groups in the schema.</returns>
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups => null;

	/// <summary>Gets the post-schema-compilation value of all schema types in the schema.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" /> of all schema types in the schema.</returns>
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes => null;

	/// <summary>Gets the post-schema-compilation value for all the elements in the schema.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> collection of all the elements in the schema.</returns>
	[XmlIgnore]
	public XmlSchemaObjectTable Elements => null;

	/// <summary>Gets or sets the string ID.</summary>
	/// <returns>The ID of the string. The default value is <see langword="String.Empty" />.</returns>
	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the post-schema-compilation value of all the groups in the schema.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> collection of all the groups in the schema.</returns>
	[XmlIgnore]
	public XmlSchemaObjectTable Groups => null;

	/// <summary>Gets the post-schema-compilation value for all notations in the schema.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> collection of all notations in the schema.</returns>
	[XmlIgnore]
	public XmlSchemaObjectTable Notations => null;

	[XmlIgnore]
	internal XmlSchemaObjectTable IdentityConstraints => null;

	[XmlIgnore]
	internal Uri BaseUri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal int SchemaId => 0;

	[XmlIgnore]
	internal bool IsChameleon
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal Hashtable Ids => null;

	[XmlIgnore]
	internal XmlDocument Document => null;

	[XmlIgnore]
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

	[XmlIgnore]
	internal override string IdAttribute
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ArrayList ImportedSchemas => null;

	internal ArrayList ImportedNamespaces => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchema" /> class.</summary>
	public XmlSchema()
	{
	}

	/// <summary>Reads an XML Schema from the supplied <see cref="T:System.Xml.XmlReader" />.</summary>
	/// <param name="reader">The <see langword="XmlReader" /> containing the XML Schema to read. </param>
	/// <param name="validationEventHandler">The validation event handler that receives information about the XML Schema syntax errors. </param>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchema" /> object representing the XML Schema.</returns>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaException">An <see cref="T:System.Xml.Schema.XmlSchemaException" /> is raised if no <see cref="T:System.Xml.Schema.ValidationEventHandler" /> is specified.</exception>
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler)
	{
		return null;
	}

	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel)
	{
		return false;
	}

	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
	{
	}

	internal new XmlSchema Clone()
	{
		return null;
	}

	internal XmlSchema DeepClone()
	{
		return null;
	}

	internal void SetIsCompiled(bool isCompiled)
	{
	}

	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
	{
	}

	internal override void AddAnnotation(XmlSchemaAnnotation annotation)
	{
	}

	internal void GetExternalSchemasList(IList extList, XmlSchema schema)
	{
	}
}
