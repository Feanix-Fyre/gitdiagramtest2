using System.Xml;

namespace System.Configuration;

/// <summary>Represents a section within a configuration file.</summary>
public abstract class ConfigurationSection : ConfigurationElement
{
	/// <summary>Reads XML from the configuration file.</summary>
	/// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> object, which reads from the configuration file.</param>
	/// <exception cref="T:System.Configuration.ConfigurationErrorsException">
	///   <paramref name="reader" /> found no elements in the configuration file.</exception>
	protected internal virtual void DeserializeSection(XmlReader reader)
	{
	}

	/// <summary>Indicates whether this configuration element has been modified since it was last saved or loaded when implemented in a derived class.</summary>
	/// <returns>
	///   <see langword="true" /> if the element has been modified; otherwise, <see langword="false" />.</returns>
	protected internal override bool IsModified()
	{
		return false;
	}

	/// <summary>Resets the value of the <see cref="M:System.Configuration.ConfigurationElement.IsModified" /> method to <see langword="false" /> when implemented in a derived class.</summary>
	protected internal override void ResetModified()
	{
	}

	/// <summary>Creates an XML string containing an unmerged view of the <see cref="T:System.Configuration.ConfigurationSection" /> object as a single section to write to a file.</summary>
	/// <param name="parentElement">The <see cref="T:System.Configuration.ConfigurationElement" /> instance to use as the parent when performing the un-merge.</param>
	/// <param name="name">The name of the section to create.</param>
	/// <param name="saveMode">The <see cref="T:System.Configuration.ConfigurationSaveMode" /> instance to use when writing to a string.</param>
	/// <returns>An XML string containing an unmerged view of the <see cref="T:System.Configuration.ConfigurationSection" /> object.</returns>
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode)
	{
		return null;
	}
}
