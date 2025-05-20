namespace System.Runtime.InteropServices;

/// <summary>Controls accessibility of an individual managed type or member, or of all types within an assembly, to COM.</summary>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
[ComVisible(true)]
public sealed class ComVisibleAttribute : Attribute
{
	internal bool _val;

	/// <summary>Initializes a new instance of the <see langword="ComVisibleAttribute" /> class.</summary>
	/// <param name="visibility">
	///   <see langword="true" /> to indicate that the type is visible to COM; otherwise, <see langword="false" />. The default is <see langword="true" />.</param>
	public ComVisibleAttribute(bool visibility)
	{
	}
}
