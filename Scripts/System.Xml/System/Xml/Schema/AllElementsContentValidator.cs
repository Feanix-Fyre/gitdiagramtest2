using System.Collections;

namespace System.Xml.Schema;

internal sealed class AllElementsContentValidator : ContentValidator
{
	private Hashtable elements;

	private object[] particles;

	private BitSet isRequired;

	private int countRequired;

	public override bool IsEmptiable => false;

	public AllElementsContentValidator(XmlSchemaContentType contentType, int size, bool isEmptiable)
		: base(default(XmlSchemaContentType))
	{
	}

	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable)
	{
		return false;
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
