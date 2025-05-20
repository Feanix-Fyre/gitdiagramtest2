namespace System.Xml.Schema;

internal class BaseProcessor
{
	private XmlNameTable nameTable;

	private SchemaNames schemaNames;

	private ValidationEventHandler eventHandler;

	private XmlSchemaCompilationSettings compilationSettings;

	private int errorCount;

	private string NsXml;

	protected XmlNameTable NameTable => null;

	protected SchemaNames SchemaNames => null;

	protected ValidationEventHandler EventHandler => null;

	protected XmlSchemaCompilationSettings CompilationSettings => null;

	protected bool HasErrors => false;

	public BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler)
	{
	}

	public BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
	{
	}

	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item)
	{
	}

	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table)
	{
		return false;
	}

	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table)
	{
		return false;
	}

	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table)
	{
		return false;
	}

	protected void SendValidationEvent(string code, XmlSchemaObject source)
	{
	}

	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source)
	{
	}

	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source)
	{
	}

	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source)
	{
	}

	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition)
	{
	}

	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity)
	{
	}

	protected void SendValidationEvent(XmlSchemaException e)
	{
	}

	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity)
	{
	}

	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
	{
	}

	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity)
	{
	}
}
