using System.Collections;

namespace System.Xml.Schema;

internal sealed class XsdValidator : BaseValidator
{
	private int startIDConstraint;

	private HWStack validationStack;

	private Hashtable attPresence;

	private XmlNamespaceManager nsManager;

	private bool bManageNamespaces;

	private Hashtable IDs;

	private IdRefNode idRefListHead;

	private Parser inlineSchemaParser;

	private XmlSchemaContentProcessing processContents;

	private static readonly XmlSchemaDatatype dtCDATA;

	private static readonly XmlSchemaDatatype dtQName;

	private static readonly XmlSchemaDatatype dtStringArray;

	private string NsXmlNs;

	private string NsXs;

	private string NsXsi;

	private string XsiType;

	private string XsiNil;

	private string XsiSchemaLocation;

	private string XsiNoNamespaceSchemaLocation;

	private string XsdSchema;

	private bool IsInlineSchemaStarted => false;

	private bool HasSchema => false;

	public override bool PreserveWhitespace => false;

	private bool HasIdentityConstraints => false;

	internal XsdValidator(BaseValidator validator)
		: base(null)
	{
	}

	internal XsdValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling)
		: base(null)
	{
	}

	private void Init()
	{
	}

	public override void Validate()
	{
	}

	public override void CompleteValidation()
	{
	}

	private void ProcessInlineSchema()
	{
	}

	private void ValidateElement()
	{
	}

	private object ValidateChildElement()
	{
		return null;
	}

	private void ProcessElement(object particle)
	{
	}

	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil)
	{
		xsiType = null;
		xsiNil = null;
	}

	private void ValidateEndElement()
	{
	}

	private SchemaElementDecl FastGetElementDecl(object particle)
	{
		return null;
	}

	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil)
	{
		return null;
	}

	private void ValidateStartElement()
	{
	}

	private void ValidateEndStartElement()
	{
	}

	private void LoadSchemaFromLocation(string uri, string url)
	{
	}

	private void LoadSchema(string uri, string url)
	{
	}

	private void ProcessTokenizedType(XmlTokenizedType ttype, string name)
	{
	}

	private void CheckValue(string value, SchemaAttDef attdef)
	{
	}

	internal void AddID(string name, object node)
	{
	}

	public override object FindId(string name)
	{
		return null;
	}

	public bool IsXSDRoot(string localName, string ns)
	{
		return false;
	}

	private void Push(XmlQualifiedName elementName)
	{
	}

	private void Pop()
	{
	}

	private void CheckForwardRefs()
	{
	}

	private void ValidateStartElementIdentityConstraints()
	{
	}

	private void AddIdentityConstraints()
	{
	}

	private void ElementIdentityConstraints()
	{
	}

	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef)
	{
	}

	private object UnWrapUnion(object typedValue)
	{
		return null;
	}

	private void EndElementIdentityConstraints()
	{
	}
}
