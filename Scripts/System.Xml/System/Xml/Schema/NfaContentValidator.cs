using System.Collections;

namespace System.Xml.Schema;

internal sealed class NfaContentValidator : ContentValidator
{
	private BitSet firstpos;

	private BitSet[] followpos;

	private SymbolsDictionary symbols;

	private Positions positions;

	private int endMarkerPos;

	internal NfaContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
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
