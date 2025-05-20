namespace System.Reflection;

/// <summary>Specifies the name of a file containing the key pair used to generate a strong name.</summary>
[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyKeyFileAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see langword="AssemblyKeyFileAttribute" /> class with the name of the file containing the key pair to generate a strong name for the assembly being attributed.</summary>
	/// <param name="keyFile">The name of the file containing the key pair.</param>
	public AssemblyKeyFileAttribute(string keyFile)
	{
	}
}
