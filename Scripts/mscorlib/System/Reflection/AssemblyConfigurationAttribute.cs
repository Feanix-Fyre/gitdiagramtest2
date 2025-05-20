namespace System.Reflection;

/// <summary>Specifies the build configuration, such as retail or debug, for an assembly.</summary>
[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyConfigurationAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyConfigurationAttribute" /> class.</summary>
	/// <param name="configuration">The assembly configuration.</param>
	public AssemblyConfigurationAttribute(string configuration)
	{
	}
}
