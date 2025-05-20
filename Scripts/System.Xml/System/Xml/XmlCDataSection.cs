using System.Xml.XPath;

namespace System.Xml;

/// <summary>Represents a CDATA section.</summary>
public class XmlCDataSection : XmlCharacterData
{
	/// <summary>Gets the qualified name of the node.</summary>
	/// <returns>For CDATA nodes, the name is <see langword="#cdata-section" />.</returns>
	public override string Name => null;

	/// <summary>Gets the local name of the node.</summary>
	/// <returns>For CDATA nodes, the local name is <see langword="#cdata-section" />.</returns>
	public override string LocalName => null;

	/// <summary>Gets the type of the current node.</summary>
	/// <returns>The node type. For CDATA nodes, the value is XmlNodeType.CDATA.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets the parent of this node (for nodes that can have parents).</summary>
	/// <returns>The <see langword="XmlNode" /> that is the parent of the current node. If a node has just been created and not yet added to the tree, or if it has been removed from the tree, the parent is <see langword="null" />. For all other nodes, the value returned depends on the <see cref="P:System.Xml.XmlNode.NodeType" /> of the node. The following table describes the possible return values for the <see langword="ParentNode" /> property.</returns>
	public override XmlNode ParentNode => null;

	internal override XPathNodeType XPNodeType => default(XPathNodeType);

	internal override bool IsText => false;

	/// <summary>Gets the text node that immediately precedes this node.</summary>
	/// <returns>Returns <see cref="T:System.Xml.XmlNode" />.</returns>
	public override XmlNode PreviousText => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlCDataSection" /> class.</summary>
	/// <param name="data">
	///       <see cref="T:System.String" /> that contains character data.</param>
	/// <param name="doc">
	///       <see cref="T:System.Xml.XmlDocument" /> object.</param>
	protected internal XmlCDataSection(string data, XmlDocument doc)
		: base(null, null)
	{
	}

	/// <summary>Creates a duplicate of this node.</summary>
	/// <param name="deep">
	///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. Because CDATA nodes do not have children, regardless of the parameter setting, the cloned node will always include the data content. </param>
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

	/// <summary>Saves the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public override void WriteContentTo(XmlWriter w)
	{
	}
}
