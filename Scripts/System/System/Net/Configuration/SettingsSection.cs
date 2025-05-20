using System.Configuration;

namespace System.Net.Configuration;

/// <summary>Represents the configuration section for sockets, IPv6, response headers, and service points. This class cannot be inherited.</summary>
public sealed class SettingsSection : ConfigurationSection
{
	protected override ConfigurationPropertyCollection Properties => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ConnectionManagementSection" /> class.</summary>
	public SettingsSection()
	{
	}
}
