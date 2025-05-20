using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Xml;

/// <summary>Represents a collection of attributes that can be accessed by name or index.</summary>
public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable
{
	/// <summary>Gets the attribute with the specified index.</summary>
	/// <param name="i">The index of the attribute. </param>
	/// <returns>The <see cref="T:System.Xml.XmlAttribute" /> at the specified index.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">The index being passed in is out of range. </exception>
	[IndexerName("ItemOf")]
	public XmlAttribute this[int i] => null;

	/// <summary>Gets the attribute with the specified name.</summary>
	/// <param name="name">The qualified name of the attribute. </param>
	/// <returns>The <see cref="T:System.Xml.XmlAttribute" /> with the specified name. If the attribute does not exist, this property returns <see langword="null" />.</returns>
	[IndexerName("ItemOf")]
	public XmlAttribute this[string name] => null;

	/// <summary>Gets the attribute with the specified local name and namespace Uniform Resource Identifier (URI).</summary>
	/// <param name="localName">The local name of the attribute. </param>
	/// <param name="namespaceURI">The namespace URI of the attribute. </param>
	/// <returns>The <see cref="T:System.Xml.XmlAttribute" /> with the specified local name and namespace URI. If the attribute does not exist, this property returns <see langword="null" />.</returns>
	[IndexerName("ItemOf")]
	public XmlAttribute this[string localName, string namespaceURI] => null;

	/// <summary>For a description of this member, see <see cref="P:System.Xml.XmlAttributeCollection.System#Collections#ICollection#IsSynchronized" />.</summary>
	/// <returns>Returns <see langword="true" /> if the collection is synchronized.</returns>
	bool ICollection.IsSynchronized => false;

	/// <summary>For a description of this member, see <see cref="P:System.Xml.XmlAttributeCollection.System#Collections#ICollection#SyncRoot" />.</summary>
	/// <returns>Returns the <see cref="T:System.Object" /> that is the root of the collection.</returns>
	object ICollection.SyncRoot => null;

	/// <summary>For a description of this member, see <see cref="P:System.Xml.XmlAttributeCollection.System#Collections#ICollection#Count" />.</summary>
	/// <returns>Returns an <see langword="int" /> that contains the count of the attributes.</returns>
	int ICollection.Count => 0;

	internal XmlAttributeCollection(XmlNode parent)
		: base(null)
	{
	}

	internal int FindNodeOffsetNS(XmlAttribute node)
	{
		return 0;
	}

	/// <summary>Adds a <see cref="T:System.Xml.XmlNode" /> using its <see cref="P:System.Xml.XmlNode.Name" /> property </summary>
	/// <param name="node">An attribute node to store in this collection. The node will later be accessible using the name of the node. If a node with that name is already present in the collection, it is replaced by the new one; otherwise, the node is appended to the end of the collection. </param>
	/// <returns>If the <paramref name="node" /> replaces an existing node with the same name, the old node is returned; otherwise, the added node is returned.</returns>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="node" /> was created from a different <see cref="T:System.Xml.XmlDocument" /> than the one that created this collection.This <see langword="XmlAttributeCollection" /> is read-only. </exception>
	/// <exception cref="T:System.InvalidOperationException">
	///         <paramref name="node" /> is an <see cref="T:System.Xml.XmlAttribute" /> that is already an attribute of another <see cref="T:System.Xml.XmlElement" /> object. To re-use attributes in other elements, you must clone the <see langword="XmlAttribute" /> objects you want to re-use. </exception>
	public override XmlNode SetNamedItem(XmlNode node)
	{
		return null;
	}

	/// <summary>Inserts the specified attribute as the last node in the collection.</summary>
	/// <param name="node">The <see cref="T:System.Xml.XmlAttribute" /> to insert. </param>
	/// <returns>The <see langword="XmlAttribute" /> to append to the collection.</returns>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="node" /> was created from a document different from the one that created this collection. </exception>
	public XmlAttribute Append(XmlAttribute node)
	{
		return null;
	}

	/// <summary>Removes the specified attribute from the collection.</summary>
	/// <param name="node">The <see cref="T:System.Xml.XmlAttribute" /> to remove. </param>
	/// <returns>The node removed or <see langword="null" /> if it is not found in the collection.</returns>
	public XmlAttribute Remove(XmlAttribute node)
	{
		return null;
	}

	/// <summary>Removes the attribute corresponding to the specified index from the collection.</summary>
	/// <param name="i">The index of the node to remove. The first node has index 0. </param>
	/// <returns>Returns <see langword="null" /> if there is no attribute at the specified index.</returns>
	public XmlAttribute RemoveAt(int i)
	{
		return null;
	}

	/// <summary>Removes all attributes from the collection.</summary>
	public void RemoveAll()
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.XmlAttributeCollection.CopyTo(System.Xml.XmlAttribute[],System.Int32)" />.</summary>
	/// <param name="array">The array that is the destination of the objects copied from this collection. </param>
	/// <param name="index">The index in the array where copying begins. </param>
	void ICollection.CopyTo(Array array, int index)
	{
	}

	internal override XmlNode AddNode(XmlNode node)
	{
		return null;
	}

	internal override XmlNode InsertNodeAt(int i, XmlNode node)
	{
		return null;
	}

	internal override XmlNode RemoveNodeAt(int i)
	{
		return null;
	}

	internal void Detach(XmlAttribute attr)
	{
	}

	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr)
	{
	}

	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr)
	{
	}

	internal int RemoveDuplicateAttribute(XmlAttribute attr)
	{
		return 0;
	}

	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName)
	{
		return false;
	}

	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal)
	{
	}

	internal XmlAttribute InternalAppendAttribute(XmlAttribute node)
	{
		return null;
	}
}
