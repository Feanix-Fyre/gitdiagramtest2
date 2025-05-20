using System.Collections.Generic;
using System.Xml.Schema;

namespace System.Xml;

internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
{
	private enum ParsingFunction
	{
		Read = 0,
		Init = 1,
		ParseDtdFromContext = 2,
		ResolveEntityInternally = 3,
		InReadBinaryContent = 4,
		ReaderClosed = 5,
		Error = 6,
		None = 7
	}

	internal class ValidationEventHandling : IValidationEventHandling
	{
		private XmlValidatingReaderImpl reader;

		private ValidationEventHandler eventHandler;

		object IValidationEventHandling.EventHandler => null;

		internal ValidationEventHandling(XmlValidatingReaderImpl reader)
		{
		}

		void IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity)
		{
		}

		internal void AddHandler(ValidationEventHandler handler)
		{
		}
	}

	private XmlReader coreReader;

	private XmlTextReaderImpl coreReaderImpl;

	private IXmlNamespaceResolver coreReaderNSResolver;

	private ValidationType validationType;

	private BaseValidator validator;

	private XmlSchemaCollection schemaCollection;

	private bool processIdentityConstraints;

	private ParsingFunction parsingFunction;

	private ValidationEventHandling eventHandling;

	private XmlParserContext parserContext;

	private ReadContentAsBinaryHelper readBinaryHelper;

	private XmlReader outerReader;

	private static XmlResolver s_tempResolver;

	public override XmlReaderSettings Settings => null;

	public override XmlNodeType NodeType => default(XmlNodeType);

	public override string Name => null;

	public override string LocalName => null;

	public override string NamespaceURI => null;

	public override string Prefix => null;

	public override string Value => null;

	public override int Depth => 0;

	public override string BaseURI => null;

	public override bool IsEmptyElement => false;

	public override bool IsDefault => false;

	public override char QuoteChar => '\0';

	public override XmlSpace XmlSpace => default(XmlSpace);

	public override string XmlLang => null;

	public override ReadState ReadState => default(ReadState);

	public override bool EOF => false;

	public override XmlNameTable NameTable => null;

	public override int AttributeCount => 0;

	public override bool CanResolveEntity => false;

	public int LineNumber => 0;

	public int LinePosition => 0;

	internal ValidationType ValidationType => default(ValidationType);

	internal XmlSchemaCollection Schemas => null;

	internal bool Namespaces => false;

	internal BaseValidator Validator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal override XmlNamespaceManager NamespaceManager => null;

	internal bool StandAlone => false;

	internal object SchemaTypeObject
	{
		set
		{
		}
	}

	internal object TypedValueObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal override IDtdInfo DtdInfo => null;

	internal XmlValidatingReaderImpl(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints)
	{
	}

	public override string GetAttribute(string name)
	{
		return null;
	}

	public override string GetAttribute(string localName, string namespaceURI)
	{
		return null;
	}

	public override string GetAttribute(int i)
	{
		return null;
	}

	public override bool MoveToAttribute(string name)
	{
		return false;
	}

	public override void MoveToAttribute(int i)
	{
	}

	public override bool MoveToFirstAttribute()
	{
		return false;
	}

	public override bool MoveToNextAttribute()
	{
		return false;
	}

	public override bool MoveToElement()
	{
		return false;
	}

	public override bool Read()
	{
		return false;
	}

	public override void Close()
	{
	}

	public override string LookupNamespace(string prefix)
	{
		return null;
	}

	public override bool ReadAttributeValue()
	{
		return false;
	}

	public override void ResolveEntity()
	{
	}

	internal void MoveOffEntityReference()
	{
	}

	public override string ReadString()
	{
		return null;
	}

	public bool HasLineInfo()
	{
		return false;
	}

	IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
	{
		return null;
	}

	string IXmlNamespaceResolver.LookupNamespace(string prefix)
	{
		return null;
	}

	string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
	{
		return null;
	}

	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
	{
		return null;
	}

	internal string LookupPrefix(string namespaceName)
	{
		return null;
	}

	private void ParseDtdFromParserContext()
	{
	}

	private void ValidateDtd()
	{
	}

	private void ResolveEntityInternally()
	{
	}

	private void SetupValidation(ValidationType valType)
	{
	}

	private XmlResolver GetResolver()
	{
		return null;
	}

	private void ProcessCoreReaderEvent()
	{
	}

	internal bool AddDefaultAttribute(SchemaAttDef attdef)
	{
		return false;
	}

	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader)
	{
	}
}
