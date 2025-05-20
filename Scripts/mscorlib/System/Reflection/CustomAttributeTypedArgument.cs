namespace System.Reflection;

/// <summary>Represents an argument of a custom attribute in the reflection-only context, or an element of an array argument.</summary>
public struct CustomAttributeTypedArgument
{
	/// <summary>Gets the type of the argument or of the array argument element.</summary>
	/// <returns>A <see cref="T:System.Type" /> object representing the type of the argument or of the array element.</returns>
	public Type ArgumentType { get; }

	/// <summary>Gets the value of the argument for a simple argument or for an element of an array argument; gets a collection of values for an array argument.</summary>
	/// <returns>An object that represents the value of the argument or element, or a generic <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> objects that represent the values of an array-type argument.</returns>
	public object Value { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> class with the specified value.</summary>
	/// <param name="value">The value of the custom attribute argument.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	public CustomAttributeTypedArgument(object value)
	{
		ArgumentType = null;
		Value = null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> class with the specified type and value.</summary>
	/// <param name="argumentType">The type of the custom attribute argument.</param>
	/// <param name="value">The value of the custom attribute argument.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="argumentType" /> is <see langword="null" />.</exception>
	public CustomAttributeTypedArgument(Type argumentType, object value)
	{
		ArgumentType = null;
		Value = null;
	}

	/// <summary>Indicates whether this instance and a specified object are equal.</summary>
	/// <param name="obj">Another object to compare to.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Tests whether two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are equivalent.</summary>
	/// <param name="left">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the left of the equality operator.</param>
	/// <param name="right">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the right of the equality operator.</param>
	/// <returns>
	///   <see langword="true" /> if the two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are equal; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
	{
		return false;
	}

	/// <summary>Tests whether two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are different.</summary>
	/// <param name="left">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the left of the inequality operator.</param>
	/// <param name="right">The <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure to the right of the inequality operator.</param>
	/// <returns>
	///   <see langword="true" /> if the two <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structures are different; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
	{
		return false;
	}

	/// <summary>Returns a string consisting of the argument name, the equal sign, and a string representation of the argument value.</summary>
	/// <returns>A string consisting of the argument name, the equal sign, and a string representation of the argument value.</returns>
	public override string ToString()
	{
		return null;
	}

	internal string ToString(bool typed)
	{
		return null;
	}

	private static object CanonicalizeValue(object value)
	{
		return null;
	}
}
