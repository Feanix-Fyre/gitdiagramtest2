namespace System.Xml.Schema;

/// <summary>Represents the post-schema-validation infoset of a validated XML node.</summary>
public class XmlSchemaInfo : IXmlSchemaInfo
{
	private bool isDefault;

	private bool isNil;

	private XmlSchemaElement schemaElement;

	private XmlSchemaAttribute schemaAttribute;

	private XmlSchemaType schemaType;

	private XmlSchemaSimpleType memberType;

	private XmlSchemaValidity validity;

	private XmlSchemaContentType contentType;

	/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaValidity" /> value of this validated XML node.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaValidity" /> value.</returns>
	public XmlSchemaValidity Validity
	{
		get
		{
			return default(XmlSchemaValidity);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating if this validated XML node was set as the result of a default being applied during XML Schema Definition Language (XSD) schema validation.</summary>
	/// <returns>A <see langword="bool" /> value.</returns>
	public bool IsDefault
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating if the value for this validated XML node is nil.</summary>
	/// <returns>A <see langword="bool" /> value.</returns>
	public bool IsNil
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the dynamic schema type for this validated XML node.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> object.</returns>
	public XmlSchemaSimpleType MemberType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the static XML Schema Definition Language (XSD) schema type of this validated XML node.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaType" /> object.</returns>
	public XmlSchemaType SchemaType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the compiled <see cref="T:System.Xml.Schema.XmlSchemaElement" /> object that corresponds to this validated XML node.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaElement" /> object.</returns>
	public XmlSchemaElement SchemaElement
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the compiled <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> object that corresponds to this validated XML node.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> object.</returns>
	public XmlSchemaAttribute SchemaAttribute
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaContentType" /> object that corresponds to the content type of this validated XML node.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaContentType" /> object.</returns>
	public XmlSchemaContentType ContentType => default(XmlSchemaContentType);

	internal XmlSchemaType XmlType => null;

	internal bool HasDefaultValue => false;

	internal bool IsUnionType => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaInfo" /> class.</summary>
	public XmlSchemaInfo()
	{
	}

	internal XmlSchemaInfo(XmlSchemaValidity validity)
	{
	}

	internal void Clear()
	{
	}
}
