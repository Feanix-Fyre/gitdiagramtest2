using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace System.Xml;

/// <summary>Represents a writer that provides a fast, non-cached, forward-only way of generating streams or files containing XML data that conforms to the W3C Extensible Markup Language (XML) 1.0 and the Namespaces in XML recommendations. Starting with the .NET Framework 2.0, we recommend that you use the <see cref="T:System.Xml.XmlWriter" /> class instead.</summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public class XmlTextWriter : XmlWriter
{
	private enum NamespaceState
	{
		Uninitialized = 0,
		NotDeclaredButInScope = 1,
		DeclaredButNotWrittenOut = 2,
		DeclaredAndWrittenOut = 3
	}

	private struct TagInfo
	{
		internal string name;

		internal string prefix;

		internal string defaultNs;

		internal NamespaceState defaultNsState;

		internal XmlSpace xmlSpace;

		internal string xmlLang;

		internal int prevNsTop;

		internal int prefixCount;

		internal bool mixed;

		internal void Init(int nsTop)
		{
		}
	}

	private struct Namespace
	{
		internal string prefix;

		internal string ns;

		internal bool declared;

		internal int prevNsIndex;

		internal void Set(string prefix, string ns, bool declared)
		{
		}
	}

	private enum SpecialAttr
	{
		None = 0,
		XmlSpace = 1,
		XmlLang = 2,
		XmlNs = 3
	}

	private enum State
	{
		Start = 0,
		Prolog = 1,
		PostDTD = 2,
		Element = 3,
		Attribute = 4,
		Content = 5,
		AttrOnly = 6,
		Epilog = 7,
		Error = 8,
		Closed = 9
	}

	private enum Token
	{
		PI = 0,
		Doctype = 1,
		Comment = 2,
		CData = 3,
		StartElement = 4,
		EndElement = 5,
		LongEndElement = 6,
		StartAttribute = 7,
		EndAttribute = 8,
		Content = 9,
		Base64 = 10,
		RawData = 11,
		Whitespace = 12,
		Empty = 13
	}

	private TextWriter textWriter;

	private XmlTextEncoder xmlEncoder;

	private Encoding encoding;

	private Formatting formatting;

	private bool indented;

	private int indentation;

	private char indentChar;

	private TagInfo[] stack;

	private int top;

	private State[] stateTable;

	private State currentState;

	private Token lastToken;

	private XmlTextWriterBase64Encoder base64Encoder;

	private char quoteChar;

	private char curQuoteChar;

	private bool namespaces;

	private SpecialAttr specialAttr;

	private string prefixForXmlNs;

	private bool flush;

	private Namespace[] nsStack;

	private int nsTop;

	private Dictionary<string, int> nsHashtable;

	private bool useNsHashtable;

	private XmlCharType xmlCharType;

	private static string[] stateName;

	private static string[] tokenName;

	private static readonly State[] stateTableDefault;

	private static readonly State[] stateTableDocument;

	/// <summary>Gets the underlying stream object.</summary>
	/// <returns>The stream to which the <see langword="XmlTextWriter" /> is writing or <see langword="null" /> if the <see langword="XmlTextWriter" /> was constructed using a <see cref="T:System.IO.TextWriter" /> that does not inherit from the <see cref="T:System.IO.StreamWriter" /> class.</returns>
	public Stream BaseStream => null;

	/// <summary>Gets or sets a value indicating whether to do namespace support.</summary>
	/// <returns>
	///     <see langword="true" /> to support namespaces; otherwise, <see langword="false" />.The default is <see langword="true" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">You can only change this property when in the <see langword="WriteState.Start" /> state. </exception>
	public bool Namespaces
	{
		set
		{
		}
	}

	/// <summary>Indicates how the output is formatted.</summary>
	/// <returns>One of the <see cref="T:System.Xml.Formatting" /> values. The default is <see langword="Formatting.None" /> (no special formatting).</returns>
	public Formatting Formatting
	{
		set
		{
		}
	}

	/// <summary>Gets or sets which character to use to quote attribute values.</summary>
	/// <returns>The character to use to quote attribute values. This must be a single quote (&amp;#39;) or a double quote (&amp;#34;). The default is a double quote.</returns>
	/// <exception cref="T:System.ArgumentException">Setting this property to something other than either a single or double quote. </exception>
	public char QuoteChar
	{
		set
		{
		}
	}

	/// <summary>Gets the state of the writer.</summary>
	/// <returns>One of the <see cref="T:System.Xml.WriteState" /> values.</returns>
	public override WriteState WriteState => default(WriteState);

	internal XmlTextWriter()
	{
	}

	/// <summary>Creates an instance of the <see langword="XmlTextWriter" /> class using the specified stream and encoding.</summary>
	/// <param name="w">The stream to which you want to write. </param>
	/// <param name="encoding">The encoding to generate. If encoding is <see langword="null" /> it writes out the stream as UTF-8 and omits the encoding attribute from the <see langword="ProcessingInstruction" />. </param>
	/// <exception cref="T:System.ArgumentException">The encoding is not supported or the stream cannot be written to. </exception>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="w" /> is <see langword="null" />. </exception>
	public XmlTextWriter(Stream w, Encoding encoding)
	{
	}

	/// <summary>Creates an instance of the <see cref="T:System.Xml.XmlTextWriter" /> class using the specified file.</summary>
	/// <param name="filename">The filename to write to. If the file exists, it truncates it and overwrites it with the new content. </param>
	/// <param name="encoding">The encoding to generate. If encoding is <see langword="null" /> it writes the file out as UTF-8, and omits the encoding attribute from the <see langword="ProcessingInstruction" />. </param>
	/// <exception cref="T:System.ArgumentException">The encoding is not supported; the filename is empty, contains only white space, or contains one or more invalid characters. </exception>
	/// <exception cref="T:System.UnauthorizedAccessException">Access is denied. </exception>
	/// <exception cref="T:System.ArgumentNullException">The filename is <see langword="null" />. </exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The directory to write to is not found. </exception>
	/// <exception cref="T:System.IO.IOException">The filename includes an incorrect or invalid syntax for file name, directory name, or volume label syntax. </exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
	public XmlTextWriter(string filename, Encoding encoding)
	{
	}

	/// <summary>Creates an instance of the <see langword="XmlTextWriter" /> class using the specified <see cref="T:System.IO.TextWriter" />.</summary>
	/// <param name="w">The <see langword="TextWriter" /> to write to. It is assumed that the <see langword="TextWriter" /> is already set to the correct encoding. </param>
	public XmlTextWriter(TextWriter w)
	{
	}

	/// <summary>Writes the XML declaration with the version "1.0".</summary>
	/// <exception cref="T:System.InvalidOperationException">This is not the first write method called after the constructor. </exception>
	public override void WriteStartDocument()
	{
	}

	/// <summary>Writes the XML declaration with the version "1.0" and the standalone attribute.</summary>
	/// <param name="standalone">If <see langword="true" />, it writes "standalone=yes"; if <see langword="false" />, it writes "standalone=no". </param>
	/// <exception cref="T:System.InvalidOperationException">This is not the first write method called after the constructor. </exception>
	public override void WriteStartDocument(bool standalone)
	{
	}

	/// <summary>Closes any open elements or attributes and puts the writer back in the Start state.</summary>
	/// <exception cref="T:System.ArgumentException">The XML document is invalid. </exception>
	public override void WriteEndDocument()
	{
	}

	/// <summary>Writes the DOCTYPE declaration with the specified name and optional attributes.</summary>
	/// <param name="name">The name of the DOCTYPE. This must be non-empty. </param>
	/// <param name="pubid">If non-null it also writes PUBLIC "pubid" "sysid" where <paramref name="pubid" /> and <paramref name="sysid" /> are replaced with the value of the given arguments. </param>
	/// <param name="sysid">If <paramref name="pubid" /> is null and <paramref name="sysid" /> is non-null it writes SYSTEM "sysid" where <paramref name="sysid" /> is replaced with the value of this argument. </param>
	/// <param name="subset">If non-null it writes [subset] where subset is replaced with the value of this argument. </param>
	/// <exception cref="T:System.InvalidOperationException">This method was called outside the prolog (after the root element). </exception>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="name" /> is <see langword="null" /> or <see langword="String.Empty" />-or- the value for <paramref name="name" /> would result in invalid XML. </exception>
	public override void WriteDocType(string name, string pubid, string sysid, string subset)
	{
	}

	/// <summary>Writes the specified start tag and associates it with the given namespace and prefix.</summary>
	/// <param name="prefix">The namespace prefix of the element. </param>
	/// <param name="localName">The local name of the element. </param>
	/// <param name="ns">The namespace URI to associate with the element. If this namespace is already in scope and has an associated prefix then the writer automatically writes that prefix also. </param>
	/// <exception cref="T:System.InvalidOperationException">The writer is closed. </exception>
	public override void WriteStartElement(string prefix, string localName, string ns)
	{
	}

	/// <summary>Closes one element and pops the corresponding namespace scope.</summary>
	public override void WriteEndElement()
	{
	}

	/// <summary>Closes one element and pops the corresponding namespace scope.</summary>
	public override void WriteFullEndElement()
	{
	}

	/// <summary>Writes the start of an attribute.</summary>
	/// <param name="prefix">
	///       <see langword="Namespace" /> prefix of the attribute. </param>
	/// <param name="localName">
	///       <see langword="LocalName" /> of the attribute. </param>
	/// <param name="ns">
	///       <see langword="NamespaceURI" /> of the attribute </param>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="localName" /> is either <see langword="null" /> or <see langword="String.Empty" />. </exception>
	public override void WriteStartAttribute(string prefix, string localName, string ns)
	{
	}

	/// <summary>Closes the previous <see cref="M:System.Xml.XmlTextWriter.WriteStartAttribute(System.String,System.String,System.String)" /> call.</summary>
	public override void WriteEndAttribute()
	{
	}

	/// <summary>Writes out a &lt;![CDATA[...]]&gt; block containing the specified text.</summary>
	/// <param name="text">Text to place inside the CDATA block. </param>
	/// <exception cref="T:System.ArgumentException">The text would result in a non-well formed XML document. </exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Xml.XmlTextWriter.WriteState" /> is <see langword="Closed" />. </exception>
	public override void WriteCData(string text)
	{
	}

	/// <summary>Writes out a comment &lt;!--...--&gt; containing the specified text.</summary>
	/// <param name="text">Text to place inside the comment. </param>
	/// <exception cref="T:System.ArgumentException">The text would result in a non-well formed XML document </exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Xml.XmlTextWriter.WriteState" /> is <see langword="Closed" />. </exception>
	public override void WriteComment(string text)
	{
	}

	/// <summary>Writes out a processing instruction with a space between the name and text as follows: &lt;?name text?&gt;.</summary>
	/// <param name="name">Name of the processing instruction. </param>
	/// <param name="text">Text to include in the processing instruction. </param>
	/// <exception cref="T:System.ArgumentException">The text would result in a non-well formed XML document.
	///         <paramref name="name" /> is either <see langword="null" /> or <see langword="String.Empty" />.This method is being used to create an XML declaration after <see cref="M:System.Xml.XmlTextWriter.WriteStartDocument" /> has already been called. </exception>
	public override void WriteProcessingInstruction(string name, string text)
	{
	}

	/// <summary>Writes out an entity reference as <see langword="&amp;name;" />.</summary>
	/// <param name="name">Name of the entity reference. </param>
	/// <exception cref="T:System.ArgumentException">The text would result in a non-well formed XML document or <paramref name="name" /> is either <see langword="null" /> or <see langword="String.Empty" />. </exception>
	public override void WriteEntityRef(string name)
	{
	}

	/// <summary>Forces the generation of a character entity for the specified Unicode character value.</summary>
	/// <param name="ch">Unicode character for which to generate a character entity. </param>
	/// <exception cref="T:System.ArgumentException">The character is in the surrogate pair character range, <see langword="0xd800" /> - <see langword="0xdfff" />; or the text would result in a non-well formed XML document. </exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Xml.XmlTextWriter.WriteState" /> is <see langword="Closed" />. </exception>
	public override void WriteCharEntity(char ch)
	{
	}

	/// <summary>Writes out the given white space.</summary>
	/// <param name="ws">The string of white space characters. </param>
	/// <exception cref="T:System.ArgumentException">The string contains non-white space characters. </exception>
	public override void WriteWhitespace(string ws)
	{
	}

	/// <summary>Writes the given text content.</summary>
	/// <param name="text">Text to write. </param>
	/// <exception cref="T:System.ArgumentException">The text string contains an invalid surrogate pair. </exception>
	public override void WriteString(string text)
	{
	}

	/// <summary>Generates and writes the surrogate character entity for the surrogate character pair.</summary>
	/// <param name="lowChar">The low surrogate. This must be a value between <see langword="0xDC00" /> and <see langword="0xDFFF" />. </param>
	/// <param name="highChar">The high surrogate. This must be a value between <see langword="0xD800" /> and <see langword="0xDBFF" />. </param>
	/// <exception cref="T:System.Exception">An invalid surrogate character pair was passed. </exception>
	public override void WriteSurrogateCharEntity(char lowChar, char highChar)
	{
	}

	/// <summary>Writes text one buffer at a time.</summary>
	/// <param name="buffer">Character array containing the text to write. </param>
	/// <param name="index">The position in the buffer indicating the start of the text to write. </param>
	/// <param name="count">The number of characters to write. </param>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="buffer" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="index" /> or <paramref name="count" /> is less than zero. -or-The buffer length minus <paramref name="index" /> is less than <paramref name="count" />; the call results in surrogate pair characters being split or an invalid surrogate pair being written.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Xml.XmlTextWriter.WriteState" /> is Closed. </exception>
	public override void WriteChars(char[] buffer, int index, int count)
	{
	}

	/// <summary>Writes raw markup manually from a character buffer.</summary>
	/// <param name="buffer">Character array containing the text to write. </param>
	/// <param name="index">The position within the buffer indicating the start of the text to write. </param>
	/// <param name="count">The number of characters to write. </param>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="buffer" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or-The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
	public override void WriteRaw(char[] buffer, int index, int count)
	{
	}

	/// <summary>Writes raw markup manually from a string.</summary>
	/// <param name="data">String containing the text to write. </param>
	public override void WriteRaw(string data)
	{
	}

	/// <summary>Encodes the specified binary bytes as base64 and writes out the resulting text.</summary>
	/// <param name="buffer">Byte array to encode. </param>
	/// <param name="index">The position within the buffer indicating the start of the bytes to write. </param>
	/// <param name="count">The number of bytes to write. </param>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="buffer" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="index" /> or <paramref name="count" /> is less than zero. </exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Xml.XmlTextWriter.WriteState" /> is <see langword="Closed" />. </exception>
	public override void WriteBase64(byte[] buffer, int index, int count)
	{
	}

	/// <summary>Encodes the specified binary bytes as binhex and writes out the resulting text.</summary>
	/// <param name="buffer">Byte array to encode. </param>
	/// <param name="index">The position in the buffer indicating the start of the bytes to write. </param>
	/// <param name="count">The number of bytes to write. </param>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="buffer" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="index" /> or <paramref name="count" /> is less than zero. </exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Xml.XmlTextWriter.WriteState" /> is Closed. </exception>
	public override void WriteBinHex(byte[] buffer, int index, int count)
	{
	}

	/// <summary>Closes this stream and the underlying stream.</summary>
	public override void Close()
	{
	}

	/// <summary>Flushes whatever is in the buffer to the underlying streams and also flushes the underlying stream.</summary>
	public override void Flush()
	{
	}

	/// <summary>Returns the closest prefix defined in the current namespace scope for the namespace URI.</summary>
	/// <param name="ns">Namespace URI whose prefix you want to find. </param>
	/// <returns>The matching prefix. Or <see langword="null" /> if no matching namespace URI is found in the current scope.</returns>
	/// <exception cref="T:System.ArgumentException">
	///         <paramref name="ns" /> is either <see langword="null" /> or <see langword="String.Empty" />. </exception>
	public override string LookupPrefix(string ns)
	{
		return null;
	}

	private void StartDocument(int standalone)
	{
	}

	private void AutoComplete(Token token)
	{
	}

	private void AutoCompleteAll()
	{
	}

	private void InternalWriteEndElement(bool longFormat)
	{
	}

	private void WriteEndStartTag(bool empty)
	{
	}

	private void WriteEndAttributeQuote()
	{
	}

	private void Indent(bool beforeEndElement)
	{
	}

	private void PushNamespace(string prefix, string ns, bool declared)
	{
	}

	private void AddNamespace(string prefix, string ns, bool declared)
	{
	}

	private void AddToNamespaceHashtable(int namespaceIndex)
	{
	}

	private void PopNamespaces(int indexFrom, int indexTo)
	{
	}

	private string GeneratePrefix()
	{
		return null;
	}

	private void InternalWriteProcessingInstruction(string name, string text)
	{
	}

	private int LookupNamespace(string prefix)
	{
		return 0;
	}

	private int LookupNamespaceInCurrentScope(string prefix)
	{
		return 0;
	}

	private string FindPrefix(string ns)
	{
		return null;
	}

	private void ValidateName(string name, bool isNCName)
	{
	}

	private void HandleSpecialAttribute()
	{
	}

	private void VerifyPrefixXml(string prefix, string ns)
	{
	}

	private void PushStack()
	{
	}

	private void FlushEncoders()
	{
	}
}
