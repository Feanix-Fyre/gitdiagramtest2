namespace System.Xml;

/// <summary>Represents an entity reference node.</summary>
public class XmlEntityReference : XmlLinkedNode
{
	private string name;

	private XmlLinkedNode lastChild;

	/// <summary>Gets the name of the node.</summary>
	/// <returns>The name of the entity referenced.</returns>
	public override string Name => null;

	/// <summary>Gets the local name of the node.</summary>
	/// <returns>For <see langword="XmlEntityReference" /> nodes, this property returns the name of the entity referenced.</returns>
	public override string LocalName => null;

	/// <summary>Gets or sets the value of the node.</summary>
	/// <returns>The value of the node. For <see langword="XmlEntityReference" /> nodes, this property returns <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">Node is read-only. </exception>
	/// <exception cref="T:System.InvalidOperationException">Setting the property. </exception>
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

	/// <summary>Gets the type of the node.</summary>
	/// <returns>The node type. For <see langword="XmlEntityReference" /> nodes, the value is XmlNodeType.EntityReference.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets a value indicating whether the node is read-only.</summary>
	/// <returns>
	///     <see langword="true" /> if the node is read-only; otherwise <see langword="false" />.Because <see langword="XmlEntityReference" /> nodes are read-only, this property always returns <see langword="true" />.</returns>
	public override bool IsReadOnly => false;

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

	/// <summary>Gets the base Uniform Resource Identifier (URI) of the current node.</summary>
	/// <returns>The location from which the node was loaded.</returns>
	public override string BaseURI => null;

	internal string ChildBaseURI => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlEntityReference" /> class.</summary>
	/// <param name="name">The name of the entity reference; see the <see cref="P:System.Xml.XmlEntityReference.Name" /> property.</param>
	/// <param name="doc">The parent XML document.</param>
	protected internal XmlEntityReference(string name, XmlDocument doc)
		: base(null)
	{
	}

	/// <summary>Creates a duplicate of this node.</summary>
	/// <param name="deep">
	///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. For <see langword="XmlEntityReference" /> nodes, this method always returns an entity reference node with no children. The replacement text is set when the node is inserted into a parent. </param>
	/// <returns>The cloned node.</returns>
	public override XmlNode CloneNode(bool deep)
	{
		return null;
	}

	internal override void SetParent(XmlNode node)
	{
	}

	internal override void SetParentForLoad(XmlNode node)
	{
	}

	internal override bool IsValidChildType(XmlNodeType type)
	{
		return false;
	}

	/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public override void WriteTo(XmlWriter w)
	{
	}

	/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public override void WriteContentTo(XmlWriter w)
	{
	}

	private string ConstructBaseURI(string baseURI, string systemId)
	{
		return null;
	}
}
