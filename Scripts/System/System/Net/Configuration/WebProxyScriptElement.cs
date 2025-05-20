using System.Configuration;

namespace System.Net.Configuration;

/// <summary>Represents information used to configure Web proxy scripts. This class cannot be inherited.</summary>
public sealed class WebProxyScriptElement : ConfigurationElement
{
	protected override ConfigurationPropertyCollection Properties => null;

	/// <summary>Initializes an instance of the <see cref="T:System.Net.Configuration.WebProxyScriptElement" /> class.</summary>
	public WebProxyScriptElement()
	{
	}
}
