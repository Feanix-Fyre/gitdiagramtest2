using System.Collections;

namespace System.Xml.Schema;

internal sealed class DfaContentValidator : ContentValidator
{
	private int[][] transitionTable;

	private SymbolsDictionary symbols;

	internal DfaContentValidator(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		: base(default(XmlSchemaContentType))
	{
	}

	public override void InitValidation(ValidationState context)
	{
	}

	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
	{
		errorCode = default(int);
		return null;
	}

	public override bool CompleteValidation(ValidationState context)
	{
		return false;
	}

	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly)
	{
		return null;
	}

	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet)
	{
		return null;
	}
}
