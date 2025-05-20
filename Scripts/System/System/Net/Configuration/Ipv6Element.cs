using System.Configuration;

namespace System.Net.Configuration;

/// <summary>Determines whether Internet Protocol version 6 is enabled on the local computer. This class cannot be inherited.</summary>
public sealed class Ipv6Element : ConfigurationElement
{
	protected override ConfigurationPropertyCollection Properties => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.Ipv6Element" /> class.</summary>
	public Ipv6Element()
	{
	}
}
