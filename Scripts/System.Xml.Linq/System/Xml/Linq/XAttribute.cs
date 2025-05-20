namespace System.Xml.Linq;

/// <summary>Represents an XML attribute.</summary>
public class XAttribute : XObject
{
	internal XAttribute next;

	internal XName name;

	internal string value;

	/// <summary>Determines if this attribute is a namespace declaration.</summary>
	/// <returns>
	///   <see langword="true" /> if this attribute is a namespace declaration; otherwise <see langword="false" />.</returns>
	public bool IsNamespaceDeclaration => false;

	/// <summary>Gets the expanded name of this attribute.</summary>
	/// <returns>An <see cref="T:System.Xml.Linq.XName" /> containing the name of this attribute.</returns>
	public XName Name => null;

	/// <summary>Gets the node type for this node.</summary>
	/// <returns>The node type. For <see cref="T:System.Xml.Linq.XAttribute" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.Attribute" />.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets or sets the value of this attribute.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the value of this attribute.</returns>
	/// <exception cref="T:System.ArgumentNullException">When setting, the <paramref name="value" /> is <see langword="null" />.</exception>
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

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XAttribute" /> class from the specified name and value.</summary>
	/// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> of the attribute.</param>
	/// <param name="value">An <see cref="T:System.Object" /> containing the value of the attribute.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> or <paramref name="value" /> parameter is <see langword="null" />.</exception>
	public XAttribute(XName name, object value)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XAttribute" /> class from another <see cref="T:System.Xml.Linq.XAttribute" /> object.</summary>
	/// <param name="other">An <see cref="T:System.Xml.Linq.XAttribute" /> object to copy from.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="other" /> parameter is <see langword="null" />.</exception>
	public XAttribute(XAttribute other)
	{
	}

	/// <summary>Converts the current <see cref="T:System.Xml.Linq.XAttribute" /> object to a string representation.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the XML text representation of an attribute and its value.</returns>
	public override string ToString()
	{
		return null;
	}

	internal string GetPrefixOfNamespace(XNamespace ns)
	{
		return null;
	}

	private static void ValidateAttribute(XName name, string value)
	{
	}
}
