namespace System.Configuration;

/// <summary>Declaratively instructs the .NET Framework to create an instance of a configuration element collection. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public sealed class ConfigurationCollectionAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.ConfigurationCollectionAttribute" /> class.</summary>
	/// <param name="itemType">The type of the property collection to create.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="itemType" /> is <see langword="null" />.</exception>
	public ConfigurationCollectionAttribute(Type itemType)
	{
	}
}
