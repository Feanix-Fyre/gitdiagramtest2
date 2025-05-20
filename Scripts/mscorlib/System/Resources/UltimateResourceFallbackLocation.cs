namespace System.Resources;

/// <summary>Specifies whether a <see cref="T:System.Resources.ResourceManager" /> object looks for the resources of the app's default culture in the main assembly or in a satellite assembly.</summary>
public enum UltimateResourceFallbackLocation
{
	/// <summary>Fallback resources are located in the main assembly.</summary>
	MainAssembly = 0,
	/// <summary>Fallback resources are located in a satellite assembly.</summary>
	Satellite = 1
}
