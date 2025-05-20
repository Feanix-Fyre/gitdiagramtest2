using System.Collections;

namespace System.Xml.Schema;

/// <summary>Contains a cache of XML Schema definition language (XSD) schemas.</summary>
public class XmlSchemaSet
{
	private XmlNameTable nameTable;

	private SchemaNames schemaNames;

	private SortedList schemas;

	private ValidationEventHandler internalEventHandler;

	private ValidationEventHandler eventHandler;

	private bool isCompiled;

	private Hashtable schemaLocations;

	private Hashtable chameleonSchemas;

	private Hashtable targetNamespaces;

	private bool compileAll;

	private SchemaInfo cachedCompiledInfo;

	private XmlReaderSettings readerSettings;

	private XmlSchema schemaForSchema;

	private XmlSchemaCompilationSettings compilationSettings;

	internal XmlSchemaObjectTable elements;

	internal XmlSchemaObjectTable attributes;

	internal XmlSchemaObjectTable schemaTypes;

	internal XmlSchemaObjectTable substitutionGroups;

	private XmlSchemaObjectTable typeExtensions;

	private object internalSyncObject;

	internal object InternalSyncObject => null;

	/// <summary>Gets a value that indicates whether the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> have been compiled.</summary>
	/// <returns>
	///     <see langword="true" /> if the schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> have been compiled since the last time a schema was added or removed from the <see cref="T:System.Xml.Schema.XmlSchemaSet" />; otherwise, <see langword="false" />.</returns>
	public bool IsCompiled => false;

	/// <summary>Sets the <see cref="T:System.Xml.XmlResolver" /> used to resolve namespaces or locations referenced in include and import elements of a schema.</summary>
	/// <returns>The <see cref="T:System.Xml.XmlResolver" /> used to resolve namespaces or locations referenced in include and import elements of a schema.</returns>
	public XmlResolver XmlResolver
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaCompilationSettings" /> for the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaCompilationSettings" /> for the <see cref="T:System.Xml.Schema.XmlSchemaSet" />. The default is an <see cref="T:System.Xml.Schema.XmlSchemaCompilationSettings" /> instance with the <see cref="P:System.Xml.Schema.XmlSchemaCompilationSettings.EnableUpaCheck" /> property set to <see langword="true" />.</returns>
	public XmlSchemaCompilationSettings CompilationSettings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the number of logical XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <returns>The number of logical schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
	public int Count => 0;

	/// <summary>Gets all the global elements in all the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <returns>The collection of global elements.</returns>
	public XmlSchemaObjectTable GlobalElements => null;

	/// <summary>Gets all the global attributes in all the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <returns>The collection of global attributes.</returns>
	public XmlSchemaObjectTable GlobalAttributes => null;

	/// <summary>Gets all of the global simple and complex types in all the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <returns>The collection of global simple and complex types.</returns>
	public XmlSchemaObjectTable GlobalTypes => null;

	internal XmlSchemaObjectTable SubstitutionGroups => null;

	internal Hashtable SchemaLocations => null;

	internal XmlSchemaObjectTable TypeExtensions => null;

	internal SchemaInfo CompiledInfo => null;

	internal XmlReaderSettings ReaderSettings => null;

	internal SortedList SortedSchemas => null;

	/// <summary>Specifies an event handler for receiving information about XML Schema definition language (XSD) schema validation errors.</summary>
	public event ValidationEventHandler ValidationEventHandler
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> class.</summary>
	public XmlSchemaSet()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />.</summary>
	/// <param name="nameTable">The <see cref="T:System.Xml.XmlNameTable" /> object to use.</param>
	/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.XmlNameTable" /> object passed as a parameter is <see langword="null" />.</exception>
	public XmlSchemaSet(XmlNameTable nameTable)
	{
	}

	/// <summary>Adds all the XML Schema definition language (XSD) schemas in the given <see cref="T:System.Xml.Schema.XmlSchemaSet" /> to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <param name="schemas">The <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object.</param>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaException">A schema in the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> is not valid.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object passed as a parameter is <see langword="null" />.</exception>
	public void Add(XmlSchemaSet schemas)
	{
	}

	/// <summary>Adds the given <see cref="T:System.Xml.Schema.XmlSchema" /> to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <param name="schema">The <see cref="T:System.Xml.Schema.XmlSchema" /> object to add to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchema" /> object if the schema is valid. If the schema is not valid and a <see cref="T:System.Xml.Schema.ValidationEventHandler" /> is specified, then <see langword="null" /> is returned and the appropriate validation event is raised. Otherwise, an <see cref="T:System.Xml.Schema.XmlSchemaException" /> is thrown.</returns>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaException">The schema is not valid.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchema" /> object passed as a parameter is <see langword="null" />.</exception>
	public XmlSchema Add(XmlSchema schema)
	{
		return null;
	}

	/// <summary>Removes the specified XML Schema definition language (XSD) schema and all the schemas it imports from the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <param name="schemaToRemove">The <see cref="T:System.Xml.Schema.XmlSchema" /> object to remove from the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
	/// <returns>
	///     <see langword="true" /> if the <see cref="T:System.Xml.Schema.XmlSchema" /> object and all its imports were successfully removed; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchema" /> passed as a parameter is <see langword="null" />.</exception>
	public bool RemoveRecursive(XmlSchema schemaToRemove)
	{
		return false;
	}

	/// <summary>Indicates whether an XML Schema definition language (XSD) schema with the specified target namespace URI is in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <param name="targetNamespace">The schema targetNamespace property.</param>
	/// <returns>
	///     <see langword="true" /> if a schema with the specified target namespace URI is in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />; otherwise, <see langword="false" />.</returns>
	public bool Contains(string targetNamespace)
	{
		return false;
	}

	/// <summary>Compiles the XML Schema definition language (XSD) schemas added to the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> into one logical schema.</summary>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaException">An error occurred when validating and compiling the schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</exception>
	public void Compile()
	{
	}

	/// <summary>Reprocesses an XML Schema definition language (XSD) schema that already exists in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <param name="schema">The schema to reprocess.</param>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchema" /> object if the schema is a valid schema. If the schema is not valid and a <see cref="T:System.Xml.Schema.ValidationEventHandler" /> is specified, <see langword="null" /> is returned and the appropriate validation event is raised. Otherwise, an <see cref="T:System.Xml.Schema.XmlSchemaException" /> is thrown.</returns>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaException">The schema is not valid.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchema" /> object passed as a parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Xml.Schema.XmlSchema" /> object passed as a parameter does not already exist in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</exception>
	public XmlSchema Reprocess(XmlSchema schema)
	{
		return null;
	}

	/// <summary>Copies all the <see cref="T:System.Xml.Schema.XmlSchema" /> objects from the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> to the given array, starting at the given index.</summary>
	/// <param name="schemas">The array to copy the objects to.</param>
	/// <param name="index">The index in the array where copying will begin.</param>
	public void CopyTo(XmlSchema[] schemas, int index)
	{
	}

	/// <summary>Returns a collection of all the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing all the schemas that have been added to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />. If no schemas have been added to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />, an empty <see cref="T:System.Collections.ICollection" /> object is returned.</returns>
	public ICollection Schemas()
	{
		return null;
	}

	/// <summary>Returns a collection of all the XML Schema definition language (XSD) schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> that belong to the given namespace.</summary>
	/// <param name="targetNamespace">The schema targetNamespace property.</param>
	/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing all the schemas that have been added to the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> that belong to the given namespace. If no schemas have been added to the <see cref="T:System.Xml.Schema.XmlSchemaSet" />, an empty <see cref="T:System.Collections.ICollection" /> object is returned.</returns>
	public ICollection Schemas(string targetNamespace)
	{
		return null;
	}

	private XmlSchema Add(string targetNamespace, XmlSchema schema)
	{
		return null;
	}

	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces)
	{
	}

	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable)
	{
		return null;
	}

	private void AddSchemaToSet(XmlSchema schema)
	{
	}

	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve)
	{
	}

	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable)
	{
	}

	internal XmlSchema Remove(XmlSchema schema, bool forceCompile)
	{
		return null;
	}

	private void ClearTables()
	{
	}

	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace)
	{
		return false;
	}

	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader)
	{
		return null;
	}

	internal void CopyFromCompiledSet(XmlSchemaSet otherSet)
	{
	}

	internal XmlResolver GetResolver()
	{
		return null;
	}

	internal ValidationEventHandler GetEventHandler()
	{
		return null;
	}

	internal SchemaNames GetSchemaNames(XmlNameTable nt)
	{
		return null;
	}

	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema)
	{
		schema = null;
		return false;
	}

	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema)
	{
		schema = null;
		return false;
	}

	internal string GetTargetNamespace(XmlSchema schema)
	{
		return null;
	}

	private void RemoveSchemaFromCaches(XmlSchema schema)
	{
	}

	private void RemoveSchemaFromGlobalTables(XmlSchema schema)
	{
	}

	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item)
	{
		return false;
	}

	private void VerifyTables()
	{
	}

	private void InternalValidationCallback(object sender, ValidationEventArgs e)
	{
	}

	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
	{
	}
}
