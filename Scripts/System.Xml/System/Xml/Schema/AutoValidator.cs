namespace System.Xml.Schema;

internal class AutoValidator : BaseValidator
{
	public override bool PreserveWhitespace => false;

	public AutoValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling)
		: base(null)
	{
	}

	public override void Validate()
	{
	}

	public override void CompleteValidation()
	{
	}

	public override object FindId(string name)
	{
		return null;
	}

	private ValidationType DetectValidationType()
	{
		return default(ValidationType);
	}
}
