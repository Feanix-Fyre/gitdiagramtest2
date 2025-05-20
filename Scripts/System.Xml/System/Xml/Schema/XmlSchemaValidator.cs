using System.Collections;
using System.Text;

namespace System.Xml.Schema;

/// <summary>Represents an XML Schema Definition Language (XSD) Schema validation engine. The <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> class cannot be inherited.</summary>
public sealed class XmlSchemaValidator
{
	private XmlSchemaSet schemaSet;

	private XmlSchemaValidationFlags validationFlags;

	private int startIDConstraint;

	private bool isRoot;

	private bool rootHasSchema;

	private bool attrValid;

	private bool checkEntity;

	private SchemaInfo compiledSchemaInfo;

	private IDtdInfo dtdSchemaInfo;

	private Hashtable validatedNamespaces;

	private HWStack validationStack;

	private ValidationState context;

	private ValidatorState currentState;

	private Hashtable attPresence;

	private SchemaAttDef wildID;

	private Hashtable IDs;

	private IdRefNode idRefListHead;

	private XmlQualifiedName contextQName;

	private string NsXs;

	private string NsXsi;

	private string NsXmlNs;

	private string NsXml;

	private XmlSchemaObject partialValidationType;

	private StringBuilder textValue;

	private ValidationEventHandler eventHandler;

	private object validationEventSender;

	private XmlNameTable nameTable;

	private IXmlLineInfo positionInfo;

	private IXmlLineInfo dummyPositionInfo;

	private XmlResolver xmlResolver;

	private Uri sourceUri;

	private string sourceUriString;

	private IXmlNamespaceResolver nsResolver;

	private XmlSchemaContentProcessing processContents;

	private string xsiTypeString;

	private string xsiNilString;

	private string xsiSchemaLocationString;

	private string xsiNoNamespaceSchemaLocationString;

	private static readonly XmlSchemaDatatype dtQName;

	private static readonly XmlSchemaDatatype dtCDATA;

	private static readonly XmlSchemaDatatype dtStringArray;

	private static XmlSchemaParticle[] EmptyParticleArray;

	private static XmlSchemaAttribute[] EmptyAttributeArray;

	private XmlCharType xmlCharType;

	internal static bool[,] ValidStates;

	private static string[] MethodNames;

	/// <summary>Sets the <see cref="T:System.Xml.XmlResolver" /> object used to resolve xs:import and xs:include elements as well as xsi:schemaLocation and xsi:noNamespaceSchemaLocation attributes.</summary>
	/// <returns>An <see cref="T:System.Xml.XmlResolver" /> object; the default is an <see cref="T:System.Xml.XmlUrlResolver" /> object.</returns>
	public XmlResolver XmlResolver
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the line number information for the XML node being validated.</summary>
	/// <returns>An <see cref="T:System.Xml.IXmlLineInfo" /> object.</returns>
	public IXmlLineInfo LineInfoProvider
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the source URI for the XML node being validated.</summary>
	/// <returns>A <see cref="T:System.Uri" /> object representing the source URI for the XML node being validated; the default is <see langword="null" />.</returns>
	public Uri SourceUri
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the object sent as the sender object of a validation event.</summary>
	/// <returns>An <see cref="T:System.Object" />; the default is this <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object.</returns>
	public object ValidationEventSender
	{
		set
		{
		}
	}

	internal XmlSchemaSet SchemaSet => null;

	internal XmlSchemaValidationFlags ValidationFlags => default(XmlSchemaValidationFlags);

	internal XmlSchemaContentType CurrentContentType => default(XmlSchemaContentType);

	private bool StrictlyAssessed => false;

	private bool HasSchema => false;

	private bool HasIdentityConstraints => false;

	internal bool ProcessIdentityConstraints => false;

	internal bool ReportValidationWarnings => false;

	internal bool ProcessSchemaHints => false;

	/// <summary>The <see cref="T:System.Xml.Schema.ValidationEventHandler" /> that receives schema validation warnings and errors encountered during schema validation.</summary>
	public event ValidationEventHandler ValidationEventHandler
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> class.</summary>
	/// <param name="nameTable">An <see cref="T:System.Xml.XmlNameTable" /> object containing element and attribute names as atomized strings.</param>
	/// <param name="schemas">An <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object containing the XML Schema Definition Language (XSD) schemas used for validation.</param>
	/// <param name="namespaceResolver">An <see cref="T:System.Xml.IXmlNamespaceResolver" /> object used for resolving namespaces encountered during validation.</param>
	/// <param name="validationFlags">An <see cref="T:System.Xml.Schema.XmlSchemaValidationFlags" /> value specifying schema validation options.</param>
	/// <exception cref="T:System.ArgumentNullException">One or more of the parameters specified are <see langword="null" />.</exception>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaException">An error occurred while compiling schemas in the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> parameter.</exception>
	public XmlSchemaValidator(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags)
	{
	}

	private void Init()
	{
	}

	private void Reset()
	{
	}

	/// <summary>Adds an XML Schema Definition Language (XSD) schema to the set of schemas used for validation.</summary>
	/// <param name="schema">An <see cref="T:System.Xml.Schema.XmlSchema" /> object to add to the set of schemas used for validation.</param>
	/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchema" /> parameter specified is <see langword="null" />.</exception>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The target namespace of the <see cref="T:System.Xml.Schema.XmlSchema" /> parameter matches that of any element or attribute already encountered by the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object.</exception>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaException">The <see cref="T:System.Xml.Schema.XmlSchema" /> parameter is invalid.</exception>
	public void AddSchema(XmlSchema schema)
	{
	}

	/// <summary>Initializes the state of the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object.</summary>
	/// <exception cref="T:System.InvalidOperationException">Calling the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.Initialize" /> method is valid immediately after the construction of an <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object or after a call to <see cref="M:System.Xml.Schema.XmlSchemaValidator.EndValidation" /> only.</exception>
	public void Initialize()
	{
	}

	/// <summary>Initializes the state of the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object using the <see cref="T:System.Xml.Schema.XmlSchemaObject" /> specified for partial validation.</summary>
	/// <param name="partialValidationType">An <see cref="T:System.Xml.Schema.XmlSchemaElement" />, <see cref="T:System.Xml.Schema.XmlSchemaAttribute" />, or <see cref="T:System.Xml.Schema.XmlSchemaType" /> object used to initialize the validation context of the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object for partial validation.</param>
	/// <exception cref="T:System.InvalidOperationException">Calling the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.Initialize" /> method is valid immediately after the construction of an <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object or after a call to <see cref="M:System.Xml.Schema.XmlSchemaValidator.EndValidation" /> only.</exception>
	/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> parameter is not an <see cref="T:System.Xml.Schema.XmlSchemaElement" />, <see cref="T:System.Xml.Schema.XmlSchemaAttribute" />, or <see cref="T:System.Xml.Schema.XmlSchemaType" /> object.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> parameter cannot be <see langword="null" />.</exception>
	public void Initialize(XmlSchemaObject partialValidationType)
	{
	}

	/// <summary>Validates the element in the current context with the xsi:Type, xsi:Nil, xsi:SchemaLocation, and xsi:NoNamespaceSchemaLocation attribute values specified.</summary>
	/// <param name="localName">The local name of the element to validate.</param>
	/// <param name="namespaceUri">The namespace URI of the element to validate.</param>
	/// <param name="schemaInfo">An <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> object whose properties are set on successful validation of the element's name. This parameter can be <see langword="null" />.</param>
	/// <param name="xsiType">The xsi:Type attribute value of the element. This parameter can be <see langword="null" />.</param>
	/// <param name="xsiNil">The xsi:Nil attribute value of the element. This parameter can be <see langword="null" />.</param>
	/// <param name="xsiSchemaLocation">The xsi:SchemaLocation attribute value of the element. This parameter can be <see langword="null" />.</param>
	/// <param name="xsiNoNamespaceSchemaLocation">The xsi:NoNamespaceSchemaLocation attribute value of the element. This parameter can be <see langword="null" />.</param>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The element's name is not valid in the current context.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateElement" /> method was not called in the correct sequence. For example, the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateElement" /> method is called after calling <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateAttribute" />.</exception>
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation)
	{
	}

	/// <summary>Validates the attribute name, namespace URI, and value in the current element context.</summary>
	/// <param name="localName">The local name of the attribute to validate.</param>
	/// <param name="namespaceUri">The namespace URI of the attribute to validate.</param>
	/// <param name="attributeValue">An <see cref="T:System.Xml.Schema.XmlValueGetter" /><see langword="delegate" /> used to pass the attribute's value as a Common Language Runtime (CLR) type compatible with the XML Schema Definition Language (XSD) type of the attribute.</param>
	/// <param name="schemaInfo">An <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> object whose properties are set on successful validation of the attribute. This parameter and can be <see langword="null" />.</param>
	/// <returns>The validated attribute's value.</returns>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The attribute is not valid in the current element context.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateAttribute" /> method was not called in the correct sequence. For example, calling <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateAttribute" /> after calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo)" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">One or more of the parameters specified are <see langword="null" />.</exception>
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo)
	{
		return null;
	}

	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo)
	{
		return null;
	}

	/// <summary>Verifies whether all the required attributes in the element context are present and prepares the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object to validate the child content of the element.</summary>
	/// <param name="schemaInfo">An <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> object whose properties are set on successful verification that all the required attributes in the element context are present. This parameter can be <see langword="null" />.</param>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">One or more of the required attributes in the current element context were not found.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="M:System.Xml.Schema.XmlSchemaValidator.ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo)" /> method was not called in the correct sequence. For example, calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo)" /> after calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.SkipToEndElement(System.Xml.Schema.XmlSchemaInfo)" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">One or more of the parameters specified are <see langword="null" />.</exception>
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo)
	{
	}

	/// <summary>Validates whether the text returned by the <see cref="T:System.Xml.Schema.XmlValueGetter" /> object specified is allowed in the current element context, and accumulates the text for validation if the current element has simple content.</summary>
	/// <param name="elementValue">An <see cref="T:System.Xml.Schema.XmlValueGetter" /><see langword="delegate" /> used to pass the text value as a Common Language Runtime (CLR) type compatible with the XML Schema Definition Language (XSD) type of the attribute.</param>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The text <see langword="string" /> specified is not allowed in the current element context.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateText" /> method was not called in the correct sequence. For example, the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateText" /> method is called after calling <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateAttribute" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">The text <see langword="string" /> parameter cannot be <see langword="null" />.</exception>
	public void ValidateText(XmlValueGetter elementValue)
	{
	}

	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter)
	{
	}

	/// <summary>Validates whether the white space returned by the <see cref="T:System.Xml.Schema.XmlValueGetter" /> object specified is allowed in the current element context, and accumulates the white space for validation if the current element has simple content.</summary>
	/// <param name="elementValue">An <see cref="T:System.Xml.Schema.XmlValueGetter" /><see langword="delegate" /> used to pass the white space value as a Common Language Runtime (CLR) type compatible with the XML Schema Definition Language (XSD) type of the attribute.</param>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">White space is not allowed in the current element context.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateWhitespace" /> method was not called in the correct sequence. For example, if the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateWhitespace" /> method is called after calling <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateAttribute" />.</exception>
	public void ValidateWhitespace(XmlValueGetter elementValue)
	{
	}

	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter)
	{
	}

	/// <summary>Verifies if the text content of the element is valid according to its data type for elements with simple content, and verifies if the content of the current element is complete for elements with complex content.</summary>
	/// <param name="schemaInfo">An <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> object whose properties are set on successful validation of the element. This parameter can be <see langword="null" />.</param>
	/// <returns>The parsed, typed text value of the element if the element has simple content.</returns>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The element's content is not valid.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateEndElement" /> method was not called in the correct sequence. For example, if the <see cref="Overload:System.Xml.Schema.XmlSchemaValidator.ValidateEndElement" /> method is called after calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.SkipToEndElement(System.Xml.Schema.XmlSchemaInfo)" />.</exception>
	public object ValidateEndElement(XmlSchemaInfo schemaInfo)
	{
		return null;
	}

	/// <summary>Skips validation of the current element content and prepares the <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> object to validate content in the parent element's context.</summary>
	/// <param name="schemaInfo">An <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> object whose properties are set if the current element content is successfully skipped. This parameter can be <see langword="null" />.</param>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="M:System.Xml.Schema.XmlSchemaValidator.SkipToEndElement(System.Xml.Schema.XmlSchemaInfo)" /> method was not called in the correct sequence. For example, calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.SkipToEndElement(System.Xml.Schema.XmlSchemaInfo)" /> after calling <see cref="M:System.Xml.Schema.XmlSchemaValidator.SkipToEndElement(System.Xml.Schema.XmlSchemaInfo)" />.</exception>
	public void SkipToEndElement(XmlSchemaInfo schemaInfo)
	{
	}

	/// <summary>Ends validation and checks identity constraints for the entire XML document.</summary>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">An identity constraint error was found in the XML document.</exception>
	public void EndValidation()
	{
	}

	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData)
	{
	}

	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo)
	{
	}

	internal string GetConcatenatedValue()
	{
		return null;
	}

	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue)
	{
		return null;
	}

	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation)
	{
	}

	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext)
	{
		invalidElementInContext = default(bool);
		return null;
	}

	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member)
	{
		return null;
	}

	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType)
	{
		memberType = null;
		return null;
	}

	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType)
	{
		memberType = null;
		return null;
	}

	private string GetTypeName(SchemaDeclBase decl)
	{
		return null;
	}

	private void SaveTextValue(object value)
	{
	}

	private void Push(XmlQualifiedName elementName)
	{
	}

	private void Pop()
	{
	}

	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle)
	{
		return null;
	}

	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound)
	{
		return null;
	}

	private void ThrowDeclNotFoundWarningOrError(bool declFound)
	{
	}

	private void CheckElementProperties()
	{
	}

	private void ValidateStartElementIdentityConstraints()
	{
	}

	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName)
	{
		return null;
	}

	private void AddXmlNamespaceSchema()
	{
	}

	internal object CheckMixedValueConstraint(string elementValue)
	{
		return null;
	}

	private void LoadSchema(string uri, string url)
	{
	}

	internal void RecompileSchemaSet()
	{
	}

	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue)
	{
	}

	private object CheckAttributeValue(object value, SchemaAttDef attdef)
	{
		return null;
	}

	private object CheckElementValue(string stringValue)
	{
		return null;
	}

	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue)
	{
	}

	private object FindId(string name)
	{
		return null;
	}

	private void CheckForwardRefs()
	{
	}

	private void CheckStateTransition(ValidatorState toState, string methodName)
	{
	}

	private void ClearPSVI()
	{
	}

	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl)
	{
	}

	private XmlSchemaElement GetSchemaElement()
	{
		return null;
	}

	internal string GetDefaultAttributePrefix(string attributeNS)
	{
		return null;
	}

	private void AddIdentityConstraints()
	{
	}

	private void ElementIdentityConstraints()
	{
	}

	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype)
	{
	}

	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype)
	{
	}

	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet)
	{
	}

	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet)
	{
	}

	internal static string PrintExpectedElements(ArrayList expected, bool getParticles)
	{
		return null;
	}

	private static string PrintNames(ArrayList expected)
	{
		return null;
	}

	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder)
	{
	}

	private static void EnumerateAny(StringBuilder builder, string namespaces)
	{
	}

	internal static string QNameString(string localName, string ns)
	{
		return null;
	}

	internal static string BuildElementName(XmlQualifiedName qname)
	{
		return null;
	}

	internal static string BuildElementName(string localName, string ns)
	{
		return null;
	}

	private void ProcessEntity(string name)
	{
	}

	private void SendValidationEvent(string code)
	{
	}

	private void SendValidationEvent(string code, string[] args)
	{
	}

	private void SendValidationEvent(string code, string arg)
	{
	}

	private void SendValidationEvent(string code, string arg1, string arg2)
	{
	}

	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity)
	{
	}

	private void SendValidationEvent(string code, string[] args, Exception innerException)
	{
	}

	private void SendValidationEvent(XmlSchemaValidationException e)
	{
	}

	private void SendValidationEvent(XmlSchemaException e)
	{
	}

	private void SendValidationEvent(string code, string msg, XmlSeverityType severity)
	{
	}

	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity)
	{
	}

	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity)
	{
	}
}
