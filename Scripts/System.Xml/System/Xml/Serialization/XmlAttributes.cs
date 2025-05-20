using System.Reflection;
using System.Text;

namespace System.Xml.Serialization;

/// <summary>Represents a collection of attribute objects that control how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes and deserializes an object.</summary>
public class XmlAttributes
{
	private XmlAnyAttributeAttribute xmlAnyAttribute;

	private XmlAnyElementAttributes xmlAnyElements;

	private XmlArrayAttribute xmlArray;

	private XmlArrayItemAttributes xmlArrayItems;

	private XmlAttributeAttribute xmlAttribute;

	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier;

	private object xmlDefaultValue;

	private XmlElementAttributes xmlElements;

	private XmlEnumAttribute xmlEnum;

	private bool xmlIgnore;

	private bool xmlns;

	private XmlRootAttribute xmlRoot;

	private XmlTextAttribute xmlText;

	private XmlTypeAttribute xmlType;

	/// <summary>Gets or sets the <see cref="T:System.Xml.Serialization.XmlAnyAttributeAttribute" /> to override.</summary>
	/// <returns>The <see cref="T:System.Xml.Serialization.XmlAnyAttributeAttribute" /> to override.</returns>
	public XmlAnyAttributeAttribute XmlAnyAttribute => null;

	/// <summary>Gets the collection of <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> objects to override.</summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlAnyElementAttributes" /> object that represents the collection of <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> objects.</returns>
	public XmlAnyElementAttributes XmlAnyElements => null;

	/// <summary>Gets or sets an object that specifies how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a public field or read/write property that returns an array.</summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlArrayAttribute" /> that specifies how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a public field or read/write property that returns an array.</returns>
	public XmlArrayAttribute XmlArray => null;

	/// <summary>Gets or sets a collection of objects that specify how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes items inserted into an array returned by a public field or read/write property.</summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlArrayItemAttributes" /> object that contains a collection of <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> objects.</returns>
	public XmlArrayItemAttributes XmlArrayItems => null;

	/// <summary>Gets or sets an object that specifies how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a public field or public read/write property as an XML attribute.</summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlAttributeAttribute" /> that controls the serialization of a public field or read/write property as an XML attribute.</returns>
	public XmlAttributeAttribute XmlAttribute => null;

	/// <summary>Gets or sets an object that allows you to distinguish between a set of choices.</summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlChoiceIdentifierAttribute" /> that can be applied to a class member that is serialized as an <see langword="xsi:choice" /> element.</returns>
	public XmlChoiceIdentifierAttribute XmlChoiceIdentifier => null;

	/// <summary>Gets or sets the default value of an XML element or attribute.</summary>
	/// <returns>An <see cref="T:System.Object" /> that represents the default value of an XML element or attribute.</returns>
	public object XmlDefaultValue => null;

	/// <summary>Gets a collection of objects that specify how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a public field or read/write property as an XML element.</summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlElementAttributes" /> that contains a collection of <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> objects.</returns>
	public XmlElementAttributes XmlElements => null;

	/// <summary>Gets or sets a value that specifies whether or not the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a public field or public read/write property.</summary>
	/// <returns>
	///     <see langword="true" /> if the <see cref="T:System.Xml.Serialization.XmlSerializer" /> must not serialize the field or property; otherwise, <see langword="false" />.</returns>
	public bool XmlIgnore => false;

	/// <summary>Gets or sets a value that specifies whether to keep all namespace declarations when an object containing a member that returns an <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> object is overridden.</summary>
	/// <returns>
	///     <see langword="true" /> if the namespace declarations should be kept; otherwise, <see langword="false" />.</returns>
	public bool Xmlns => false;

	/// <summary>Gets or sets an object that specifies how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a class as an XML root element.</summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that overrides a class attributed as an XML root element.</returns>
	public XmlRootAttribute XmlRoot => null;

	/// <summary>Gets or sets an object that instructs the <see cref="T:System.Xml.Serialization.XmlSerializer" /> to serialize a public field or public read/write property as XML text.</summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlTextAttribute" /> that overrides the default serialization of a public property or field.</returns>
	public XmlTextAttribute XmlText => null;

	/// <summary>Gets or sets an object that specifies how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a class to which the <see cref="T:System.Xml.Serialization.XmlTypeAttribute" /> has been applied.</summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlTypeAttribute" /> that overrides an <see cref="T:System.Xml.Serialization.XmlTypeAttribute" /> applied to a class declaration.</returns>
	public XmlTypeAttribute XmlType => null;

	internal int? Order => null;

	internal int SortableOrder => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlAttributes" /> class.</summary>
	public XmlAttributes()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlAttributes" /> class and customizes how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes and deserializes an object. </summary>
	/// <param name="provider">A class that can provide alternative implementations of attributes that control XML serialization.</param>
	public XmlAttributes(ICustomAttributeProvider provider)
	{
	}

	internal void AddKeyHash(StringBuilder sb)
	{
	}
}
