namespace System.Runtime.Serialization;

/// <summary>Specifies that the field is an enumeration member and should be serialized.</summary>
[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public sealed class EnumMemberAttribute : Attribute
{
	private string value;

	/// <summary>Gets or sets the value associated with the enumeration member the attribute is applied to.</summary>
	/// <returns>The value associated with the enumeration member.</returns>
	public string Value => null;
}
