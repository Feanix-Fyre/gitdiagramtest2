using System.Configuration;
using System.Reflection;

namespace System.Net.Configuration;

/// <summary>Represents a container for the addresses of resources that bypass the proxy server. This class cannot be inherited.</summary>
[ConfigurationCollection(typeof(BypassElement))]
[DefaultMember("Item")]
public sealed class BypassElementCollection : ConfigurationElementCollection
{
	/// <summary>Initializes an empty instance of the <see cref="T:System.Net.Configuration.BypassElementCollection" /> class.</summary>
	public BypassElementCollection()
	{
	}
}
