using System.Runtime.Versioning;

namespace System;

/// <summary>Represents a value type that can be assigned <see langword="null" />.</summary>
/// <typeparam name="T">The underlying value type of the <see cref="T:System.Nullable`1" /> generic type.</typeparam>
[Serializable]
[NonVersionable]
public struct Nullable<T> where T : struct
{
	private readonly bool hasValue;

	internal T value;

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Nullable`1" /> object has a valid value of its underlying type.</summary>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.Nullable`1" /> object has a value; <see langword="false" /> if the current <see cref="T:System.Nullable`1" /> object has no value.</returns>
	public bool HasValue
	{
		[NonVersionable]
		get
		{
			return false;
		}
	}

	/// <summary>Gets the value of the current <see cref="T:System.Nullable`1" /> object if it has been assigned a valid underlying value.</summary>
	/// <returns>The value of the current <see cref="T:System.Nullable`1" /> object if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />. An exception is thrown if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />.</exception>
	public T Value => default(T);

	/// <summary>Initializes a new instance of the <see cref="T:System.Nullable`1" /> structure to the specified value.</summary>
	/// <param name="value">A value type.</param>
	[NonVersionable]
	public Nullable(T value)
	{
		hasValue = false;
		this.value = default(T);
	}

	/// <summary>Retrieves the value of the current <see cref="T:System.Nullable`1" /> object, or the default value of the underlying type.</summary>
	/// <returns>The value of the <see cref="P:System.Nullable`1.Value" /> property if the  <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />; otherwise, the default value of the underlying type.</returns>
	[NonVersionable]
	public T GetValueOrDefault()
	{
		return default(T);
	}

	/// <summary>Retrieves the value of the current <see cref="T:System.Nullable`1" /> object, or the specified default value.</summary>
	/// <param name="defaultValue">A value to return if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />.</param>
	/// <returns>The value of the <see cref="P:System.Nullable`1.Value" /> property if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />; otherwise, the <paramref name="defaultValue" /> parameter.</returns>
	[NonVersionable]
	public T GetValueOrDefault(T defaultValue)
	{
		return default(T);
	}

	/// <summary>Indicates whether the current <see cref="T:System.Nullable`1" /> object is equal to a specified object.</summary>
	/// <param name="other">An object.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="other" /> parameter is equal to the current <see cref="T:System.Nullable`1" /> object; otherwise, <see langword="false" />.  
	/// This table describes how equality is defined for the compared values:  
	///  Return Value  
	///
	///  Description  
	///
	/// <see langword="true" /> The <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />, and the <paramref name="other" /> parameter is <see langword="null" />. That is, two null values are equal by definition.  
	///
	/// -or-  
	///
	/// The <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />, and the value returned by the <see cref="P:System.Nullable`1.Value" /> property is equal to the <paramref name="other" /> parameter.  
	///
	/// <see langword="false" /> The <see cref="P:System.Nullable`1.HasValue" /> property for the current <see cref="T:System.Nullable`1" /> structure is <see langword="true" />, and the <paramref name="other" /> parameter is <see langword="null" />.  
	///
	/// -or-  
	///
	/// The <see cref="P:System.Nullable`1.HasValue" /> property for the current <see cref="T:System.Nullable`1" /> structure is <see langword="false" />, and the <paramref name="other" /> parameter is not <see langword="null" />.  
	///
	/// -or-  
	///
	/// The <see cref="P:System.Nullable`1.HasValue" /> property for the current <see cref="T:System.Nullable`1" /> structure is <see langword="true" />, and the value returned by the <see cref="P:System.Nullable`1.Value" /> property is not equal to the <paramref name="other" /> parameter.</returns>
	public override bool Equals(object other)
	{
		return false;
	}

	/// <summary>Retrieves the hash code of the object returned by the <see cref="P:System.Nullable`1.Value" /> property.</summary>
	/// <returns>The hash code of the object returned by the <see cref="P:System.Nullable`1.Value" /> property if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />, or zero if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns the text representation of the value of the current <see cref="T:System.Nullable`1" /> object.</summary>
	/// <returns>The text representation of the value of the current <see cref="T:System.Nullable`1" /> object if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="true" />, or an empty string ("") if the <see cref="P:System.Nullable`1.HasValue" /> property is <see langword="false" />.</returns>
	public override string ToString()
	{
		return null;
	}

	private static object Box(T? o)
	{
		return null;
	}

	private static T? Unbox(object o)
	{
		return null;
	}

	private static T? UnboxExact(object o)
	{
		return null;
	}
}
/// <summary>Supports a value type that can be assigned <see langword="null" />. This class cannot be inherited.</summary>
public static class Nullable
{
	/// <summary>Returns the underlying type argument of the specified nullable type.</summary>
	/// <param name="nullableType">A <see cref="T:System.Type" /> object that describes a closed generic nullable type.</param>
	/// <returns>The type argument of the <paramref name="nullableType" /> parameter, if the <paramref name="nullableType" /> parameter is a closed generic nullable type; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="nullableType" /> is <see langword="null" />.</exception>
	public static Type GetUnderlyingType(Type nullableType)
	{
		return null;
	}
}
