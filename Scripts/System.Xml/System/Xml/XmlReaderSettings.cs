using System.IO;
using System.Xml.Schema;

namespace System.Xml;

/// <summary>Specifies a set of features to support on the <see cref="T:System.Xml.XmlReader" /> object created by the <see cref="Overload:System.Xml.XmlReader.Create" /> method. </summary>
public sealed class XmlReaderSettings
{
	private bool useAsync;

	private XmlNameTable nameTable;

	private XmlResolver xmlResolver;

	private int lineNumberOffset;

	private int linePositionOffset;

	private ConformanceLevel conformanceLevel;

	private bool checkCharacters;

	private long maxCharactersInDocument;

	private long maxCharactersFromEntities;

	private bool ignoreWhitespace;

	private bool ignorePIs;

	private bool ignoreComments;

	private DtdProcessing dtdProcessing;

	private ValidationType validationType;

	private XmlSchemaValidationFlags validationFlags;

	private XmlSchemaSet schemas;

	private ValidationEventHandler valEventHandler;

	private bool closeInput;

	private bool isReadOnly;

	private static bool? s_enableLegacyXmlSettings;

	/// <summary>Gets or sets whether asynchronous <see cref="T:System.Xml.XmlReader" /> methods can be used on a particular <see cref="T:System.Xml.XmlReader" /> instance.</summary>
	/// <returns>
	///     <see langword="true" /> if asynchronous methods can be used; otherwise, <see langword="false" />.</returns>
	public bool Async
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Xml.XmlNameTable" /> used for atomized string comparisons.</summary>
	/// <returns>The <see cref="T:System.Xml.XmlNameTable" /> that stores all the atomized strings used by all <see cref="T:System.Xml.XmlReader" /> instances created using this <see cref="T:System.Xml.XmlReaderSettings" /> object.The default is <see langword="null" />. The created <see cref="T:System.Xml.XmlReader" /> instance will use a new empty <see cref="T:System.Xml.NameTable" /> if this value is <see langword="null" />.</returns>
	public XmlNameTable NameTable
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool IsXmlResolverSet { get; set; }

	/// <summary>Sets the <see cref="T:System.Xml.XmlResolver" /> used to access external documents.</summary>
	/// <returns>An <see cref="T:System.Xml.XmlResolver" /> used to access external documents. If set to <see langword="null" />, an <see cref="T:System.Xml.XmlException" /> is thrown when the <see cref="T:System.Xml.XmlReader" /> tries to access an external resource. The default is a new <see cref="T:System.Xml.XmlUrlResolver" /> with no credentials.  Starting with the .NET Framework 4.5.2, this setting has a default value of <see langword="null" />.</returns>
	public XmlResolver XmlResolver
	{
		set
		{
		}
	}

	/// <summary>Gets or sets line number offset of the <see cref="T:System.Xml.XmlReader" /> object.</summary>
	/// <returns>The line number offset. The default is 0.</returns>
	public int LineNumberOffset
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets line position offset of the <see cref="T:System.Xml.XmlReader" /> object.</summary>
	/// <returns>The line position offset. The default is 0.</returns>
	public int LinePositionOffset
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the level of conformance which the <see cref="T:System.Xml.XmlReader" /> will comply.</summary>
	/// <returns>One of the enumeration values that specifies the level of conformance that the XML reader will enforce. The default is <see cref="F:System.Xml.ConformanceLevel.Document" />.</returns>
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

	/// <summary>Gets or sets a value indicating whether to do character checking.</summary>
	/// <returns>
	///     <see langword="true" /> to do character checking; otherwise <see langword="false" />. The default is <see langword="true" />.If the <see cref="T:System.Xml.XmlReader" /> is processing text data, it always checks that the XML names and text content are valid, regardless of the property setting. Setting <see cref="P:System.Xml.XmlReaderSettings.CheckCharacters" /> to <see langword="false" /> turns off character checking for character entity references.</returns>
	public bool CheckCharacters
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating the maximum allowable number of characters in an XML document. A zero (0) value means no limits on the size of the XML document. A non-zero value specifies the maximum size, in characters.</summary>
	/// <returns>The maximum allowable number of characters in an XML document. The default is 0.</returns>
	public long MaxCharactersInDocument
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating the maximum allowable number of characters in a document that result from expanding entities.</summary>
	/// <returns>The maximum allowable number of characters from expanded entities. The default is 0.</returns>
	public long MaxCharactersFromEntities
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether to ignore insignificant white space.</summary>
	/// <returns>
	///     <see langword="true" /> to ignore white space; otherwise <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool IgnoreWhitespace
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether to ignore processing instructions.</summary>
	/// <returns>
	///     <see langword="true" /> to ignore processing instructions; otherwise <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool IgnoreProcessingInstructions
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether to ignore comments.</summary>
	/// <returns>
	///     <see langword="true" /> to ignore comments; otherwise <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool IgnoreComments
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value that determines the processing of DTDs.</summary>
	/// <returns>One of the enumeration values that determines the processing of DTDs. The default is <see cref="F:System.Xml.DtdProcessing.Prohibit" />.</returns>
	public DtdProcessing DtdProcessing
	{
		get
		{
			return default(DtdProcessing);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the underlying stream or <see cref="T:System.IO.TextReader" /> should be closed when the reader is closed.</summary>
	/// <returns>
	///     <see langword="true" /> to close the underlying stream or <see cref="T:System.IO.TextReader" /> when the reader is closed; otherwise <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool CloseInput
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Xml.XmlReader" /> will perform validation or type assignment when reading.</summary>
	/// <returns>One of the <see cref="T:System.Xml.ValidationType" /> values that indicates whether XmlReader will perform validation or type assignment when reading. The default is <see langword="ValidationType.None" />.</returns>
	public ValidationType ValidationType
	{
		get
		{
			return default(ValidationType);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating the schema validation settings. This setting applies to <see cref="T:System.Xml.XmlReader" /> objects that validate schemas (<see cref="P:System.Xml.XmlReaderSettings.ValidationType" /> property set to <see langword="ValidationType.Schema" />).</summary>
	/// <returns>A bitwise combination of enumeration values that specify validation options. <see cref="F:System.Xml.Schema.XmlSchemaValidationFlags.ProcessIdentityConstraints" /> and <see cref="F:System.Xml.Schema.XmlSchemaValidationFlags.AllowXmlAttributes" /> are enabled by default. <see cref="F:System.Xml.Schema.XmlSchemaValidationFlags.ProcessInlineSchema" />, <see cref="F:System.Xml.Schema.XmlSchemaValidationFlags.ProcessSchemaLocation" />, and <see cref="F:System.Xml.Schema.XmlSchemaValidationFlags.ReportValidationWarnings" /> are disabled by default.</returns>
	public XmlSchemaValidationFlags ValidationFlags
	{
		get
		{
			return default(XmlSchemaValidationFlags);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> to use when performing schema validation.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaSet" /> to use when performing schema validation. The default is an empty <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object.</returns>
	public XmlSchemaSet Schemas
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool ReadOnly
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlReaderSettings" /> class.</summary>
	public XmlReaderSettings()
	{
	}

	internal XmlResolver GetXmlResolver()
	{
		return null;
	}

	internal XmlResolver GetXmlResolver_CheckConfig()
	{
		return null;
	}

	/// <summary>Creates a copy of the <see cref="T:System.Xml.XmlReaderSettings" /> instance.</summary>
	/// <returns>The cloned <see cref="T:System.Xml.XmlReaderSettings" /> object.</returns>
	public XmlReaderSettings Clone()
	{
		return null;
	}

	internal ValidationEventHandler GetEventHandler()
	{
		return null;
	}

	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext)
	{
		return null;
	}

	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext)
	{
		return null;
	}

	private void CheckReadOnly(string propertyName)
	{
	}

	private void Initialize()
	{
	}

	private void Initialize(XmlResolver resolver)
	{
	}

	private static XmlResolver CreateDefaultResolver()
	{
		return null;
	}

	internal XmlReader AddValidation(XmlReader reader)
	{
		return null;
	}

	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader)
	{
		return null;
	}

	internal static bool EnableLegacyXmlSettings()
	{
		return false;
	}
}
