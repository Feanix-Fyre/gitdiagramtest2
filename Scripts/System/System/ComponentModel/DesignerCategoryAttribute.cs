namespace System.ComponentModel;

/// <summary>Specifies that the designer for a class belongs to a certain category.</summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public sealed class DesignerCategoryAttribute : Attribute
{
	/// <summary>Specifies that a component marked with this category use a component designer. This field is read-only.</summary>
	public static readonly DesignerCategoryAttribute Component;

	/// <summary>Specifies that a component marked with this category cannot use a visual designer. This <see langword="static" /> field is read-only.</summary>
	public static readonly DesignerCategoryAttribute Default;

	/// <summary>Specifies that a component marked with this category use a form designer. This <see langword="static" /> field is read-only.</summary>
	public static readonly DesignerCategoryAttribute Form;

	/// <summary>Specifies that a component marked with this category use a generic designer. This <see langword="static" /> field is read-only.</summary>
	public static readonly DesignerCategoryAttribute Generic;

	/// <summary>Gets the name of the category.</summary>
	/// <returns>The name of the category.</returns>
	public string Category { get; }

	/// <summary>Gets a unique identifier for this attribute.</summary>
	/// <returns>An <see cref="T:System.Object" /> that is a unique identifier for the attribute.</returns>
	public override object TypeId => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerCategoryAttribute" /> class with an empty string ("").</summary>
	public DesignerCategoryAttribute()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerCategoryAttribute" /> class with the given category name.</summary>
	/// <param name="category">The name of the category.</param>
	public DesignerCategoryAttribute(string category)
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
