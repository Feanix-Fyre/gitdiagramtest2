using System.Collections;

namespace System.Xml.Schema;

internal class ContentValidator
{
	private XmlSchemaContentType contentType;

	private bool isOpen;

	private bool isEmptiable;

	public static readonly ContentValidator Empty;

	public static readonly ContentValidator TextOnly;

	public static readonly ContentValidator Mixed;

	public static readonly ContentValidator Any;

	public XmlSchemaContentType ContentType => default(XmlSchemaContentType);

	public bool PreserveWhitespace => false;

	public virtual bool IsEmptiable => false;

	public bool IsOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ContentValidator(XmlSchemaContentType contentType)
	{
	}

	protected ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
	{
	}

	public virtual void InitValidation(ValidationState context)
	{
	}

	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
	{
		errorCode = default(int);
		return null;
	}

	public virtual bool CompleteValidation(ValidationState context)
	{
		return false;
	}

	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly)
	{
		return null;
	}

	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet)
	{
		return null;
	}

	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles)
	{
	}

	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global)
	{
	}
}
