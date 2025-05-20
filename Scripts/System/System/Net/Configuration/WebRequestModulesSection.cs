using System.Configuration;

namespace System.Net.Configuration;

/// <summary>Represents the configuration section for Web request modules. This class cannot be inherited.</summary>
public sealed class WebRequestModulesSection : ConfigurationSection
{
	protected override ConfigurationPropertyCollection Properties => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.WebRequestModulesSection" /> class.</summary>
	public WebRequestModulesSection()
	{
	}
}
