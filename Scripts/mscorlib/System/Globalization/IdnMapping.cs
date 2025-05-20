namespace System.Globalization;

/// <summary>Supports the use of non-ASCII characters for Internet domain names. This class cannot be inherited.</summary>
public sealed class IdnMapping
{
	private bool allow_unassigned;

	private bool use_std3;

	private Punycode puny;

	/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.IdnMapping" /> class.</summary>
	public IdnMapping()
	{
	}

	/// <summary>Indicates whether a specified object and the current <see cref="T:System.Globalization.IdnMapping" /> object are equal.</summary>
	/// <param name="obj">The object to compare to the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the object specified by the <paramref name="obj" /> parameter is derived from <see cref="T:System.Globalization.IdnMapping" /> and its <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties are equal; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns a hash code for this <see cref="T:System.Globalization.IdnMapping" /> object.</summary>
	/// <returns>One of four 32-bit signed constants derived from the properties of an <see cref="T:System.Globalization.IdnMapping" /> object.  The return value has no special meaning and is not suitable for use in a hash code algorithm.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Encodes a string of domain name labels that consist of Unicode characters to a string of displayable Unicode characters in the US-ASCII character range. The string is formatted according to the IDNA standard.</summary>
	/// <param name="unicode">The string to convert, which consists of one or more domain name labels delimited with label separators.</param>
	/// <returns>The equivalent of the string specified by the <paramref name="unicode" /> parameter, consisting of displayable Unicode characters in the US-ASCII character range (U+0020 to U+007E) and formatted according to the IDNA standard.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="unicode" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="unicode" /> is invalid based on the <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties, and the IDNA standard.</exception>
	public string GetAscii(string unicode)
	{
		return null;
	}

	/// <summary>Encodes the specified number of characters in a  substring of domain name labels that include Unicode characters outside the US-ASCII character range. The substring is converted to a string of displayable Unicode characters in the US-ASCII character range and is formatted according to the IDNA standard.</summary>
	/// <param name="unicode">The string to convert, which consists of one or more domain name labels delimited with label separators.</param>
	/// <param name="index">A zero-based offset into <paramref name="unicode" /> that specifies the start of the substring.</param>
	/// <param name="count">The number of characters to convert in the substring that starts at the position specified by  <paramref name="index" /> in the <paramref name="unicode" /> string.</param>
	/// <returns>The equivalent of the substring specified by the <paramref name="unicode" />, <paramref name="index" />, and <paramref name="count" /> parameters, consisting of displayable Unicode characters in the US-ASCII character range (U+0020 to U+007E) and formatted according to the IDNA standard.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="unicode" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is greater than the length of <paramref name="unicode" />.  
	/// -or-  
	/// <paramref name="index" /> is greater than the length of <paramref name="unicode" /> minus <paramref name="count" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="unicode" /> is invalid based on the <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties, and the IDNA standard.</exception>
	public string GetAscii(string unicode, int index, int count)
	{
		return null;
	}

	private string Convert(string input, int index, int count, bool toAscii)
	{
		return null;
	}

	private string ToAscii(string s, int offset)
	{
		return null;
	}

	private void VerifyLength(string s, int offset)
	{
	}

	private string NamePrep(string s, int offset)
	{
		return null;
	}

	private void VerifyProhibitedCharacters(string s, int offset)
	{
	}

	private void VerifyStd3AsciiRules(string s, int offset)
	{
	}

	/// <summary>Decodes a string of one or more domain name labels, encoded according to the IDNA standard, to a string of Unicode characters.</summary>
	/// <param name="ascii">The string to decode, which consists of one or more labels in the US-ASCII character range (U+0020 to U+007E) encoded according to the IDNA standard.</param>
	/// <returns>The Unicode equivalent of the IDNA substring specified by the <paramref name="ascii" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="ascii" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="ascii" /> is invalid based on the <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties, and the IDNA standard.</exception>
	public string GetUnicode(string ascii)
	{
		return null;
	}

	/// <summary>Decodes a substring of a specified length that contains one or more domain name labels, encoded according to the IDNA standard, to a string of Unicode characters.</summary>
	/// <param name="ascii">The string to decode, which consists of one or more labels in the US-ASCII character range (U+0020 to U+007E) encoded according to the IDNA standard.</param>
	/// <param name="index">A zero-based offset into <paramref name="ascii" /> that specifies the start of the substring.</param>
	/// <param name="count">The number of characters to convert in the substring that starts at the position specified by <paramref name="index" /> in the <paramref name="ascii" /> string.</param>
	/// <returns>The Unicode equivalent of the IDNA substring specified by the <paramref name="ascii" />, <paramref name="index" />, and <paramref name="count" /> parameters.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="ascii" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is greater than the length of <paramref name="ascii" />.  
	/// -or-  
	/// <paramref name="index" /> is greater than the length of <paramref name="ascii" /> minus <paramref name="count" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="ascii" /> is invalid based on the <see cref="P:System.Globalization.IdnMapping.AllowUnassigned" /> and <see cref="P:System.Globalization.IdnMapping.UseStd3AsciiRules" /> properties, and the IDNA standard.</exception>
	public string GetUnicode(string ascii, int index, int count)
	{
		return null;
	}

	private string ToUnicode(string s, int offset)
	{
		return null;
	}
}
