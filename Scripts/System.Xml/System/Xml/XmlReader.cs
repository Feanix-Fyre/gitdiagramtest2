using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Schema;

namespace System.Xml;

/// <summary>Represents a reader that provides fast, noncached, forward-only access to XML data.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
public abstract class XmlReader : IDisposable
{
	private static uint IsTextualNodeBitmap;

	private static uint CanReadContentAsBitmap;

	private static uint HasValueBitmap;

	/// <summary>Gets the <see cref="T:System.Xml.XmlReaderSettings" /> object used to create this <see cref="T:System.Xml.XmlReader" /> instance.</summary>
	/// <returns>The <see cref="T:System.Xml.XmlReaderSettings" /> object used to create this reader instance. If this reader was not created using the <see cref="Overload:System.Xml.XmlReader.Create" /> method, this property returns <see langword="null" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual XmlReaderSettings Settings => null;

	/// <summary>When overridden in a derived class, gets the type of the current node.</summary>
	/// <returns>One of the enumeration values that specify the type of the current node.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract XmlNodeType NodeType { get; }

	/// <summary>When overridden in a derived class, gets the qualified name of the current node.</summary>
	/// <returns>The qualified name of the current node. For example, <see langword="Name" /> is <see langword="bk:book" /> for the element &lt;bk:book&gt;.The name returned is dependent on the <see cref="P:System.Xml.XmlReader.NodeType" /> of the node. The following node types return the listed values. All other node types return an empty string.Node type Name 
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
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual string Name => null;

	/// <summary>When overridden in a derived class, gets the local name of the current node.</summary>
	/// <returns>The name of the current node with the prefix removed. For example, <see langword="LocalName" /> is <see langword="book" /> for the element &lt;bk:book&gt;.For node types that do not have a name (like <see langword="Text" />, <see langword="Comment" />, and so on), this property returns <see langword="String.Empty" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract string LocalName { get; }

	/// <summary>When overridden in a derived class, gets the namespace URI (as defined in the W3C Namespace specification) of the node on which the reader is positioned.</summary>
	/// <returns>The namespace URI of the current node; otherwise an empty string.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract string NamespaceURI { get; }

	/// <summary>When overridden in a derived class, gets the namespace prefix associated with the current node.</summary>
	/// <returns>The namespace prefix associated with the current node.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract string Prefix { get; }

	/// <summary>When overridden in a derived class, gets the text value of the current node.</summary>
	/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlReader.NodeType" /> of the node. The following table lists node types that have a value to return. All other node types return <see langword="String.Empty" />.Node type Value 
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
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract string Value { get; }

	/// <summary>When overridden in a derived class, gets the depth of the current node in the XML document.</summary>
	/// <returns>The depth of the current node in the XML document.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract int Depth { get; }

	/// <summary>When overridden in a derived class, gets the base URI of the current node.</summary>
	/// <returns>The base URI of the current node.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract string BaseURI { get; }

	/// <summary>When overridden in a derived class, gets a value indicating whether the current node is an empty element (for example, &lt;MyElement/&gt;).</summary>
	/// <returns>
	///     <see langword="true" /> if the current node is an element (<see cref="P:System.Xml.XmlReader.NodeType" /> equals <see langword="XmlNodeType.Element" />) that ends with /&gt;; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract bool IsEmptyElement { get; }

	/// <summary>When overridden in a derived class, gets a value indicating whether the current node is an attribute that was generated from the default value defined in the DTD or schema.</summary>
	/// <returns>
	///     <see langword="true" /> if the current node is an attribute whose value was generated from the default value defined in the DTD or schema; <see langword="false" /> if the attribute value was explicitly set.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual bool IsDefault => false;

	/// <summary>When overridden in a derived class, gets the quotation mark character used to enclose the value of an attribute node.</summary>
	/// <returns>The quotation mark character (" or ') used to enclose the value of an attribute node.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual char QuoteChar => '\0';

	/// <summary>When overridden in a derived class, gets the current <see langword="xml:space" /> scope.</summary>
	/// <returns>One of the <see cref="T:System.Xml.XmlSpace" /> values. If no <see langword="xml:space" /> scope exists, this property defaults to <see langword="XmlSpace.None" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual XmlSpace XmlSpace => default(XmlSpace);

	/// <summary>When overridden in a derived class, gets the current <see langword="xml:lang" /> scope.</summary>
	/// <returns>The current <see langword="xml:lang" /> scope.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual string XmlLang => null;

	/// <summary>Gets the schema information that has been assigned to the current node as a result of schema validation.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object containing the schema information for the current node. Schema information can be set on elements, attributes, or on text nodes with a non-null <see cref="P:System.Xml.XmlReader.ValueType" /> (typed values).If the current node is not one of the above node types, or if the <see langword="XmlReader" /> instance does not report schema information, this property returns <see langword="null" />.If this property is called from an <see cref="T:System.Xml.XmlTextReader" /> or an <see cref="T:System.Xml.XmlValidatingReader" /> object, this property always returns <see langword="null" />. These <see langword="XmlReader" /> implementations do not expose schema information through the <see langword="SchemaInfo" /> property.If you have to get the post-schema-validation information set (PSVI) for an element, position the reader on the end tag of the element, rather than on the start tag. You get the PSVI through the <see langword="SchemaInfo" /> property of a reader. The validating reader that is created through <see cref="Overload:System.Xml.XmlReader.Create" /> with the <see cref="P:System.Xml.XmlReaderSettings.ValidationType" /> property set to <see cref="F:System.Xml.ValidationType.Schema" /> has complete PSVI for an element only when the reader is positioned on the end tag of an element.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual IXmlSchemaInfo SchemaInfo => null;

	/// <summary>Gets The Common Language Runtime (CLR) type for the current node.</summary>
	/// <returns>The CLR type that corresponds to the typed value of the node. The default is <see langword="System.String" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual Type ValueType => null;

	/// <summary>When overridden in a derived class, gets the number of attributes on the current node.</summary>
	/// <returns>The number of attributes on the current node.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract int AttributeCount { get; }

	/// <summary>When overridden in a derived class, gets a value indicating whether the reader is positioned at the end of the stream.</summary>
	/// <returns>
	///     <see langword="true" /> if the reader is positioned at the end of the stream; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract bool EOF { get; }

	/// <summary>When overridden in a derived class, gets the state of the reader.</summary>
	/// <returns>One of the enumeration values that specifies the state of the reader.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract ReadState ReadState { get; }

	/// <summary>When overridden in a derived class, gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this implementation.</summary>
	/// <returns>The <see langword="XmlNameTable" /> enabling you to get the atomized version of a string within the node.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract XmlNameTable NameTable { get; }

	/// <summary>Gets a value indicating whether this reader can parse and resolve entities.</summary>
	/// <returns>
	///     <see langword="true" /> if the reader can parse and resolve entities; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual bool CanResolveEntity => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Xml.XmlReader" /> implements the <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" /> method.</summary>
	/// <returns>
	///     <see langword="true" /> if the <see cref="T:System.Xml.XmlReader" /> implements the <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" /> method; otherwise <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual bool CanReadValueChunk => false;

	/// <summary>Gets a value indicating whether the current node has any attributes.</summary>
	/// <returns>
	///     <see langword="true" /> if the current node has attributes; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual bool HasAttributes => false;

	internal virtual XmlNamespaceManager NamespaceManager => null;

	internal bool IsDefaultInternal => false;

	internal virtual IDtdInfo DtdInfo => null;

	/// <summary>When overridden in a derived class, gets the value of the attribute with the specified <see cref="P:System.Xml.XmlReader.Name" />.</summary>
	/// <param name="name">The qualified name of the attribute.</param>
	/// <returns>The value of the specified attribute. If the attribute is not found or the value is <see langword="String.Empty" />, <see langword="null" /> is returned.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract string GetAttribute(string name);

	/// <summary>When overridden in a derived class, gets the value of the attribute with the specified <see cref="P:System.Xml.XmlReader.LocalName" /> and <see cref="P:System.Xml.XmlReader.NamespaceURI" />.</summary>
	/// <param name="name">The local name of the attribute.</param>
	/// <param name="namespaceURI">The namespace URI of the attribute.</param>
	/// <returns>The value of the specified attribute. If the attribute is not found or the value is <see langword="String.Empty" />, <see langword="null" /> is returned. This method does not move the reader.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract string GetAttribute(string name, string namespaceURI);

	/// <summary>When overridden in a derived class, gets the value of the attribute with the specified index.</summary>
	/// <param name="i">The index of the attribute. The index is zero-based. (The first attribute has index 0.)</param>
	/// <returns>The value of the specified attribute. This method does not move the reader.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="i" /> is out of range. It must be non-negative and less than the size of the attribute collection.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract string GetAttribute(int i);

	/// <summary>When overridden in a derived class, moves to the attribute with the specified <see cref="P:System.Xml.XmlReader.Name" />.</summary>
	/// <param name="name">The qualified name of the attribute.</param>
	/// <returns>
	///     <see langword="true" /> if the attribute is found; otherwise, <see langword="false" />. If <see langword="false" />, the reader's position does not change.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	/// <exception cref="T:System.ArgumentException">The parameter is an empty string.</exception>
	public abstract bool MoveToAttribute(string name);

	/// <summary>When overridden in a derived class, moves to the attribute with the specified index.</summary>
	/// <param name="i">The index of the attribute.</param>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The parameter has a negative value.</exception>
	public virtual void MoveToAttribute(int i)
	{
	}

	/// <summary>When overridden in a derived class, moves to the first attribute.</summary>
	/// <returns>
	///     <see langword="true" /> if an attribute exists (the reader moves to the first attribute); otherwise, <see langword="false" /> (the position of the reader does not change).</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract bool MoveToFirstAttribute();

	/// <summary>When overridden in a derived class, moves to the next attribute.</summary>
	/// <returns>
	///     <see langword="true" /> if there is a next attribute; <see langword="false" /> if there are no more attributes.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract bool MoveToNextAttribute();

	/// <summary>When overridden in a derived class, moves to the element that contains the current attribute node.</summary>
	/// <returns>
	///     <see langword="true" /> if the reader is positioned on an attribute (the reader moves to the element that owns the attribute); <see langword="false" /> if the reader is not positioned on an attribute (the position of the reader does not change).</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract bool MoveToElement();

	/// <summary>When overridden in a derived class, parses the attribute value into one or more <see langword="Text" />, <see langword="EntityReference" />, or <see langword="EndEntity" /> nodes.</summary>
	/// <returns>
	///     <see langword="true" /> if there are nodes to return.
	///     <see langword="false" /> if the reader is not positioned on an attribute node when the initial call is made or if all the attribute values have been read.An empty attribute, such as, misc="", returns <see langword="true" /> with a single node with a value of <see langword="String.Empty" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract bool ReadAttributeValue();

	/// <summary>When overridden in a derived class, reads the next node from the stream.</summary>
	/// <returns>
	///     <see langword="true" /> if the next node was read successfully; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Xml.XmlException">An error occurred while parsing the XML.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract bool Read();

	/// <summary>When overridden in a derived class, changes the <see cref="P:System.Xml.XmlReader.ReadState" /> to <see cref="F:System.Xml.ReadState.Closed" />.</summary>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual void Close()
	{
	}

	/// <summary>Skips the children of the current node.</summary>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual void Skip()
	{
	}

	/// <summary>When overridden in a derived class, resolves a namespace prefix in the current element's scope.</summary>
	/// <param name="prefix">The prefix whose namespace URI you want to resolve. To match the default namespace, pass an empty string. </param>
	/// <returns>The namespace URI to which the prefix maps or <see langword="null" /> if no matching prefix is found.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract string LookupNamespace(string prefix);

	/// <summary>When overridden in a derived class, resolves the entity reference for <see langword="EntityReference" /> nodes.</summary>
	/// <exception cref="T:System.InvalidOperationException">The reader is not positioned on an <see langword="EntityReference" /> node; this implementation of the reader cannot resolve entities (<see cref="P:System.Xml.XmlReader.CanResolveEntity" /> returns <see langword="false" />).</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void ResolveEntity();

	/// <summary>Reads large streams of text embedded in an XML document.</summary>
	/// <param name="buffer">The array of characters that serves as the buffer to which the text contents are written. This value cannot be <see langword="null" />.</param>
	/// <param name="index">The offset within the buffer where the <see cref="T:System.Xml.XmlReader" /> can start to copy the results.</param>
	/// <param name="count">The maximum number of characters to copy into the buffer. The actual number of characters copied is returned from this method.</param>
	/// <returns>The number of characters read into the buffer. The value zero is returned when there is no more text content.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current node does not have a value (<see cref="P:System.Xml.XmlReader.HasValue" /> is <see langword="false" />).</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> value is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The index into the buffer, or index + count is larger than the allocated buffer size.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Xml.XmlReader" /> implementation does not support this method.</exception>
	/// <exception cref="T:System.Xml.XmlException">The XML data is not well-formed.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual int ReadValueChunk(char[] buffer, int index, int count)
	{
		return 0;
	}

	/// <summary>When overridden in a derived class, reads the contents of an element or text node as a string. However, we recommend that you use the <see cref="Overload:System.Xml.XmlReader.ReadElementContentAsString" /> method instead, because it provides a more straightforward way to handle this operation.</summary>
	/// <returns>The contents of the element or an empty string.</returns>
	/// <exception cref="T:System.Xml.XmlException">An error occurred while parsing the XML.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual string ReadString()
	{
		return null;
	}

	/// <summary>Checks whether the current node is a content (non-white space text, <see langword="CDATA" />, <see langword="Element" />, <see langword="EndElement" />, <see langword="EntityReference" />, or <see langword="EndEntity" />) node. If the node is not a content node, the reader skips ahead to the next content node or end of file. It skips over nodes of the following type: <see langword="ProcessingInstruction" />, <see langword="DocumentType" />, <see langword="Comment" />, <see langword="Whitespace" />, or <see langword="SignificantWhitespace" />.</summary>
	/// <returns>The <see cref="P:System.Xml.XmlReader.NodeType" /> of the current node found by the method or <see langword="XmlNodeType.None" /> if the reader has reached the end of the input stream.</returns>
	/// <exception cref="T:System.Xml.XmlException">Incorrect XML encountered in the input stream.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual XmlNodeType MoveToContent()
	{
		return default(XmlNodeType);
	}

	/// <summary>Checks that the current node is an element and advances the reader to the next node.</summary>
	/// <exception cref="T:System.Xml.XmlException">Incorrect XML was encountered in the input stream.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual void ReadStartElement()
	{
	}

	/// <summary>Reads a text-only element. However, we recommend that you use the <see cref="M:System.Xml.XmlReader.ReadElementContentAsString" /> method instead, because it provides a more straightforward way to handle this operation.</summary>
	/// <returns>The text contained in the element that was read. An empty string if the element is empty.</returns>
	/// <exception cref="T:System.Xml.XmlException">The next content node is not a start tag; or the element found does not contain a simple text value.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual string ReadElementString()
	{
		return null;
	}

	/// <summary>Checks that the current content node is an end tag and advances the reader to the next node.</summary>
	/// <exception cref="T:System.Xml.XmlException">The current node is not an end tag or if incorrect XML is encountered in the input stream.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual void ReadEndElement()
	{
	}

	/// <summary>Calls <see cref="M:System.Xml.XmlReader.MoveToContent" /> and tests if the current content node is a start tag or empty element tag and if the <see cref="P:System.Xml.XmlReader.LocalName" /> and <see cref="P:System.Xml.XmlReader.NamespaceURI" /> properties of the element found match the given strings.</summary>
	/// <param name="localname">The string to match against the <see langword="LocalName" /> property of the element found.</param>
	/// <param name="ns">The string to match against the <see langword="NamespaceURI" /> property of the element found.</param>
	/// <returns>
	///     <see langword="true" /> if the resulting node is an element. <see langword="false" /> if a node type other than <see langword="XmlNodeType.Element" /> was found or if the <see langword="LocalName" /> and <see langword="NamespaceURI" /> properties of the element do not match the specified strings.</returns>
	/// <exception cref="T:System.Xml.XmlException">Incorrect XML is encountered in the input stream.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual bool IsStartElement(string localname, string ns)
	{
		return false;
	}

	/// <summary>Reads until an element with the specified qualified name is found.</summary>
	/// <param name="name">The qualified name of the element.</param>
	/// <returns>
	///     <see langword="true" /> if a matching element is found; otherwise <see langword="false" /> and the <see cref="T:System.Xml.XmlReader" /> is in an end of file state.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	/// <exception cref="T:System.ArgumentException">The parameter is an empty string.</exception>
	public virtual bool ReadToFollowing(string name)
	{
		return false;
	}

	/// <summary>When overridden in a derived class, reads all the content, including markup, as a string.</summary>
	/// <returns>All the XML content, including markup, in the current node. If the current node has no children, an empty string is returned.If the current node is neither an element nor attribute, an empty string is returned.</returns>
	/// <exception cref="T:System.Xml.XmlException">The XML was not well-formed, or an error occurred while parsing the XML.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual string ReadInnerXml()
	{
		return null;
	}

	private void WriteNode(XmlWriter xtw, bool defattr)
	{
	}

	private void WriteAttributeValue(XmlWriter xtw)
	{
	}

	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw)
	{
		return null;
	}

	private void SetNamespacesFlag(XmlTextWriter xtw)
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Xml.XmlReader" /> class.</summary>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Xml.XmlReader" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	protected virtual void Dispose(bool disposing)
	{
	}

	internal static bool IsTextualNode(XmlNodeType nodeType)
	{
		return false;
	}

	internal static bool HasValueInternal(XmlNodeType nodeType)
	{
		return false;
	}

	private bool SkipSubtree()
	{
		return false;
	}

	/// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance using the specified stream, base URI, and settings.</summary>
	/// <param name="input">The stream that contains the XML data. The <see cref="T:System.Xml.XmlReader" /> scans the first bytes of the stream looking for a byte order mark or other sign of encoding. When encoding is determined, the encoding is used to continue reading the stream, and processing continues parsing the input as a stream of (Unicode) characters.</param>
	/// <param name="settings">The settings for the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be <see langword="null" />.</param>
	/// <param name="baseUri">The base URI for the entity or document being read. This value can be <see langword="null" />.
	///       Security Note   The base URI is used to resolve the relative URI of the XML document. Do not use a base URI from an untrusted source.</param>
	/// <returns>An object that is used to read the XML data in the stream.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is <see langword="null" />.</exception>
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri)
	{
		return null;
	}

	/// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance by using the specified text reader and settings.</summary>
	/// <param name="input">The text reader from which to read the XML data. A text reader returns a stream of Unicode characters, so the encoding specified in the XML declaration isn't used by the XML reader to decode the data stream.</param>
	/// <param name="settings">The settings for the new <see cref="T:System.Xml.XmlReader" />. This value can be <see langword="null" />.</param>
	/// <returns>An object that is used to read the XML data in the stream.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is <see langword="null" />.</exception>
	public static XmlReader Create(TextReader input, XmlReaderSettings settings)
	{
		return null;
	}

	/// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance by using the specified text reader, settings, and base URI.</summary>
	/// <param name="input">The text reader from which to read the XML data. A text reader returns a stream of Unicode characters, so the encoding specified in the XML declaration isn't used by the <see cref="T:System.Xml.XmlReader" /> to decode the data stream.</param>
	/// <param name="settings">The settings for the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be <see langword="null" />.</param>
	/// <param name="baseUri">The base URI for the entity or document being read. This value can be <see langword="null" />.
	///       Security Note   The base URI is used to resolve the relative URI of the XML document. Do not use a base URI from an untrusted source.</param>
	/// <returns>An object that is used to read the XML data in the stream.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is <see langword="null" />.</exception>
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri)
	{
		return null;
	}

	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext)
	{
		return null;
	}

	internal static int CalcBufferSize(Stream input)
	{
		return 0;
	}

	/// <summary>Initializes a new instance of the <see langword="XmlReader" /> class.</summary>
	protected XmlReader()
	{
	}
}
