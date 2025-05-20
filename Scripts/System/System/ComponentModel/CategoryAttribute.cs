namespace System.ComponentModel;

/// <summary>Specifies the name of the category in which to group the property or event when displayed in a <see cref="T:System.Windows.Forms.PropertyGrid" /> control set to Categorized mode.</summary>
[AttributeUsage(AttributeTargets.All)]
public class CategoryAttribute : Attribute
{
	private static CategoryAttribute defAttr;

	private bool localized;

	private string categoryValue;

	/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Default category.</summary>
	/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the default category.</returns>
	public static CategoryAttribute Default => null;

	/// <summary>Gets the name of the category for the property or event that this attribute is applied to.</summary>
	/// <returns>The name of the category for the property or event that this attribute is applied to.</returns>
	public string Category => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CategoryAttribute" /> class using the category name Default.</summary>
	public CategoryAttribute()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CategoryAttribute" /> class using the specified category name.</summary>
	/// <param name="category">The name of the category.</param>
	public CategoryAttribute(string category)
	{
	}

	/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.CategoryAttribute" />.</summary>
	/// <param name="obj">The object to test the value equality of.</param>
	/// <returns>
	///   <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this attribute.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Looks up the localized name of the specified category.</summary>
	/// <param name="value">The identifer for the category to look up.</param>
	/// <returns>The localized name of the category, or <see langword="null" /> if a localized name does not exist.</returns>
	protected virtual string GetLocalizedString(string value)
	{
		return null;
	}

	/// <summary>Determines if this attribute is the default.</summary>
	/// <returns>
	///   <see langword="true" /> if the attribute is the default value for this attribute class; otherwise, <see langword="false" />.</returns>
	public override bool IsDefaultAttribute()
	{
		return false;
	}
}
