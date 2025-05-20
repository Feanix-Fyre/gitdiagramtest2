using System.Xml.XPath;

namespace System.Xml;

/// <summary>Represents a lightweight object that is useful for tree insert operations.</summary>
public class XmlDocumentFragment : XmlNode
{
	private XmlLinkedNode lastChild;

	/// <summary>Gets the qualified name of the node.</summary>
	/// <returns>For <see langword="XmlDocumentFragment" />, the name is <see langword="#document-fragment" />.</returns>
	public override string Name => null;

	/// <summary>Gets the local name of the node.</summary>
	/// <returns>For <see langword="XmlDocumentFragment" /> nodes, the local name is <see langword="#document-fragment" />.</returns>
	public override string LocalName => null;

	/// <summary>Gets the type of the current node.</summary>
	/// <returns>For <see langword="XmlDocumentFragment" /> nodes, this value is XmlNodeType.DocumentFragment.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets the parent of this node (for nodes that can have parents).</summary>
	/// <returns>The parent of this node.For <see langword="XmlDocumentFragment" /> nodes, this property is always <see langword="null" />.</returns>
	public override XmlNode ParentNode => null;

	/// <summary>Gets the <see cref="T:System.Xml.XmlDocument" /> to which this node belongs.</summary>
	/// <returns>The <see langword="XmlDocument" /> to which this node belongs.</returns>
	public override XmlDocument OwnerDocument => null;

	/// <summary>Gets or sets the markup representing the children of this node.</summary>
	/// <returns>The markup of the children of this node.</returns>
	/// <exception cref="T:System.Xml.XmlException">The XML specified when setting this property is not well-formed. </exception>
	public override string InnerXml
	{
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

	internal override XPathNodeType XPNodeType => default(XPathNodeType);

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlDocumentFragment" /> class.</summary>
	/// <param name="ownerDocument">The XML document that is the source of the fragment.</param>
	protected internal XmlDocumentFragment(XmlDocument ownerDocument)
	{
	}

	/// <summary>Creates a duplicate of this node.</summary>
	/// <param name="deep">
	///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. </param>
	/// <returns>The cloned node.</returns>
	public override XmlNode CloneNode(bool deep)
	{
		return null;
	}

	internal override bool IsValidChildType(XmlNodeType type)
	{
		return false;
	}

	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
	{
		return false;
	}

	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild)
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
}
