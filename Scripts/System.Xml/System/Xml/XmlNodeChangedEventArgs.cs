namespace System.Xml;

/// <summary>Provides data for the <see cref="E:System.Xml.XmlDocument.NodeChanged" />, <see cref="E:System.Xml.XmlDocument.NodeChanging" />, <see cref="E:System.Xml.XmlDocument.NodeInserted" />, <see cref="E:System.Xml.XmlDocument.NodeInserting" />, <see cref="E:System.Xml.XmlDocument.NodeRemoved" /> and <see cref="E:System.Xml.XmlDocument.NodeRemoving" /> events.</summary>
public class XmlNodeChangedEventArgs : EventArgs
{
	private XmlNodeChangedAction action;

	private XmlNode node;

	private XmlNode oldParent;

	private XmlNode newParent;

	private string oldValue;

	private string newValue;

	/// <summary>Gets a value indicating what type of node change event is occurring.</summary>
	/// <returns>An <see langword="XmlNodeChangedAction" /> value describing the node change event.XmlNodeChangedAction Value Description Insert A node has been or will be inserted. Remove A node has been or will be removed. Change A node has been or will be changed. The <see langword="Action" /> value does not differentiate between when the event occurred (before or after). You can create separate event handlers to handle both instances.</returns>
	public XmlNodeChangedAction Action => default(XmlNodeChangedAction);

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlNodeChangedEventArgs" /> class.</summary>
	/// <param name="node">The <see cref="T:System.Xml.XmlNode" /> that generated the event.</param>
	/// <param name="oldParent">The old parent <see cref="T:System.Xml.XmlNode" /> of the <see cref="T:System.Xml.XmlNode" /> that generated the event.</param>
	/// <param name="newParent">The new parent <see cref="T:System.Xml.XmlNode" /> of the <see cref="T:System.Xml.XmlNode" /> that generated the event.</param>
	/// <param name="oldValue">The old value of the <see cref="T:System.Xml.XmlNode" /> that generated the event.</param>
	/// <param name="newValue">The new value of the <see cref="T:System.Xml.XmlNode" /> that generated the event.</param>
	/// <param name="action">The <see cref="T:System.Xml.XmlNodeChangedAction" />.</param>
	public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
	{
	}
}
