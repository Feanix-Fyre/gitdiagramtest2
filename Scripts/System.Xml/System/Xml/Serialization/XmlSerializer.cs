using System.Collections;
using System.IO;
using System.Reflection;

namespace System.Xml.Serialization;

/// <summary>Serializes and deserializes objects into and from XML documents. The <see cref="T:System.Xml.Serialization.XmlSerializer" /> enables you to control how objects are encoded into XML.</summary>
public class XmlSerializer
{
	internal class SerializerData
	{
		public MethodInfo ReaderMethod;

		public Type WriterType;

		public MethodInfo WriterMethod;

		public XmlSerializerImplementation Implementation;

		public XmlSerializationWriter CreateWriter()
		{
			return null;
		}
	}

	private static int generationThreshold;

	private static bool backgroundGeneration;

	private static bool deleteTempFiles;

	private static bool generatorFallback;

	private bool customSerializer;

	private XmlMapping typeMapping;

	private SerializerData serializerData;

	private static Hashtable serializerTypes;

	private UnreferencedObjectEventHandler onUnreferencedObject;

	private XmlAttributeEventHandler onUnknownAttribute;

	private XmlElementEventHandler onUnknownElement;

	private XmlNodeEventHandler onUnknownNode;

	internal XmlMapping Mapping => null;

	static XmlSerializer()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML documents, and deserialize XML documents into objects of the specified type.</summary>
	/// <param name="type">The type of the object that this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can serialize. </param>
	public XmlSerializer(Type type)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of type <see cref="T:System.Object" /> into XML document instances, and deserialize XML document instances into objects of type <see cref="T:System.Object" />. Each object to be serialized can itself contain instances of classes, which this overload overrides with other classes. This overload also specifies the default namespace for all the XML elements and the class to use as the XML root element.</summary>
	/// <param name="type">The type of the object that this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can serialize. </param>
	/// <param name="overrides">An <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> that extends or overrides the behavior of the class specified in the <paramref name="type" /> parameter. </param>
	/// <param name="extraTypes">A <see cref="T:System.Type" /> array of additional object types to serialize. </param>
	/// <param name="root">An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that defines the XML root element properties. </param>
	/// <param name="defaultNamespace">The default namespace of all XML elements in the XML document. </param>
	public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace)
	{
	}

	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e)
	{
	}

	internal virtual void OnUnknownElement(XmlElementEventArgs e)
	{
	}

	internal virtual void OnUnknownNode(XmlNodeEventArgs e)
	{
	}

	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e)
	{
	}

	/// <summary>Returns an object used to read the XML document to be serialized.</summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlSerializationReader" /> used to read the XML document.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
	protected virtual XmlSerializationReader CreateReader()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, returns a writer used to serialize the object.</summary>
	/// <returns>An instance that implements the <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> class.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
	protected virtual XmlSerializationWriter CreateWriter()
	{
		return null;
	}

	/// <summary>Deserializes the XML document contained by the specified <see cref="T:System.IO.TextReader" />.</summary>
	/// <param name="textReader">The <see cref="T:System.IO.TextReader" /> that contains the XML document to deserialize. </param>
	/// <returns>The <see cref="T:System.Object" /> being deserialized.</returns>
	/// <exception cref="T:System.InvalidOperationException">An error occurred during deserialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
	public object Deserialize(TextReader textReader)
	{
		return null;
	}

	/// <summary>Deserializes the XML document contained by the specified <see cref="T:System.Xml.XmlReader" />.</summary>
	/// <param name="xmlReader">The <see cref="T:System.Xml.XmlReader" /> that contains the XML document to deserialize. </param>
	/// <returns>The <see cref="T:System.Object" /> being deserialized.</returns>
	/// <exception cref="T:System.InvalidOperationException">An error occurred during deserialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
	public object Deserialize(XmlReader xmlReader)
	{
		return null;
	}

	/// <summary>Deserializes the XML document contained by the specified <see cref="T:System.Xml.Serialization.XmlSerializationReader" />.</summary>
	/// <param name="reader">The <see cref="T:System.Xml.Serialization.XmlSerializationReader" /> that contains the XML document to deserialize. </param>
	/// <returns>The deserialized object.</returns>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
	protected virtual object Deserialize(XmlSerializationReader reader)
	{
		return null;
	}

	/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.Xml.Serialization.XmlSerializationWriter" />.</summary>
	/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
	/// <param name="writer">The <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> used to write the XML document. </param>
	/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
	protected virtual void Serialize(object o, XmlSerializationWriter writer)
	{
	}

	/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.IO.TextWriter" />.</summary>
	/// <param name="textWriter">The <see cref="T:System.IO.TextWriter" /> used to write the XML document. </param>
	/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
	public void Serialize(TextWriter textWriter, object o)
	{
	}

	/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="xmlWriter">The <see cref="T:System.Xml.XmlWriter" /> used to write the XML document. </param>
	/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
	/// <exception cref="T:System.InvalidOperationException">An error occurred during serialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
	public void Serialize(XmlWriter xmlWriter, object o)
	{
	}

	/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.Xml.XmlWriter" /> and references the specified namespaces.</summary>
	/// <param name="xmlWriter">The <see cref="T:System.Xml.XmlWriter" /> used to write the XML document. </param>
	/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
	/// <param name="namespaces">The <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> referenced by the object. </param>
	/// <exception cref="T:System.InvalidOperationException">An error occurred during serialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces)
	{
	}

	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping)
	{
		return null;
	}

	private XmlSerializationReader CreateReader(XmlMapping typeMapping)
	{
		return null;
	}
}
