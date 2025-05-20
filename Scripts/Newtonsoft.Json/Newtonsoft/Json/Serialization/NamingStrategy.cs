namespace Newtonsoft.Json.Serialization;

public abstract class NamingStrategy
{
	public bool ProcessDictionaryKeys { get; set; }

	public bool ProcessExtensionDataNames { get; set; }

	public bool OverrideSpecifiedNames { get; set; }

	public virtual string GetPropertyName(string name, bool hasSpecifiedName)
	{
		return null;
	}

	public virtual string GetExtensionDataName(string name)
	{
		return null;
	}

	public virtual string GetDictionaryKey(string key)
	{
		return null;
	}

	protected abstract string ResolvePropertyName(string name);

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object? obj)
	{
		return false;
	}

	protected bool Equals(NamingStrategy? other)
	{
		return false;
	}
}
