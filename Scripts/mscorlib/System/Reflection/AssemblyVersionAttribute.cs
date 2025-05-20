namespace System.Reflection;

/// <summary>Specifies the version of the assembly being attributed.</summary>
[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyVersionAttribute : Attribute
{
	private readonly string _003CVersion_003Ek__BackingField;

	/// <summary>Gets the version number of the attributed assembly.</summary>
	/// <returns>A string containing the assembly version number.</returns>
	public string Version => _003CVersion_003Ek__BackingField;

	/// <summary>Initializes a new instance of the <see langword="AssemblyVersionAttribute" /> class with the version number of the assembly being attributed.</summary>
	/// <param name="version">The version number of the attributed assembly.</param>
	public AssemblyVersionAttribute(string version)
	{
		_003CVersion_003Ek__BackingField = version;
	}
}
