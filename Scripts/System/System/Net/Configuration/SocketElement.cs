using System.Configuration;

namespace System.Net.Configuration;

/// <summary>Represents information used to configure <see cref="T:System.Net.Sockets.Socket" /> objects. This class cannot be inherited.</summary>
public sealed class SocketElement : ConfigurationElement
{
	protected override ConfigurationPropertyCollection Properties => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.SocketElement" /> class.</summary>
	public SocketElement()
	{
	}
}
