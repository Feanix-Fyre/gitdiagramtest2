using System.Collections;
using System.Text;

namespace System.Xml.Serialization;

/// <summary>Allows you to override property, field, and class attributes when you use the <see cref="T:System.Xml.Serialization.XmlSerializer" /> to serialize or deserialize an object.</summary>
public class XmlAttributeOverrides
{
	private Hashtable overrides;

	/// <summary>Gets the object associated with the specified, base-class, type.</summary>
	/// <param name="type">The base class <see cref="T:System.Type" /> that is associated with the collection of attributes you want to retrieve. </param>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlAttributes" /> that represents the collection of overriding attributes.</returns>
	public XmlAttributes this[Type type] => null;

	/// <summary>Gets the object associated with the specified (base-class) type. The member parameter specifies the base-class member that is overridden.</summary>
	/// <param name="type">The base class <see cref="T:System.Type" /> that is associated with the collection of attributes you want. </param>
	/// <param name="member">The name of the overridden member that specifies the <see cref="T:System.Xml.Serialization.XmlAttributes" /> to return. </param>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlAttributes" /> that represents the collection of overriding attributes.</returns>
	public XmlAttributes this[Type type, string member] => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> class. </summary>
	public XmlAttributeOverrides()
	{
	}

	private TypeMember GetKey(Type type, string member)
	{
		return null;
	}

	internal void AddKeyHash(StringBuilder sb)
	{
	}
}
