namespace System.Xml.Serialization;

/// <summary>Provides data for the known, but unreferenced, object found in an encoded SOAP XML stream during deserialization.</summary>
public class UnreferencedObjectEventArgs : EventArgs
{
	private object o;

	private string id;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.UnreferencedObjectEventArgs" /> class.</summary>
	/// <param name="o">The unreferenced object. </param>
	/// <param name="id">A unique string used to identify the unreferenced object. </param>
	public UnreferencedObjectEventArgs(object o, string id)
	{
	}
}
