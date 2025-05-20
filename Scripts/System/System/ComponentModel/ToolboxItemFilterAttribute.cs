namespace System.ComponentModel;

/// <summary>Specifies the filter string and filter type to use for a toolbox item.</summary>
[Serializable]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public sealed class ToolboxItemFilterAttribute : Attribute
{
	private string _typeId;

	/// <summary>Gets the filter string for the toolbox item.</summary>
	/// <returns>The filter string for the toolbox item.</returns>
	public string FilterString { get; }

	/// <summary>Gets the type of the filter.</summary>
	/// <returns>A <see cref="T:System.ComponentModel.ToolboxItemFilterType" /> that indicates the type of the filter.</returns>
	public ToolboxItemFilterType FilterType { get; }

	/// <summary>Gets the type ID for the attribute.</summary>
	/// <returns>The type ID for this attribute. All <see cref="T:System.ComponentModel.ToolboxItemFilterAttribute" /> objects with the same filter string return the same type ID.</returns>
	public override object TypeId => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemFilterAttribute" /> class using the specified filter string.</summary>
	/// <param name="filterString">The filter string for the toolbox item.</param>
	public ToolboxItemFilterAttribute(string filterString)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemFilterAttribute" /> class using the specified filter string and type.</summary>
	/// <param name="filterString">The filter string for the toolbox item.</param>
	/// <param name="filterType">A <see cref="T:System.ComponentModel.ToolboxItemFilterType" /> indicating the type of the filter.</param>
	public ToolboxItemFilterAttribute(string filterString, ToolboxItemFilterType filterType)
	{
	}

	/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance or a null reference (<see langword="Nothing" /> in Visual Basic).</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
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

	/// <summary>Indicates whether the specified object has a matching filter string.</summary>
	/// <param name="obj">The object to test for a matching filter string.</param>
	/// <returns>
	///   <see langword="true" /> if the specified object has a matching filter string; otherwise, <see langword="false" />.</returns>
	public override bool Match(object obj)
	{
		return false;
	}

	/// <summary>Returns a string that represents the current object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}
}
