using System.Xml.Schema;
using System.Xml.XPath;

namespace System.Xml;

/// <summary>Represents an attribute. Valid and default values for the attribute are defined in a document type definition (DTD) or schema.</summary>
public class XmlAttribute : XmlNode
{
	private XmlName name;

	private XmlLinkedNode lastChild;

	internal int LocalNameHash => 0;

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

	/// <summary>Gets the parent of this node. For <see langword="XmlAttribute" /> nodes, this property always returns <see langword="null" />.</summary>
	/// <returns>For <see langword="XmlAttribute" /> nodes, this property always returns <see langword="null" />.</returns>
	public override XmlNode ParentNode => null;

	/// <summary>Gets the qualified name of the node.</summary>
	/// <returns>The qualified name of the attribute node.</returns>
	public override string Name => null;

	/// <summary>Gets the local name of the node.</summary>
	/// <returns>The name of the attribute node with the prefix removed. In the following example &lt;book bk:genre= 'novel'&gt;, the <see langword="LocalName" /> of the attribute is <see langword="genre" />.</returns>
	public override string LocalName => null;

	/// <summary>Gets the namespace URI of this node.</summary>
	/// <returns>The namespace URI of this node. If the attribute is not explicitly given a namespace, this property returns String.Empty.</returns>
	public override string NamespaceURI => null;

	/// <summary>Gets or sets the namespace prefix of this node.</summary>
	/// <returns>The namespace prefix of this node. If there is no prefix, this property returns String.Empty.</returns>
	/// <exception cref="T:System.ArgumentException">This node is read-only.</exception>
	/// <exception cref="T:System.Xml.XmlException">The specified prefix contains an invalid character.The specified prefix is malformed.The namespaceURI of this node is <see langword="null" />.The specified prefix is "xml", and the namespaceURI of this node is different from "http://www.w3.org/XML/1998/namespace".This node is an attribute, the specified prefix is "xmlns", and the namespaceURI of this node is different from "http://www.w3.org/2000/xmlns/".This node is an attribute, and the qualifiedName of this node is "xmlns" [Namespaces].</exception>
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
	/// <returns>The node type for <see langword="XmlAttribute" /> nodes is XmlNodeType.Attribute.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets the <see cref="T:System.Xml.XmlDocument" /> to which this node belongs.</summary>
	/// <returns>An XML document to which this node belongs.</returns>
	public override XmlDocument OwnerDocument => null;

	/// <summary>Gets or sets the value of the node.</summary>
	/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node. For <see langword="XmlAttribute" /> nodes, this property is the value of attribute.</returns>
	/// <exception cref="T:System.ArgumentException">The node is read-only and a set operation is called.</exception>
	public override string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the post-schema-validation-infoset that has been assigned to this node as a result of schema validation.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> containing the post-schema-validation-infoset of this node.</returns>
	public override IXmlSchemaInfo SchemaInfo => null;

	/// <summary>Sets the concatenated values of the node and all its children.</summary>
	/// <returns>The concatenated values of the node and all its children. For attribute nodes, this property has the same functionality as the <see cref="P:System.Xml.XmlAttribute.Value" /> property.</returns>
	public override string InnerText
	{
		set
		{
		}
	}

	internal override bool IsContainer => false;

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

	/// <summary>Gets a value indicating whether the attribute value was explicitly set.</summary>
	/// <returns>
	///     <see langword="true" /> if this attribute was explicitly given a value in the original instance document; otherwise, <see langword="false" />. A value of <see langword="false" /> indicates that the value of the attribute came from the DTD.</returns>
	public virtual bool Specified => false;

	/// <summary>Gets the <see cref="T:System.Xml.XmlElement" /> to which the attribute belongs.</summary>
	/// <returns>The <see langword="XmlElement" /> that the attribute belongs to or <see langword="null" /> if this attribute is not part of an <see langword="XmlElement" />.</returns>
	public virtual XmlElement OwnerElement => null;

	/// <summary>Sets the value of the attribute.</summary>
	/// <returns>The attribute value.</returns>
	/// <exception cref="T:System.Xml.XmlException">The XML specified when setting this property is not well-formed.</exception>
	public override string InnerXml
	{
		set
		{
		}
	}

	/// <summary>Gets the base Uniform Resource Identifier (URI) of the node.</summary>
	/// <returns>The location from which the node was loaded or String.Empty if the node has no base URI. Attribute nodes have the same base URI as their owner element. If an attribute node does not have an owner element, <see langword="BaseURI" /> returns String.Empty.</returns>
	public override string BaseURI => null;

	internal override XmlSpace XmlSpace => default(XmlSpace);

	internal override string XmlLang => null;

	internal override XPathNodeType XPNodeType => default(XPathNodeType);

	internal override string XPLocalName => null;

	internal bool IsNamespace => false;

	internal XmlAttribute(XmlName name, XmlDocument doc)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlAttribute" /> class.</summary>
	/// <param name="prefix">The namespace prefix.</param>
	/// <param name="localName">The local name of the attribute.</param>
	/// <param name="namespaceURI">The namespace uniform resource identifier (URI).</param>
	/// <param name="doc">The parent XML document.</param>
	protected internal XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc)
	{
	}

	/// <summary>Creates a duplicate of this node.</summary>
	/// <param name="deep">
	///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself </param>
	/// <returns>The duplicate node.</returns>
	public override XmlNode CloneNode(bool deep)
	{
		return null;
	}

	internal bool PrepareOwnerElementInElementIdAttrMap()
	{
		return false;
	}

	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText)
	{
	}

	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
	{
		return null;
	}

	internal override bool IsValidChildType(XmlNodeType type)
	{
		return false;
	}

	/// <summary>Inserts the specified node immediately before the specified reference node.</summary>
	/// <param name="newChild">The <see cref="T:System.Xml.XmlNode" /> to insert.</param>
	/// <param name="refChild">The <see cref="T:System.Xml.XmlNode" /> that is the reference node. The <paramref name="newChild" /> is placed before this node.</param>
	/// <returns>The <see cref="T:System.Xml.XmlNode" /> inserted.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.The <paramref name="refChild" /> is not a child of this node.This node is read-only.</exception>
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild)
	{
		return null;
	}

	/// <summary>Inserts the specified node immediately after the specified reference node.</summary>
	/// <param name="newChild">The <see cref="T:System.Xml.XmlNode" /> to insert.</param>
	/// <param name="refChild">The <see cref="T:System.Xml.XmlNode" /> that is the reference node. The <paramref name="newChild" /> is placed after the <paramref name="refChild" />.</param>
	/// <returns>The <see cref="T:System.Xml.XmlNode" /> inserted.</returns>
	/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.The <paramref name="refChild" /> is not a child of this node.This node is read-only.</exception>
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild)
	{
		return null;
	}

	/// <summary>Removes the specified child node.</summary>
	/// <param name="oldChild">The <see cref="T:System.Xml.XmlNode" /> to remove.</param>
	/// <returns>The <see cref="T:System.Xml.XmlNode" /> removed.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="oldChild" /> is not a child of this node. Or this node is read-only.</exception>
	public override XmlNode RemoveChild(XmlNode oldChild)
	{
		return null;
	}

	/// <summary>Adds the specified node to the beginning of the list of child nodes for this node.</summary>
	/// <param name="newChild">The <see cref="T:System.Xml.XmlNode" /> to add. If it is an <see cref="T:System.Xml.XmlDocumentFragment" />, the entire contents of the document fragment are moved into the child list of this node.</param>
	/// <returns>The <see cref="T:System.Xml.XmlNode" /> added.</returns>
	/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.This node is read-only.</exception>
	public override XmlNode PrependChild(XmlNode newChild)
	{
		return null;
	}

	/// <summary>Adds the specified node to the end of the list of child nodes, of this node.</summary>
	/// <param name="newChild">The <see cref="T:System.Xml.XmlNode" /> to add.</param>
	/// <returns>The <see cref="T:System.Xml.XmlNode" /> added.</returns>
	/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.This node is read-only.</exception>
	public override XmlNode AppendChild(XmlNode newChild)
	{
		return null;
	}

	/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save.</param>
	public override void WriteTo(XmlWriter w)
	{
	}

	/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save.</param>
	public override void WriteContentTo(XmlWriter w)
	{
	}

	internal override void SetParent(XmlNode node)
	{
	}
}
