using System.Text;

namespace System.Xml.Linq;

/// <summary>Represents the abstract concept of a node (element, comment, document type, processing instruction, or text node) in the XML tree.</summary>
public abstract class XNode : XObject
{
	internal XNode next;

	internal XNode()
	{
	}

	/// <summary>Removes this node from its parent.</summary>
	/// <exception cref="T:System.InvalidOperationException">The parent is <see langword="null" />.</exception>
	public void Remove()
	{
	}

	/// <summary>Returns the indented XML for this node.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the indented XML.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Writes this node to an <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
	public abstract void WriteTo(XmlWriter writer);

	internal virtual void AppendText(StringBuilder sb)
	{
	}

	internal abstract XNode CloneNode();

	private string GetXmlString(SaveOptions o)
	{
		return null;
	}
}
