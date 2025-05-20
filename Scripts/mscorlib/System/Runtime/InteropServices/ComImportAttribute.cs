namespace System.Runtime.InteropServices;

/// <summary>Indicates that the attributed type was previously defined in COM.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
[ComVisible(true)]
public sealed class ComImportAttribute : Attribute
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.ComImportAttribute" />.</summary>
	public ComImportAttribute()
	{
	}
}
