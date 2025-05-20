using System.Collections.Generic;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;
using Unity.Services.Core.Internal.Serialization;

namespace Unity.Services.Core.Configuration;

internal class ProjectConfiguration : IProjectConfiguration, IServiceComponent
{
	private string m_JsonCache;

	private readonly IReadOnlyDictionary<string, ConfigurationEntry> m_ConfigValues;

	internal IJsonSerializer Serializer { get; }

	public ProjectConfiguration(IReadOnlyDictionary<string, ConfigurationEntry> configValues, IJsonSerializer serializer)
	{
	}

	public bool GetBool(string key, bool defaultValue = false)
	{
		return false;
	}

	public int GetInt(string key, int defaultValue = 0)
	{
		return 0;
	}

	public float GetFloat(string key, float defaultValue = 0f)
	{
		return 0f;
	}

	public string GetString(string key, string defaultValue = null)
	{
		return null;
	}

	public string ToJson()
	{
		return null;
	}
}
