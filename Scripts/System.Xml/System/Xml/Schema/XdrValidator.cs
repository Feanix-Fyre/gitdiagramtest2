using System.Collections;

namespace System.Xml.Schema;

internal sealed class XdrValidator : BaseValidator
{
	private HWStack validationStack;

	private Hashtable attPresence;

	private XmlQualifiedName name;

	private XmlNamespaceManager nsManager;

	private bool isProcessContents;

	private Hashtable IDs;

	private IdRefNode idRefListHead;

	private Parser inlineSchemaParser;

	private bool IsInlineSchemaStarted => false;

	private bool HasSchema => false;

	public override bool PreserveWhitespace => false;

	internal XdrValidator(BaseValidator validator)
		: base(null)
	{
	}

	internal XdrValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling)
		: base(null)
	{
	}

	private void Init()
	{
	}

	public override void Validate()
	{
	}

	private void ValidateElement()
	{
	}

	private void ValidateChildElement()
	{
	}

	private void ProcessInlineSchema()
	{
	}

	private void ProcessElement()
	{
	}

	private void ValidateEndElement()
	{
	}

	private SchemaElementDecl ThoroughGetElementDecl()
	{
		return null;
	}

	private void ValidateStartElement()
	{
	}

	private void ValidateEndStartElement()
	{
	}

	private void LoadSchemaFromLocation(string uri)
	{
	}

	private void LoadSchema(string uri)
	{
	}

	private void ProcessTokenizedType(XmlTokenizedType ttype, string name)
	{
	}

	public override void CompleteValidation()
	{
	}

	private void CheckValue(string value, SchemaAttDef attdef)
	{
	}

	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos)
	{
	}

	internal void AddID(string name, object node)
	{
	}

	public override object FindId(string name)
	{
		return null;
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

	private XmlQualifiedName QualifiedName(string name, string ns)
	{
		return null;
	}
}
