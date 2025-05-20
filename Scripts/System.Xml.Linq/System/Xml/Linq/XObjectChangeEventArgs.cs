namespace System.Xml.Linq;

/// <summary>Provides data for the <see cref="E:System.Xml.Linq.XObject.Changing" /> and <see cref="E:System.Xml.Linq.XObject.Changed" /> events.</summary>
public class XObjectChangeEventArgs : EventArgs
{
	private XObjectChange _objectChange;

	/// <summary>Event argument for an <see cref="F:System.Xml.Linq.XObjectChange.Add" /> change event.</summary>
	public static readonly XObjectChangeEventArgs Add;

	/// <summary>Event argument for a <see cref="F:System.Xml.Linq.XObjectChange.Remove" /> change event.</summary>
	public static readonly XObjectChangeEventArgs Remove;

	/// <summary>Event argument for a <see cref="F:System.Xml.Linq.XObjectChange.Name" /> change event.</summary>
	public static readonly XObjectChangeEventArgs Name;

	/// <summary>Event argument for a <see cref="F:System.Xml.Linq.XObjectChange.Value" /> change event.</summary>
	public static readonly XObjectChangeEventArgs Value;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XObjectChangeEventArgs" /> class.</summary>
	/// <param name="objectChange">An <see cref="T:System.Xml.Linq.XObjectChange" /> that contains the event arguments for LINQ to XML events.</param>
	public XObjectChangeEventArgs(XObjectChange objectChange)
	{
	}
}
