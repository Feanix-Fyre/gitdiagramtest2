namespace System.Xml.Linq;

/// <summary>Represents an XML declaration.</summary>
public class XDeclaration
{
	private string _version;

	private string _encoding;

	private string _standalone;

	/// <summary>Gets or sets the encoding for this document.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the code page name for this document.</returns>
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

	/// <summary>Gets or sets the standalone property for this document.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the standalone property for this document.</returns>
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

	/// <summary>Gets or sets the version property for this document.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the version property for this document.</returns>
	public string Version => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XDeclaration" /> class with the specified version, encoding, and standalone status.</summary>
	/// <param name="version">The version of the XML, usually "1.0".</param>
	/// <param name="encoding">The encoding for the XML document.</param>
	/// <param name="standalone">A string containing "yes" or "no" that specifies whether the XML is standalone or requires external entities to be resolved.</param>
	public XDeclaration(string version, string encoding, string standalone)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XDeclaration" /> class from another <see cref="T:System.Xml.Linq.XDeclaration" /> object.</summary>
	/// <param name="other">The <see cref="T:System.Xml.Linq.XDeclaration" /> used to initialize this <see cref="T:System.Xml.Linq.XDeclaration" /> object.</param>
	public XDeclaration(XDeclaration other)
	{
	}

	/// <summary>Provides the declaration as a formatted string.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the formatted XML string.</returns>
	public override string ToString()
	{
		return null;
	}
}
