using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Xml.Schema;
using System.Xml.XPath;

namespace System.Xml;

/// <summary>Represents a single node in the XML document. </summary>
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
public abstract class XmlNode : ICloneable, IEnumerable, IXPathNavigable
{
	internal XmlNode parentNode;

	/// <summary>Gets the qualified name of the node, when overridden in a derived class.</summary>
	/// <returns>The qualified name of the node. The name returned is dependent on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node: Type Name Attribute The qualified name of the attribute. CDATA #cdata-section Comment #comment Document #document DocumentFragment #document-fragment DocumentType The document type name. Element The qualified name of the element. Entity The name of the entity. EntityReference The name of the entity referenced. Notation The notation name. ProcessingInstruction The target of the processing instruction. Text #text Whitespace #whitespace SignificantWhitespace #significant-whitespace XmlDeclaration #xml-declaration </returns>
	public abstract string Name { get; }

	/// <summary>Gets or sets the value of the node.</summary>
	/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node: Type Value Attribute The value of the attribute. CDATASection The content of the CDATA Section. Comment The content of the comment. Document 
	///             <see langword="null" />. DocumentFragment 
	///             <see langword="null" />. DocumentType 
	///             <see langword="null" />. Element 
	///             <see langword="null" />. You can use the <see cref="P:System.Xml.XmlElement.InnerText" /> or <see cref="P:System.Xml.XmlElement.InnerXml" /> properties to access the value of the element node. Entity 
	///             <see langword="null" />. EntityReference 
	///             <see langword="null" />. Notation 
	///             <see langword="null" />. ProcessingInstruction The entire content excluding the target. Text The content of the text node. SignificantWhitespace The white space characters. White space can consist of one or more space characters, carriage returns, line feeds, or tabs. Whitespace The white space characters. White space can consist of one or more space characters, carriage returns, line feeds, or tabs. XmlDeclaration The content of the declaration (that is, everything between &lt;?xml and ?&gt;). </returns>
	/// <exception cref="T:System.ArgumentException">Setting the value of a node that is read-only. </exception>
	/// <exception cref="T:System.InvalidOperationException">Setting the value of a node that is not supposed to have a value (for example, an Element node). </exception>
	public virtual string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the type of the current node, when overridden in a derived class.</summary>
	/// <returns>One of the <see cref="T:System.Xml.XmlNodeType" /> values.</returns>
	public abstract XmlNodeType NodeType { get; }

	/// <summary>Gets the parent of this node (for nodes that can have parents).</summary>
	/// <returns>The <see langword="XmlNode" /> that is the parent of the current node. If a node has just been created and not yet added to the tree, or if it has been removed from the tree, the parent is <see langword="null" />. For all other nodes, the value returned depends on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node. The following table describes the possible return values for the <see langword="ParentNode" /> property.NodeType Return Value of ParentNode Attribute, Document, DocumentFragment, Entity, Notation Returns <see langword="null" />; these nodes do not have parents. CDATA Returns the element or entity reference containing the CDATA section. Comment Returns the element, entity reference, document type, or document containing the comment. DocumentType Returns the document node. Element Returns the parent node of the element. If the element is the root node in the tree, the parent is the document node. EntityReference Returns the element, attribute, or entity reference containing the entity reference. ProcessingInstruction Returns the document, element, document type, or entity reference containing the processing instruction. Text Returns the parent element, attribute, or entity reference containing the text node. </returns>
	public virtual XmlNode ParentNode => null;

	/// <summary>Gets all the child nodes of the node.</summary>
	/// <returns>An object that contains all the child nodes of the node.If there are no child nodes, this property returns an empty <see cref="T:System.Xml.XmlNodeList" />.</returns>
	public virtual XmlNodeList ChildNodes => null;

	/// <summary>Gets the node immediately preceding this node.</summary>
	/// <returns>The preceding <see langword="XmlNode" />. If there is no preceding node, <see langword="null" /> is returned.</returns>
	public virtual XmlNode PreviousSibling => null;

	/// <summary>Gets the node immediately following this node.</summary>
	/// <returns>The next <see langword="XmlNode" />. If there is no next node, <see langword="null" /> is returned.</returns>
	public virtual XmlNode NextSibling => null;

	/// <summary>Gets an <see cref="T:System.Xml.XmlAttributeCollection" /> containing the attributes of this node.</summary>
	/// <returns>An <see langword="XmlAttributeCollection" /> containing the attributes of the node.If the node is of type XmlNodeType.Element, the attributes of the node are returned. Otherwise, this property returns <see langword="null" />.</returns>
	public virtual XmlAttributeCollection Attributes => null;

	/// <summary>Gets the <see cref="T:System.Xml.XmlDocument" /> to which this node belongs.</summary>
	/// <returns>The <see cref="T:System.Xml.XmlDocument" /> to which this node belongs.If the node is an <see cref="T:System.Xml.XmlDocument" /> (NodeType equals XmlNodeType.Document), this property returns <see langword="null" />.</returns>
	public virtual XmlDocument OwnerDocument => null;

	/// <summary>Gets the first child of the node.</summary>
	/// <returns>The first child of the node. If there is no such node, <see langword="null" /> is returned.</returns>
	public virtual XmlNode FirstChild => null;

	/// <summary>Gets the last child of the node.</summary>
	/// <returns>The last child of the node. If there is no such node, <see langword="null" /> is returned.</returns>
	public virtual XmlNode LastChild => null;

	internal virtual bool IsContainer => false;

	internal virtual XmlLinkedNode LastNode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets a value indicating whether this node has any child nodes.</summary>
	/// <returns>
	///     <see langword="true" /> if the node has child nodes; otherwise, <see langword="false" />.</returns>
	public virtual bool HasChildNodes => false;

	/// <summary>Gets the namespace URI of this node.</summary>
	/// <returns>The namespace URI of this node. If there is no namespace URI, this property returns String.Empty.</returns>
	public virtual string NamespaceURI => null;

	/// <summary>Gets or sets the namespace prefix of this node.</summary>
	/// <returns>The namespace prefix of this node. For example, <see langword="Prefix" /> is bk for the element &lt;bk:book&gt;. If there is no prefix, this property returns String.Empty.</returns>
	/// <exception cref="T:System.ArgumentException">This node is read-only. </exception>
	/// <exception cref="T:System.Xml.XmlException">The specified prefix contains an invalid character.The specified prefix is malformed.The specified prefix is "xml" and the namespaceURI of this node is different from "http://www.w3.org/XML/1998/namespace".This node is an attribute and the specified prefix is "xmlns" and the namespaceURI of this node is different from "http://www.w3.org/2000/xmlns/ ".This node is an attribute and the qualifiedName of this node is "xmlns". </exception>
	public virtual string Prefix
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the local name of the node, when overridden in a derived class.</summary>
	/// <returns>The name of the node with the prefix removed. For example, <see langword="LocalName" /> is book for the element &lt;bk:book&gt;.The name returned is dependent on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node: Type Name Attribute The local name of the attribute. CDATA #cdata-section Comment #comment Document #document DocumentFragment #document-fragment DocumentType The document type name. Element The local name of the element. Entity The name of the entity. EntityReference The name of the entity referenced. Notation The notation name. ProcessingInstruction The target of the processing instruction. Text #text Whitespace #whitespace SignificantWhitespace #significant-whitespace XmlDeclaration #xml-declaration </returns>
	public abstract string LocalName { get; }

	/// <summary>Gets a value indicating whether the node is read-only.</summary>
	/// <returns>
	///     <see langword="true" /> if the node is read-only; otherwise <see langword="false" />.</returns>
	public virtual bool IsReadOnly => false;

	/// <summary>Gets or sets the concatenated values of the node and all its child nodes.</summary>
	/// <returns>The concatenated values of the node and all its child nodes.</returns>
	public virtual string InnerText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the markup representing only the child nodes of this node.</summary>
	/// <returns>The markup of the child nodes of this node.
	///       <see langword="InnerXml" /> does not return default attributes.</returns>
	/// <exception cref="T:System.InvalidOperationException">Setting this property on a node that cannot have child nodes. </exception>
	/// <exception cref="T:System.Xml.XmlException">The XML specified when setting this property is not well-formed. </exception>
	public virtual string InnerXml
	{
		set
		{
		}
	}

	/// <summary>Gets the post schema validation infoset that has been assigned to this node as a result of schema validation.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object containing the post schema validation infoset of this node.</returns>
	public virtual IXmlSchemaInfo SchemaInfo => null;

	/// <summary>Gets the base URI of the current node.</summary>
	/// <returns>The location from which the node was loaded or String.Empty if the node has no base URI.</returns>
	public virtual string BaseURI => null;

	internal XmlDocument Document => null;

	internal virtual XmlSpace XmlSpace => default(XmlSpace);

	internal virtual string XmlLang => null;

	internal virtual XPathNodeType XPNodeType => default(XPathNodeType);

	internal virtual string XPLocalName => null;

	internal virtual bool IsText => false;

	/// <summary>Gets the text node that immediately precedes this node.</summary>
	/// <returns>Returns <see cref="T:System.Xml.XmlNode" />.</returns>
	public virtual XmlNode PreviousText => null;

	internal XmlNode()
	{
	}

	internal XmlNode(XmlDocument doc)
	{
	}

	/// <summary>Creates an <see cref="T:System.Xml.XPath.XPathNavigator" /> for navigating this object.</summary>
	/// <returns>An <see langword="XPathNavigator" /> object used to navigate the node. The <see langword="XPathNavigator" /> is positioned on the node from which the method was called. It is not positioned on the root of the document.</returns>
	public virtual XPathNavigator CreateNavigator()
	{
		return null;
	}

	/// <summary>Selects the first <see langword="XmlNode" /> that matches the XPath expression.</summary>
	/// <param name="xpath">The XPath expression. See XPath Examples.</param>
	/// <returns>The first <see langword="XmlNode" /> that matches the XPath query or <see langword="null" /> if no matching node is found. </returns>
	/// <exception cref="T:System.Xml.XPath.XPathException">The XPath expression contains a prefix. </exception>
	public XmlNode SelectSingleNode(string xpath)
	{
		return null;
	}

	/// <summary>Selects a list of nodes matching the XPath expression.</summary>
	/// <param name="xpath">The XPath expression. </param>
	/// <returns>An <see cref="T:System.Xml.XmlNodeList" /> containing a collection of nodes matching the XPath query.</returns>
	/// <exception cref="T:System.Xml.XPath.XPathException">The XPath expression contains a prefix. See XPath Examples.</exception>
	public XmlNodeList SelectNodes(string xpath)
	{
		return null;
	}

	internal bool AncestorNode(XmlNode node)
	{
		return false;
	}

	internal bool IsConnected()
	{
		return false;
	}

	/// <summary>Inserts the specified node immediately before the specified reference node.</summary>
	/// <param name="newChild">The <see langword="XmlNode" /> to insert. </param>
	/// <param name="refChild">The <see langword="XmlNode" /> that is the reference node. The <paramref name="newChild" /> is placed before this node. </param>
	/// <returns>The node being inserted.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.The <paramref name="refChild" /> is not a child of this node.This node is read-only. </exception>
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild)
	{
		return null;
	}

	/// <summary>Inserts the specified node immediately after the specified reference node.</summary>
	/// <param name="newChild">The <see langword="XmlNode" /> to insert. </param>
	/// <param name="refChild">The <see langword="XmlNode" /> that is the reference node. The <paramref name="newNode" /> is placed after the <paramref name="refNode" />. </param>
	/// <returns>The node being inserted.</returns>
	/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.The <paramref name="refChild" /> is not a child of this node.This node is read-only. </exception>
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild)
	{
		return null;
	}

	/// <summary>Removes specified child node.</summary>
	/// <param name="oldChild">The node being removed. </param>
	/// <returns>The node removed.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="oldChild" /> is not a child of this node. Or this node is read-only. </exception>
	public virtual XmlNode RemoveChild(XmlNode oldChild)
	{
		return null;
	}

	/// <summary>Adds the specified node to the beginning of the list of child nodes for this node.</summary>
	/// <param name="newChild">The node to add. All the contents of the node to be added are moved into the specified location.</param>
	/// <returns>The node added.</returns>
	/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.This node is read-only. </exception>
	public virtual XmlNode PrependChild(XmlNode newChild)
	{
		return null;
	}

	/// <summary>Adds the specified node to the end of the list of child nodes, of this node.</summary>
	/// <param name="newChild">The node to add. All the contents of the node to be added are moved into the specified location. </param>
	/// <returns>The node added.</returns>
	/// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.This node is read-only. </exception>
	public virtual XmlNode AppendChild(XmlNode newChild)
	{
		return null;
	}

	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
	{
		return null;
	}

	internal virtual bool IsValidChildType(XmlNodeType type)
	{
		return false;
	}

	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild)
	{
		return false;
	}

	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
	{
		return false;
	}

	/// <summary>Creates a duplicate of the node, when overridden in a derived class.</summary>
	/// <param name="deep">
	///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. </param>
	/// <returns>The cloned node.</returns>
	/// <exception cref="T:System.InvalidOperationException">Calling this method on a node type that cannot be cloned. </exception>
	public abstract XmlNode CloneNode(bool deep);

	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep)
	{
	}

	internal static bool HasReadOnlyParent(XmlNode n)
	{
		return false;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.XmlNode.Clone" />.</summary>
	/// <returns>A copy of the node from which it is called.</returns>
	object ICloneable.Clone()
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.XmlNode.GetEnumerator" />.</summary>
	/// <returns>Returns an enumerator for the collection.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	/// <summary>Get an enumerator that iterates through the child nodes in the current node.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the child nodes in the current node.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	private void AppendChildText(StringBuilder builder)
	{
	}

	/// <summary>Saves the current node to the specified <see cref="T:System.Xml.XmlWriter" />, when overridden in a derived class.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public abstract void WriteTo(XmlWriter w);

	/// <summary>Saves all the child nodes of the node to the specified <see cref="T:System.Xml.XmlWriter" />, when overridden in a derived class.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public abstract void WriteContentTo(XmlWriter w);

	/// <summary>Removes all the child nodes and/or attributes of the current node.</summary>
	public virtual void RemoveAll()
	{
	}

	/// <summary>Looks up the closest xmlns declaration for the given namespace URI that is in scope for the current node and returns the prefix defined in that declaration.</summary>
	/// <param name="namespaceURI">The namespace URI whose prefix you want to find. </param>
	/// <returns>The prefix for the specified namespace URI.</returns>
	public virtual string GetPrefixOfNamespace(string namespaceURI)
	{
		return null;
	}

	internal string GetPrefixOfNamespaceStrict(string namespaceURI)
	{
		return null;
	}

	internal virtual void SetParent(XmlNode node)
	{
	}

	internal virtual void SetParentForLoad(XmlNode node)
	{
	}

	internal static void SplitName(string name, out string prefix, out string localName)
	{
		prefix = null;
		localName = null;
	}

	internal virtual XmlNode FindChild(XmlNodeType type)
	{
		return null;
	}

	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
	{
		return null;
	}

	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args)
	{
	}

	internal virtual void AfterEvent(XmlNodeChangedEventArgs args)
	{
	}

	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode)
	{
	}

	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode)
	{
	}
}
