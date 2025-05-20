using System.Collections;
using System.Text;

namespace System.Xml.Serialization;

/// <summary>Represents a collection of <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> objects.</summary>
public class XmlAnyElementAttributes : CollectionBase
{
	/// <summary>Gets or sets the <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> at the specified index.</summary>
	/// <param name="index">The index of the <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />. </param>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> at the specified index.</returns>
	public XmlAnyElementAttribute this[int index] => null;

	internal int Order => 0;

	/// <summary>Adds an <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> to the collection.</summary>
	/// <param name="attribute">The <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> to add. </param>
	/// <returns>The index of the newly added <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />.</returns>
	public int Add(XmlAnyElementAttribute attribute)
	{
		return 0;
	}

	internal void AddKeyHash(StringBuilder sb)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlAnyElementAttributes" /> class. </summary>
	public XmlAnyElementAttributes()
	{
	}
}
