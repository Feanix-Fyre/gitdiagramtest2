using System.Text;

namespace System.Xml.Schema;

internal class BaseValidator
{
	private XmlSchemaCollection schemaCollection;

	private IValidationEventHandling eventHandling;

	private XmlNameTable nameTable;

	private SchemaNames schemaNames;

	private PositionInfo positionInfo;

	private XmlResolver xmlResolver;

	private Uri baseUri;

	protected SchemaInfo schemaInfo;

	protected XmlValidatingReaderImpl reader;

	protected XmlQualifiedName elementName;

	protected ValidationState context;

	protected StringBuilder textValue;

	protected string textString;

	protected bool hasSibling;

	protected bool checkDatatype;

	public XmlValidatingReaderImpl Reader => null;

	public XmlSchemaCollection SchemaCollection => null;

	public XmlNameTable NameTable => null;

	public SchemaNames SchemaNames => null;

	public PositionInfo PositionInfo => null;

	public XmlResolver XmlResolver
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Uri BaseUri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValidationEventHandler EventHandler => null;

	public SchemaInfo SchemaInfo => null;

	public IDtdInfo DtdInfo
	{
		set
		{
		}
	}

	public virtual bool PreserveWhitespace => false;

	public BaseValidator(BaseValidator other)
	{
	}

	public BaseValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling)
	{
	}

	public virtual void Validate()
	{
	}

	public virtual void CompleteValidation()
	{
	}

	public virtual object FindId(string name)
	{
		return null;
	}

	public void ValidateText()
	{
	}

	public void ValidateWhitespace()
	{
	}

	private void SaveTextValue(string value)
	{
	}

	protected void SendValidationEvent(string code)
	{
	}

	protected void SendValidationEvent(string code, string[] args)
	{
	}

	protected void SendValidationEvent(string code, string arg)
	{
	}

	protected void SendValidationEvent(XmlSchemaException e)
	{
	}

	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity)
	{
	}

	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity)
	{
	}

	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
	{
	}

	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition)
	{
	}

	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition)
	{
	}

	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints)
	{
		return null;
	}
}
