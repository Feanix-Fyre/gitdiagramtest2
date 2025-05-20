using System.Collections.Generic;
using System.Xml.Schema;

namespace System.Xml;

/// <summary>Represents a reader that provides fast, non-cached forward only access to XML data in an <see cref="T:System.Xml.XmlNode" />.</summary>
public class XmlNodeReader : XmlReader, IXmlNamespaceResolver
{
	private XmlNodeReaderNavigator readerNav;

	private XmlNodeType nodeType;

	private int curDepth;

	private ReadState readState;

	private bool fEOF;

	private bool bResolveEntity;

	private bool bStartFromDocument;

	private bool bInReadBinary;

	private ReadContentAsBinaryHelper readBinaryHelper;

	/// <summary>Gets the type of the current node.</summary>
	/// <returns>One of the <see cref="T:System.Xml.XmlNodeType" /> values representing the type of the current node.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets the qualified name of the current node.</summary>
	/// <returns>The qualified name of the current node. For example, <see langword="Name" /> is <see langword="bk:book" /> for the element &lt;bk:book&gt;.The name returned is dependent on the <see cref="P:System.Xml.XmlNodeReader.NodeType" /> of the node. The following node types return the listed values. All other node types return an empty string.Node Type Name 
	///             <see langword="Attribute" />
	///           The name of the attribute. 
	///             <see langword="DocumentType" />
	///           The document type name. 
	///             <see langword="Element" />
	///           The tag name. 
	///             <see langword="EntityReference" />
	///           The name of the entity referenced. 
	///             <see langword="ProcessingInstruction" />
	///           The target of the processing instruction. 
	///             <see langword="XmlDeclaration" />
	///           The literal string <see langword="xml" />. </returns>
	public override string Name => null;

	/// <summary>Gets the local name of the current node.</summary>
	/// <returns>The name of the current node with the prefix removed. For example, <see langword="LocalName" /> is <see langword="book" /> for the element &lt;bk:book&gt;.For node types that do not have a name (like <see langword="Text" />, <see langword="Comment" />, and so on), this property returns String.Empty.</returns>
	public override string LocalName => null;

	/// <summary>Gets the namespace URI (as defined in the W3C Namespace specification) of the node on which the reader is positioned.</summary>
	/// <returns>The namespace URI of the current node; otherwise an empty string.</returns>
	public override string NamespaceURI => null;

	/// <summary>Gets the namespace prefix associated with the current node.</summary>
	/// <returns>The namespace prefix associated with the current node.</returns>
	public override string Prefix => null;

	/// <summary>Gets the text value of the current node.</summary>
	/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlNodeReader.NodeType" /> of the node. The following table lists node types that have a value to return. All other node types return String.Empty.Node Type Value 
	///             <see langword="Attribute" />
	///           The value of the attribute. 
	///             <see langword="CDATA" />
	///           The content of the CDATA section. 
	///             <see langword="Comment" />
	///           The content of the comment. 
	///             <see langword="DocumentType" />
	///           The internal subset. 
	///             <see langword="ProcessingInstruction" />
	///           The entire content, excluding the target. 
	///             <see langword="SignificantWhitespace" />
	///           The white space between markup in a mixed content model. 
	///             <see langword="Text" />
	///           The content of the text node. 
	///             <see langword="Whitespace" />
	///           The white space between markup. 
	///             <see langword="XmlDeclaration" />
	///           The content of the declaration. </returns>
	public override string Value => null;

	/// <summary>Gets the depth of the current node in the XML document.</summary>
	/// <returns>The depth of the current node in the XML document.</returns>
	public override int Depth => 0;

	/// <summary>Gets the base URI of the current node.</summary>
	/// <returns>The base URI of the current node.</returns>
	public override string BaseURI => null;

	/// <summary>Gets a value indicating whether this reader can parse and resolve entities.</summary>
	/// <returns>
	///     <see langword="true" /> if the reader can parse and resolve entities; otherwise, <see langword="false" />. <see langword="XmlNodeReader" /> always returns <see langword="true" />.</returns>
	public override bool CanResolveEntity => false;

	/// <summary>Gets a value indicating whether the current node is an empty element (for example, &lt;MyElement/&gt;).</summary>
	/// <returns>
	///     <see langword="true" /> if the current node is an element (<see cref="P:System.Xml.XmlNodeReader.NodeType" /> equals <see langword="XmlNodeType.Element" />) and it ends with /&gt;; otherwise, <see langword="false" />.</returns>
	public override bool IsEmptyElement => false;

	/// <summary>Gets a value indicating whether the current node is an attribute that was generated from the default value defined in the document type definition (DTD) or schema.</summary>
	/// <returns>
	///     <see langword="true" /> if the current node is an attribute whose value was generated from the default value defined in the DTD or schema; <see langword="false" /> if the attribute value was explicitly set.</returns>
	public override bool IsDefault => false;

	/// <summary>Gets the current <see langword="xml:space" /> scope.</summary>
	/// <returns>One of the <see cref="T:System.Xml.XmlSpace" /> values. If no <see langword="xml:space" /> scope exists, this property defaults to <see langword="XmlSpace.None" />.</returns>
	public override XmlSpace XmlSpace => default(XmlSpace);

	/// <summary>Gets the current <see langword="xml:lang" /> scope.</summary>
	/// <returns>The current <see langword="xml:lang" /> scope.</returns>
	public override string XmlLang => null;

	/// <summary>Gets the schema information that has been assigned to the current node.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object containing the schema information for the current node.</returns>
	public override IXmlSchemaInfo SchemaInfo => null;

	/// <summary>Gets the number of attributes on the current node.</summary>
	/// <returns>The number of attributes on the current node. This number includes default attributes.</returns>
	public override int AttributeCount => 0;

	/// <summary>Gets a value indicating whether the reader is positioned at the end of the stream.</summary>
	/// <returns>
	///     <see langword="true" /> if the reader is positioned at the end of the stream; otherwise, <see langword="false" />.</returns>
	public override bool EOF => false;

	/// <summary>Gets the state of the reader.</summary>
	/// <returns>One of the <see cref="T:System.Xml.ReadState" /> values.</returns>
	public override ReadState ReadState => default(ReadState);

	/// <summary>Gets a value indicating whether the current node has any attributes.</summary>
	/// <returns>
	///     <see langword="true" /> if the current node has attributes; otherwise, <see langword="false" />.</returns>
	public override bool HasAttributes => false;

	/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this implementation.</summary>
	/// <returns>The <see langword="XmlNameTable" /> enabling you to get the atomized version of a string within the node.</returns>
	public override XmlNameTable NameTable => null;

	internal override IDtdInfo DtdInfo => null;

	/// <summary>Creates an instance of the <see langword="XmlNodeReader" /> class using the specified <see cref="T:System.Xml.XmlNode" />.</summary>
	/// <param name="node">The <see langword="XmlNode" /> you want to read. </param>
	public XmlNodeReader(XmlNode node)
	{
	}

	internal bool IsInReadingStates()
	{
		return false;
	}

	/// <summary>Gets the value of the attribute with the specified name.</summary>
	/// <param name="name">The qualified name of the attribute. </param>
	/// <returns>The value of the specified attribute. If the attribute is not found, <see langword="null" /> is returned.</returns>
	public override string GetAttribute(string name)
	{
		return null;
	}

	/// <summary>Gets the value of the attribute with the specified local name and namespace URI.</summary>
	/// <param name="name">The local name of the attribute. </param>
	/// <param name="namespaceURI">The namespace URI of the attribute. </param>
	/// <returns>The value of the specified attribute. If the attribute is not found, <see langword="null" /> is returned.</returns>
	public override string GetAttribute(string name, string namespaceURI)
	{
		return null;
	}

	/// <summary>Gets the value of the attribute with the specified index.</summary>
	/// <param name="attributeIndex">The index of the attribute. The index is zero-based. (The first attribute has index 0.) </param>
	/// <returns>The value of the specified attribute.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="i" /> parameter is less than 0 or greater than or equal to <see cref="P:System.Xml.XmlNodeReader.AttributeCount" />. </exception>
	public override string GetAttribute(int attributeIndex)
	{
		return null;
	}

	/// <summary>Moves to the attribute with the specified name.</summary>
	/// <param name="name">The qualified name of the attribute. </param>
	/// <returns>
	///     <see langword="true" /> if the attribute is found; otherwise, <see langword="false" />. If <see langword="false" />, the reader's position does not change.</returns>
	public override bool MoveToAttribute(string name)
	{
		return false;
	}

	/// <summary>Moves to the attribute with the specified index.</summary>
	/// <param name="attributeIndex">The index of the attribute. </param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="i" /> parameter is less than 0 or greater than or equal to <see cref="P:System.Xml.XmlReader.AttributeCount" />. </exception>
	public override void MoveToAttribute(int attributeIndex)
	{
	}

	/// <summary>Moves to the first attribute.</summary>
	/// <returns>
	///     <see langword="true" /> if an attribute exists (the reader moves to the first attribute); otherwise, <see langword="false" /> (the position of the reader does not change).</returns>
	public override bool MoveToFirstAttribute()
	{
		return false;
	}

	/// <summary>Moves to the next attribute.</summary>
	/// <returns>
	///     <see langword="true" /> if there is a next attribute; <see langword="false" /> if there are no more attributes.</returns>
	public override bool MoveToNextAttribute()
	{
		return false;
	}

	/// <summary>Moves to the element that contains the current attribute node.</summary>
	/// <returns>
	///     <see langword="true" /> if the reader is positioned on an attribute (the reader moves to the element that owns the attribute); <see langword="false" /> if the reader is not positioned on an attribute (the position of the reader does not change).</returns>
	public override bool MoveToElement()
	{
		return false;
	}

	/// <summary>Reads the next node from the stream.</summary>
	/// <returns>
	///     <see langword="true" /> if the next node was read successfully; <see langword="false" /> if there are no more nodes to read.</returns>
	public override bool Read()
	{
		return false;
	}

	private bool Read(bool fSkipChildren)
	{
		return false;
	}

	private bool ReadNextNode(bool fSkipChildren)
	{
		return false;
	}

	private void SetEndOfFile()
	{
	}

	private bool ReadAtZeroLevel(bool fSkipChildren)
	{
		return false;
	}

	private bool ReadForward(bool fSkipChildren)
	{
		return false;
	}

	private void ReSetReadingMarks()
	{
	}

	/// <summary>Changes the <see cref="P:System.Xml.XmlNodeReader.ReadState" /> to <see langword="Closed" />.</summary>
	public override void Close()
	{
	}

	/// <summary>Skips the children of the current node.</summary>
	public override void Skip()
	{
	}

	/// <summary>Reads the contents of an element or text node as a string.</summary>
	/// <returns>The contents of the element or text-like node (This can include CDATA, Text nodes, and so on). This can be an empty string if the reader is positioned on something other than an element or text node, or if there is no more text content to return in the current context.
	///     <see langword="Note:" /> The text node can be either an element or an attribute text node.</returns>
	public override string ReadString()
	{
		return null;
	}

	/// <summary>Resolves a namespace prefix in the current element's scope.</summary>
	/// <param name="prefix">The prefix whose namespace URI you want to resolve. To match the default namespace, pass an empty string. This string does not have to be atomized. </param>
	/// <returns>The namespace URI to which the prefix maps or <see langword="null" /> if no matching prefix is found.</returns>
	public override string LookupNamespace(string prefix)
	{
		return null;
	}

	/// <summary>Resolves the entity reference for <see langword="EntityReference" /> nodes.</summary>
	/// <exception cref="T:System.InvalidOperationException">The reader is not positioned on an <see langword="EntityReference" /> node. </exception>
	public override void ResolveEntity()
	{
	}

	/// <summary>Parses the attribute value into one or more <see langword="Text" />, <see langword="EntityReference" />, or <see langword="EndEntity" /> nodes.</summary>
	/// <returns>
	///     <see langword="true" /> if there are nodes to return.
	///     <see langword="false" /> if the reader is not positioned on an attribute node when the initial call is made or if all the attribute values have been read.An empty attribute, such as, misc="", returns <see langword="true" /> with a single node with a value of String.Empty.</returns>
	public override bool ReadAttributeValue()
	{
		return false;
	}

	private void FinishReadBinary()
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope)" />.</summary>
	/// <param name="scope">
	///       <see cref="T:System.Xml.XmlNamespaceScope" /> object.</param>
	/// <returns>
	///     <see cref="T:System.Collections.IDictionary" /> object that contains the namespaces that are in scope.</returns>
	IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String)" />.</summary>
	/// <param name="namespaceName">
	///       <see cref="T:System.String" /> object that identifies the namespace.</param>
	/// <returns>
	///     <see cref="T:System.String" /> object that contains the namespace prefix.</returns>
	string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String)" />.</summary>
	/// <param name="prefix">
	///       <see cref="T:System.String" /> that contains the namespace prefix.</param>
	/// <returns>
	///     <see cref="T:System.String" /> that contains the namespace name.</returns>
	string IXmlNamespaceResolver.LookupNamespace(string prefix)
	{
		return null;
	}
}
