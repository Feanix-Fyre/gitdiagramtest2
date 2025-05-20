namespace System.Xml;

/// <summary>Defines the context for a set of <see cref="T:System.Xml.XmlDocument" /> objects.</summary>
public class XmlImplementation
{
	private XmlNameTable nameTable;

	internal XmlNameTable NameTable => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlImplementation" /> class.</summary>
	public XmlImplementation()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlImplementation" /> class with the <see cref="T:System.Xml.XmlNameTable" /> specified.</summary>
	/// <param name="nt">An <see cref="T:System.Xml.XmlNameTable" /> object.</param>
	public XmlImplementation(XmlNameTable nt)
	{
	}

	/// <summary>Creates a new <see cref="T:System.Xml.XmlDocument" />.</summary>
	/// <returns>The new <see langword="XmlDocument" /> object.</returns>
	public virtual XmlDocument CreateDocument()
	{
		return null;
	}
}
