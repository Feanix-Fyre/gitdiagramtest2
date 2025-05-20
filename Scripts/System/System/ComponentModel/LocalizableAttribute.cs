namespace System.ComponentModel;

/// <summary>Specifies whether a property should be localized. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class LocalizableAttribute : Attribute
{
	/// <summary>Specifies that a property should be localized. This <see langword="static" /> field is read-only.</summary>
	public static readonly LocalizableAttribute Yes;

	/// <summary>Specifies that a property should not be localized. This <see langword="static" /> field is read-only.</summary>
	public static readonly LocalizableAttribute No;

	/// <summary>Specifies the default value, which is <see cref="F:System.ComponentModel.LocalizableAttribute.No" />. This <see langword="static" /> field is read-only.</summary>
	public static readonly LocalizableAttribute Default;

	/// <summary>Gets a value indicating whether a property should be localized.</summary>
	/// <returns>
	///   <see langword="true" /> if a property should be localized; otherwise, <see langword="false" />.</returns>
	public bool IsLocalizable { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.LocalizableAttribute" /> class.</summary>
	/// <param name="isLocalizable">
	///   <see langword="true" /> if a property should be localized; otherwise, <see langword="false" />.</param>
	public LocalizableAttribute(bool isLocalizable)
	{
	}

	/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.LocalizableAttribute" />.</summary>
	/// <param name="obj">The object to test the value equality of.</param>
	/// <returns>
	///   <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A hash code for the current <see cref="T:System.ComponentModel.LocalizableAttribute" />.</returns>
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
