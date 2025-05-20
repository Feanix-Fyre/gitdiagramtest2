using System.Configuration;

namespace System.Net.Configuration;

/// <summary>Represents the configuration section for connection management. This class cannot be inherited.</summary>
public sealed class ConnectionManagementSection : ConfigurationSection
{
	protected override ConfigurationPropertyCollection Properties => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ConnectionManagementSection" /> class.</summary>
	public ConnectionManagementSection()
	{
	}
}
