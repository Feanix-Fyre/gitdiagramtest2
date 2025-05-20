using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="group" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class defines groups at the <see langword="schema" /> level that are referenced from the complex types. It groups a set of element declarations so that they can be incorporated as a group into complex type definitions.</summary>
public class XmlSchemaGroup : XmlSchemaAnnotated
{
	private string name;

	private XmlSchemaGroupBase particle;

	private XmlSchemaParticle canonicalParticle;

	private XmlQualifiedName qname;

	private XmlSchemaGroup redefined;

	private int selfReferenceCount;

	/// <summary>Gets or sets the name of the schema group.</summary>
	/// <returns>The name of the schema group.</returns>
	[XmlAttribute("name")]
	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets one of the <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes.</summary>
	/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes.</returns>
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaGroupBase Particle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the qualified name of the schema group.</summary>
	/// <returns>An <see cref="T:System.Xml.XmlQualifiedName" /> object representing the qualified name of the schema group.</returns>
	[XmlIgnore]
	public XmlQualifiedName QualifiedName => null;

	[XmlIgnore]
	internal XmlSchemaParticle CanonicalParticle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal XmlSchemaGroup Redefined
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal int SelfReferenceCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal override string NameAttribute
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal void SetQualifiedName(XmlQualifiedName value)
	{
	}

	internal override XmlSchemaObject Clone()
	{
		return null;
	}

	internal XmlSchemaObject Clone(XmlSchema parentSchema)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaGroup" /> class.</summary>
	public XmlSchemaGroup()
	{
	}
}
