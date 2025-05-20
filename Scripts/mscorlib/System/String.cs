using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

namespace System;

/// <summary>Represents text as a sequence of UTF-16 code units.</summary>
[Serializable]
public sealed class String : IComparable, IEnumerable, IEnumerable<char>, IComparable<string>, IEquatable<string>, IConvertible, ICloneable
{
	private enum TrimType
	{
		Head = 0,
		Tail = 1,
		Both = 2
	}

	[StructLayout((LayoutKind)2, Size = 32)]
	private struct ProbabilisticMap
	{
	}

	private const int StackallocIntBufferSizeLimit = 128;

	private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7;

	private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3;

	private const int PROBABILISTICMAP_SIZE = 8;

	[NonSerialized]
	private int _stringLength;

	[NonSerialized]
	private char _firstChar;

	/// <summary>Represents the empty string. This field is read-only.</summary>
	public static readonly string Empty;

	/// <summary>Gets the number of characters in the current <see cref="T:System.String" /> object.</summary>
	/// <returns>The number of characters in the current string.</returns>
	public int Length => 0;

	/// <summary>Gets the <see cref="T:System.Char" /> object at a specified position in the current <see cref="T:System.String" /> object.</summary>
	/// <param name="index">A position in the current string.</param>
	/// <returns>The object at position <paramref name="index" />.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="index" /> is greater than or equal to the length of this object or less than zero.</exception>
	[IndexerName("Chars")]
	public char this[int index]
	{
		[Intrinsic]
		get
		{
			return '\0';
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool EqualsHelper(string strA, string strB)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB)
	{
		return 0;
	}

	private static int CompareOrdinalHelper(string strA, string strB)
	{
		return 0;
	}

	/// <summary>Compares two specified <see cref="T:System.String" /> objects and returns an integer that indicates their relative position in the sort order.</summary>
	/// <param name="strA">The first string to compare.</param>
	/// <param name="strB">The second string to compare.</param>
	/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///  <paramref name="strA" /> precedes <paramref name="strB" /> in the sort order.  
	///
	///   Zero  
	///
	///  <paramref name="strA" /> occurs in the same position as <paramref name="strB" /> in the sort order.  
	///
	///   Greater than zero  
	///
	///  <paramref name="strA" /> follows <paramref name="strB" /> in the sort order.</returns>
	public static int Compare(string strA, string strB)
	{
		return 0;
	}

	/// <summary>Compares two specified <see cref="T:System.String" /> objects, ignoring or honoring their case, and returns an integer that indicates their relative position in the sort order.</summary>
	/// <param name="strA">The first string to compare.</param>
	/// <param name="strB">The second string to compare.</param>
	/// <param name="ignoreCase">
	///   <see langword="true" /> to ignore case during the comparison; otherwise, <see langword="false" />.</param>
	/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///  <paramref name="strA" /> precedes <paramref name="strB" /> in the sort order.  
	///
	///   Zero  
	///
	///  <paramref name="strA" /> occurs in the same position as <paramref name="strB" /> in the sort order.  
	///
	///   Greater than zero  
	///
	///  <paramref name="strA" /> follows <paramref name="strB" /> in the sort order.</returns>
	public static int Compare(string strA, string strB, bool ignoreCase)
	{
		return 0;
	}

	/// <summary>Compares two specified <see cref="T:System.String" /> objects using the specified rules, and returns an integer that indicates their relative position in the sort order.</summary>
	/// <param name="strA">The first string to compare.</param>
	/// <param name="strB">The second string to compare.</param>
	/// <param name="comparisonType">One of the enumeration values that specifies the rules to use in the comparison.</param>
	/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///  <paramref name="strA" /> precedes <paramref name="strB" /> in the sort order.  
	///
	///   Zero  
	///
	///  <paramref name="strA" /> is in the same position as <paramref name="strB" /> in the sort order.  
	///
	///   Greater than zero  
	///
	///  <paramref name="strA" /> follows <paramref name="strB" /> in the sort order.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <see cref="T:System.StringComparison" /> is not supported.</exception>
	public static int Compare(string strA, string strB, StringComparison comparisonType)
	{
		return 0;
	}

	/// <summary>Compares two specified <see cref="T:System.String" /> objects using the specified comparison options and culture-specific information to influence the comparison, and returns an integer that indicates the relationship of the two strings to each other in the sort order.</summary>
	/// <param name="strA">The first string to compare.</param>
	/// <param name="strB">The second string to compare.</param>
	/// <param name="culture">The culture that supplies culture-specific comparison information.</param>
	/// <param name="options">Options to use when performing the comparison (such as ignoring case or symbols).</param>
	/// <returns>A 32-bit signed integer that indicates the lexical relationship between <paramref name="strA" /> and <paramref name="strB" />, as shown in the following table  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///  <paramref name="strA" /> precedes <paramref name="strB" /> in the sort order.  
	///
	///   Zero  
	///
	///  <paramref name="strA" /> occurs in the same position as <paramref name="strB" /> in the sort order.  
	///
	///   Greater than zero  
	///
	///  <paramref name="strA" /> follows <paramref name="strB" /> in the sort order.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> is not a <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="culture" /> is <see langword="null" />.</exception>
	public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		return 0;
	}

	/// <summary>Compares two specified <see cref="T:System.String" /> objects, ignoring or honoring their case, and using culture-specific information to influence the comparison, and returns an integer that indicates their relative position in the sort order.</summary>
	/// <param name="strA">The first string to compare.</param>
	/// <param name="strB">The second string to compare.</param>
	/// <param name="ignoreCase">
	///   <see langword="true" /> to ignore case during the comparison; otherwise, <see langword="false" />.</param>
	/// <param name="culture">An object that supplies culture-specific comparison information.</param>
	/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///  <paramref name="strA" /> precedes <paramref name="strB" /> in the sort order.  
	///
	///   Zero  
	///
	///  <paramref name="strA" /> occurs in the same position as <paramref name="strB" /> in the sort order.  
	///
	///   Greater than zero  
	///
	///  <paramref name="strA" /> follows <paramref name="strB" /> in the sort order.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="culture" /> is <see langword="null" />.</exception>
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
	{
		return 0;
	}

	/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects and returns an integer that indicates their relative position in the sort order.</summary>
	/// <param name="strA">The first string to use in the comparison.</param>
	/// <param name="indexA">The position of the substring within <paramref name="strA" />.</param>
	/// <param name="strB">The second string to use in the comparison.</param>
	/// <param name="indexB">The position of the substring within <paramref name="strB" />.</param>
	/// <param name="length">The maximum number of characters in the substrings to compare.</param>
	/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   The substring in <paramref name="strA" /> precedes the substring in <paramref name="strB" /> in the sort order.  
	///
	///   Zero  
	///
	///   The substrings occur in the same position in the sort order, or <paramref name="length" /> is zero.  
	///
	///   Greater than zero  
	///
	///   The substring in <paramref name="strA" /> follows the substring in <paramref name="strB" /> in the sort order.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.  
	/// -or-  
	/// <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.  
	/// -or-  
	/// <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative.  
	/// -or-  
	/// Either <paramref name="indexA" /> or <paramref name="indexB" /> is <see langword="null" />, and <paramref name="length" /> is greater than zero.</exception>
	public static int Compare(string strA, int indexA, string strB, int indexB, int length)
	{
		return 0;
	}

	/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects, ignoring or honoring their case, and returns an integer that indicates their relative position in the sort order.</summary>
	/// <param name="strA">The first string to use in the comparison.</param>
	/// <param name="indexA">The position of the substring within <paramref name="strA" />.</param>
	/// <param name="strB">The second string to use in the comparison.</param>
	/// <param name="indexB">The position of the substring within <paramref name="strB" />.</param>
	/// <param name="length">The maximum number of characters in the substrings to compare.</param>
	/// <param name="ignoreCase">
	///   <see langword="true" /> to ignore case during the comparison; otherwise, <see langword="false" />.</param>
	/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   The substring in <paramref name="strA" /> precedes the substring in <paramref name="strB" /> in the sort order.  
	///
	///   Zero  
	///
	///   The substrings occur in the same position in the sort order, or <paramref name="length" /> is zero.  
	///
	///   Greater than zero  
	///
	///   The substring in <paramref name="strA" /> follows the substring in <paramref name="strB" /> in the sort order.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.  
	/// -or-  
	/// <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.  
	/// -or-  
	/// <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative.  
	/// -or-  
	/// Either <paramref name="indexA" /> or <paramref name="indexB" /> is <see langword="null" />, and <paramref name="length" /> is greater than zero.</exception>
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase)
	{
		return 0;
	}

	/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects using the specified rules, and returns an integer that indicates their relative position in the sort order.</summary>
	/// <param name="strA">The first string to use in the comparison.</param>
	/// <param name="indexA">The position of the substring within <paramref name="strA" />.</param>
	/// <param name="strB">The second string to use in the comparison.</param>
	/// <param name="indexB">The position of the substring within <paramref name="strB" />.</param>
	/// <param name="length">The maximum number of characters in the substrings to compare.</param>
	/// <param name="comparisonType">One of the enumeration values that specifies the rules to use in the comparison.</param>
	/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   The substring in <paramref name="strA" /> precedes the substring in <paramref name="strB" /> in the sort order.  
	///
	///   Zero  
	///
	///   The substrings occur in the same position in the sort order, or the <paramref name="length" /> parameter is zero.  
	///
	///   Greater than zero  
	///
	///   The substring in <paramref name="strA" /> follllows the substring in <paramref name="strB" /> in the sort order.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.  
	/// -or-  
	/// <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.  
	/// -or-  
	/// <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative.  
	/// -or-  
	/// Either <paramref name="indexA" /> or <paramref name="indexB" /> is <see langword="null" />, and <paramref name="length" /> is greater than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
	{
		return 0;
	}

	/// <summary>Compares two specified <see cref="T:System.String" /> objects by evaluating the numeric values of the corresponding <see cref="T:System.Char" /> objects in each string.</summary>
	/// <param name="strA">The first string to compare.</param>
	/// <param name="strB">The second string to compare.</param>
	/// <returns>An integer that indicates the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///  <paramref name="strA" /> is less than <paramref name="strB" />.  
	///
	///   Zero  
	///
	///  <paramref name="strA" /> and <paramref name="strB" /> are equal.  
	///
	///   Greater than zero  
	///
	///  <paramref name="strA" /> is greater than <paramref name="strB" />.</returns>
	public static int CompareOrdinal(string strA, string strB)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
	{
		return 0;
	}

	/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects by evaluating the numeric values of the corresponding <see cref="T:System.Char" /> objects in each substring.</summary>
	/// <param name="strA">The first string to use in the comparison.</param>
	/// <param name="indexA">The starting index of the substring in <paramref name="strA" />.</param>
	/// <param name="strB">The second string to use in the comparison.</param>
	/// <param name="indexB">The starting index of the substring in <paramref name="strB" />.</param>
	/// <param name="length">The maximum number of characters in the substrings to compare.</param>
	/// <returns>A 32-bit signed integer that indicates the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   The substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />.  
	///
	///   Zero  
	///
	///   The substrings are equal, or <paramref name="length" /> is zero.  
	///
	///   Greater than zero  
	///
	///   The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="strA" /> is not <see langword="null" /> and <paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.  
	/// -or-  
	/// <paramref name="strB" /> is not <see langword="null" /> and <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.  
	/// -or-  
	/// <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative.</exception>
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
	{
		return 0;
	}

	/// <summary>Compares this instance with a specified <see cref="T:System.Object" /> and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Object" />.</summary>
	/// <param name="value">An object that evaluates to a <see cref="T:System.String" />.</param>
	/// <returns>A 32-bit signed integer that indicates whether this instance precedes, follows, or appears in the same position in the sort order as the <paramref name="value" /> parameter.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance precedes <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance has the same position in the sort order as <paramref name="value" />.  
	///
	///   Greater than zero  
	///
	///   This instance follows <paramref name="value" />.  
	///
	///  -or-  
	///
	///  <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is not a <see cref="T:System.String" />.</exception>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this instance with a specified <see cref="T:System.String" /> object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified string.</summary>
	/// <param name="strB">The string to compare with this instance.</param>
	/// <returns>A 32-bit signed integer that indicates whether this instance precedes, follows, or appears in the same position in the sort order as the <paramref name="strB" /> parameter.  
	///   Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance precedes <paramref name="strB" />.  
	///
	///   Zero  
	///
	///   This instance has the same position in the sort order as <paramref name="strB" />.  
	///
	///   Greater than zero  
	///
	///   This instance follows <paramref name="strB" />.  
	///
	///  -or-  
	///
	///  <paramref name="strB" /> is <see langword="null" />.</returns>
	public int CompareTo(string strB)
	{
		return 0;
	}

	/// <summary>Determines whether the end of this string instance matches the specified string.</summary>
	/// <param name="value">The string to compare to the substring at the end of this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> matches the end of this instance; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	public bool EndsWith(string value)
	{
		return false;
	}

	/// <summary>Determines whether the end of this string instance matches the specified string when compared using the specified comparison option.</summary>
	/// <param name="value">The string to compare to the substring at the end of this instance.</param>
	/// <param name="comparisonType">One of the enumeration values that determines how this string and <paramref name="value" /> are compared.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="value" /> parameter matches the end of this string; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
	public bool EndsWith(string value, StringComparison comparisonType)
	{
		return false;
	}

	public bool EndsWith(char value)
	{
		return false;
	}

	/// <summary>Determines whether this instance and a specified object, which must also be a <see cref="T:System.String" /> object, have the same value.</summary>
	/// <param name="obj">The string to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.String" /> and its value is the same as this instance; otherwise, <see langword="false" />.  If <paramref name="obj" /> is <see langword="null" />, the method returns <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Determines whether this instance and another specified <see cref="T:System.String" /> object have the same value.</summary>
	/// <param name="value">The string to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the value of the <paramref name="value" /> parameter is the same as the value of this instance; otherwise, <see langword="false" />. If <paramref name="value" /> is <see langword="null" />, the method returns <see langword="false" />.</returns>
	public bool Equals(string value)
	{
		return false;
	}

	/// <summary>Determines whether this string and a specified <see cref="T:System.String" /> object have the same value. A parameter specifies the culture, case, and sort rules used in the comparison.</summary>
	/// <param name="value">The string to compare to this instance.</param>
	/// <param name="comparisonType">One of the enumeration values that specifies how the strings will be compared.</param>
	/// <returns>
	///   <see langword="true" /> if the value of the <paramref name="value" /> parameter is the same as this string; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
	public bool Equals(string value, StringComparison comparisonType)
	{
		return false;
	}

	/// <summary>Determines whether two specified <see cref="T:System.String" /> objects have the same value.</summary>
	/// <param name="a">The first string to compare, or <see langword="null" />.</param>
	/// <param name="b">The second string to compare, or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if the value of <paramref name="a" /> is the same as the value of <paramref name="b" />; otherwise, <see langword="false" />. If both <paramref name="a" /> and <paramref name="b" /> are <see langword="null" />, the method returns <see langword="true" />.</returns>
	public static bool Equals(string a, string b)
	{
		return false;
	}

	/// <summary>Determines whether two specified <see cref="T:System.String" /> objects have the same value. A parameter specifies the culture, case, and sort rules used in the comparison.</summary>
	/// <param name="a">The first string to compare, or <see langword="null" />.</param>
	/// <param name="b">The second string to compare, or <see langword="null" />.</param>
	/// <param name="comparisonType">One of the enumeration values that specifies the rules for the comparison.</param>
	/// <returns>
	///   <see langword="true" /> if the value of the <paramref name="a" /> parameter is equal to the value of the <paramref name="b" /> parameter; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
	public static bool Equals(string a, string b, StringComparison comparisonType)
	{
		return false;
	}

	/// <summary>Determines whether two specified strings have the same value.</summary>
	/// <param name="a">The first string to compare, or <see langword="null" />.</param>
	/// <param name="b">The second string to compare, or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if the value of <paramref name="a" /> is the same as the value of <paramref name="b" />; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(string a, string b)
	{
		return false;
	}

	/// <summary>Determines whether two specified strings have different values.</summary>
	/// <param name="a">The first string to compare, or <see langword="null" />.</param>
	/// <param name="b">The second string to compare, or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if the value of <paramref name="a" /> is different from the value of <paramref name="b" />; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(string a, string b)
	{
		return false;
	}

	/// <summary>Returns the hash code for this string.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	internal int GetLegacyNonRandomizedHashCode()
	{
		return 0;
	}

	/// <summary>Determines whether the beginning of this string instance matches the specified string.</summary>
	/// <param name="value">The string to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> matches the beginning of this string; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	public bool StartsWith(string value)
	{
		return false;
	}

	/// <summary>Determines whether the beginning of this string instance matches the specified string when compared using the specified comparison option.</summary>
	/// <param name="value">The string to compare.</param>
	/// <param name="comparisonType">One of the enumeration values that determines how this string and <paramref name="value" /> are compared.</param>
	/// <returns>
	///   <see langword="true" /> if this instance begins with <paramref name="value" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
	public bool StartsWith(string value, StringComparison comparisonType)
	{
		return false;
	}

	internal static void CheckStringComparison(StringComparison comparisonType)
	{
	}

	private static void FillStringChecked(string dest, int destPos, string src)
	{
	}

	/// <summary>Concatenates the string representations of two specified objects.</summary>
	/// <param name="arg0">The first object to concatenate.</param>
	/// <param name="arg1">The second object to concatenate.</param>
	/// <returns>The concatenated string representations of the values of <paramref name="arg0" /> and <paramref name="arg1" />.</returns>
	public static string Concat(object arg0, object arg1)
	{
		return null;
	}

	/// <summary>Concatenates the string representations of three specified objects.</summary>
	/// <param name="arg0">The first object to concatenate.</param>
	/// <param name="arg1">The second object to concatenate.</param>
	/// <param name="arg2">The third object to concatenate.</param>
	/// <returns>The concatenated string representations of the values of <paramref name="arg0" />, <paramref name="arg1" />, and <paramref name="arg2" />.</returns>
	public static string Concat(object arg0, object arg1, object arg2)
	{
		return null;
	}

	/// <summary>Concatenates the string representations of the elements in a specified <see cref="T:System.Object" /> array.</summary>
	/// <param name="args">An object array that contains the elements to concatenate.</param>
	/// <returns>The concatenated string representations of the values of the elements in <paramref name="args" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="args" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
	public static string Concat(params object[] args)
	{
		return null;
	}

	/// <summary>Concatenates two specified instances of <see cref="T:System.String" />.</summary>
	/// <param name="str0">The first string to concatenate.</param>
	/// <param name="str1">The second string to concatenate.</param>
	/// <returns>The concatenation of <paramref name="str0" /> and <paramref name="str1" />.</returns>
	public static string Concat(string str0, string str1)
	{
		return null;
	}

	/// <summary>Concatenates three specified instances of <see cref="T:System.String" />.</summary>
	/// <param name="str0">The first string to concatenate.</param>
	/// <param name="str1">The second string to concatenate.</param>
	/// <param name="str2">The third string to concatenate.</param>
	/// <returns>The concatenation of <paramref name="str0" />, <paramref name="str1" />, and <paramref name="str2" />.</returns>
	public static string Concat(string str0, string str1, string str2)
	{
		return null;
	}

	/// <summary>Concatenates four specified instances of <see cref="T:System.String" />.</summary>
	/// <param name="str0">The first string to concatenate.</param>
	/// <param name="str1">The second string to concatenate.</param>
	/// <param name="str2">The third string to concatenate.</param>
	/// <param name="str3">The fourth string to concatenate.</param>
	/// <returns>The concatenation of <paramref name="str0" />, <paramref name="str1" />, <paramref name="str2" />, and <paramref name="str3" />.</returns>
	public static string Concat(string str0, string str1, string str2, string str3)
	{
		return null;
	}

	/// <summary>Concatenates the elements of a specified <see cref="T:System.String" /> array.</summary>
	/// <param name="values">An array of string instances.</param>
	/// <returns>The concatenated elements of <paramref name="values" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="values" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
	public static string Concat(params string[] values)
	{
		return null;
	}

	/// <summary>Replaces one or more format items in a string with the string representation of a specified object.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The object to format.</param>
	/// <returns>A copy of <paramref name="format" /> in which any format items are replaced by the string representation of <paramref name="arg0" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The format item in <paramref name="format" /> is invalid.  
	///  -or-  
	///  The index of a format item is not zero.</exception>
	public static string Format(string format, object arg0)
	{
		return null;
	}

	/// <summary>Replaces the format items in a string with the string representation of two specified objects.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The first object to format.</param>
	/// <param name="arg1">The second object to format.</param>
	/// <returns>A copy of <paramref name="format" /> in which format items are replaced by the string representations of <paramref name="arg0" /> and <paramref name="arg1" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is not zero or one.</exception>
	public static string Format(string format, object arg0, object arg1)
	{
		return null;
	}

	/// <summary>Replaces the format items in a string with the string representation of three specified objects.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The first object to format.</param>
	/// <param name="arg1">The second object to format.</param>
	/// <param name="arg2">The third object to format.</param>
	/// <returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representations of <paramref name="arg0" />, <paramref name="arg1" />, and <paramref name="arg2" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is less than zero, or greater than two.</exception>
	public static string Format(string format, object arg0, object arg1, object arg2)
	{
		return null;
	}

	/// <summary>Replaces the format item in a specified string with the string representation of a corresponding object in a specified array.</summary>
	/// <param name="format">A composite format string.</param>
	/// <param name="args">An object array that contains zero or more objects to format.</param>
	/// <returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representation of the corresponding objects in <paramref name="args" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> or <paramref name="args" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is less than zero, or greater than or equal to the length of the <paramref name="args" /> array.</exception>
	public static string Format(string format, params object[] args)
	{
		return null;
	}

	/// <summary>Replaces the format item or items in a specified string with the string representation of the corresponding object. A parameter supplies culture-specific formatting information.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The object to format.</param>
	/// <returns>A copy of <paramref name="format" /> in which the format item or items have been replaced by the string representation of <paramref name="arg0" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is not zero.</exception>
	public static string Format(IFormatProvider provider, string format, object arg0)
	{
		return null;
	}

	/// <summary>Replaces the format items in a string with the string representation of two specified objects. A parameter supplies culture-specific formatting information.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The first object to format.</param>
	/// <param name="arg1">The second object to format.</param>
	/// <returns>A copy of <paramref name="format" /> in which format items are replaced by the string representations of <paramref name="arg0" /> and <paramref name="arg1" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is not zero or one.</exception>
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1)
	{
		return null;
	}

	/// <summary>Replaces the format items in a string with the string representation of three specified objects. An parameter supplies culture-specific formatting information.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <param name="format">A composite format string.</param>
	/// <param name="arg0">The first object to format.</param>
	/// <param name="arg1">The second object to format.</param>
	/// <param name="arg2">The third object to format.</param>
	/// <returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representations of <paramref name="arg0" />, <paramref name="arg1" />, and <paramref name="arg2" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is less than zero, or greater than two.</exception>
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
	{
		return null;
	}

	/// <summary>Replaces the format items in a string with the string representations of corresponding objects in a specified array. A parameter supplies culture-specific formatting information.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <param name="format">A composite format string.</param>
	/// <param name="args">An object array that contains zero or more objects to format.</param>
	/// <returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representation of the corresponding objects in <paramref name="args" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> or <paramref name="args" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.  
	/// -or-  
	/// The index of a format item is less than zero, or greater than or equal to the length of the <paramref name="args" /> array.</exception>
	public static string Format(IFormatProvider provider, string format, params object[] args)
	{
		return null;
	}

	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args)
	{
		return null;
	}

	/// <summary>Returns a new string in which a specified string is inserted at a specified index position in this instance.</summary>
	/// <param name="startIndex">The zero-based index position of the insertion.</param>
	/// <param name="value">The string to insert.</param>
	/// <returns>A new string that is equivalent to this instance, but with <paramref name="value" /> inserted at position <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is negative or greater than the length of this instance.</exception>
	public string Insert(int startIndex, string value)
	{
		return null;
	}

	/// <summary>Concatenates all the elements of a string array, using the specified separator between each element.</summary>
	/// <param name="separator">The string to use as a separator. <paramref name="separator" /> is included in the returned string only if <paramref name="value" /> has more than one element.</param>
	/// <param name="value">An array that contains the elements to concatenate.</param>
	/// <returns>A string that consists of the elements in <paramref name="value" /> delimited by the <paramref name="separator" /> string. If <paramref name="value" /> is an empty array, the method returns <see cref="F:System.String.Empty" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	public static string Join(string separator, params string[] value)
	{
		return null;
	}

	/// <summary>Concatenates the members of a collection, using the specified separator between each member.</summary>
	/// <param name="separator">The string to use as a separator.<paramref name="separator" /> is included in the returned string only if <paramref name="values" /> has more than one element.</param>
	/// <param name="values">A collection that contains the objects to concatenate.</param>
	/// <typeparam name="T">The type of the members of <paramref name="values" />.</typeparam>
	/// <returns>A string that consists of the members of <paramref name="values" /> delimited by the <paramref name="separator" /> string. If <paramref name="values" /> has no members, the method returns <see cref="F:System.String.Empty" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="values" /> is <see langword="null" />.</exception>
	public static string Join<T>(string separator, IEnumerable<T> values)
	{
		return null;
	}

	/// <summary>Concatenates the members of a constructed <see cref="T:System.Collections.Generic.IEnumerable`1" /> collection of type <see cref="T:System.String" />, using the specified separator between each member.</summary>
	/// <param name="separator">The string to use as a separator.<paramref name="separator" /> is included in the returned string only if <paramref name="values" /> has more than one element.</param>
	/// <param name="values">A collection that contains the strings to concatenate.</param>
	/// <returns>A string that consists of the members of <paramref name="values" /> delimited by the <paramref name="separator" /> string. If <paramref name="values" /> has no members, the method returns <see cref="F:System.String.Empty" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="values" /> is <see langword="null" />.</exception>
	public static string Join(string separator, IEnumerable<string> values)
	{
		return null;
	}

	/// <summary>Concatenates the specified elements of a string array, using the specified separator between each element.</summary>
	/// <param name="separator">The string to use as a separator. <paramref name="separator" /> is included in the returned string only if <paramref name="value" /> has more than one element.</param>
	/// <param name="value">An array that contains the elements to concatenate.</param>
	/// <param name="startIndex">The first element in <paramref name="value" /> to use.</param>
	/// <param name="count">The number of elements of <paramref name="value" /> to use.</param>
	/// <returns>A string that consists of the strings in <paramref name="value" /> delimited by the <paramref name="separator" /> string.  
	///  -or-  
	///  <see cref="F:System.String.Empty" /> if <paramref name="count" /> is zero, <paramref name="value" /> has no elements, or <paramref name="separator" /> and all the elements of <paramref name="value" /> are <see cref="F:System.String.Empty" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> or <paramref name="count" /> is less than 0.  
	/// -or-  
	/// <paramref name="startIndex" /> plus <paramref name="count" /> is greater than the number of elements in <paramref name="value" />.</exception>
	/// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
	public static string Join(string separator, string[] value, int startIndex, int count)
	{
		return null;
	}

	private unsafe static string JoinCore<T>(char* separator, int separatorLength, IEnumerable<T> values)
	{
		return null;
	}

	private unsafe static string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count)
	{
		return null;
	}

	/// <summary>Returns a new string that right-aligns the characters in this instance by padding them with spaces on the left, for a specified total length.</summary>
	/// <param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters.</param>
	/// <returns>A new string that is equivalent to this instance, but right-aligned and padded on the left with as many spaces as needed to create a length of <paramref name="totalWidth" />. However, if <paramref name="totalWidth" /> is less than the length of this instance, the method returns a reference to the existing instance. If <paramref name="totalWidth" /> is equal to the length of this instance, the method returns a new string that is identical to this instance.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="totalWidth" /> is less than zero.</exception>
	public string PadLeft(int totalWidth)
	{
		return null;
	}

	/// <summary>Returns a new string that right-aligns the characters in this instance by padding them on the left with a specified Unicode character, for a specified total length.</summary>
	/// <param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters.</param>
	/// <param name="paddingChar">A Unicode padding character.</param>
	/// <returns>A new string that is equivalent to this instance, but right-aligned and padded on the left with as many <paramref name="paddingChar" /> characters as needed to create a length of <paramref name="totalWidth" />. However, if <paramref name="totalWidth" /> is less than the length of this instance, the method returns a reference to the existing instance. If <paramref name="totalWidth" /> is equal to the length of this instance, the method returns a new string that is identical to this instance.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="totalWidth" /> is less than zero.</exception>
	public string PadLeft(int totalWidth, char paddingChar)
	{
		return null;
	}

	/// <summary>Returns a new string that left-aligns the characters in this string by padding them with spaces on the right, for a specified total length.</summary>
	/// <param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters.</param>
	/// <returns>A new string that is equivalent to this instance, but left-aligned and padded on the right with as many spaces as needed to create a length of <paramref name="totalWidth" />. However, if <paramref name="totalWidth" /> is less than the length of this instance, the method returns a reference to the existing instance. If <paramref name="totalWidth" /> is equal to the length of this instance, the method returns a new string that is identical to this instance.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="totalWidth" /> is less than zero.</exception>
	public string PadRight(int totalWidth)
	{
		return null;
	}

	/// <summary>Returns a new string that left-aligns the characters in this string by padding them on the right with a specified Unicode character, for a specified total length.</summary>
	/// <param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters.</param>
	/// <param name="paddingChar">A Unicode padding character.</param>
	/// <returns>A new string that is equivalent to this instance, but left-aligned and padded on the right with as many <paramref name="paddingChar" /> characters as needed to create a length of <paramref name="totalWidth" />. However, if <paramref name="totalWidth" /> is less than the length of this instance, the method returns a reference to the existing instance. If <paramref name="totalWidth" /> is equal to the length of this instance, the method returns a new string that is identical to this instance.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="totalWidth" /> is less than zero.</exception>
	public string PadRight(int totalWidth, char paddingChar)
	{
		return null;
	}

	/// <summary>Returns a new string in which a specified number of characters in the current instance beginning at a specified position have been deleted.</summary>
	/// <param name="startIndex">The zero-based position to begin deleting characters.</param>
	/// <param name="count">The number of characters to delete.</param>
	/// <returns>A new string that is equivalent to this instance except for the removed characters.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Either <paramref name="startIndex" /> or <paramref name="count" /> is less than zero.  
	///  -or-  
	///  <paramref name="startIndex" /> plus <paramref name="count" /> specify a position outside this instance.</exception>
	public string Remove(int startIndex, int count)
	{
		return null;
	}

	/// <summary>Returns a new string in which all the characters in the current instance, beginning at a specified position and continuing through the last position, have been deleted.</summary>
	/// <param name="startIndex">The zero-based position to begin deleting characters.</param>
	/// <returns>A new string that is equivalent to this string except for the removed characters.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> specifies a position that is not within this string.</exception>
	public string Remove(int startIndex)
	{
		return null;
	}

	/// <summary>Returns a new string in which all occurrences of a specified Unicode character in this instance are replaced with another specified Unicode character.</summary>
	/// <param name="oldChar">The Unicode character to be replaced.</param>
	/// <param name="newChar">The Unicode character to replace all occurrences of <paramref name="oldChar" />.</param>
	/// <returns>A string that is equivalent to this instance except that all instances of <paramref name="oldChar" /> are replaced with <paramref name="newChar" />. If <paramref name="oldChar" /> is not found in the current instance, the method returns the current instance unchanged.</returns>
	public string Replace(char oldChar, char newChar)
	{
		return null;
	}

	/// <summary>Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.</summary>
	/// <param name="oldValue">The string to be replaced.</param>
	/// <param name="newValue">The string to replace all occurrences of <paramref name="oldValue" />.</param>
	/// <returns>A string that is equivalent to the current string except that all instances of <paramref name="oldValue" /> are replaced with <paramref name="newValue" />. If <paramref name="oldValue" /> is not found in the current instance, the method returns the current instance unchanged.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="oldValue" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="oldValue" /> is the empty string ("").</exception>
	public string Replace(string oldValue, string newValue)
	{
		return null;
	}

	private string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices)
	{
		return null;
	}

	public string[] Split(char separator, StringSplitOptions options = StringSplitOptions.None)
	{
		return null;
	}

	/// <summary>Splits a string into substrings that are based on the characters in an array.</summary>
	/// <param name="separator">A character array that delimits the substrings in this string, an empty array that contains no delimiters, or <see langword="null" />.</param>
	/// <returns>An array whose elements contain the substrings from this instance that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns>
	public string[] Split(params char[] separator)
	{
		return null;
	}

	/// <summary>Splits a string into a maximum number of substrings based on the characters in an array. You also specify the maximum number of substrings to return.</summary>
	/// <param name="separator">A character array that delimits the substrings in this string, an empty array that contains no delimiters, or <see langword="null" />.</param>
	/// <param name="count">The maximum number of substrings to return.</param>
	/// <returns>An array whose elements contain the substrings in this instance that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is negative.</exception>
	public string[] Split(char[] separator, int count)
	{
		return null;
	}

	/// <summary>Splits a string into substrings based on the characters in an array. You can specify whether the substrings include empty array elements.</summary>
	/// <param name="separator">A character array that delimits the substrings in this string, an empty array that contains no delimiters, or <see langword="null" />.</param>
	/// <param name="options">
	///   <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned; or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned.</param>
	/// <returns>An array whose elements contain the substrings in this string that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception>
	public string[] Split(char[] separator, StringSplitOptions options)
	{
		return null;
	}

	private string[] SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options)
	{
		return null;
	}

	/// <summary>Splits a string into substrings based on the strings in an array. You can specify whether the substrings include empty array elements.</summary>
	/// <param name="separator">A string array that delimits the substrings in this string, an empty array that contains no delimiters, or <see langword="null" />.</param>
	/// <param name="options">
	///   <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned; or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned.</param>
	/// <returns>An array whose elements contain the substrings in this string that are delimited by one or more strings in <paramref name="separator" />. For more information, see the Remarks section.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception>
	public string[] Split(string[] separator, StringSplitOptions options)
	{
		return null;
	}

	private string[] SplitInternal(string separator, string[] separators, int count, StringSplitOptions options)
	{
		return null;
	}

	private string[] SplitInternal(string separator, int count, StringSplitOptions options)
	{
		return null;
	}

	private string[] SplitKeepEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
	{
		return null;
	}

	private string[] SplitOmitEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
	{
		return null;
	}

	private void MakeSeparatorList(ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder)
	{
	}

	private void MakeSeparatorList(string separator, ref ValueListBuilder<int> sepListBuilder)
	{
	}

	private void MakeSeparatorList(string[] separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder)
	{
	}

	/// <summary>Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.</summary>
	/// <param name="startIndex">The zero-based starting character position of a substring in this instance.</param>
	/// <returns>A string that is equivalent to the substring that begins at <paramref name="startIndex" /> in this instance, or <see cref="F:System.String.Empty" /> if <paramref name="startIndex" /> is equal to the length of this instance.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than zero or greater than the length of this instance.</exception>
	public string Substring(int startIndex)
	{
		return null;
	}

	/// <summary>Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.</summary>
	/// <param name="startIndex">The zero-based starting character position of a substring in this instance.</param>
	/// <param name="length">The number of characters in the substring.</param>
	/// <returns>A string that is equivalent to the substring of length <paramref name="length" /> that begins at <paramref name="startIndex" /> in this instance, or <see cref="F:System.String.Empty" /> if <paramref name="startIndex" /> is equal to the length of this instance and <paramref name="length" /> is zero.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> plus <paramref name="length" /> indicates a position not within this instance.  
	/// -or-  
	/// <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.</exception>
	public string Substring(int startIndex, int length)
	{
		return null;
	}

	private string InternalSubString(int startIndex, int length)
	{
		return null;
	}

	/// <summary>Returns a copy of this string converted to lowercase.</summary>
	/// <returns>A string in lowercase.</returns>
	public string ToLower()
	{
		return null;
	}

	/// <summary>Returns a copy of this string converted to lowercase, using the casing rules of the specified culture.</summary>
	/// <param name="culture">An object that supplies culture-specific casing rules.</param>
	/// <returns>The lowercase equivalent of the current string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="culture" /> is <see langword="null" />.</exception>
	public string ToLower(CultureInfo culture)
	{
		return null;
	}

	/// <summary>Returns a copy of this <see cref="T:System.String" /> object converted to lowercase using the casing rules of the invariant culture.</summary>
	/// <returns>The lowercase equivalent of the current string.</returns>
	public string ToLowerInvariant()
	{
		return null;
	}

	/// <summary>Returns a copy of this string converted to uppercase.</summary>
	/// <returns>The uppercase equivalent of the current string.</returns>
	public string ToUpper()
	{
		return null;
	}

	/// <summary>Returns a copy of this string converted to uppercase, using the casing rules of the specified culture.</summary>
	/// <param name="culture">An object that supplies culture-specific casing rules.</param>
	/// <returns>The uppercase equivalent of the current string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="culture" /> is <see langword="null" />.</exception>
	public string ToUpper(CultureInfo culture)
	{
		return null;
	}

	/// <summary>Returns a copy of this <see cref="T:System.String" /> object converted to uppercase using the casing rules of the invariant culture.</summary>
	/// <returns>The uppercase equivalent of the current string.</returns>
	public string ToUpperInvariant()
	{
		return null;
	}

	/// <summary>Removes all leading and trailing white-space characters from the current <see cref="T:System.String" /> object.</summary>
	/// <returns>The string that remains after all white-space characters are removed from the start and end of the current string. If no characters can be trimmed from the current instance, the method returns the current instance unchanged.</returns>
	public string Trim()
	{
		return null;
	}

	public string Trim(char trimChar)
	{
		return null;
	}

	/// <summary>Removes all leading and trailing occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary>
	/// <param name="trimChars">An array of Unicode characters to remove, or <see langword="null" />.</param>
	/// <returns>The string that remains after all occurrences of the characters in the <paramref name="trimChars" /> parameter are removed from the start and end of the current string. If <paramref name="trimChars" /> is <see langword="null" /> or an empty array, white-space characters are removed instead. If no characters can be trimmed from the current instance, the method returns the current instance unchanged.</returns>
	public string Trim(params char[] trimChars)
	{
		return null;
	}

	public string TrimStart()
	{
		return null;
	}

	public string TrimStart(char trimChar)
	{
		return null;
	}

	/// <summary>Removes all leading occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary>
	/// <param name="trimChars">An array of Unicode characters to remove, or <see langword="null" />.</param>
	/// <returns>The string that remains after all occurrences of characters in the <paramref name="trimChars" /> parameter are removed from the start of the current string. If <paramref name="trimChars" /> is <see langword="null" /> or an empty array, white-space characters are removed instead.</returns>
	public string TrimStart(params char[] trimChars)
	{
		return null;
	}

	public string TrimEnd()
	{
		return null;
	}

	public string TrimEnd(char trimChar)
	{
		return null;
	}

	/// <summary>Removes all trailing occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary>
	/// <param name="trimChars">An array of Unicode characters to remove, or <see langword="null" />.</param>
	/// <returns>The string that remains after all occurrences of the characters in the <paramref name="trimChars" /> parameter are removed from the end of the current string. If <paramref name="trimChars" /> is <see langword="null" /> or an empty array, Unicode white-space characters are removed instead. If no characters can be trimmed from the current instance, the method returns the current instance unchanged.</returns>
	public string TrimEnd(params char[] trimChars)
	{
		return null;
	}

	private string TrimWhiteSpaceHelper(TrimType trimType)
	{
		return null;
	}

	private unsafe string TrimHelper(char* trimChars, int trimCharsLength, TrimType trimType)
	{
		return null;
	}

	private string CreateTrimmedString(int start, int end)
	{
		return null;
	}

	/// <summary>Returns a value indicating whether a specified substring occurs within this string.</summary>
	/// <param name="value">The string to seek.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="value" /> parameter occurs within this string, or if <paramref name="value" /> is the empty string (""); otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	public bool Contains(string value)
	{
		return false;
	}

	public bool Contains(string value, StringComparison comparisonType)
	{
		return false;
	}

	public bool Contains(char value)
	{
		return false;
	}

	/// <summary>Reports the zero-based index of the first occurrence of the specified Unicode character in this string.</summary>
	/// <param name="value">A Unicode character to seek.</param>
	/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns>
	public int IndexOf(char value)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index of the first occurrence of the specified Unicode character in this string. The search starts at a specified character position.</summary>
	/// <param name="value">A Unicode character to seek.</param>
	/// <param name="startIndex">The search starting position.</param>
	/// <returns>The zero-based index position of <paramref name="value" /> from the start of the string if that character is found, or -1 if it is not.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than 0 (zero) or greater than the length of the string.</exception>
	public int IndexOf(char value, int startIndex)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index of the first occurrence of the specified character in this instance. The search starts at a specified character position and examines a specified number of character positions.</summary>
	/// <param name="value">A Unicode character to seek.</param>
	/// <param name="startIndex">The search starting position.</param>
	/// <param name="count">The number of character positions to examine.</param>
	/// <returns>The zero-based index position of <paramref name="value" /> from the start of the string if that character is found, or -1 if it is not.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> or <paramref name="startIndex" /> is negative.  
	/// -or-  
	/// <paramref name="startIndex" /> is greater than the length of this string.  
	/// -or-  
	/// <paramref name="count" /> is greater than the length of this string minus <paramref name="startIndex" />.</exception>
	public int IndexOf(char value, int startIndex, int count)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters.</summary>
	/// <param name="anyOf">A Unicode character array containing one or more characters to seek.</param>
	/// <returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="anyOf" /> is <see langword="null" />.</exception>
	public int IndexOfAny(char[] anyOf)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters. The search starts at a specified character position.</summary>
	/// <param name="anyOf">A Unicode character array containing one or more characters to seek.</param>
	/// <param name="startIndex">The search starting position.</param>
	/// <returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="anyOf" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is negative.  
	/// -or-  
	/// <paramref name="startIndex" /> is greater than the number of characters in this instance.</exception>
	public int IndexOfAny(char[] anyOf, int startIndex)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters. The search starts at a specified character position and examines a specified number of character positions.</summary>
	/// <param name="anyOf">A Unicode character array containing one or more characters to seek.</param>
	/// <param name="startIndex">The search starting position.</param>
	/// <param name="count">The number of character positions to examine.</param>
	/// <returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="anyOf" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> or <paramref name="startIndex" /> is negative.  
	/// -or-  
	/// <paramref name="count" /> + <paramref name="startIndex" /> is greater than the number of characters in this instance.</exception>
	public int IndexOfAny(char[] anyOf, int startIndex, int count)
	{
		return 0;
	}

	private int IndexOfAny(char value1, char value2, int startIndex, int count)
	{
		return 0;
	}

	private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count)
	{
		return 0;
	}

	private int IndexOfCharArray(char[] anyOf, int startIndex, int count)
	{
		return 0;
	}

	private unsafe static void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan<char> anyOf)
	{
	}

	private static bool ArrayContains(char searchChar, char[] anyOf)
	{
		return false;
	}

	private unsafe static bool IsCharBitSet(uint* charMap, byte value)
	{
		return false;
	}

	private unsafe static void SetCharBit(uint* charMap, byte value)
	{
	}

	/// <summary>Reports the zero-based index of the first occurrence of the specified string in this instance.</summary>
	/// <param name="value">The string to seek.</param>
	/// <returns>The zero-based index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is 0.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	public int IndexOf(string value)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index of the first occurrence of the specified string in this instance. The search starts at a specified character position.</summary>
	/// <param name="value">The string to seek.</param>
	/// <param name="startIndex">The search starting position.</param>
	/// <returns>The zero-based index position of <paramref name="value" /> from the start of the current instance if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than 0 (zero) or greater than the length of this string.</exception>
	public int IndexOf(string value, int startIndex)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. A parameter specifies the type of search to use for the specified string.</summary>
	/// <param name="value">The string to seek.</param>
	/// <param name="comparisonType">One of the enumeration values that specifies the rules for the search.</param>
	/// <returns>The index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is 0.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
	public int IndexOf(string value, StringComparison comparisonType)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. Parameters specify the starting search position in the current string and the type of search to use for the specified string.</summary>
	/// <param name="value">The string to seek.</param>
	/// <param name="startIndex">The search starting position.</param>
	/// <param name="comparisonType">One of the enumeration values that specifies the rules for the search.</param>
	/// <returns>The zero-based index position of the <paramref name="value" /> parameter from the start of the current instance if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is less than 0 (zero) or greater than the length of this string.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
	public int IndexOf(string value, int startIndex, StringComparison comparisonType)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. Parameters specify the starting search position in the current string, the number of characters in the current string to search, and the type of search to use for the specified string.</summary>
	/// <param name="value">The string to seek.</param>
	/// <param name="startIndex">The search starting position.</param>
	/// <param name="count">The number of character positions to examine.</param>
	/// <param name="comparisonType">One of the enumeration values that specifies the rules for the search.</param>
	/// <returns>The zero-based index position of the <paramref name="value" /> parameter from the start of the current instance if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> or <paramref name="startIndex" /> is negative.  
	/// -or-  
	/// <paramref name="startIndex" /> is greater than the length of this instance.  
	/// -or-  
	/// <paramref name="count" /> is greater than the length of this string minus <paramref name="startIndex" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance.</summary>
	/// <param name="value">The Unicode character to seek.</param>
	/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns>
	public int LastIndexOf(char value)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index position of the last occurrence of a specified Unicode character within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string.</summary>
	/// <param name="value">The Unicode character to seek.</param>
	/// <param name="startIndex">The starting position of the search. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param>
	/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is less than zero or greater than or equal to the length of this instance.</exception>
	public int LastIndexOf(char value, int startIndex)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index position of the last occurrence of the specified Unicode character in a substring within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string for a specified number of character positions.</summary>
	/// <param name="value">The Unicode character to seek.</param>
	/// <param name="startIndex">The starting position of the search. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param>
	/// <param name="count">The number of character positions to examine.</param>
	/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is less than zero or greater than or equal to the length of this instance.  
	///  -or-  
	///  The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> - <paramref name="count" /> + 1 is less than zero.</exception>
	public int LastIndexOf(char value, int startIndex, int count)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array.</summary>
	/// <param name="anyOf">A Unicode character array containing one or more characters to seek.</param>
	/// <returns>The index position of the last occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="anyOf" /> is <see langword="null" />.</exception>
	public int LastIndexOfAny(char[] anyOf)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array. The search starts at a specified character position and proceeds backward toward the beginning of the string.</summary>
	/// <param name="anyOf">A Unicode character array containing one or more characters to seek.</param>
	/// <param name="startIndex">The search starting position. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param>
	/// <returns>The index position of the last occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found or if the current instance equals <see cref="F:System.String.Empty" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="anyOf" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> specifies a position that is not within this instance.</exception>
	public int LastIndexOfAny(char[] anyOf, int startIndex)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array. The search starts at a specified character position and proceeds backward toward the beginning of the string for a specified number of character positions.</summary>
	/// <param name="anyOf">A Unicode character array containing one or more characters to seek.</param>
	/// <param name="startIndex">The search starting position. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param>
	/// <param name="count">The number of character positions to examine.</param>
	/// <returns>The index position of the last occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found or if the current instance equals <see cref="F:System.String.Empty" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="anyOf" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="count" /> or <paramref name="startIndex" /> is negative.  
	///  -or-  
	///  The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> minus <paramref name="count" /> + 1 is less than zero.</exception>
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
	{
		return 0;
	}

	private int LastIndexOfCharArray(char[] anyOf, int startIndex, int count)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index position of the last occurrence of a specified string within this instance.</summary>
	/// <param name="value">The string to seek.</param>
	/// <returns>The zero-based starting index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the last index position in this instance.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	public int LastIndexOf(string value)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index of the last occurrence of a specified string within the current <see cref="T:System.String" /> object. A parameter specifies the type of search to use for the specified string.</summary>
	/// <param name="value">The string to seek.</param>
	/// <param name="comparisonType">One of the enumeration values that specifies the rules for the search.</param>
	/// <returns>The zero-based starting index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the last index position in this instance.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
	public int LastIndexOf(string value, StringComparison comparisonType)
	{
		return 0;
	}

	/// <summary>Reports the zero-based index position of the last occurrence of a specified string within this instance. The search starts at a specified character position and proceeds backward toward the beginning of the string for the specified number of character positions. A parameter specifies the type of comparison to perform when searching for the specified string.</summary>
	/// <param name="value">The string to seek.</param>
	/// <param name="startIndex">The search starting position. The search proceeds from <paramref name="startIndex" /> toward the beginning of this instance.</param>
	/// <param name="count">The number of character positions to examine.</param>
	/// <param name="comparisonType">One of the enumeration values that specifies the rules for the search.</param>
	/// <returns>The zero-based starting index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the smaller of <paramref name="startIndex" /> and the last index position in this instance.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is negative.  
	/// -or-  
	/// The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is negative.  
	/// -or-  
	/// The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> is greater than the length of this instance.  
	/// -or-  
	/// The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="startIndex" /> + 1 - <paramref name="count" /> specifies a position that is not within this instance.  
	/// -or-  
	/// The current instance equals <see cref="F:System.String.Empty" /> and <paramref name="start" /> is less than -1 or greater than zero.  
	/// -or-  
	/// The current instance equals <see cref="F:System.String.Empty" /> and <paramref name="count" /> is greater than 1.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
	{
		return 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by an array of Unicode characters.</summary>
	/// <param name="value">An array of Unicode characters.</param>
	public String(char[] value)
	{
	}

	private static string Ctor(char[] value)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by an array of Unicode characters, a starting character position within that array, and a length.</summary>
	/// <param name="value">An array of Unicode characters.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <param name="length">The number of characters within <paramref name="value" /> to use.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.  
	/// -or-  
	/// The sum of <paramref name="startIndex" /> and <paramref name="length" /> is greater than the number of elements in <paramref name="value" />.</exception>
	public String(char[] value, int startIndex, int length)
	{
	}

	private static string Ctor(char[] value, int startIndex, int length)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of Unicode characters.</summary>
	/// <param name="value">A pointer to a null-terminated array of Unicode characters.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The current process does not have read access to all the addressed characters.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> specifies an array that contains an invalid Unicode character, or <paramref name="value" /> specifies an address less than 64000.</exception>
	[CLSCompliant(false)]
	public unsafe String(char* value)
	{
	}

	private unsafe static string Ctor(char* ptr)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of Unicode characters, a starting character position within that array, and a length.</summary>
	/// <param name="value">A pointer to an array of Unicode characters.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <param name="length">The number of characters within <paramref name="value" /> to use.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero, <paramref name="value" /> + <paramref name="startIndex" /> cause a pointer overflow, or the current process does not have read access to all the addressed characters.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> specifies an array that contains an invalid Unicode character, or <paramref name="value" /> + <paramref name="startIndex" /> specifies an address less than 64000.</exception>
	[CLSCompliant(false)]
	public unsafe String(char* value, int startIndex, int length)
	{
	}

	private unsafe static string Ctor(char* ptr, int startIndex, int length)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of 8-bit signed integers, a starting position within that array, and a length.</summary>
	/// <param name="value">A pointer to an array of 8-bit signed integers. The integers are interpreted using the current system code page encoding (that is, the encoding specified by <see cref="P:System.Text.Encoding.Default" />).</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <param name="length">The number of characters within <paramref name="value" /> to use.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.  
	/// -or-  
	/// The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is too large for the current platform; that is, the address calculation overflowed.  
	/// -or-  
	/// The length of the new string to initialize is too large to allocate.</exception>
	/// <exception cref="T:System.ArgumentException">The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is less than 64K.  
	///  -or-  
	///  A new instance of <see cref="T:System.String" /> could not be initialized using <paramref name="value" />, assuming <paramref name="value" /> is encoded in ANSI.</exception>
	/// <exception cref="T:System.AccessViolationException">
	///   <paramref name="value" />, <paramref name="startIndex" />, and <paramref name="length" /> collectively specify an invalid address.</exception>
	[CLSCompliant(false)]
	public unsafe String(sbyte* value, int startIndex, int length)
	{
	}

	private unsafe static string Ctor(sbyte* value, int startIndex, int length)
	{
		return null;
	}

	private unsafe static string CreateStringForSByteConstructor(byte* pb, int numBytes)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of 8-bit signed integers, a starting position within that array, a length, and an <see cref="T:System.Text.Encoding" /> object.</summary>
	/// <param name="value">A pointer to an array of 8-bit signed integers.</param>
	/// <param name="startIndex">The starting position within <paramref name="value" />.</param>
	/// <param name="length">The number of characters within <paramref name="value" /> to use.</param>
	/// <param name="enc">An object that specifies how the array referenced by <paramref name="value" /> is encoded. If <paramref name="enc" /> is <see langword="null" />, ANSI encoding is assumed.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.  
	/// -or-  
	/// The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is too large for the current platform; that is, the address calculation overflowed.  
	/// -or-  
	/// The length of the new string to initialize is too large to allocate.</exception>
	/// <exception cref="T:System.ArgumentException">The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is less than 64K.  
	///  -or-  
	///  A new instance of <see cref="T:System.String" /> could not be initialized using <paramref name="value" />, assuming <paramref name="value" /> is encoded as specified by <paramref name="enc" />.</exception>
	/// <exception cref="T:System.AccessViolationException">
	///   <paramref name="value" />, <paramref name="startIndex" />, and <paramref name="length" /> collectively specify an invalid address.</exception>
	[CLSCompliant(false)]
	public unsafe String(sbyte* value, int startIndex, int length, Encoding enc)
	{
	}

	private unsafe static string Ctor(sbyte* value, int startIndex, int length, Encoding enc)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified Unicode character repeated a specified number of times.</summary>
	/// <param name="c">A Unicode character.</param>
	/// <param name="count">The number of times <paramref name="c" /> occurs.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is less than zero.</exception>
	public String(char c, int count)
	{
	}

	private static string Ctor(char c, int count)
	{
		return null;
	}

	public String(ReadOnlySpan<char> value)
	{
	}

	private static string Ctor(ReadOnlySpan<char> value)
	{
		return null;
	}

	public static string Create<TState>(int length, TState state, SpanAction<char, TState> action)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator ReadOnlySpan<char>(string value)
	{
		return default(ReadOnlySpan<char>);
	}

	/// <summary>Returns a reference to this instance of <see cref="T:System.String" />.</summary>
	/// <returns>This instance of <see cref="T:System.String" />.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Creates a new instance of <see cref="T:System.String" /> with the same value as a specified <see cref="T:System.String" />.</summary>
	/// <param name="str">The string to copy.</param>
	/// <returns>A new string with the same value as <paramref name="str" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="str" /> is <see langword="null" />.</exception>
	public static string Copy(string str)
	{
		return null;
	}

	/// <summary>Copies a specified number of characters from a specified position in this instance to a specified position in an array of Unicode characters.</summary>
	/// <param name="sourceIndex">The index of the first character in this instance to copy.</param>
	/// <param name="destination">An array of Unicode characters to which characters in this instance are copied.</param>
	/// <param name="destinationIndex">The index in <paramref name="destination" /> at which the copy operation begins.</param>
	/// <param name="count">The number of characters in this instance to copy to <paramref name="destination" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="destination" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="sourceIndex" />, <paramref name="destinationIndex" />, or <paramref name="count" /> is negative  
	/// -or-  
	/// <paramref name="sourceIndex" /> does not identify a position in the current instance.  
	/// -or-  
	/// <paramref name="destinationIndex" /> does not identify a valid index in the <paramref name="destination" /> array.  
	/// -or-  
	/// <paramref name="count" /> is greater than the length of the substring from <paramref name="sourceIndex" /> to the end of this instance  
	/// -or-  
	/// <paramref name="count" /> is greater than the length of the subarray from <paramref name="destinationIndex" /> to the end of the <paramref name="destination" /> array.</exception>
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
	{
	}

	/// <summary>Copies the characters in this instance to a Unicode character array.</summary>
	/// <returns>A Unicode character array whose elements are the individual characters of this instance. If this instance is an empty string, the returned array is empty and has a zero length.</returns>
	public char[] ToCharArray()
	{
		return null;
	}

	/// <summary>Copies the characters in a specified substring in this instance to a Unicode character array.</summary>
	/// <param name="startIndex">The starting position of a substring in this instance.</param>
	/// <param name="length">The length of the substring in this instance.</param>
	/// <returns>A Unicode character array whose elements are the <paramref name="length" /> number of characters in this instance starting from character position <paramref name="startIndex" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> plus <paramref name="length" /> is greater than the length of this instance.</exception>
	public char[] ToCharArray(int startIndex, int length)
	{
		return null;
	}

	/// <summary>Indicates whether the specified string is <see langword="null" /> or an empty string ("").</summary>
	/// <param name="value">The string to test.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="value" /> parameter is <see langword="null" /> or an empty string (""); otherwise, <see langword="false" />.</returns>
	[NonVersionable]
	public static bool IsNullOrEmpty(string value)
	{
		return false;
	}

	/// <summary>Indicates whether a specified string is <see langword="null" />, empty, or consists only of white-space characters.</summary>
	/// <param name="value">The string to test.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="value" /> parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />, or if <paramref name="value" /> consists exclusively of white-space characters.</returns>
	public static bool IsNullOrWhiteSpace(string value)
	{
		return false;
	}

	internal ref char GetRawStringData()
	{
		throw null;
	}

	internal unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding)
	{
		return null;
	}

	internal static string CreateFromChar(char c)
	{
		return null;
	}

	internal unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
	{
	}

	/// <summary>Returns this instance of <see cref="T:System.String" />; no actual conversion is performed.</summary>
	/// <returns>The current string.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Returns this instance of <see cref="T:System.String" />; no actual conversion is performed.</summary>
	/// <param name="provider">(Reserved) An object that supplies culture-specific formatting information.</param>
	/// <returns>The current string.</returns>
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Returns an enumerator that iterates through the current <see cref="T:System.String" /> object. </summary>
	/// <returns>A strongly-typed enumerator that can be used to iterate through the current <see cref="T:System.String" /> object. </returns>
	IEnumerator<char> IEnumerable<char>.GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an enumerator that iterates through the current <see cref="T:System.String" /> object.</summary>
	/// <returns>An enumerator that can be used to iterate through the current string.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	internal unsafe static int wcslen(char* ptr)
	{
		return 0;
	}

	/// <summary>Returns the <see cref="T:System.TypeCode" /> for class <see cref="T:System.String" />.</summary>
	/// <returns>The enumerated constant, <see cref="F:System.TypeCode.String" />.</returns>
	public TypeCode GetTypeCode()
	{
		return default(TypeCode);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>
	///   <see langword="true" /> if the value of the current string is <see cref="F:System.Boolean.TrueString" />; <see langword="false" /> if the value of the current string is <see cref="F:System.Boolean.FalseString" />.</returns>
	/// <exception cref="T:System.FormatException">The value of the current string is not <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</exception>
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The character at index 0 in the current <see cref="T:System.String" /> object.</returns>
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed.</exception>
	/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />.</exception>
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed.</exception>
	/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />.</exception>
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed.</exception>
	/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />.</exception>
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed.</exception>
	/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.UInt16.MaxValue" /> or less than <see cref="F:System.UInt16.MinValue" />.</exception>
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed.</exception>
	/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater <see cref="F:System.UInt32.MaxValue" /> or less than <see cref="F:System.UInt32.MinValue" /></exception>
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed.</exception>
	/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />.</exception>
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed.</exception>
	/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number less than <see cref="F:System.Decimal.MinValue" /> or than <see cref="F:System.Decimal.MaxValue" /> greater.</exception>
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDateTime(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
	/// <param name="type">The type of the returned object.</param>
	/// <param name="provider">An object that provides culture-specific formatting information.</param>
	/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The value of the current <see cref="T:System.String" /> object cannot be converted to the type specified by the <paramref name="type" /> parameter.</exception>
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Returns a new string whose textual value is the same as this string, but whose binary representation is in the specified Unicode normalization form.</summary>
	/// <param name="normalizationForm">A Unicode normalization form.</param>
	/// <returns>A new string whose textual value is the same as this string, but whose binary representation is in the normalization form specified by the <paramref name="normalizationForm" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentException">The current instance contains invalid Unicode characters.</exception>
	public string Normalize(NormalizationForm normalizationForm)
	{
		return null;
	}

	internal int IndexOfUnchecked(string value, int startIndex, int count)
	{
		return 0;
	}

	internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
	{
		return 0;
	}

	internal int LastIndexOfUnchecked(string value, int startIndex, int count)
	{
		return 0;
	}

	internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
	{
		return 0;
	}

	internal bool StartsWithOrdinalUnchecked(string value)
	{
		return false;
	}

	internal static string FastAllocateString(int length)
	{
		return null;
	}

	private static string InternalIntern(string str)
	{
		return null;
	}

	private unsafe static void memset(byte* dest, int val, int len)
	{
	}

	private unsafe static void memcpy(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void bzero(byte* dest, int len)
	{
	}

	internal unsafe static void bzero_aligned_1(byte* dest, int len)
	{
	}

	internal unsafe static void bzero_aligned_2(byte* dest, int len)
	{
	}

	internal unsafe static void bzero_aligned_4(byte* dest, int len)
	{
	}

	internal unsafe static void bzero_aligned_8(byte* dest, int len)
	{
	}

	internal unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
	{
	}

	internal unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
	{
	}

	private unsafe string CreateString(sbyte* value, int startIndex, int length)
	{
		return null;
	}

	private unsafe string CreateString(char* value)
	{
		return null;
	}

	private unsafe string CreateString(char* value, int startIndex, int length)
	{
		return null;
	}

	private string CreateString(char[] val, int startIndex, int length)
	{
		return null;
	}

	private string CreateString(char[] val)
	{
		return null;
	}

	private string CreateString(char c, int count)
	{
		return null;
	}

	private unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc)
	{
		return null;
	}

	private string CreateString(ReadOnlySpan<char> value)
	{
		return null;
	}

	/// <summary>Retrieves the system's reference to the specified <see cref="T:System.String" />.</summary>
	/// <param name="str">A string to search for in the intern pool.</param>
	/// <returns>The system's reference to <paramref name="str" />, if it is interned; otherwise, a new reference to a string with the value of <paramref name="str" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="str" /> is <see langword="null" />.</exception>
	public static string Intern(string str)
	{
		return null;
	}
}
