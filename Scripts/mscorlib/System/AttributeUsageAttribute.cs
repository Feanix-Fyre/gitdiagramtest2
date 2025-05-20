namespace System;

/// <summary>Specifies the usage of another attribute class. This class cannot be inherited.</summary>
[Serializable]
[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public sealed class AttributeUsageAttribute : Attribute
{
	private AttributeTargets _attributeTarget;

	private bool _allowMultiple;

	private bool _inherited;

	internal static AttributeUsageAttribute Default;

	/// <summary>Gets or sets a Boolean value indicating whether more than one instance of the indicated attribute can be specified for a single program element.</summary>
	/// <returns>
	///   <see langword="true" /> if more than one instance is allowed to be specified; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool AllowMultiple
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that determines whether the indicated attribute is inherited by derived classes and overriding members.</summary>
	/// <returns>
	///   <see langword="true" /> if the attribute can be inherited by derived classes and overriding members; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	public bool Inherited
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.AttributeUsageAttribute" /> class with the specified list of <see cref="T:System.AttributeTargets" />, the <see cref="P:System.AttributeUsageAttribute.AllowMultiple" /> value, and the <see cref="P:System.AttributeUsageAttribute.Inherited" /> value.</summary>
	/// <param name="validOn">The set of values combined using a bitwise OR operation to indicate which program elements are valid.</param>
	public AttributeUsageAttribute(AttributeTargets validOn)
	{
	}
}
