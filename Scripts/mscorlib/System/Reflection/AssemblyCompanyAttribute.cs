namespace System.Reflection;

/// <summary>Defines a company name custom attribute for an assembly manifest.</summary>
[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyCompanyAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyCompanyAttribute" /> class.</summary>
	/// <param name="company">The company name information.</param>
	public AssemblyCompanyAttribute(string company)
	{
	}
}
