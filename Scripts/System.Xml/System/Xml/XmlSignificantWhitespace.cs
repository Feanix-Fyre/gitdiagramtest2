using System.Xml.XPath;

namespace System.Xml;

/// <summary>Represents white space between markup in a mixed content node or white space within an xml:space= 'preserve' scope. This is also referred to as significant white space.</summary>
public class XmlSignificantWhitespace : XmlCharacterData
{
	/// <summary>Gets the qualified name of the node.</summary>
	/// <returns>For <see langword="XmlSignificantWhitespace" /> nodes, this property returns <see langword="#significant-whitespace" />.</returns>
	public override string Name => null;

	/// <summary>Gets the local name of the node.</summary>
	/// <returns>For <see langword="XmlSignificantWhitespace" /> nodes, this property returns <see langword="#significant-whitespace" />.</returns>
	public override string LocalName => null;

	/// <summary>Gets the type of the current node.</summary>
	/// <returns>For <see langword="XmlSignificantWhitespace" /> nodes, this value is XmlNodeType.SignificantWhitespace.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets the parent of the current node.</summary>
	/// <returns>The <see cref="T:System.Xml.XmlNode" /> parent node of the current node.</returns>
	public override XmlNode ParentNode => null;

	/// <summary>Gets or sets the value of the node.</summary>
	/// <returns>The white space characters found in the node.</returns>
	/// <exception cref="T:System.ArgumentException">Setting <see langword="Value" /> to invalid white space characters. </exception>
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

	internal override XPathNodeType XPNodeType => default(XPathNodeType);

	internal override bool IsText => false;

	/// <summary>Gets the text node that immediately precedes this node.</summary>
	/// <returns>Returns <see cref="T:System.Xml.XmlNode" />.</returns>
	public override XmlNode PreviousText => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlSignificantWhitespace" /> class.</summary>
	/// <param name="strData">The white space characters of the node.</param>
	/// <param name="doc">The <see cref="T:System.Xml.XmlDocument" /> object.</param>
	protected internal XmlSignificantWhitespace(string strData, XmlDocument doc)
		: base(null, null)
	{
	}

	/// <summary>Creates a duplicate of this node.</summary>
	/// <param name="deep">
	///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. For significant white space nodes, the cloned node always includes the data value, regardless of the parameter setting. </param>
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

	/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
	public override void WriteContentTo(XmlWriter w)
	{
	}
}
