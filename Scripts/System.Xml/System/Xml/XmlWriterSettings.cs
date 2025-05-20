using System.Collections.Generic;
using System.IO;
using System.Text;

namespace System.Xml;

/// <summary>Specifies a set of features to support on the <see cref="T:System.Xml.XmlWriter" /> object created by the <see cref="Overload:System.Xml.XmlWriter.Create" /> method.</summary>
public sealed class XmlWriterSettings
{
	private bool useAsync;

	private Encoding encoding;

	private bool omitXmlDecl;

	private NewLineHandling newLineHandling;

	private string newLineChars;

	private TriState indent;

	private string indentChars;

	private bool newLineOnAttributes;

	private bool closeOutput;

	private NamespaceHandling namespaceHandling;

	private ConformanceLevel conformanceLevel;

	private bool checkCharacters;

	private bool writeEndDocumentOnClose;

	private XmlOutputMethod outputMethod;

	private List<XmlQualifiedName> cdataSections;

	private bool doNotEscapeUriAttributes;

	private bool mergeCDataSections;

	private string mediaType;

	private string docTypeSystem;

	private string docTypePublic;

	private XmlStandalone standalone;

	private bool autoXmlDecl;

	private bool isReadOnly;

	/// <summary>Gets or sets a value that indicates whether asynchronous <see cref="T:System.Xml.XmlWriter" /> methods can be used on a particular <see cref="T:System.Xml.XmlWriter" /> instance.</summary>
	/// <returns>
	///     <see langword="true" /> if asynchronous methods can be used; otherwise, <see langword="false" />.</returns>
	public bool Async => false;

	/// <summary>Gets or sets the type of text encoding to use.</summary>
	/// <returns>The text encoding to use. The default is <see langword="Encoding.UTF8" />.</returns>
	public Encoding Encoding => null;

	/// <summary>Gets or sets a value indicating whether to omit an XML declaration.</summary>
	/// <returns>
	///     <see langword="true" /> to omit the XML declaration; otherwise, <see langword="false" />. The default is <see langword="false" />, an XML declaration is written.</returns>
	public bool OmitXmlDeclaration
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether to normalize line breaks in the output.</summary>
	/// <returns>One of the <see cref="T:System.Xml.NewLineHandling" /> values. The default is <see cref="F:System.Xml.NewLineHandling.Replace" />.</returns>
	public NewLineHandling NewLineHandling => default(NewLineHandling);

	/// <summary>Gets or sets the character string to use for line breaks.</summary>
	/// <returns>The character string to use for line breaks. This can be set to any string value. However, to ensure valid XML, you should specify only valid white space characters, such as space characters, tabs, carriage returns, or line feeds. The default is \r\n (carriage return, new line).</returns>
	/// <exception cref="T:System.ArgumentNullException">The value assigned to the <see cref="P:System.Xml.XmlWriterSettings.NewLineChars" /> is <see langword="null" />.</exception>
	public string NewLineChars => null;

	/// <summary>Gets or sets a value indicating whether to indent elements.</summary>
	/// <returns>
	///     <see langword="true" /> to write individual elements on new lines and indent; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool Indent
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the character string to use when indenting. This setting is used when the <see cref="P:System.Xml.XmlWriterSettings.Indent" /> property is set to <see langword="true" />.</summary>
	/// <returns>The character string to use when indenting. This can be set to any string value. However, to ensure valid XML, you should specify only valid white space characters, such as space characters, tabs, carriage returns, or line feeds. The default is two spaces.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value assigned to the <see cref="P:System.Xml.XmlWriterSettings.IndentChars" /> is <see langword="null" />.</exception>
	public string IndentChars => null;

	/// <summary>Gets or sets a value indicating whether to write attributes on a new line.</summary>
	/// <returns>
	///     <see langword="true" /> to write attributes on individual lines; otherwise, <see langword="false" />. The default is <see langword="false" />.This setting has no effect when the <see cref="P:System.Xml.XmlWriterSettings.Indent" /> property value is <see langword="false" />.When <see cref="P:System.Xml.XmlWriterSettings.NewLineOnAttributes" /> is set to <see langword="true" />, each attribute is pre-pended with a new line and one extra level of indentation.</returns>
	public bool NewLineOnAttributes => false;

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Xml.XmlWriter" /> should also close the underlying stream or <see cref="T:System.IO.TextWriter" /> when the <see cref="M:System.Xml.XmlWriter.Close" /> method is called.</summary>
	/// <returns>
	///     <see langword="true" /> to also close the underlying stream or <see cref="T:System.IO.TextWriter" />; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool CloseOutput => false;

	/// <summary>Gets or sets the level of conformance that the XML writer checks the XML output for.</summary>
	/// <returns>One of the enumeration values that specifies the level of conformance (document, fragment, or automatic detection). The default is <see cref="F:System.Xml.ConformanceLevel.Document" />.</returns>
	public ConformanceLevel ConformanceLevel
	{
		get
		{
			return default(ConformanceLevel);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value that indicates whether the XML writer should check to ensure that all characters in the document conform to the "2.2 Characters" section of the W3C XML 1.0 Recommendation.</summary>
	/// <returns>
	///     <see langword="true" /> to do character checking; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	public bool CheckCharacters => false;

	/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Xml.XmlWriter" /> should remove duplicate namespace declarations when writing XML content. The default behavior is for the writer to output all namespace declarations that are present in the writer's namespace resolver.</summary>
	/// <returns>The <see cref="T:System.Xml.NamespaceHandling" /> enumeration used to specify whether to remove duplicate namespace declarations in the <see cref="T:System.Xml.XmlWriter" />.</returns>
	public NamespaceHandling NamespaceHandling
	{
		get
		{
			return default(NamespaceHandling);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Xml.XmlWriter" /> will add closing tags to all unclosed element tags when the <see cref="M:System.Xml.XmlWriter.Close" /> method is called.</summary>
	/// <returns>
	///     <see langword="true" /> if all unclosed element tags will be closed out; otherwise, <see langword="false" />. The default value is <see langword="true" />. </returns>
	public bool WriteEndDocumentOnClose => false;

	/// <summary>Gets the method used to serialize the <see cref="T:System.Xml.XmlWriter" /> output.</summary>
	/// <returns>One of the <see cref="T:System.Xml.XmlOutputMethod" /> values. The default is <see cref="F:System.Xml.XmlOutputMethod.Xml" />.</returns>
	public XmlOutputMethod OutputMethod
	{
		get
		{
			return default(XmlOutputMethod);
		}
		internal set
		{
		}
	}

	internal List<XmlQualifiedName> CDataSectionElements => null;

	/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Xml.XmlWriter" /> does not escape URI attributes.</summary>
	/// <returns>
	///     <see langword="true" /> if the <see cref="T:System.Xml.XmlWriter" /> do not escape URI attributes; otherwise, <see langword="false" />.</returns>
	public bool DoNotEscapeUriAttributes => false;

	internal bool MergeCDataSections => false;

	internal string MediaType => null;

	internal string DocTypeSystem => null;

	internal string DocTypePublic => null;

	internal XmlStandalone Standalone => default(XmlStandalone);

	internal bool AutoXmlDeclaration => false;

	internal TriState IndentInternal => default(TriState);

	internal bool IsQuerySpecific => false;

	internal bool ReadOnly
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlWriterSettings" /> class.</summary>
	public XmlWriterSettings()
	{
	}

	/// <summary>Creates a copy of the <see cref="T:System.Xml.XmlWriterSettings" /> instance.</summary>
	/// <returns>The cloned <see cref="T:System.Xml.XmlWriterSettings" /> object.</returns>
	public XmlWriterSettings Clone()
	{
		return null;
	}

	internal XmlWriter CreateWriter(Stream output)
	{
		return null;
	}

	internal XmlWriter CreateWriter(TextWriter output)
	{
		return null;
	}

	private void CheckReadOnly(string propertyName)
	{
	}

	private void Initialize()
	{
	}
}
