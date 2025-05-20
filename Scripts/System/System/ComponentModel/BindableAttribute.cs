namespace System.ComponentModel;

/// <summary>Specifies whether a member is typically used for binding. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class BindableAttribute : Attribute
{
	/// <summary>Specifies that a property is typically used for binding. This field is read-only.</summary>
	public static readonly BindableAttribute Yes;

	/// <summary>Specifies that a property is not typically used for binding. This field is read-only.</summary>
	public static readonly BindableAttribute No;

	/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.BindableAttribute" />, which is <see cref="F:System.ComponentModel.BindableAttribute.No" />. This field is read-only.</summary>
	public static readonly BindableAttribute Default;

	private bool _isDefault;

	/// <summary>Gets a value indicating that a property is typically used for binding.</summary>
	/// <returns>
	///   <see langword="true" /> if the property is typically used for binding; otherwise, <see langword="false" />.</returns>
	public bool Bindable { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BindableAttribute" /> class with a Boolean value.</summary>
	/// <param name="bindable">
	///   <see langword="true" /> to use property for binding; otherwise, <see langword="false" />.</param>
	public BindableAttribute(bool bindable)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BindableAttribute" /> class.</summary>
	/// <param name="bindable">
	///   <see langword="true" /> to use property for binding; otherwise, <see langword="false" />.</param>
	/// <param name="direction">One of the <see cref="T:System.ComponentModel.BindingDirection" /> values.</param>
	public BindableAttribute(bool bindable, BindingDirection direction)
	{
	}

	/// <summary>Determines whether two <see cref="T:System.ComponentModel.BindableAttribute" /> objects are equal.</summary>
	/// <param name="obj">The object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.ComponentModel.BindableAttribute" /> is equal to the current <see cref="T:System.ComponentModel.BindableAttribute" />; <see langword="false" /> if it is not equal.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Serves as a hash function for the <see cref="T:System.ComponentModel.BindableAttribute" /> class.</summary>
	/// <returns>A hash code for the current <see cref="T:System.ComponentModel.BindableAttribute" />.</returns>
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
