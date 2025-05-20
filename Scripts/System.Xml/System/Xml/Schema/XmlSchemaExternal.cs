using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>An abstract class. Provides information about the included schema.</summary>
public abstract class XmlSchemaExternal : XmlSchemaObject
{
	private string location;

	private Uri baseUri;

	private XmlSchema schema;

	private string id;

	private XmlAttribute[] moreAttributes;

	private Compositor compositor;

	/// <summary>Gets or sets the Uniform Resource Identifier (URI) location for the schema, which tells the schema processor where the schema physically resides.</summary>
	/// <returns>The URI location for the schema.Optional for imported schemas.</returns>
	[XmlAttribute("schemaLocation", DataType = "anyURI")]
	public string SchemaLocation
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see langword="XmlSchema" /> for the referenced schema.</summary>
	/// <returns>The <see langword="XmlSchema" /> for the referenced schema.</returns>
	[XmlIgnore]
	public XmlSchema Schema
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the string id.</summary>
	/// <returns>The string id. The default is <see langword="String.Empty" />.Optional.</returns>
	[XmlAttribute("id", DataType = "ID")]
	public string Id
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
	internal Uri BaseUri
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
	internal override string IdAttribute
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal Compositor Compositor
	{
		get
		{
			return default(Compositor);
		}
		set
		{
		}
	}

	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaExternal" /> class.</summary>
	protected XmlSchemaExternal()
	{
	}
}
