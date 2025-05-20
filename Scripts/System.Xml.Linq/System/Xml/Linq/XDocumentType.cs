namespace System.Xml.Linq;

/// <summary>Represents an XML Document Type Definition (DTD).</summary>
public class XDocumentType : XNode
{
	private string _name;

	private string _publicId;

	private string _systemId;

	private string _internalSubset;

	/// <summary>Gets or sets the internal subset for this Document Type Definition (DTD).</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the internal subset for this Document Type Definition (DTD).</returns>
	public string InternalSubset => null;

	/// <summary>Gets or sets the name for this Document Type Definition (DTD).</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the name for this Document Type Definition (DTD).</returns>
	public string Name => null;

	/// <summary>Gets the node type for this node.</summary>
	/// <returns>The node type. For <see cref="T:System.Xml.Linq.XDocumentType" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.DocumentType" />.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets or sets the public identifier for this Document Type Definition (DTD).</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the public identifier for this Document Type Definition (DTD).</returns>
	public string PublicId => null;

	/// <summary>Gets or sets the system identifier for this Document Type Definition (DTD).</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the system identifier for this Document Type Definition (DTD).</returns>
	public string SystemId => null;

	/// <summary>Initializes an instance of the <see cref="T:System.Xml.Linq.XDocumentType" /> class.</summary>
	/// <param name="name">A <see cref="T:System.String" /> that contains the qualified name of the DTD, which is the same as the qualified name of the root element of the XML document.</param>
	/// <param name="publicId">A <see cref="T:System.String" /> that contains the public identifier of an external public DTD.</param>
	/// <param name="systemId">A <see cref="T:System.String" /> that contains the system identifier of an external private DTD.</param>
	/// <param name="internalSubset">A <see cref="T:System.String" /> that contains the internal subset for an internal DTD.</param>
	public XDocumentType(string name, string publicId, string systemId, string internalSubset)
	{
	}

	/// <summary>Initializes an instance of the <see cref="T:System.Xml.Linq.XDocumentType" /> class from another <see cref="T:System.Xml.Linq.XDocumentType" /> object.</summary>
	/// <param name="other">An <see cref="T:System.Xml.Linq.XDocumentType" /> object to copy from.</param>
	public XDocumentType(XDocumentType other)
	{
	}

	/// <summary>Write this <see cref="T:System.Xml.Linq.XDocumentType" /> to an <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
	public override void WriteTo(XmlWriter writer)
	{
	}

	internal override XNode CloneNode()
	{
		return null;
	}
}
