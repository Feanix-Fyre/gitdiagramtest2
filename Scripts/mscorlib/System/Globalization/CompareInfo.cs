using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System.Globalization;

/// <summary>Implements a set of methods for culture-sensitive string comparisons.</summary>
[Serializable]
public class CompareInfo : IDeserializationCallback
{
	private const CompareOptions ValidIndexMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

	private const CompareOptions ValidCompareMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

	private const CompareOptions ValidSortkeyCtorMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

	internal static readonly CompareInfo Invariant;

	[OptionalField(VersionAdded = 2)]
	private string m_name;

	[NonSerialized]
	private string _sortName;

	[OptionalField(VersionAdded = 3)]
	private SortVersion m_SortVersion;

	private int culture;

	[NonSerialized]
	private ISimpleCollator collator;

	private static Dictionary<string, ISimpleCollator> collators;

	private static bool managedCollation;

	private static bool managedCollationChecked;

	/// <summary>Gets the name of the culture used for sorting operations by this <see cref="T:System.Globalization.CompareInfo" /> object.</summary>
	/// <returns>The name of a culture.</returns>
	public virtual string Name => null;

	private static bool UseManagedCollation => false;

	internal static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	internal static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	private unsafe static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start)
	{
		return 0;
	}

	private static char InvariantToUpper(char c)
	{
		return '\0';
	}

	private SortKey InvariantCreateSortKey(string source, CompareOptions options)
	{
		return null;
	}

	internal CompareInfo(CultureInfo culture)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Globalization.CompareInfo" /> object that is associated with the culture with the specified name.</summary>
	/// <param name="name">A string representing the culture name.</param>
	/// <returns>A new <see cref="T:System.Globalization.CompareInfo" /> object associated with the culture with the specified identifier and using string comparison methods in the current <see cref="T:System.Reflection.Assembly" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is an invalid culture name.</exception>
	public static CompareInfo GetCompareInfo(string name)
	{
		return null;
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	/// <summary>Runs when the entire object graph has been deserialized.</summary>
	/// <param name="sender">The object that initiated the callback.</param>
	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	private void OnDeserialized()
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	/// <summary>Compares two strings.</summary>
	/// <param name="string1">The first string to compare.</param>
	/// <param name="string2">The second string to compare.</param>
	/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   zero  
	///
	///   The two strings are equal.  
	///
	///   less than zero  
	///
	///  <paramref name="string1" /> is less than <paramref name="string2" />.  
	///
	///   greater than zero  
	///
	///  <paramref name="string1" /> is greater than <paramref name="string2" />.</returns>
	public virtual int Compare(string string1, string string2)
	{
		return 0;
	}

	/// <summary>Compares two strings using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
	/// <param name="string1">The first string to compare.</param>
	/// <param name="string2">The second string to compare.</param>
	/// <param name="options">A value that defines how <paramref name="string1" /> and <paramref name="string2" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
	/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   zero  
	///
	///   The two strings are equal.  
	///
	///   less than zero  
	///
	///  <paramref name="string1" /> is less than <paramref name="string2" />.  
	///
	///   greater than zero  
	///
	///  <paramref name="string1" /> is greater than <paramref name="string2" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
	public virtual int Compare(string string1, string string2, CompareOptions options)
	{
		return 0;
	}

	internal int Compare(ReadOnlySpan<char> string1, string string2, CompareOptions options)
	{
		return 0;
	}

	internal int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2)
	{
		return 0;
	}

	/// <summary>Compares a section of one string with a section of another string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
	/// <param name="string1">The first string to compare.</param>
	/// <param name="offset1">The zero-based index of the character in <paramref name="string1" /> at which to start comparing.</param>
	/// <param name="length1">The number of consecutive characters in <paramref name="string1" /> to compare.</param>
	/// <param name="string2">The second string to compare.</param>
	/// <param name="offset2">The zero-based index of the character in <paramref name="string2" /> at which to start comparing.</param>
	/// <param name="length2">The number of consecutive characters in <paramref name="string2" /> to compare.</param>
	/// <param name="options">A value that defines how <paramref name="string1" /> and <paramref name="string2" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
	/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.  
	///   Value  
	///
	///   Condition  
	///
	///   zero  
	///
	///   The two strings are equal.  
	///
	///   less than zero  
	///
	///   The specified section of <paramref name="string1" /> is less than the specified section of <paramref name="string2" />.  
	///
	///   greater than zero  
	///
	///   The specified section of <paramref name="string1" /> is greater than the specified section of <paramref name="string2" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset1" /> or <paramref name="length1" /> or <paramref name="offset2" /> or <paramref name="length2" /> is less than zero.  
	/// -or-  
	/// <paramref name="offset1" /> is greater than or equal to the number of characters in <paramref name="string1" />.  
	/// -or-  
	/// <paramref name="offset2" /> is greater than or equal to the number of characters in <paramref name="string2" />.  
	/// -or-  
	/// <paramref name="length1" /> is greater than the number of characters from <paramref name="offset1" /> to the end of <paramref name="string1" />.  
	/// -or-  
	/// <paramref name="length2" /> is greater than the number of characters from <paramref name="offset2" /> to the end of <paramref name="string2" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
	{
		return 0;
	}

	internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB)
	{
		return 0;
	}

	internal static int CompareOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
	{
		return 0;
	}

	/// <summary>Determines whether the specified source string starts with the specified prefix using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
	/// <param name="source">The string to search in.</param>
	/// <param name="prefix">The string to compare with the beginning of <paramref name="source" />.</param>
	/// <param name="options">A value that defines how <paramref name="source" /> and <paramref name="prefix" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
	/// <returns>
	///   <see langword="true" /> if the length of <paramref name="prefix" /> is less than or equal to the length of <paramref name="source" /> and <paramref name="source" /> starts with <paramref name="prefix" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="source" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="prefix" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options)
	{
		return false;
	}

	/// <summary>Determines whether the specified source string ends with the specified suffix using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
	/// <param name="source">The string to search in.</param>
	/// <param name="suffix">The string to compare with the end of <paramref name="source" />.</param>
	/// <param name="options">A value that defines how <paramref name="source" /> and <paramref name="suffix" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" /> used by itself, or the bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
	/// <returns>
	///   <see langword="true" /> if the length of <paramref name="suffix" /> is less than or equal to the length of <paramref name="source" /> and <paramref name="source" /> ends with <paramref name="suffix" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="source" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="suffix" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options)
	{
		return false;
	}

	internal bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
	{
		return false;
	}

	/// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the entire source string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
	/// <param name="source">The string to search.</param>
	/// <param name="value">The string to locate within <paramref name="source" />.</param>
	/// <param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
	/// <returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within <paramref name="source" />, using the specified comparison options; otherwise, -1. Returns 0 (zero) if <paramref name="value" /> is an ignorable character.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="source" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
	public virtual int IndexOf(string source, string value, CompareOptions options)
	{
		return 0;
	}

	/// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the section of the source string that starts at the specified index and contains the specified number of elements using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
	/// <param name="source">The string to search.</param>
	/// <param name="value">The string to locate within <paramref name="source" />.</param>
	/// <param name="startIndex">The zero-based starting index of the search.</param>
	/// <param name="count">The number of elements in the section to search.</param>
	/// <param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
	/// <returns>The zero-based index of the first occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that starts at <paramref name="startIndex" /> and contains the number of elements specified by <paramref name="count" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="source" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
	{
		return 0;
	}

	internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	/// <summary>Searches for the specified substring and returns the zero-based index of the last occurrence within the section of the source string that contains the specified number of elements and ends at the specified index using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
	/// <param name="source">The string to search.</param>
	/// <param name="value">The string to locate within <paramref name="source" />.</param>
	/// <param name="startIndex">The zero-based starting index of the backward search.</param>
	/// <param name="count">The number of elements in the section to search.</param>
	/// <param name="options">A value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the enumeration value <see cref="F:System.Globalization.CompareOptions.Ordinal" />, or a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
	/// <returns>The zero-based index of the last occurrence of <paramref name="value" />, if found, within the section of <paramref name="source" /> that contains the number of elements specified by <paramref name="count" /> and that ends at <paramref name="startIndex" />, using the specified comparison options; otherwise, -1. Returns <paramref name="startIndex" /> if <paramref name="value" /> is an ignorable character.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="source" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
	{
		return 0;
	}

	internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	/// <summary>Gets a <see cref="T:System.Globalization.SortKey" /> object for the specified string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
	/// <param name="source">The string for which a <see cref="T:System.Globalization.SortKey" /> object is obtained.</param>
	/// <param name="options">A bitwise combination of one or more of the following enumeration values that define how the sort key is calculated: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
	/// <returns>The <see cref="T:System.Globalization.SortKey" /> object that contains the sort key for the specified string.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
	public virtual SortKey GetSortKey(string source, CompareOptions options)
	{
		return null;
	}

	/// <summary>Determines whether the specified object is equal to the current <see cref="T:System.Globalization.CompareInfo" /> object.</summary>
	/// <param name="value">The object to compare with the current <see cref="T:System.Globalization.CompareInfo" />.</param>
	/// <returns>
	///   <see langword="true" /> if the specified object is equal to the current <see cref="T:System.Globalization.CompareInfo" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Serves as a hash function for the current <see cref="T:System.Globalization.CompareInfo" /> for hashing algorithms and data structures, such as a hash table.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Globalization.CompareInfo" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	internal static int GetIgnoreCaseHash(string source)
	{
		return 0;
	}

	internal int GetHashCodeOfString(string source, CompareOptions options)
	{
		return 0;
	}

	/// <summary>Gets the hash code for a string based on specified comparison options.</summary>
	/// <param name="source">The string whose hash code is to be returned.</param>
	/// <param name="options">A value that determines how strings are compared.</param>
	/// <returns>A 32-bit signed integer hash code.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="source" /> is <see langword="null" />.</exception>
	public virtual int GetHashCode(string source, CompareOptions options)
	{
		return 0;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Globalization.CompareInfo" /> object.</summary>
	/// <returns>A string that represents the current <see cref="T:System.Globalization.CompareInfo" /> object.</returns>
	public override string ToString()
	{
		return null;
	}

	private ISimpleCollator GetCollator()
	{
		return null;
	}

	private SortKey CreateSortKeyCore(string source, CompareOptions options)
	{
		return null;
	}

	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
	{
		return 0;
	}

	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
	{
		return 0;
	}

	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
	{
		return 0;
	}

	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
	{
		return 0;
	}

	private unsafe static int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options)
	{
		return 0;
	}

	private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
	{
		return 0;
	}

	private unsafe static int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first)
	{
		return 0;
	}

	private static int internal_index(string source, int sindex, int count, string value, bool first)
	{
		return 0;
	}

	private void InitSort(CultureInfo culture)
	{
	}

	private unsafe static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2)
	{
		return 0;
	}

	internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
	{
		return 0;
	}

	private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options)
	{
		return 0;
	}

	private unsafe int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr)
	{
		return 0;
	}

	private int CompareString(ReadOnlySpan<char> string1, string string2, CompareOptions options)
	{
		return 0;
	}

	private int CompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options)
	{
		return 0;
	}

	private SortKey CreateSortKey(string source, CompareOptions options)
	{
		return null;
	}

	private bool StartsWith(string source, string prefix, CompareOptions options)
	{
		return false;
	}

	private bool EndsWith(string source, string suffix, CompareOptions options)
	{
		return false;
	}

	private bool EndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
	{
		return false;
	}

	internal int GetHashCodeOfStringCore(string source, CompareOptions options)
	{
		return 0;
	}

	internal CompareInfo()
	{
	}
}
