namespace System.Xml;

/// <summary>Represents an entity declaration, such as &lt;!ENTITY... &gt;.</summary>
public class XmlEntity : XmlNode
{
	private string publicId;

	private string systemId;

	private string notationName;

	private string name;

	private string unparsedReplacementStr;

	private string baseURI;

	private XmlLinkedNode lastChild;

	private bool childrenFoliating;

	/// <summary>Gets a value indicating whether the node is read-only.</summary>
	/// <returns>
	///     <see langword="true" /> if the node is read-only; otherwise <see langword="false" />.Because <see langword="XmlEntity" /> nodes are read-only, this property always returns <see langword="true" />.</returns>
	public override bool IsReadOnly => false;

	/// <summary>Gets the name of the node.</summary>
	/// <returns>The name of the entity.</returns>
	public override string Name => null;

	/// <summary>Gets the name of the node without the namespace prefix.</summary>
	/// <returns>For <see langword="XmlEntity" /> nodes, this property returns the name of the entity.</returns>
	public override string LocalName => null;

	/// <summary>Gets the concatenated values of the entity node and all its children.</summary>
	/// <returns>The concatenated values of the node and all its children.</returns>
	/// <exception cref="T:System.InvalidOperationException">Attempting to set the property. </exception>
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

	internal override bool IsContainer => false;

	internal override XmlLinkedNode LastNode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the type of the node.</summary>
	/// <returns>The node type. For <see langword="XmlEntity" /> nodes, the value is XmlNodeType.Entity.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets the value of the system identifier on the entity declaration.</summary>
	/// <returns>The system identifier on the entity. If there is no system identifier, <see langword="null" /> is returned.</returns>
	public string SystemId => null;

	/// <summary>Gets the markup representing the children of this node.</summary>
	/// <returns>For <see langword="XmlEntity" /> nodes, String.Empty is returned.</returns>
	/// <exception cref="T:System.InvalidOperationException">Attempting to set the property. </exception>
	public override string InnerXml
	{
		set
		{
		}
	}

	/// <summary>Gets the base Uniform Resource Identifier (URI) of the current node.</summary>
	/// <returns>The location from which the node was loaded.</returns>
	public override string BaseURI => null;

	internal XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc)
	{
	}

	/// <summary>Creates a duplicate of this node. Entity nodes cannot be cloned. Calling this method on an <see cref="T:System.Xml.XmlEntity" /> object throws an exception.</summary>
	/// <param name="deep">
	///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself.</param>
	/// <returns>Returns a copy of the <see cref="T:System.Xml.XmlNode" /> from which the method is called.</returns>
	/// <exception cref="T:System.InvalidOperationException">Entity nodes cannot be cloned. Calling this method on an <see cref="T:System.Xml.XmlEntity" /> object throws an exception.</exception>
	public override XmlNode CloneNode(bool deep)
	{
		return null;
	}

	internal override bool IsValidChildType(XmlNodeType type)
	{
		return false;
	}

	/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />. For <see langword="XmlEntity" /> nodes, this method has no effect.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public override void WriteTo(XmlWriter w)
	{
	}

	/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />. For <see langword="XmlEntity" /> nodes, this method has no effect.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public override void WriteContentTo(XmlWriter w)
	{
	}

	internal void SetBaseURI(string inBaseURI)
	{
	}
}
