using System.Text;

namespace System.Xml.Linq;

/// <summary>Represents a text node.</summary>
public class XText : XNode
{
	internal string text;

	/// <summary>Gets the node type for this node.</summary>
	/// <returns>The node type. For <see cref="T:System.Xml.Linq.XText" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.Text" />.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets or sets the value of this node.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the value of this node.</returns>
	public string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XText" /> class.</summary>
	/// <param name="value">The <see cref="T:System.String" /> that contains the value of the <see cref="T:System.Xml.Linq.XText" /> node.</param>
	public XText(string value)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XText" /> class from another <see cref="T:System.Xml.Linq.XText" /> object.</summary>
	/// <param name="other">The <see cref="T:System.Xml.Linq.XText" /> node to copy from.</param>
	public XText(XText other)
	{
	}

	/// <summary>Writes this node to an <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
	public override void WriteTo(XmlWriter writer)
	{
	}

	internal override void AppendText(StringBuilder sb)
	{
	}

	internal override XNode CloneNode()
	{
		return null;
	}
}
