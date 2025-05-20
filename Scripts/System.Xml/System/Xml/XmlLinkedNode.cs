namespace System.Xml;

/// <summary>Gets the node immediately preceding or following this node.</summary>
public abstract class XmlLinkedNode : XmlNode
{
	internal XmlLinkedNode next;

	/// <summary>Gets the node immediately preceding this node.</summary>
	/// <returns>The preceding <see cref="T:System.Xml.XmlNode" /> or <see langword="null" /> if one does not exist.</returns>
	public override XmlNode PreviousSibling => null;

	/// <summary>Gets the node immediately following this node.</summary>
	/// <returns>The <see cref="T:System.Xml.XmlNode" /> immediately following this node or <see langword="null" /> if one does not exist.</returns>
	public override XmlNode NextSibling => null;

	internal XmlLinkedNode(XmlDocument doc)
	{
	}
}
