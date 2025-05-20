namespace System.Runtime.InteropServices;

/// <summary>Specifies the COM dispatch identifier (DISPID) of a method, field, or property.</summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, Inherited = false)]
[ComVisible(true)]
public sealed class DispIdAttribute : Attribute
{
	internal int _val;

	/// <summary>Initializes a new instance of the <see langword="DispIdAttribute" /> class with the specified DISPID.</summary>
	/// <param name="dispId">The DISPID for the member.</param>
	public DispIdAttribute(int dispId)
	{
	}
}
