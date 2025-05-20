namespace System.ComponentModel;

/// <summary>Specifies the default value for a property.</summary>
[AttributeUsage(AttributeTargets.All)]
public class DefaultValueAttribute : Attribute
{
	private object _value;

	private static object s_convertFromInvariantString;

	/// <summary>Gets the default value of the property this attribute is bound to.</summary>
	/// <returns>An <see cref="T:System.Object" /> that represents the default value of the property this attribute is bound to.</returns>
	public virtual object Value => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class, converting the specified value to the specified type, and using an invariant culture as the translation context.</summary>
	/// <param name="type">A <see cref="T:System.Type" /> that represents the type to convert the value to.</param>
	/// <param name="value">A <see cref="T:System.String" /> that can be converted to the type using the <see cref="T:System.ComponentModel.TypeConverter" /> for the type and the U.S. English culture.</param>
	public DefaultValueAttribute(Type type, string value)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a Unicode character.</summary>
	/// <param name="value">A Unicode character that is the default value.</param>
	public DefaultValueAttribute(char value)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a 32-bit signed integer.</summary>
	/// <param name="value">A 32-bit signed integer that is the default value.</param>
	public DefaultValueAttribute(int value)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a 64-bit signed integer.</summary>
	/// <param name="value">A 64-bit signed integer that is the default value.</param>
	public DefaultValueAttribute(long value)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a double-precision floating point number.</summary>
	/// <param name="value">A double-precision floating point number that is the default value.</param>
	public DefaultValueAttribute(double value)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a <see cref="T:System.Boolean" /> value.</summary>
	/// <param name="value">A <see cref="T:System.Boolean" /> that is the default value.</param>
	public DefaultValueAttribute(bool value)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a <see cref="T:System.String" />.</summary>
	/// <param name="value">A <see cref="T:System.String" /> that is the default value.</param>
	public DefaultValueAttribute(string value)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class.</summary>
	/// <param name="value">An <see cref="T:System.Object" /> that represents the default value.</param>
	public DefaultValueAttribute(object value)
	{
	}

	/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DefaultValueAttribute" />.</summary>
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
}
