namespace System.Runtime.CompilerServices;

/// <summary>Specifies that types that are ordinarily visible only within the current assembly are visible to a specified assembly.</summary>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
public sealed class InternalsVisibleToAttribute : Attribute
{
	private string _assemblyName;

	private bool _allInternalsVisible;

	/// <summary>This property is not implemented.</summary>
	/// <returns>This property does not return a value.</returns>
	public bool AllInternalsVisible
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.InternalsVisibleToAttribute" /> class with the name of the specified friend assembly.</summary>
	/// <param name="assemblyName">The name of a friend assembly.</param>
	public InternalsVisibleToAttribute(string assemblyName)
	{
	}
}
