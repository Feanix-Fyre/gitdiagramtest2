namespace System.ComponentModel;

/// <summary>Indicates that the property grid should refresh when the associated property value changes. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class RefreshPropertiesAttribute : Attribute
{
	/// <summary>Indicates that all properties are queried again and refreshed if the property value is changed. This field is read-only.</summary>
	public static readonly RefreshPropertiesAttribute All;

	/// <summary>Indicates that all properties are repainted if the property value is changed. This field is read-only.</summary>
	public static readonly RefreshPropertiesAttribute Repaint;

	/// <summary>Indicates that no other properties are refreshed if the property value is changed. This field is read-only.</summary>
	public static readonly RefreshPropertiesAttribute Default;

	private RefreshProperties refresh;

	/// <summary>Gets the refresh properties for the member.</summary>
	/// <returns>A <see cref="T:System.ComponentModel.RefreshProperties" /> that indicates the current refresh properties for the member.</returns>
	public RefreshProperties RefreshProperties => default(RefreshProperties);

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.RefreshPropertiesAttribute" /> class.</summary>
	/// <param name="refresh">A <see cref="T:System.ComponentModel.RefreshProperties" /> value indicating the nature of the refresh.</param>
	public RefreshPropertiesAttribute(RefreshProperties refresh)
	{
	}

	/// <summary>Overrides the object's <see cref="Overload:System.Object.Equals" /> method.</summary>
	/// <param name="value">The object to test for equality.</param>
	/// <returns>
	///   <see langword="true" /> if the specified object is the same; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns the hash code for this object.</summary>
	/// <returns>The hash code for the object that the attribute belongs to.</returns>
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
}
