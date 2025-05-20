using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Abstract class for all facets that are used when simple types are derived by restriction.</summary>
public abstract class XmlSchemaFacet : XmlSchemaAnnotated
{
	private string value;

	private bool isFixed;

	private FacetType facetType;

	/// <summary>Gets or sets the <see langword="value" /> attribute of the facet.</summary>
	/// <returns>The value attribute.</returns>
	[XmlAttribute("value")]
	public string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets information that indicates that this facet is fixed.</summary>
	/// <returns>If <see langword="true" />, value is fixed; otherwise, <see langword="false" />. The default is <see langword="false" />.Optional.</returns>
	[XmlAttribute("fixed")]
	[DefaultValue(false)]
	public virtual bool IsFixed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal FacetType FacetType
	{
		get
		{
			return default(FacetType);
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaFacet" /> class.</summary>
	protected XmlSchemaFacet()
	{
	}
}
