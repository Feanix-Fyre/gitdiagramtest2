namespace System.Runtime.CompilerServices;

/// <summary>Indicates when a dependency is to be loaded by the referring assembly. This class cannot be inherited.</summary>
[Serializable]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class DependencyAttribute : Attribute
{
	private string dependentAssembly;

	private LoadHint loadHint;

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.DependencyAttribute" /> class with the specified <see cref="T:System.Runtime.CompilerServices.LoadHint" /> value.</summary>
	/// <param name="dependentAssemblyArgument">The dependent assembly to bind to.</param>
	/// <param name="loadHintArgument">One of the <see cref="T:System.Runtime.CompilerServices.LoadHint" /> values.</param>
	public DependencyAttribute(string dependentAssemblyArgument, LoadHint loadHintArgument)
	{
	}
}
