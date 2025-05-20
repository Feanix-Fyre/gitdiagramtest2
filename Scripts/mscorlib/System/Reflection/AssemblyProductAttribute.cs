namespace System.Reflection;

/// <summary>Defines a product name custom attribute for an assembly manifest.</summary>
[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyProductAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyProductAttribute" /> class.</summary>
	/// <param name="product">The product name information.</param>
	public AssemblyProductAttribute(string product)
	{
	}
}
