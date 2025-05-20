namespace System.ComponentModel;

/// <summary>
///   <see cref="T:System.ComponentModel.DesignTimeVisibleAttribute" /> marks a component's visibility. If <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Yes" /> is present, a visual designer can show this component on a designer.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public sealed class DesignTimeVisibleAttribute : Attribute
{
	/// <summary>Marks a component as visible in a visual designer.</summary>
	public static readonly DesignTimeVisibleAttribute Yes;

	/// <summary>Marks a component as not visible in a visual designer.</summary>
	public static readonly DesignTimeVisibleAttribute No;

	/// <summary>The default visibility which is <see langword="Yes" />.</summary>
	public static readonly DesignTimeVisibleAttribute Default;

	/// <summary>Gets or sets whether the component should be shown at design time.</summary>
	/// <returns>
	///   <see langword="true" /> if this component should be shown at design time, or <see langword="false" /> if it shouldn't.</returns>
	public bool Visible { get; }

	/// <summary>Creates a new <see cref="T:System.ComponentModel.DesignTimeVisibleAttribute" /> with the <see cref="P:System.ComponentModel.DesignTimeVisibleAttribute.Visible" /> property set to the given value in <paramref name="visible" />.</summary>
	/// <param name="visible">The value that the <see cref="P:System.ComponentModel.DesignTimeVisibleAttribute.Visible" /> property will be set against.</param>
	public DesignTimeVisibleAttribute(bool visible)
	{
	}

	/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An Object to compare with this instance or a null reference (<see langword="Nothing" /> in Visual Basic).</param>
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

	/// <summary>Gets a value indicating if this instance is equal to the <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Default" /> value.</summary>
	/// <returns>
	///   <see langword="true" />, if this instance is equal to the <see cref="F:System.ComponentModel.DesignTimeVisibleAttribute.Default" /> value; otherwise, <see langword="false" />.</returns>
	public override bool IsDefaultAttribute()
	{
		return false;
	}
}
