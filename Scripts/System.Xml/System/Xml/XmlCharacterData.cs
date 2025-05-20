using System.Xml.XPath;

namespace System.Xml;

/// <summary>Provides text manipulation methods that are used by several classes.</summary>
public abstract class XmlCharacterData : XmlLinkedNode
{
	private string data;

	/// <summary>Gets or sets the value of the node.</summary>
	/// <returns>The value of the node.</returns>
	/// <exception cref="T:System.ArgumentException">Node is read-only. </exception>
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

	/// <summary>Gets or sets the concatenated values of the node and all the children of the node.</summary>
	/// <returns>The concatenated values of the node and all the children of the node.</returns>
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

	/// <summary>Contains the data of the node.</summary>
	/// <returns>The data of the node.</returns>
	public virtual string Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlCharacterData" /> class.</summary>
	/// <param name="data">String that contains character data to be added to document.</param>
	/// <param name="doc">
	///       <see cref="T:System.Xml.XmlDocument" /> to contain character data.</param>
	protected internal XmlCharacterData(string data, XmlDocument doc)
		: base(null)
	{
	}

	internal bool CheckOnData(string data)
	{
		return false;
	}

	internal bool DecideXPNodeTypeForTextNodes(XmlNode node, ref XPathNodeType xnt)
	{
		return false;
	}
}
