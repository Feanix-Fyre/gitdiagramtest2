namespace System.ComponentModel;

/// <summary>Specifies whether a property can only be set at design time.</summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class DesignOnlyAttribute : Attribute
{
	/// <summary>Specifies that a property can be set only at design time. This <see langword="static" /> field is read-only.</summary>
	public static readonly DesignOnlyAttribute Yes;

	/// <summary>Specifies that a property can be set at design time or at run time. This <see langword="static" /> field is read-only.</summary>
	public static readonly DesignOnlyAttribute No;

	/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.DesignOnlyAttribute" />, which is <see cref="F:System.ComponentModel.DesignOnlyAttribute.No" />. This <see langword="static" /> field is read-only.</summary>
	public static readonly DesignOnlyAttribute Default;

	/// <summary>Gets a value indicating whether a property can be set only at design time.</summary>
	/// <returns>
	///   <see langword="true" /> if a property can be set only at design time; otherwise, <see langword="false" />.</returns>
	public bool IsDesignOnly { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignOnlyAttribute" /> class.</summary>
	/// <param name="isDesignOnly">
	///   <see langword="true" /> if a property can be set only at design time; <see langword="false" /> if the property can be set at design time and at run time.</param>
	public DesignOnlyAttribute(bool isDesignOnly)
	{
	}

	/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DesignOnlyAttribute" />.</summary>
	/// <param name="obj">The object to test the value equality of.</param>
	/// <returns>
	///   <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
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
