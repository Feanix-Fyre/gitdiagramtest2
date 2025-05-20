namespace System.ComponentModel;

/// <summary>Indicates whether the component associated with this attribute has been inherited from a base class. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
public sealed class InheritanceAttribute : Attribute
{
	/// <summary>Specifies that the component is inherited. This field is read-only.</summary>
	public static readonly InheritanceAttribute Inherited;

	/// <summary>Specifies that the component is inherited and is read-only. This field is read-only.</summary>
	public static readonly InheritanceAttribute InheritedReadOnly;

	/// <summary>Specifies that the component is not inherited. This field is read-only.</summary>
	public static readonly InheritanceAttribute NotInherited;

	/// <summary>Specifies that the default value for <see cref="T:System.ComponentModel.InheritanceAttribute" /> is <see cref="F:System.ComponentModel.InheritanceAttribute.NotInherited" />. This field is read-only.</summary>
	public static readonly InheritanceAttribute Default;

	/// <summary>Gets or sets the current inheritance level stored in this attribute.</summary>
	/// <returns>The <see cref="T:System.ComponentModel.InheritanceLevel" /> stored in this attribute.</returns>
	public InheritanceLevel InheritanceLevel { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InheritanceAttribute" /> class with the specified inheritance level.</summary>
	/// <param name="inheritanceLevel">An <see cref="T:System.ComponentModel.InheritanceLevel" /> that indicates the level of inheritance to set this attribute to.</param>
	public InheritanceAttribute(InheritanceLevel inheritanceLevel)
	{
	}

	/// <summary>Override to test for equality.</summary>
	/// <param name="value">The object to test.</param>
	/// <returns>
	///   <see langword="true" /> if the object is the same; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns the hashcode for this object.</summary>
	/// <returns>A hash code for the current <see cref="T:System.ComponentModel.InheritanceAttribute" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
	/// <returns>
	///   <see langword="true" /> if the current value of the attribute is the default; otherwise, <see langword="false" />.</returns>
	public override bool IsDefaultAttribute()
	{
		return false;
	}

	/// <summary>Converts this attribute to a string.</summary>
	/// <returns>A string that represents this <see cref="T:System.ComponentModel.InheritanceAttribute" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
