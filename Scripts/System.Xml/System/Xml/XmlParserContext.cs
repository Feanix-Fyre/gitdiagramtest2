using System.Text;

namespace System.Xml;

/// <summary>Provides all the context information required by the <see cref="T:System.Xml.XmlReader" /> to parse an XML fragment.</summary>
public class XmlParserContext
{
	private XmlNameTable _nt;

	private XmlNamespaceManager _nsMgr;

	private string _docTypeName;

	private string _pubId;

	private string _sysId;

	private string _internalSubset;

	private string _xmlLang;

	private XmlSpace _xmlSpace;

	private string _baseURI;

	private Encoding _encoding;

	/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> used to atomize strings. For more information on atomized strings, see <see cref="T:System.Xml.XmlNameTable" />.</summary>
	/// <returns>The <see langword="XmlNameTable" />.</returns>
	public XmlNameTable NameTable => null;

	/// <summary>Gets or sets the <see cref="T:System.Xml.XmlNamespaceManager" />.</summary>
	/// <returns>The <see langword="XmlNamespaceManager" />.</returns>
	public XmlNamespaceManager NamespaceManager => null;

	/// <summary>Gets or sets the name of the document type declaration.</summary>
	/// <returns>The name of the document type declaration.</returns>
	public string DocTypeName => null;

	/// <summary>Gets or sets the public identifier.</summary>
	/// <returns>The public identifier.</returns>
	public string PublicId => null;

	/// <summary>Gets or sets the system identifier.</summary>
	/// <returns>The system identifier.</returns>
	public string SystemId => null;

	/// <summary>Gets or sets the base URI.</summary>
	/// <returns>The base URI to use to resolve the DTD file.</returns>
	public string BaseURI => null;

	/// <summary>Gets or sets the internal DTD subset.</summary>
	/// <returns>The internal DTD subset. For example, this property returns everything between the square brackets &lt;!DOCTYPE doc [...]&gt;.</returns>
	public string InternalSubset => null;

	/// <summary>Gets or sets the current <see langword="xml:lang" /> scope.</summary>
	/// <returns>The current <see langword="xml:lang" /> scope. If there is no <see langword="xml:lang" /> in scope, <see langword="String.Empty" /> is returned.</returns>
	public string XmlLang => null;

	/// <summary>Gets or sets the current <see langword="xml:space" /> scope.</summary>
	/// <returns>An <see cref="T:System.Xml.XmlSpace" /> value indicating the <see langword="xml:space" /> scope.</returns>
	public XmlSpace XmlSpace => default(XmlSpace);

	/// <summary>Gets or sets the encoding type.</summary>
	/// <returns>An <see cref="T:System.Text.Encoding" /> object indicating the encoding type.</returns>
	public Encoding Encoding => null;

	internal bool HasDtdInfo => false;

	/// <summary>Initializes a new instance of the <see langword="XmlParserContext" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />, <see cref="T:System.Xml.XmlNamespaceManager" />, <see langword="xml:lang" />, and <see langword="xml:space" /> values.</summary>
	/// <param name="nt">The <see cref="T:System.Xml.XmlNameTable" /> to use to atomize strings. If this is <see langword="null" />, the name table used to construct the <paramref name="nsMgr" /> is used instead. For more information about atomized strings, see <see cref="T:System.Xml.XmlNameTable" />. </param>
	/// <param name="nsMgr">The <see cref="T:System.Xml.XmlNamespaceManager" /> to use for looking up namespace information, or <see langword="null" />. </param>
	/// <param name="xmlLang">The <see langword="xml:lang" /> scope. </param>
	/// <param name="xmlSpace">An <see cref="T:System.Xml.XmlSpace" /> value indicating the <see langword="xml:space" /> scope. </param>
	/// <exception cref="T:System.Xml.XmlException">
	///         <paramref name="nt" /> is not the same <see langword="XmlNameTable" /> used to construct <paramref name="nsMgr" />. </exception>
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace)
	{
	}

	/// <summary>Initializes a new instance of the <see langword="XmlParserContext" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />, <see cref="T:System.Xml.XmlNamespaceManager" />, base URI, <see langword="xml:lang" />, <see langword="xml:space" />, and document type values.</summary>
	/// <param name="nt">The <see cref="T:System.Xml.XmlNameTable" /> to use to atomize strings. If this is <see langword="null" />, the name table used to construct the <paramref name="nsMgr" /> is used instead. For more information about atomized strings, see <see cref="T:System.Xml.XmlNameTable" />. </param>
	/// <param name="nsMgr">The <see cref="T:System.Xml.XmlNamespaceManager" /> to use for looking up namespace information, or <see langword="null" />. </param>
	/// <param name="docTypeName">The name of the document type declaration. </param>
	/// <param name="pubId">The public identifier. </param>
	/// <param name="sysId">The system identifier. </param>
	/// <param name="internalSubset">The internal DTD subset. The DTD subset is used for entity resolution, not for document validation.</param>
	/// <param name="baseURI">The base URI for the XML fragment (the location from which the fragment was loaded). </param>
	/// <param name="xmlLang">The <see langword="xml:lang" /> scope. </param>
	/// <param name="xmlSpace">An <see cref="T:System.Xml.XmlSpace" /> value indicating the <see langword="xml:space" /> scope. </param>
	/// <exception cref="T:System.Xml.XmlException">
	///         <paramref name="nt" /> is not the same <see langword="XmlNameTable" /> used to construct <paramref name="nsMgr" />. </exception>
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace)
	{
	}

	/// <summary>Initializes a new instance of the <see langword="XmlParserContext" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />, <see cref="T:System.Xml.XmlNamespaceManager" />, base URI, <see langword="xml:lang" />, <see langword="xml:space" />, encoding, and document type values.</summary>
	/// <param name="nt">The <see cref="T:System.Xml.XmlNameTable" /> to use to atomize strings. If this is <see langword="null" />, the name table used to construct the <paramref name="nsMgr" /> is used instead. For more information about atomized strings, see <see cref="T:System.Xml.XmlNameTable" />. </param>
	/// <param name="nsMgr">The <see cref="T:System.Xml.XmlNamespaceManager" /> to use for looking up namespace information, or <see langword="null" />. </param>
	/// <param name="docTypeName">The name of the document type declaration. </param>
	/// <param name="pubId">The public identifier. </param>
	/// <param name="sysId">The system identifier. </param>
	/// <param name="internalSubset">The internal DTD subset. The DTD is used for entity resolution, not for document validation.</param>
	/// <param name="baseURI">The base URI for the XML fragment (the location from which the fragment was loaded). </param>
	/// <param name="xmlLang">The <see langword="xml:lang" /> scope. </param>
	/// <param name="xmlSpace">An <see cref="T:System.Xml.XmlSpace" /> value indicating the <see langword="xml:space" /> scope. </param>
	/// <param name="enc">An <see cref="T:System.Text.Encoding" /> object indicating the encoding setting. </param>
	/// <exception cref="T:System.Xml.XmlException">
	///         <paramref name="nt" /> is not the same <see langword="XmlNameTable" /> used to construct <paramref name="nsMgr" />. </exception>
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc)
	{
	}
}
