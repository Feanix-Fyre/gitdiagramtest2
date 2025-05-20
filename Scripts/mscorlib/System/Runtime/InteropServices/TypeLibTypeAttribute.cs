namespace System.Runtime.InteropServices;

/// <summary>Contains the <see cref="T:System.Runtime.InteropServices.TYPEFLAGS" /> that were originally imported for this type from the COM type library.</summary>
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, Inherited = false)]
public sealed class TypeLibTypeAttribute : Attribute
{
	internal TypeLibTypeFlags _val;

	/// <summary>Initializes a new instance of the <see langword="TypeLibTypeAttribute" /> class with the specified <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> value.</summary>
	/// <param name="flags">The <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> value for the attributed type as found in the type library it was imported from.</param>
	public TypeLibTypeAttribute(TypeLibTypeFlags flags)
	{
	}
}
