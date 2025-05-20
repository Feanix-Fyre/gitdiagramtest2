using System.Xml.Schema;
using System.Xml.XPath;

namespace System.Xml;

/// <summary>Represents an element.</summary>
public class XmlElement : XmlLinkedNode
{
	private XmlName name;

	private XmlAttributeCollection attributes;

	private XmlLinkedNode lastChild;

	internal XmlName XmlName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the qualified name of the node.</summary>
	/// <returns>The qualified name of the node. For <see langword="XmlElement" /> nodes, this is the tag name of the element.</returns>
	public override string Name => null;

	/// <summary>Gets the local name of the current node.</summary>
	/// <returns>The name of the current node with the prefix removed. For example, <see langword="LocalName" /> is book for the element &lt;bk:book&gt;.</returns>
	public override string LocalName => null;

	/// <summary>Gets the namespace URI of this node.</summary>
	/// <returns>The namespace URI of this node. If there is no namespace URI, this property returns String.Empty.</returns>
	public override string NamespaceURI => null;

	/// <summary>Gets or sets the namespace prefix of this node.</summary>
	/// <returns>The namespace prefix of this node. If there is no prefix, this property returns String.Empty.</returns>
	/// <exception cref="T:System.ArgumentException">This node is read-only </exception>
	/// <exception cref="T:System.Xml.XmlException">The specified prefix contains an invalid character.The specified prefix is malformed.The namespaceURI of this node is <see langword="null" />.The specified prefix is "xml" and the namespaceURI of this node is different from http://www.w3.org/XML/1998/namespace. </exception>
	public override string Prefix
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the type of the current node.</summary>
	/// <returns>The node type. For <see langword="XmlElement" /> nodes, this value is XmlNodeType.Element.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets the parent of this node (for nodes that can have parents).</summary>
	/// <returns>The <see langword="XmlNode" /> that is the parent of the current node. If a node has just been created and not yet added to the tree, or if it has been removed from the tree, the parent is <see langword="null" />. For all other nodes, the value returned depends on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node. The following table describes the possible return values for the <see langword="ParentNode" /> property.</returns>
	public override XmlNode ParentNode => null;

	/// <summary>Gets the <see cref="T:System.Xml.XmlDocument" /> to which this node belongs.</summary>
	/// <returns>The <see langword="XmlDocument" /> to which this element belongs.</returns>
	public override XmlDocument OwnerDocument => null;

	internal override bool IsContainer => false;

	/// <summary>Gets or sets the tag format of the element.</summary>
	/// <returns>Returns <see langword="true" /> if the element is to be serialized in the short tag format "&lt;item/&gt;"; <see langword="false" /> for the long format "&lt;item&gt;&lt;/item&gt;".When setting this property, if set to <see langword="true" />, the children of the element are removed and the element is serialized in the short tag format. If set to <see langword="false" />, the value of the property is changed (regardless of whether or not the element has content); if the element is empty, it is serialized in the long format.This property is a Microsoft extension to the Document Object Model (DOM).</returns>
	public bool IsEmpty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal override XmlLinkedNode LastNode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets an <see cref="T:System.Xml.XmlAttributeCollection" /> containing the list of attributes for this node.</summary>
	/// <returns>
	///     <see cref="T:System.Xml.XmlAttributeCollection" /> containing the list of attributes for this node.</returns>
	public override XmlAttributeCollection Attributes => null;

	/// <summary>Gets a <see langword="boolean" /> value indicating whether the current node has any attributes.</summary>
	/// <returns>
	///     <see langword="true" /> if the current node has attributes; otherwise, <see langword="false" />.</returns>
	public virtual bool HasAttributes => false;

	/// <summary>Gets the post schema validation infoset that has been assigned to this node as a result of schema validation.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object containing the post schema validation infoset of this node.</returns>
	public override IXmlSchemaInfo SchemaInfo => null;

	/// <summary>Gets or sets the markup representing just the children of this node.</summary>
	/// <returns>The markup of the children of this node.</returns>
	/// <exception cref="T:System.Xml.XmlException">The XML specified when setting this property is not well-formed. </exception>
	public override string InnerXml
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the concatenated values of the node and all its children.</summary>
	/// <returns>The concatenated values of the node and all its children.</returns>
	public override string InnerText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the <see cref="T:System.Xml.XmlNode" /> immediately following this element.</summary>
	/// <returns>The <see langword="XmlNode" /> immediately following this element.</returns>
	public override XmlNode NextSibling => null;

	internal override XPathNodeType XPNodeType => default(XPathNodeType);

	internal override string XPLocalName => null;

	internal XmlElement(XmlName name, bool empty, XmlDocument doc)
		: base(null)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlElement" /> class.</summary>
	/// <param name="prefix">The namespace prefix; see the <see cref="P:System.Xml.XmlElement.Prefix" /> property.</param>
	/// <param name="localName">The local name; see the <see cref="P:System.Xml.XmlElement.LocalName" /> property.</param>
	/// <param name="namespaceURI">The namespace URI; see the <see cref="P:System.Xml.XmlElement.NamespaceURI" /> property.</param>
	/// <param name="doc">The parent XML document.</param>
	protected internal XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc)
		: base(null)
	{
	}

	/// <summary>Creates a duplicate of this node.</summary>
	/// <param name="deep">
	///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself (and its attributes if the node is an <see langword="XmlElement" />). </param>
	/// <returns>The cloned node.</returns>
	public override XmlNode CloneNode(bool deep)
	{
		return null;
	}

	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
	{
		return null;
	}

	internal override bool IsValidChildType(XmlNodeType type)
	{
		return false;
	}

	/// <summary>Returns the value for the attribute with the specified name.</summary>
	/// <param name="name">The name of the attribute to retrieve. This is a qualified name. It is matched against the <see langword="Name" /> property of the matching node. </param>
	/// <returns>The value of the specified attribute. An empty string is returned if a matching attribute is not found or if the attribute does not have a specified or default value.</returns>
	public virtual string GetAttribute(string name)
	{
		return null;
	}

	/// <summary>Sets the value of the attribute with the specified name.</summary>
	/// <param name="name">The name of the attribute to create or alter. This is a qualified name. If the name contains a colon it is parsed into prefix and local name components. </param>
	/// <param name="value">The value to set for the attribute. </param>
	/// <exception cref="T:System.Xml.XmlException">The specified name contains an invalid character. </exception>
	/// <exception cref="T:System.ArgumentException">The node is read-only. </exception>
	public virtual void SetAttribute(string name, string value)
	{
	}

	/// <summary>Returns the <see langword="XmlAttribute" /> with the specified name.</summary>
	/// <param name="name">The name of the attribute to retrieve. This is a qualified name. It is matched against the <see langword="Name" /> property of the matching node. </param>
	/// <returns>The specified <see langword="XmlAttribute" /> or <see langword="null" /> if a matching attribute was not found.</returns>
	public virtual XmlAttribute GetAttributeNode(string name)
	{
		return null;
	}

	/// <summary>Adds the specified <see cref="T:System.Xml.XmlAttribute" />.</summary>
	/// <param name="newAttr">The <see langword="XmlAttribute" /> node to add to the attribute collection for this element. </param>
	/// <returns>If the attribute replaces an existing attribute with the same name, the old <see langword="XmlAttribute" /> is returned; otherwise, <see langword="null" /> is returned.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="newAttr" /> was created from a different document than the one that created this node. Or this node is read-only. </exception>
	/// <exception cref="T:System.InvalidOperationException">The <paramref name="newAttr" /> is already an attribute of another <see langword="XmlElement" /> object. You must explicitly clone <see langword="XmlAttribute" /> nodes to re-use them in other <see langword="XmlElement" /> objects. </exception>
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr)
	{
		return null;
	}

	/// <summary>Returns the value for the attribute with the specified local name and namespace URI.</summary>
	/// <param name="localName">The local name of the attribute to retrieve. </param>
	/// <param name="namespaceURI">The namespace URI of the attribute to retrieve. </param>
	/// <returns>The value of the specified attribute. An empty string is returned if a matching attribute is not found or if the attribute does not have a specified or default value.</returns>
	public virtual string GetAttribute(string localName, string namespaceURI)
	{
		return null;
	}

	/// <summary>Sets the value of the attribute with the specified local name and namespace URI.</summary>
	/// <param name="localName">The local name of the attribute. </param>
	/// <param name="namespaceURI">The namespace URI of the attribute. </param>
	/// <param name="value">The value to set for the attribute. </param>
	/// <returns>The attribute value.</returns>
	public virtual string SetAttribute(string localName, string namespaceURI, string value)
	{
		return null;
	}

	/// <summary>Returns the <see cref="T:System.Xml.XmlAttribute" /> with the specified local name and namespace URI.</summary>
	/// <param name="localName">The local name of the attribute. </param>
	/// <param name="namespaceURI">The namespace URI of the attribute. </param>
	/// <returns>The specified <see langword="XmlAttribute" /> or <see langword="null" /> if a matching attribute was not found.</returns>
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI)
	{
		return null;
	}

	/// <summary>Adds the specified <see cref="T:System.Xml.XmlAttribute" />.</summary>
	/// <param name="localName">The local name of the attribute. </param>
	/// <param name="namespaceURI">The namespace URI of the attribute. </param>
	/// <returns>The <see langword="XmlAttribute" /> to add.</returns>
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI)
	{
		return null;
	}

	/// <summary>Determines whether the current node has an attribute with the specified name.</summary>
	/// <param name="name">The name of the attribute to find. This is a qualified name. It is matched against the <see langword="Name" /> property of the matching node. </param>
	/// <returns>
	///     <see langword="true" /> if the current node has the specified attribute; otherwise, <see langword="false" />.</returns>
	public virtual bool HasAttribute(string name)
	{
		return false;
	}

	/// <summary>Saves the current node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public override void WriteTo(XmlWriter w)
	{
	}

	private static void WriteElementTo(XmlWriter writer, XmlElement e)
	{
	}

	private void WriteStartElement(XmlWriter w)
	{
	}

	/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public override void WriteContentTo(XmlWriter w)
	{
	}

	/// <summary>Removes all specified attributes from the element. Default attributes are not removed.</summary>
	public virtual void RemoveAllAttributes()
	{
	}

	/// <summary>Removes all specified attributes and children of the current node. Default attributes are not removed.</summary>
	public override void RemoveAll()
	{
	}

	internal void RemoveAllChildren()
	{
	}

	internal override void SetParent(XmlNode node)
	{
	}
}
