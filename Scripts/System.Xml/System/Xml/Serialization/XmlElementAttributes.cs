using System.Collections;
using System.Text;

namespace System.Xml.Serialization;

/// <summary>Represents a collection of <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> objects used by the <see cref="T:System.Xml.Serialization.XmlSerializer" /> to override the default way it serializes a class.</summary>
public class XmlElementAttributes : CollectionBase
{
	/// <summary>Gets or sets the element at the specified index.</summary>
	/// <param name="index">The zero-based index of the element to get or set. </param>
	/// <returns>The element at the specified index.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="index" /> is not a valid index in the <see cref="T:System.Xml.Serialization.XmlElementAttributes" />. </exception>
	/// <exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Xml.Serialization.XmlElementAttributes" /> is read-only. </exception>
	public XmlElementAttribute this[int index] => null;

	internal int Order => 0;

	/// <summary>Adds an <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> to the collection.</summary>
	/// <param name="attribute">The <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> to add. </param>
	/// <returns>The zero-based index of the newly added item.</returns>
	public int Add(XmlElementAttribute attribute)
	{
		return 0;
	}

	internal void AddKeyHash(StringBuilder sb)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlElementAttributes" /> class. </summary>
	public XmlElementAttributes()
	{
	}
}
