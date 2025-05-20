namespace System.ComponentModel;

/// <summary>Specifies whether the property this attribute is bound to is read-only or read/write. This class cannot be inherited</summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class ReadOnlyAttribute : Attribute
{
	/// <summary>Specifies that the property this attribute is bound to is read-only and cannot be modified in the server explorer. This <see langword="static" /> field is read-only.</summary>
	public static readonly ReadOnlyAttribute Yes;

	/// <summary>Specifies that the property this attribute is bound to is read/write and can be modified. This <see langword="static" /> field is read-only.</summary>
	public static readonly ReadOnlyAttribute No;

	/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.ReadOnlyAttribute" />, which is <see cref="F:System.ComponentModel.ReadOnlyAttribute.No" /> (that is, the property this attribute is bound to is read/write). This <see langword="static" /> field is read-only.</summary>
	public static readonly ReadOnlyAttribute Default;

	/// <summary>Gets a value indicating whether the property this attribute is bound to is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the property this attribute is bound to is read-only; <see langword="false" /> if the property is read/write.</returns>
	public bool IsReadOnly { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ReadOnlyAttribute" /> class.</summary>
	/// <param name="isReadOnly">
	///   <see langword="true" /> to show that the property this attribute is bound to is read-only; <see langword="false" /> to show that the property is read/write.</param>
	public ReadOnlyAttribute(bool isReadOnly)
	{
	}

	/// <summary>Indicates whether this instance and a specified object are equal.</summary>
	/// <param name="value">Another object to compare to.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A hash code for the current <see cref="T:System.ComponentModel.ReadOnlyAttribute" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Determines if this attribute is the default.</summary>
	/// <returns>
	///   <see langword="true" /> if the attribute is the default value for this attribute class; otherwise, <see langword="false" />.</returns>
	public override bool IsDefaultAttribute()
	{
		return false;
	}
}
