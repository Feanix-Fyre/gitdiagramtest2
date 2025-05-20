namespace System.Xml;

internal class XmlUnspecifiedAttribute : XmlAttribute
{
	private bool fSpecified;

	public override bool Specified => false;

	public override string InnerText
	{
		set
		{
		}
	}

	protected internal XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc)
		: base(null, null)
	{
	}

	public override XmlNode CloneNode(bool deep)
	{
		return null;
	}

	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild)
	{
		return null;
	}

	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild)
	{
		return null;
	}

	public override XmlNode RemoveChild(XmlNode oldChild)
	{
		return null;
	}

	public override XmlNode AppendChild(XmlNode newChild)
	{
		return null;
	}

	public override void WriteTo(XmlWriter w)
	{
	}

	internal void SetSpecified(bool f)
	{
	}
}
