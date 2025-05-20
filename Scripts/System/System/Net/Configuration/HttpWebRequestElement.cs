using System.Configuration;

namespace System.Net.Configuration;

/// <summary>Represents the maximum length for response headers. This class cannot be inherited.</summary>
public sealed class HttpWebRequestElement : ConfigurationElement
{
	protected override ConfigurationPropertyCollection Properties => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.HttpWebRequestElement" /> class.</summary>
	public HttpWebRequestElement()
	{
	}
}
