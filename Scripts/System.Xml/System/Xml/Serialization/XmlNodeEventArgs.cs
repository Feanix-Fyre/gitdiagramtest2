namespace System.Xml.Serialization;

/// <summary>Provides data for the <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> event.</summary>
public class XmlNodeEventArgs : EventArgs
{
	private object o;

	private XmlNode xmlNode;

	private int lineNumber;

	private int linePosition;

	internal XmlNodeEventArgs(XmlNode xmlNode, int lineNumber, int linePosition, object o)
	{
	}
}
