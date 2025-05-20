using System.Reflection;

namespace System.Configuration;

/// <summary>Represents a configuration element within a configuration file.</summary>
[DefaultMember("Item")]
public abstract class ConfigurationElement
{
	/// <summary>Gets the collection of properties.</summary>
	/// <returns>The <see cref="T:System.Configuration.ConfigurationPropertyCollection" /> of properties for the element.</returns>
	protected internal virtual ConfigurationPropertyCollection Properties => null;

	/// <summary>Indicates whether this configuration element has been modified since it was last saved or loaded, when implemented in a derived class.</summary>
	/// <returns>
	///   <see langword="true" /> if the element has been modified; otherwise, <see langword="false" />.</returns>
	protected internal virtual bool IsModified()
	{
		return false;
	}

	/// <summary>Resets the internal state of the <see cref="T:System.Configuration.ConfigurationElement" /> object, including the locks and the properties collections.</summary>
	/// <param name="parentElement">The parent node of the configuration element.</param>
	protected internal virtual void Reset(ConfigurationElement parentElement)
	{
	}

	/// <summary>Resets the value of the <see cref="M:System.Configuration.ConfigurationElement.IsModified" /> method to <see langword="false" /> when implemented in a derived class.</summary>
	protected internal virtual void ResetModified()
	{
	}
}
