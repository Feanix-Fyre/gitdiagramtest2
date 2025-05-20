using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging;

/// <summary>Defines the out-of-band data for a call.</summary>
[Serializable]
[ComVisible(true)]
public class Header
{
	/// <summary>Indicates the XML namespace that the current <see cref="T:System.Runtime.Remoting.Messaging.Header" /> belongs to.</summary>
	public string HeaderNamespace;

	/// <summary>Indicates whether the receiving end must understand the out-of-band data.</summary>
	public bool MustUnderstand;

	/// <summary>Contains the name of the <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</summary>
	public string Name;

	/// <summary>Contains the value for the <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</summary>
	public object Value;
}
