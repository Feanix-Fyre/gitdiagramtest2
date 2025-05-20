using System.Configuration;
using System.Reflection;

namespace System.Net.Configuration;

/// <summary>Represents a container for connection management configuration elements. This class cannot be inherited.</summary>
[ConfigurationCollection(typeof(ConnectionManagementElement))]
[DefaultMember("Item")]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ConnectionManagementElementCollection" /> class.</summary>
	public ConnectionManagementElementCollection()
	{
	}
}
