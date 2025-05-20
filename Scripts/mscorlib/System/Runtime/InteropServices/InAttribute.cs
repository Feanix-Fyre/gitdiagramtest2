namespace System.Runtime.InteropServices;

/// <summary>Indicates that data should be marshaled from the caller to the callee, but not back to the caller.</summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
[ComVisible(true)]
public sealed class InAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.InAttribute" /> class.</summary>
	public InAttribute()
	{
	}
}
