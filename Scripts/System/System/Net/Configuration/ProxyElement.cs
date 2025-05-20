using System.Configuration;

namespace System.Net.Configuration;

/// <summary>Identifies the configuration settings for Web proxy server. This class cannot be inherited.</summary>
public sealed class ProxyElement : ConfigurationElement
{
	protected override ConfigurationPropertyCollection Properties => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ProxyElement" /> class.</summary>
	public ProxyElement()
	{
	}
}
