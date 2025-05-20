namespace System.Xml.Serialization;

/// <summary>Provides data for the <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownAttribute" /> event.</summary>
public class XmlAttributeEventArgs : EventArgs
{
	private object o;

	private XmlAttribute attr;

	private string qnames;

	private int lineNumber;

	private int linePosition;

	internal XmlAttributeEventArgs(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames)
	{
	}
}
