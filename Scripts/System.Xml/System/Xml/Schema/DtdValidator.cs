using System.Collections;

namespace System.Xml.Schema;

internal sealed class DtdValidator : BaseValidator
{
	private class NamespaceManager : XmlNamespaceManager
	{
		public override string LookupNamespace(string prefix)
		{
			return null;
		}
	}

	private static NamespaceManager namespaceManager;

	private HWStack validationStack;

	private Hashtable attPresence;

	private XmlQualifiedName name;

	private Hashtable IDs;

	private IdRefNode idRefListHead;

	private bool processIdentityConstraints;

	public override bool PreserveWhitespace => false;

	internal DtdValidator(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints)
		: base(null)
	{
	}

	private void Init()
	{
	}

	public override void Validate()
	{
	}

	private bool MeetsStandAloneConstraint()
	{
		return false;
	}

	private void ValidatePIComment()
	{
	}

	private void ValidateElement()
	{
	}

	private void ValidateChildElement()
	{
	}

	private void ValidateStartElement()
	{
	}

	private void ValidateEndStartElement()
	{
	}

	private void ProcessElement()
	{
	}

	public override void CompleteValidation()
	{
	}

	private void ValidateEndElement()
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

	private bool GenEntity(XmlQualifiedName qname)
	{
		return false;
	}

	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity)
	{
		return null;
	}

	private void CheckForwardRefs()
	{
	}

	private void Push(XmlQualifiedName elementName)
	{
	}

	private bool Pop()
	{
		return false;
	}

	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter)
	{
	}

	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr)
	{
	}
}
