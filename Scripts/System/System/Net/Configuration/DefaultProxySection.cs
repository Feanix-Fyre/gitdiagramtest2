using System.Configuration;

namespace System.Net.Configuration;

/// <summary>Represents the configuration section for Web proxy server usage. This class cannot be inherited.</summary>
public sealed class DefaultProxySection : ConfigurationSection
{
	protected override ConfigurationPropertyCollection Properties => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.DefaultProxySection" /> class.</summary>
	public DefaultProxySection()
	{
	}

	protected override void Reset(ConfigurationElement parentElement)
	{
	}
}
