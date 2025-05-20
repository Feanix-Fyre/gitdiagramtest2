namespace System.Xml.Serialization;

/// <summary>Defines the reader, writer, and methods for pre-generated, typed serializers.</summary>
public abstract class XmlSerializerImplementation
{
	/// <summary>Gets the XML writer object for the serializer.</summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> that is used to write to an XML data stream or document.</returns>
	public virtual XmlSerializationWriter Writer => null;
}
