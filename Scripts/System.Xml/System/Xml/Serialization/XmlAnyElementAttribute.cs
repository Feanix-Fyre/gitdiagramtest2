using System.Text;

namespace System.Xml.Serialization;

/// <summary>Specifies that the member (a field that returns an array of <see cref="T:System.Xml.XmlElement" /> or <see cref="T:System.Xml.XmlNode" /> objects) contains objects that represent any XML element that has no corresponding member in the object being serialized or deserialized.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
public class XmlAnyElementAttribute : Attribute
{
	private string elementName;

	private string ns;

	private int order;

	/// <summary>Gets or sets the XML element name.</summary>
	/// <returns>The name of the XML element.</returns>
	/// <exception cref="T:System.InvalidOperationException">The element name of an array member does not match the element name specified by the <see cref="P:System.Xml.Serialization.XmlAnyElementAttribute.Name" /> property. </exception>
	public string Name => null;

	/// <summary>Gets or sets the XML namespace generated in the XML document.</summary>
	/// <returns>An XML namespace.</returns>
	public string Namespace => null;

	/// <summary>Gets or sets the explicit order in which the elements are serialized or deserialized.</summary>
	/// <returns>The order of the code generation.</returns>
	public int Order => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> class.</summary>
	public XmlAnyElementAttribute()
	{
	}

	internal void AddKeyHash(StringBuilder sb)
	{
	}
}
