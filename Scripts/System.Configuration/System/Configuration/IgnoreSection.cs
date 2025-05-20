using System.Xml;

namespace System.Configuration;

/// <summary>Provides a wrapper type definition for configuration sections that are not handled by the <see cref="N:System.Configuration" /> types.</summary>
public sealed class IgnoreSection : ConfigurationSection
{
	protected internal override ConfigurationPropertyCollection Properties => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.IgnoreSection" /> class.</summary>
	public IgnoreSection()
	{
	}

	protected internal override void DeserializeSection(XmlReader xmlReader)
	{
	}

	protected internal override bool IsModified()
	{
		return false;
	}

	protected internal override void Reset(ConfigurationElement parentSection)
	{
	}

	protected internal override void ResetModified()
	{
	}

	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode)
	{
		return null;
	}
}
