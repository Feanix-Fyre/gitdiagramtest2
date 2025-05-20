namespace System.Globalization;

/// <summary>Retrieves information about a Unicode character. This class cannot be inherited.</summary>
public static class CharUnicodeInfo
{
	private static ReadOnlySpan<byte> CategoryLevel1Index => default(ReadOnlySpan<byte>);

	private static ReadOnlySpan<byte> CategoryLevel2Index => default(ReadOnlySpan<byte>);

	private static ReadOnlySpan<byte> CategoryLevel3Index => default(ReadOnlySpan<byte>);

	private static ReadOnlySpan<byte> CategoriesValue => default(ReadOnlySpan<byte>);

	internal static int InternalConvertToUtf32(string s, int index)
	{
		return 0;
	}

	internal static int InternalConvertToUtf32(string s, int index, out int charLength)
	{
		charLength = default(int);
		return 0;
	}

	/// <summary>Gets the Unicode category of the specified character.</summary>
	/// <param name="ch">The Unicode character for which to get the Unicode category.</param>
	/// <returns>A <see cref="T:System.Globalization.UnicodeCategory" /> value indicating the category of the specified character.</returns>
	public static UnicodeCategory GetUnicodeCategory(char ch)
	{
		return default(UnicodeCategory);
	}

	/// <summary>Gets the Unicode category of the character at the specified index of the specified string.</summary>
	/// <param name="s">The <see cref="T:System.String" /> containing the Unicode character for which to get the Unicode category.</param>
	/// <param name="index">The index of the Unicode character for which to get the Unicode category.</param>
	/// <returns>A <see cref="T:System.Globalization.UnicodeCategory" /> value indicating the category of the character at the specified index of the specified string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the range of valid indexes in <paramref name="s" />.</exception>
	public static UnicodeCategory GetUnicodeCategory(string s, int index)
	{
		return default(UnicodeCategory);
	}

	public static UnicodeCategory GetUnicodeCategory(int codePoint)
	{
		return default(UnicodeCategory);
	}

	internal static byte InternalGetCategoryValue(int ch, int offset)
	{
		return 0;
	}

	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
	{
		return default(UnicodeCategory);
	}

	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength)
	{
		charLength = default(int);
		return default(UnicodeCategory);
	}

	internal static bool IsWhiteSpace(string s, int index)
	{
		return false;
	}

	internal static bool IsWhiteSpace(char c)
	{
		return false;
	}
}
