namespace System.Runtime.InteropServices;

/// <summary>Indicates that data should be marshaled from callee back to caller.</summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
[ComVisible(true)]
public sealed class OutAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.OutAttribute" /> class.</summary>
	public OutAttribute()
	{
	}
}
