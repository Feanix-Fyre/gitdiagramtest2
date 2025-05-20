namespace System.ComponentModel;

/// <summary>Specifies the type of persistence to use when serializing a property on a component at design time.</summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
public sealed class DesignerSerializationVisibilityAttribute : Attribute
{
	/// <summary>Specifies that a serializer should serialize the contents of the property, rather than the property itself. This field is read-only.</summary>
	public static readonly DesignerSerializationVisibilityAttribute Content;

	/// <summary>Specifies that a serializer should not serialize the value of the property. This <see langword="static" /> field is read-only.</summary>
	public static readonly DesignerSerializationVisibilityAttribute Hidden;

	/// <summary>Specifies that a serializer should be allowed to serialize the value of the property. This <see langword="static" /> field is read-only.</summary>
	public static readonly DesignerSerializationVisibilityAttribute Visible;

	/// <summary>Specifies the default value, which is <see cref="F:System.ComponentModel.DesignerSerializationVisibilityAttribute.Visible" />, that is, a visual designer uses default rules to generate the value of a property. This <see langword="static" /> field is read-only.</summary>
	public static readonly DesignerSerializationVisibilityAttribute Default;

	/// <summary>Gets a value indicating the basic serialization mode a serializer should use when determining whether and how to persist the value of a property.</summary>
	/// <returns>One of the <see cref="T:System.ComponentModel.DesignerSerializationVisibility" /> values. The default is <see cref="F:System.ComponentModel.DesignerSerializationVisibility.Visible" />.</returns>
	public DesignerSerializationVisibility Visibility { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerSerializationVisibilityAttribute" /> class using the specified <see cref="T:System.ComponentModel.DesignerSerializationVisibility" /> value.</summary>
	/// <param name="visibility">One of the <see cref="T:System.ComponentModel.DesignerSerializationVisibility" /> values.</param>
	public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
	{
	}

	/// <summary>Indicates whether this instance and a specified object are equal.</summary>
	/// <param name="obj">Another object to compare to.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this object.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
	/// <returns>
	///   <see langword="true" /> if the attribute is set to the default value; otherwise, <see langword="false" />.</returns>
	public override bool IsDefaultAttribute()
	{
		return false;
	}
}
