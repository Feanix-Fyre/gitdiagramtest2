using System.IO;

namespace System.Xml;

/// <summary>Represents a writer that provides a fast, non-cached, forward-only way to generate streams or files that contain XML data.</summary>
public abstract class XmlWriter : IDisposable
{
	private char[] writeNodeBuffer;

	/// <summary>When overridden in a derived class, gets the state of the writer.</summary>
	/// <returns>One of the <see cref="T:System.Xml.WriteState" /> values.</returns>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract WriteState WriteState { get; }

	/// <summary>When overridden in a derived class, writes the XML declaration with the version "1.0".</summary>
	/// <exception cref="T:System.InvalidOperationException">This is not the first write method called after the constructor.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteStartDocument();

	/// <summary>When overridden in a derived class, writes the XML declaration with the version "1.0" and the standalone attribute.</summary>
	/// <param name="standalone">If <see langword="true" />, it writes "standalone=yes"; if <see langword="false" />, it writes "standalone=no".</param>
	/// <exception cref="T:System.InvalidOperationException">This is not the first write method called after the constructor. </exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteStartDocument(bool standalone);

	/// <summary>When overridden in a derived class, closes any open elements or attributes and puts the writer back in the Start state.</summary>
	/// <exception cref="T:System.ArgumentException">The XML document is invalid.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteEndDocument();

	/// <summary>When overridden in a derived class, writes the DOCTYPE declaration with the specified name and optional attributes.</summary>
	/// <param name="name">The name of the DOCTYPE. This must be non-empty.</param>
	/// <param name="pubid">If non-null it also writes PUBLIC "pubid" "sysid" where <paramref name="pubid" /> and <paramref name="sysid" /> are replaced with the value of the given arguments.</param>
	/// <param name="sysid">If <paramref name="pubid" /> is <see langword="null" /> and <paramref name="sysid" /> is non-null it writes SYSTEM "sysid" where <paramref name="sysid" /> is replaced with the value of this argument.</param>
	/// <param name="subset">If non-null it writes [subset] where subset is replaced with the value of this argument.</param>
	/// <exception cref="T:System.InvalidOperationException">This method was called outside the prolog (after the root element). </exception>
	/// <exception cref="T:System.ArgumentException">The value for <paramref name="name" /> would result in invalid XML.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

	/// <summary>When overridden in a derived class, writes the specified start tag and associates it with the given namespace.</summary>
	/// <param name="localName">The local name of the element.</param>
	/// <param name="ns">The namespace URI to associate with the element. If this namespace is already in scope and has an associated prefix, the writer automatically writes that prefix also.</param>
	/// <exception cref="T:System.InvalidOperationException">The writer is closed.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">There is a character in the buffer that is a valid XML character but is not valid for the output encoding. For example, if the output encoding is ASCII, you should only use characters from the range of 0 to 127 for element and attribute names. The invalid character might be in the argument of this method or in an argument of previous methods that were writing to the buffer. Such characters are escaped by character entity references when possible (for example, in text nodes or attribute values). However, the character entity reference is not allowed in element and attribute names, comments, processing instructions, or CDATA sections.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public void WriteStartElement(string localName, string ns)
	{
	}

	/// <summary>When overridden in a derived class, writes the specified start tag and associates it with the given namespace and prefix.</summary>
	/// <param name="prefix">The namespace prefix of the element.</param>
	/// <param name="localName">The local name of the element.</param>
	/// <param name="ns">The namespace URI to associate with the element.</param>
	/// <exception cref="T:System.InvalidOperationException">The writer is closed.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">There is a character in the buffer that is a valid XML character but is not valid for the output encoding. For example, if the output encoding is ASCII, you should only use characters from the range of 0 to 127 for element and attribute names. The invalid character might be in the argument of this method or in an argument of previous methods that were writing to the buffer. Such characters are escaped by character entity references when possible (for example, in text nodes or attribute values). However, the character entity reference is not allowed in element and attribute names, comments, processing instructions, or CDATA sections.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteStartElement(string prefix, string localName, string ns);

	/// <summary>When overridden in a derived class, writes out a start tag with the specified local name.</summary>
	/// <param name="localName">The local name of the element.</param>
	/// <exception cref="T:System.InvalidOperationException">The writer is closed.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">There is a character in the buffer that is a valid XML character but is not valid for the output encoding. For example, if the output encoding is ASCII, you should only use characters from the range of 0 to 127 for element and attribute names. The invalid character might be in the argument of this method or in an argument of previous methods that were writing to the buffer. Such characters are escaped by character entity references when possible (for example, in text nodes or attribute values). However, the character entity reference is not allowed in element and attribute names, comments, processing instructions, or CDATA sections. </exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public void WriteStartElement(string localName)
	{
	}

	/// <summary>When overridden in a derived class, closes one element and pops the corresponding namespace scope.</summary>
	/// <exception cref="T:System.InvalidOperationException">This results in an invalid XML document.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteEndElement();

	/// <summary>When overridden in a derived class, closes one element and pops the corresponding namespace scope.</summary>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteFullEndElement();

	/// <summary>When overridden in a derived class, writes an attribute with the specified local name, namespace URI, and value.</summary>
	/// <param name="localName">The local name of the attribute.</param>
	/// <param name="ns">The namespace URI to associate with the attribute.</param>
	/// <param name="value">The value of the attribute.</param>
	/// <exception cref="T:System.InvalidOperationException">The state of writer is not <see langword="WriteState.Element" /> or writer is closed. </exception>
	/// <exception cref="T:System.ArgumentException">The <see langword="xml:space" /> or <see langword="xml:lang" /> attribute value is invalid. </exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public void WriteAttributeString(string localName, string ns, string value)
	{
	}

	/// <summary>When overridden in a derived class, writes out the attribute with the specified local name and value.</summary>
	/// <param name="localName">The local name of the attribute.</param>
	/// <param name="value">The value of the attribute.</param>
	/// <exception cref="T:System.InvalidOperationException">The state of writer is not <see langword="WriteState.Element" /> or writer is closed. </exception>
	/// <exception cref="T:System.ArgumentException">The <see langword="xml:space" /> or <see langword="xml:lang" /> attribute value is invalid. </exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public void WriteAttributeString(string localName, string value)
	{
	}

	/// <summary>When overridden in a derived class, writes out the attribute with the specified prefix, local name, namespace URI, and value.</summary>
	/// <param name="prefix">The namespace prefix of the attribute.</param>
	/// <param name="localName">The local name of the attribute.</param>
	/// <param name="ns">The namespace URI of the attribute.</param>
	/// <param name="value">The value of the attribute.</param>
	/// <exception cref="T:System.InvalidOperationException">The state of writer is not <see langword="WriteState.Element" /> or writer is closed. </exception>
	/// <exception cref="T:System.ArgumentException">The <see langword="xml:space" /> or <see langword="xml:lang" /> attribute value is invalid. </exception>
	/// <exception cref="T:System.Xml.XmlException">The <paramref name="localName" /> or <paramref name="ns" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public void WriteAttributeString(string prefix, string localName, string ns, string value)
	{
	}

	/// <summary>When overridden in a derived class, writes the start of an attribute with the specified prefix, local name, and namespace URI.</summary>
	/// <param name="prefix">The namespace prefix of the attribute.</param>
	/// <param name="localName">The local name of the attribute.</param>
	/// <param name="ns">The namespace URI for the attribute.</param>
	/// <exception cref="T:System.Text.EncoderFallbackException">There is a character in the buffer that is a valid XML character but is not valid for the output encoding. For example, if the output encoding is ASCII, you should only use characters from the range of 0 to 127 for element and attribute names. The invalid character might be in the argument of this method or in an argument of previous methods that were writing to the buffer. Such characters are escaped by character entity references when possible (for example, in text nodes or attribute values). However, the character entity reference is not allowed in element and attribute names, comments, processing instructions, or CDATA sections. </exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteStartAttribute(string prefix, string localName, string ns);

	/// <summary>When overridden in a derived class, closes the previous <see cref="M:System.Xml.XmlWriter.WriteStartAttribute(System.String,System.String)" /> call.</summary>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteEndAttribute();

	/// <summary>When overridden in a derived class, writes out a &lt;![CDATA[...]]&gt; block containing the specified text.</summary>
	/// <param name="text">The text to place inside the CDATA block.</param>
	/// <exception cref="T:System.ArgumentException">The text would result in a non-well formed XML document.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteCData(string text);

	/// <summary>When overridden in a derived class, writes out a comment &lt;!--...--&gt; containing the specified text.</summary>
	/// <param name="text">Text to place inside the comment.</param>
	/// <exception cref="T:System.ArgumentException">The text would result in a non-well-formed XML document.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteComment(string text);

	/// <summary>When overridden in a derived class, writes out a processing instruction with a space between the name and text as follows: &lt;?name text?&gt;.</summary>
	/// <param name="name">The name of the processing instruction.</param>
	/// <param name="text">The text to include in the processing instruction.</param>
	/// <exception cref="T:System.ArgumentException">The text would result in a non-well formed XML document.
	///         <paramref name="name" /> is either <see langword="null" /> or <see langword="String.Empty" />.This method is being used to create an XML declaration after <see cref="M:System.Xml.XmlWriter.WriteStartDocument" /> has already been called. </exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteProcessingInstruction(string name, string text);

	/// <summary>When overridden in a derived class, writes out an entity reference as <see langword="&amp;name;" />.</summary>
	/// <param name="name">The name of the entity reference.</param>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="name" /> is either <see langword="null" /> or <see langword="String.Empty" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteEntityRef(string name);

	/// <summary>When overridden in a derived class, forces the generation of a character entity for the specified Unicode character value.</summary>
	/// <param name="ch">The Unicode character for which to generate a character entity.</param>
	/// <exception cref="T:System.ArgumentException">The character is in the surrogate pair character range, <see langword="0xd800" /> - <see langword="0xdfff" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteCharEntity(char ch);

	/// <summary>When overridden in a derived class, writes out the given white space.</summary>
	/// <param name="ws">The string of white space characters.</param>
	/// <exception cref="T:System.ArgumentException">The string contains non-white space characters.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteWhitespace(string ws);

	/// <summary>When overridden in a derived class, writes the given text content.</summary>
	/// <param name="text">The text to write.</param>
	/// <exception cref="T:System.ArgumentException">The text string contains an invalid surrogate pair.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteString(string text);

	/// <summary>When overridden in a derived class, generates and writes the surrogate character entity for the surrogate character pair.</summary>
	/// <param name="lowChar">The low surrogate. This must be a value between 0xDC00 and 0xDFFF.</param>
	/// <param name="highChar">The high surrogate. This must be a value between 0xD800 and 0xDBFF.</param>
	/// <exception cref="T:System.ArgumentException">An invalid surrogate character pair was passed.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

	/// <summary>When overridden in a derived class, writes text one buffer at a time.</summary>
	/// <param name="buffer">Character array containing the text to write.</param>
	/// <param name="index">The position in the buffer indicating the start of the text to write.</param>
	/// <param name="count">The number of characters to write.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or-The buffer length minus <paramref name="index" /> is less than <paramref name="count" />; the call results in surrogate pair characters being split or an invalid surrogate pair being written.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="buffer" /> parameter value is not valid.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteChars(char[] buffer, int index, int count);

	/// <summary>When overridden in a derived class, writes raw markup manually from a character buffer.</summary>
	/// <param name="buffer">Character array containing the text to write.</param>
	/// <param name="index">The position within the buffer indicating the start of the text to write.</param>
	/// <param name="count">The number of characters to write.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="index" /> or <paramref name="count" /> is less than zero. -or-The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteRaw(char[] buffer, int index, int count);

	/// <summary>When overridden in a derived class, writes raw markup manually from a string.</summary>
	/// <param name="data">String containing the text to write.</param>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="data" /> is either <see langword="null" /> or <see langword="String.Empty" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteRaw(string data);

	/// <summary>When overridden in a derived class, encodes the specified binary bytes as Base64 and writes out the resulting text.</summary>
	/// <param name="buffer">Byte array to encode.</param>
	/// <param name="index">The position in the buffer indicating the start of the bytes to write.</param>
	/// <param name="count">The number of bytes to write.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="buffer" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="index" /> or <paramref name="count" /> is less than zero. -or-The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void WriteBase64(byte[] buffer, int index, int count);

	/// <summary>When overridden in a derived class, encodes the specified binary bytes as <see langword="BinHex" /> and writes out the resulting text.</summary>
	/// <param name="buffer">Byte array to encode.</param>
	/// <param name="index">The position in the buffer indicating the start of the bytes to write.</param>
	/// <param name="count">The number of bytes to write.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The writer is closed or in error state.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="index" /> or <paramref name="count" /> is less than zero. -or-The buffer length minus <paramref name="index" /> is less than <paramref name="count" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual void WriteBinHex(byte[] buffer, int index, int count)
	{
	}

	/// <summary>When overridden in a derived class, closes this stream and the underlying stream.</summary>
	/// <exception cref="T:System.InvalidOperationException">A call is made to write more output after <see langword="Close" /> has been called or the result of this call is an invalid XML document.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual void Close()
	{
	}

	/// <summary>When overridden in a derived class, flushes whatever is in the buffer to the underlying streams and also flushes the underlying stream.</summary>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract void Flush();

	/// <summary>When overridden in a derived class, returns the closest prefix defined in the current namespace scope for the namespace URI.</summary>
	/// <param name="ns">The namespace URI whose prefix you want to find.</param>
	/// <returns>The matching prefix or <see langword="null" /> if no matching namespace URI is found in the current scope.</returns>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="ns" /> is either <see langword="null" /> or <see langword="String.Empty" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public abstract string LookupPrefix(string ns);

	/// <summary>Writes a <see cref="T:System.String" /> value.</summary>
	/// <param name="value">The <see cref="T:System.String" /> value to write.</param>
	/// <exception cref="T:System.ArgumentException">An invalid value was specified.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual void WriteValue(string value)
	{
	}

	/// <summary>When overridden in a derived class, writes out all the attributes found at the current position in the <see cref="T:System.Xml.XmlReader" />.</summary>
	/// <param name="reader">The <see langword="XmlReader" /> from which to copy the attributes.</param>
	/// <param name="defattr">
	///       <see langword="true" /> to copy the default attributes from the <see langword="XmlReader" />; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="reader" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.Xml.XmlException">The reader is not positioned on an <see langword="element" />, <see langword="attribute" /> or <see langword="XmlDeclaration" /> node. </exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual void WriteAttributes(XmlReader reader, bool defattr)
	{
	}

	/// <summary>When overridden in a derived class, copies everything from the reader to the writer and moves the reader to the start of the next sibling.</summary>
	/// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> to read from.</param>
	/// <param name="defattr">
	///       <see langword="true" /> to copy the default attributes from the <see langword="XmlReader" />; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="reader" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="reader" /> contains invalid characters.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public virtual void WriteNode(XmlReader reader, bool defattr)
	{
	}

	/// <summary>Writes an element with the specified local name, namespace URI, and value.</summary>
	/// <param name="localName">The local name of the element.</param>
	/// <param name="ns">The namespace URI to associate with the element.</param>
	/// <param name="value">The value of the element.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="localName" /> value is <see langword="null" /> or an empty string.-or-The parameter values are not valid.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">There is a character in the buffer that is a valid XML character but is not valid for the output encoding. For example, if the output encoding is ASCII, you should only use characters from the range of 0 to 127 for element and attribute names. The invalid character might be in the argument of this method or in an argument of previous methods that were writing to the buffer. Such characters are escaped by character entity references when possible (for example, in text nodes or attribute values). However, the character entity reference is not allowed in element and attribute names, comments, processing instructions, or CDATA sections.</exception>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public void WriteElementString(string localName, string ns, string value)
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Xml.XmlWriter" /> class.</summary>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Xml.XmlWriter" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlWriter" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the stream and <see cref="T:System.Xml.XmlWriterSettings" /> object.</summary>
	/// <param name="output">The stream to which you want to write. The <see cref="T:System.Xml.XmlWriter" /> writes XML 1.0 text syntax and appends it to the specified stream.</param>
	/// <param name="settings">The <see cref="T:System.Xml.XmlWriterSettings" /> object used to configure the new <see cref="T:System.Xml.XmlWriter" /> instance. If this is <see langword="null" />, a <see cref="T:System.Xml.XmlWriterSettings" /> with default settings is used.If the <see cref="T:System.Xml.XmlWriter" /> is being used with the <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> method, you should use the <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> property to obtain an <see cref="T:System.Xml.XmlWriterSettings" /> object with the correct settings. This ensures that the created <see cref="T:System.Xml.XmlWriter" /> object has the correct output settings.</param>
	/// <returns>An <see cref="T:System.Xml.XmlWriter" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="stream" /> value is <see langword="null" />.</exception>
	public static XmlWriter Create(Stream output, XmlWriterSettings settings)
	{
		return null;
	}

	/// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the <see cref="T:System.IO.TextWriter" /> and <see cref="T:System.Xml.XmlWriterSettings" /> objects.</summary>
	/// <param name="output">The <see cref="T:System.IO.TextWriter" /> to which you want to write. The <see cref="T:System.Xml.XmlWriter" /> writes XML 1.0 text syntax and appends it to the specified <see cref="T:System.IO.TextWriter" />.</param>
	/// <param name="settings">The <see cref="T:System.Xml.XmlWriterSettings" /> object used to configure the new <see cref="T:System.Xml.XmlWriter" /> instance. If this is <see langword="null" />, a <see cref="T:System.Xml.XmlWriterSettings" /> with default settings is used.If the <see cref="T:System.Xml.XmlWriter" /> is being used with the <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> method, you should use the <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> property to obtain an <see cref="T:System.Xml.XmlWriterSettings" /> object with the correct settings. This ensures that the created <see cref="T:System.Xml.XmlWriter" /> object has the correct output settings.</param>
	/// <returns>An <see cref="T:System.Xml.XmlWriter" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="text" /> value is <see langword="null" />.</exception>
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlWriter" /> class.</summary>
	protected XmlWriter()
	{
	}
}
