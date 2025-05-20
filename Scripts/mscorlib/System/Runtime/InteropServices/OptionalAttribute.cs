namespace System.Runtime.InteropServices;

/// <summary>Indicates that a parameter is optional.</summary>
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
public sealed class OptionalAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see langword="OptionalAttribute" /> class with default values.</summary>
	public OptionalAttribute()
	{
	}
}
