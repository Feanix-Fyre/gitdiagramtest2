using System.Configuration;

namespace System.Net.Configuration;

/// <summary>Represents the default settings used to create connections to a remote computer. This class cannot be inherited.</summary>
public sealed class ServicePointManagerElement : ConfigurationElement
{
	protected override ConfigurationPropertyCollection Properties => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ServicePointManagerElement" /> class.</summary>
	public ServicePointManagerElement()
	{
	}
}
