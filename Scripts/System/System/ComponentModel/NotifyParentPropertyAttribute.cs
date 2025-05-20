namespace System.ComponentModel;

/// <summary>Indicates that the parent property is notified when the value of the property that this attribute is applied to is modified. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class NotifyParentPropertyAttribute : Attribute
{
	/// <summary>Indicates that the parent property is notified of changes to the value of the property. This field is read-only.</summary>
	public static readonly NotifyParentPropertyAttribute Yes;

	/// <summary>Indicates that the parent property is not be notified of changes to the value of the property. This field is read-only.</summary>
	public static readonly NotifyParentPropertyAttribute No;

	/// <summary>Indicates the default attribute state, that the property should not notify the parent property of changes to its value. This field is read-only.</summary>
	public static readonly NotifyParentPropertyAttribute Default;

	private bool notifyParent;

	/// <summary>Gets or sets a value indicating whether the parent property should be notified of changes to the value of the property.</summary>
	/// <returns>
	///   <see langword="true" /> if the parent property should be notified of changes; otherwise, <see langword="false" />.</returns>
	public bool NotifyParent => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.NotifyParentPropertyAttribute" /> class, using the specified value to determine whether the parent property is notified of changes to the value of the property.</summary>
	/// <param name="notifyParent">
	///   <see langword="true" /> if the parent should be notified of changes; otherwise, <see langword="false" />.</param>
	public NotifyParentPropertyAttribute(bool notifyParent)
	{
	}

	/// <summary>Gets a value indicating whether the specified object is the same as the current object.</summary>
	/// <param name="obj">The object to test for equality.</param>
	/// <returns>
	///   <see langword="true" /> if the object is the same as this object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Gets the hash code for this object.</summary>
	/// <returns>The hash code for the object the attribute belongs to.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
	/// <returns>
	///   <see langword="true" /> if the current value of the attribute is the default value of the attribute; otherwise, <see langword="false" />.</returns>
	public override bool IsDefaultAttribute()
	{
		return false;
	}
}
