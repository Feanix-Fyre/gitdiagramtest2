namespace System.Xml;

/// <summary>Represents a reader that provides document type definition (DTD), XML-Data Reduced (XDR) schema, and XML Schema definition language (XSD) validation.This class is obsolete. Starting with the .NET Framework 2.0, we recommend that you use the <see cref="T:System.Xml.XmlReaderSettings" /> class and the <see cref="Overload:System.Xml.XmlReader.Create" /> method to create a validating XML reader.</summary>
[Obsolete("Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. https://go.microsoft.com/fwlink/?linkid=14202")]
public class XmlValidatingReader : XmlReader
{
	private XmlValidatingReaderImpl impl;

	/// <summary>Gets the type of the current node.</summary>
	/// <returns>One of the <see cref="T:System.Xml.XmlNodeType" /> values representing the type of the current node.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets the local name of the current node.</summary>
	/// <returns>The name of the current node with the prefix removed. For example, <see langword="LocalName" /> is <see langword="book" /> for the element &lt;bk:book&gt;.For node types that do not have a name (like <see langword="Text" />, <see langword="Comment" />, and so on), this property returns String.Empty.</returns>
	public override string LocalName => null;

	/// <summary>Gets the namespace Uniform Resource Identifier (URI) (as defined in the World Wide Web Consortium (W3C) Namespace specification) of the node on which the reader is positioned.</summary>
	/// <returns>The namespace URI of the current node; otherwise an empty string.</returns>
	public override string NamespaceURI => null;

	/// <summary>Gets the namespace prefix associated with the current node.</summary>
	/// <returns>The namespace prefix associated with the current node.</returns>
	public override string Prefix => null;

	/// <summary>Gets the text value of the current node.</summary>
	/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlValidatingReader.NodeType" /> of the node. The following table lists node types that have a value to return. All other node types return String.Empty.Node Type Value 
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

	/// <summary>Gets a value indicating whether the current node is an empty element (for example, &lt;MyElement/&gt;).</summary>
	/// <returns>
	///     <see langword="true" /> if the current node is an element (<see cref="P:System.Xml.XmlValidatingReader.NodeType" /> equals <see langword="XmlNodeType.Element" />) that ends with /&gt;; otherwise, <see langword="false" />.</returns>
	public override bool IsEmptyElement => false;

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

	/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this implementation.</summary>
	/// <returns>
	///     <see langword="XmlNameTable" /> that enables you to get the atomized version of a string within the node.</returns>
	public override XmlNameTable NameTable => null;

	/// <summary>Gets or sets a value indicating whether to do namespace support.</summary>
	/// <returns>
	///     <see langword="true" /> to do namespace support; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	public bool Namespaces => false;

	/// <summary>Gets the value of the attribute with the specified name.</summary>
	/// <param name="name">The qualified name of the attribute. </param>
	/// <returns>The value of the specified attribute. If the attribute is not found, <see langword="null" /> is returned.</returns>
	public override string GetAttribute(string name)
	{
		return null;
	}

	/// <summary>Gets the value of the attribute with the specified local name and namespace Uniform Resource Identifier (URI).</summary>
	/// <param name="localName">The local name of the attribute. </param>
	/// <param name="namespaceURI">The namespace URI of the attribute. </param>
	/// <returns>The value of the specified attribute. If the attribute is not found, <see langword="null" /> is returned. This method does not move the reader.</returns>
	public override string GetAttribute(string localName, string namespaceURI)
	{
		return null;
	}

	/// <summary>Gets the value of the attribute with the specified index.</summary>
	/// <param name="i">The index of the attribute. The index is zero-based. (The first attribute has index 0.) </param>
	/// <returns>The value of the specified attribute.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="i" /> parameter is less than 0 or greater than or equal to <see cref="P:System.Xml.XmlValidatingReader.AttributeCount" />. </exception>
	public override string GetAttribute(int i)
	{
		return null;
	}

	/// <summary>Moves to the attribute with the specified name.</summary>
	/// <param name="name">The qualified name of the attribute. </param>
	/// <returns>
	///     <see langword="true" /> if the attribute is found; otherwise, <see langword="false" />. If <see langword="false" />, the position of the reader does not change.</returns>
	public override bool MoveToAttribute(string name)
	{
		return false;
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

	/// <summary>Parses the attribute value into one or more <see langword="Text" />, <see langword="EntityReference" />, or <see langword="EndEntity" /> nodes.</summary>
	/// <returns>
	///     <see langword="true" /> if there are nodes to return.
	///     <see langword="false" /> if the reader is not positioned on an attribute node when the initial call is made or if all the attribute values have been read.An empty attribute, such as, misc="", returns <see langword="true" /> with a single node with a value of String.Empty.</returns>
	public override bool ReadAttributeValue()
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

	/// <summary>Resolves a namespace prefix in the current element's scope.</summary>
	/// <param name="prefix">The prefix whose namespace Uniform Resource Identifier (URI) you want to resolve. To match the default namespace, pass an empty string. </param>
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
}
