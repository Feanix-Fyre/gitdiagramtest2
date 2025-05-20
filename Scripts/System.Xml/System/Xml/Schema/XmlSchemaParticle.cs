using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Abstract class for that is the base class for all particle types (e.g. <see cref="T:System.Xml.Schema.XmlSchemaAny" />).</summary>
public abstract class XmlSchemaParticle : XmlSchemaAnnotated
{
	[Flags]
	private enum Occurs
	{
		None = 0,
		Min = 1,
		Max = 2
	}

	private class EmptyParticle : XmlSchemaParticle
	{
		internal override bool IsEmpty => false;
	}

	private decimal minOccurs;

	private decimal maxOccurs;

	private Occurs flags;

	internal static readonly XmlSchemaParticle Empty;

	/// <summary>Gets or sets the number as a string value. The minimum number of times the particle can occur.</summary>
	/// <returns>The number as a string value. <see langword="String.Empty" /> indicates that <see langword="MinOccurs" /> is equal to the default value. The default is a null reference.</returns>
	[XmlAttribute("minOccurs")]
	public string MinOccursString
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the number as a string value. Maximum number of times the particle can occur.</summary>
	/// <returns>The number as a string value. <see langword="String.Empty" /> indicates that <see langword="MaxOccurs" /> is equal to the default value. The default is a null reference.</returns>
	[XmlAttribute("maxOccurs")]
	public string MaxOccursString
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the minimum number of times the particle can occur.</summary>
	/// <returns>The minimum number of times the particle can occur. The default is 1.</returns>
	[XmlIgnore]
	public decimal MinOccurs
	{
		get
		{
			return default(decimal);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the maximum number of times the particle can occur.</summary>
	/// <returns>The maximum number of times the particle can occur. The default is 1.</returns>
	[XmlIgnore]
	public decimal MaxOccurs
	{
		get
		{
			return default(decimal);
		}
		set
		{
		}
	}

	internal virtual bool IsEmpty => false;

	internal virtual string NameString => null;

	internal XmlQualifiedName GetQualifiedName()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaParticle" /> class.</summary>
	protected XmlSchemaParticle()
	{
	}
}
