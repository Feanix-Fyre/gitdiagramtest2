namespace System.Xml.Serialization;

/// <summary>Provides data for the <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownElement" /> event.</summary>
public class XmlElementEventArgs : EventArgs
{
	private object o;

	private XmlElement elem;

	private string qnames;

	private int lineNumber;

	private int linePosition;

	internal XmlElementEventArgs(XmlElement elem, int lineNumber, int linePosition, object o, string qnames)
	{
	}
}
