namespace System.Xml.Linq;

/// <summary>Represents an XML processing instruction.</summary>
public class XProcessingInstruction : XNode
{
	internal string target;

	internal string data;

	/// <summary>Gets or sets the string value of this processing instruction.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the string value of this processing instruction.</returns>
	/// <exception cref="T:System.ArgumentNullException">The string <paramref name="value" /> is <see langword="null" />.</exception>
	public string Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the node type for this node.</summary>
	/// <returns>The node type. For <see cref="T:System.Xml.Linq.XProcessingInstruction" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.ProcessingInstruction" />.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets or sets a string containing the target application for this processing instruction.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the target application for this processing instruction.</returns>
	/// <exception cref="T:System.ArgumentNullException">The string <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="target" /> does not follow the constraints of an XML name.</exception>
	public string Target => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XProcessingInstruction" /> class.</summary>
	/// <param name="target">A <see cref="T:System.String" /> containing the target application for this <see cref="T:System.Xml.Linq.XProcessingInstruction" />.</param>
	/// <param name="data">The string data for this <see cref="T:System.Xml.Linq.XProcessingInstruction" />.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="target" /> or <paramref name="data" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="target" /> does not follow the constraints of an XML name.</exception>
	public XProcessingInstruction(string target, string data)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XProcessingInstruction" /> class.</summary>
	/// <param name="other">The <see cref="T:System.Xml.Linq.XProcessingInstruction" /> node to copy from.</param>
	public XProcessingInstruction(XProcessingInstruction other)
	{
	}

	/// <summary>Writes this processing instruction to an <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> to write this processing instruction to.</param>
	public override void WriteTo(XmlWriter writer)
	{
	}

	internal override XNode CloneNode()
	{
		return null;
	}

	private static void ValidateName(string name)
	{
	}
}
