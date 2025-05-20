namespace System.ComponentModel;

/// <summary>Enables attribute redirection. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.Property)]
public class AttributeProviderAttribute : Attribute
{
	/// <summary>Gets the assembly qualified type name passed into the constructor.</summary>
	/// <returns>The assembly qualified name of the type specified in the constructor.</returns>
	public string TypeName { get; }

	/// <summary>Gets the name of the property for which attributes will be retrieved.</summary>
	/// <returns>The name of the property for which attributes will be retrieved.</returns>
	public string PropertyName { get; }
}
