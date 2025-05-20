namespace System.Runtime.InteropServices;

/// <summary>Indicates the COM alias for a parameter or field type.</summary>
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
public sealed class ComAliasNameAttribute : Attribute
{
	internal string _val;

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.ComAliasNameAttribute" /> class with the alias for the attributed field or parameter.</summary>
	/// <param name="alias">The alias for the field or parameter as found in the type library when it was imported.</param>
	public ComAliasNameAttribute(string alias)
	{
	}
}
