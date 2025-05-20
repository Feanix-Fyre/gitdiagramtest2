using System.Collections;

namespace System.Xml.Serialization;

/// <summary>Contains the XML namespaces and prefixes that the <see cref="T:System.Xml.Serialization.XmlSerializer" /> uses to generate qualified names in an XML-document instance.</summary>
public class XmlSerializerNamespaces
{
	private Hashtable namespaces;

	/// <summary>Gets the number of prefix and namespace pairs in the collection.</summary>
	/// <returns>The number of prefix and namespace pairs in the collection.</returns>
	public int Count => 0;

	internal ArrayList NamespaceList => null;

	internal Hashtable Namespaces
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> class.</summary>
	public XmlSerializerNamespaces()
	{
	}

	/// <summary>Adds a prefix and namespace pair to an <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> object.</summary>
	/// <param name="prefix">The prefix associated with an XML namespace. </param>
	/// <param name="ns">An XML namespace. </param>
	public void Add(string prefix, string ns)
	{
	}

	internal void AddInternal(string prefix, string ns)
	{
	}

	/// <summary>Gets the array of prefix and namespace pairs in an <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> object.</summary>
	/// <returns>An array of <see cref="T:System.Xml.XmlQualifiedName" /> objects that are used as qualified names in an XML document.</returns>
	public XmlQualifiedName[] ToArray()
	{
		return null;
	}
}
