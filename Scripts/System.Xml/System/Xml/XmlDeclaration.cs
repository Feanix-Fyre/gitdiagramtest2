namespace System.Xml;

/// <summary>Represents the XML declaration node &lt;?xml version='1.0'...?&gt;.</summary>
public class XmlDeclaration : XmlLinkedNode
{
	private string version;

	private string encoding;

	private string standalone;

	/// <summary>Gets the XML version of the document.</summary>
	/// <returns>The value is always <see langword="1.0" />.</returns>
	public string Version
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	/// <summary>Gets or sets the encoding level of the XML document.</summary>
	/// <returns>The valid character encoding name. The most commonly supported character encoding names for XML are the following: Category Encoding Names Unicode UTF-8, UTF-16 ISO 10646 ISO-10646-UCS-2, ISO-10646-UCS-4 ISO 8859 ISO-8859-n (where "n" is a digit from 1 to 9) JIS X-0208-1997 ISO-2022-JP, Shift_JIS, EUC-JP This value is optional. If a value is not set, this property returns String.Empty.If an encoding attribute is not included, UTF-8 encoding is assumed when the document is written or saved out.</returns>
	public string Encoding
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the value of the standalone attribute.</summary>
	/// <returns>Valid values are <see langword="yes" /> if all entity declarations required by the XML document are contained within the document or <see langword="no" /> if an external document type definition (DTD) is required. If a standalone attribute is not present in the XML declaration, this property returns String.Empty.</returns>
	public string Standalone
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the value of the <see langword="XmlDeclaration" />.</summary>
	/// <returns>The contents of the <see langword="XmlDeclaration" /> (that is, everything between &lt;?xml and ?&gt;).</returns>
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

	/// <summary>Gets or sets the concatenated values of the <see langword="XmlDeclaration" />.</summary>
	/// <returns>The concatenated values of the <see langword="XmlDeclaration" /> (that is, everything between &lt;?xml and ?&gt;).</returns>
	public override string InnerText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the qualified name of the node.</summary>
	/// <returns>For <see langword="XmlDeclaration" /> nodes, the name is <see langword="xml" />.</returns>
	public override string Name => null;

	/// <summary>Gets the local name of the node.</summary>
	/// <returns>For <see langword="XmlDeclaration" /> nodes, the local name is <see langword="xml" />.</returns>
	public override string LocalName => null;

	/// <summary>Gets the type of the current node.</summary>
	/// <returns>For <see langword="XmlDeclaration" /> nodes, this value is XmlNodeType.XmlDeclaration.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlDeclaration" /> class.</summary>
	/// <param name="version">The XML version; see the <see cref="P:System.Xml.XmlDeclaration.Version" /> property.</param>
	/// <param name="encoding">The encoding scheme; see the <see cref="P:System.Xml.XmlDeclaration.Encoding" /> property.</param>
	/// <param name="standalone">Indicates whether the XML document depends on an external DTD; see the <see cref="P:System.Xml.XmlDeclaration.Standalone" /> property.</param>
	/// <param name="doc">The parent XML document.</param>
	protected internal XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc)
		: base(null)
	{
	}

	/// <summary>Creates a duplicate of this node.</summary>
	/// <param name="deep">
	///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. Because <see langword="XmlDeclaration" /> nodes do not have children, the cloned node always includes the data value, regardless of the parameter setting. </param>
	/// <returns>The cloned node.</returns>
	public override XmlNode CloneNode(bool deep)
	{
		return null;
	}

	/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public override void WriteTo(XmlWriter w)
	{
	}

	/// <summary>Saves the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />. Because <see langword="XmlDeclaration" /> nodes do not have children, this method has no effect.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public override void WriteContentTo(XmlWriter w)
	{
	}

	private bool IsValidXmlVersion(string ver)
	{
		return false;
	}
}
