namespace System.Runtime.InteropServices;

/// <summary>Indicates to a COM client that all classes in the current version of an assembly are compatible with classes in an earlier version of the assembly.</summary>
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class ComCompatibleVersionAttribute : Attribute
{
	internal int _major;

	internal int _minor;

	internal int _build;

	internal int _revision;

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.ComCompatibleVersionAttribute" /> class with the major version, minor version, build, and revision numbers of the assembly.</summary>
	/// <param name="major">The major version number of the assembly.</param>
	/// <param name="minor">The minor version number of the assembly.</param>
	/// <param name="build">The build number of the assembly.</param>
	/// <param name="revision">The revision number of the assembly.</param>
	public ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
	{
	}
}
