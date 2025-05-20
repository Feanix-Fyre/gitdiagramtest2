using System.Collections;

namespace System.Xml.Serialization;

/// <summary>Creates typed versions of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> for more efficient serialization.</summary>
public class XmlSerializerFactory
{
	private static Hashtable serializersBySource;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializerFactory" /> class. </summary>
	public XmlSerializerFactory()
	{
	}

	/// <summary>Returns a derivation of the <see cref="T:System.Xml.Serialization.XmlSerializerFactory" /> class that is used to serialize the specified type.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> to serialize.</param>
	/// <returns>A derivation of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that is specifically created to serialize the specified type.</returns>
	public XmlSerializer CreateSerializer(Type type)
	{
		return null;
	}

	/// <summary>Returns a derivation of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML documents, and vice versa. Specifies the object that represents the XML root element.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> to serialize.</param>
	/// <param name="root">An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that represents the XML root element.</param>
	/// <returns>A derivation of the <see cref="T:System.Xml.Serialization.XmlSerializer" />.</returns>
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root)
	{
		return null;
	}

	/// <summary>Returns a derivation of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML document instances, and vice versa. Each object to be serialized can itself contain instances of classes, which this overload can override with other classes. This overload also specifies the default namespace for all the XML elements, and the class to use as the XML root element.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> to serialize.</param>
	/// <param name="overrides">An <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> that contains fields that override the default serialization behavior.</param>
	/// <param name="extraTypes">A <see cref="T:System.Type" /> array of additional object types to serialize.</param>
	/// <param name="root">An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that represents the XML root element.</param>
	/// <param name="defaultNamespace">The default namespace of all XML elements in the XML document. </param>
	/// <returns>A derivation of the <see cref="T:System.Xml.Serialization.XmlSerializer" />.</returns>
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace)
	{
		return null;
	}
}
