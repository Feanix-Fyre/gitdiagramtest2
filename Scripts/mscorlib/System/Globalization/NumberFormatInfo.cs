using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization;

/// <summary>Provides culture-specific information for formatting and parsing numeric values.</summary>
[Serializable]
[ComVisible(true)]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider
{
	private static NumberFormatInfo invariantInfo;

	internal int[] numberGroupSizes;

	internal int[] currencyGroupSizes;

	internal int[] percentGroupSizes;

	internal string positiveSign;

	internal string negativeSign;

	internal string numberDecimalSeparator;

	internal string numberGroupSeparator;

	internal string currencyGroupSeparator;

	internal string currencyDecimalSeparator;

	internal string currencySymbol;

	internal string ansiCurrencySymbol;

	internal string nanSymbol;

	internal string positiveInfinitySymbol;

	internal string negativeInfinitySymbol;

	internal string percentDecimalSeparator;

	internal string percentGroupSeparator;

	internal string percentSymbol;

	internal string perMilleSymbol;

	[OptionalField(VersionAdded = 2)]
	internal string[] nativeDigits;

	[OptionalField(VersionAdded = 1)]
	internal int m_dataItem;

	internal int numberDecimalDigits;

	internal int currencyDecimalDigits;

	internal int currencyPositivePattern;

	internal int currencyNegativePattern;

	internal int numberNegativePattern;

	internal int percentPositivePattern;

	internal int percentNegativePattern;

	internal int percentDecimalDigits;

	[OptionalField(VersionAdded = 2)]
	internal int digitSubstitution;

	internal bool isReadOnly;

	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride;

	[OptionalField(VersionAdded = 2)]
	internal bool m_isInvariant;

	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsNumber;

	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsCurrency;

	private const NumberStyles InvalidNumberStyles = ~(NumberStyles.Any | NumberStyles.AllowHexSpecifier);

	/// <summary>Gets a read-only <see cref="T:System.Globalization.NumberFormatInfo" /> object that is culture-independent (invariant).</summary>
	/// <returns>A read-only  object that is culture-independent (invariant).</returns>
	public static NumberFormatInfo InvariantInfo => null;

	/// <summary>Gets or sets the number of decimal places to use in currency values.</summary>
	/// <returns>The number of decimal places to use in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 2.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 99.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public int CurrencyDecimalDigits => 0;

	/// <summary>Gets or sets the string to use as the decimal separator in currency values.</summary>
	/// <returns>The string to use as the decimal separator in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ".".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	/// <exception cref="T:System.ArgumentException">The property is being set to an empty string.</exception>
	public string CurrencyDecimalSeparator => null;

	/// <summary>Gets a value that indicates whether this <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only; otherwise, <see langword="false" />.</returns>
	public bool IsReadOnly => false;

	/// <summary>Gets or sets the number of digits in each group to the left of the decimal in currency values.</summary>
	/// <returns>The number of digits in each group to the left of the decimal in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is a one-dimensional array with only one element, which is set to 3.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The property is being set and the array contains an entry that is less than 0 or greater than 9.  
	///  -or-  
	///  The property is being set and the array contains an entry, other than the last entry, that is set to 0.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public int[] CurrencyGroupSizes => null;

	/// <summary>Gets or sets the number of digits in each group to the left of the decimal in numeric values.</summary>
	/// <returns>The number of digits in each group to the left of the decimal in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is a one-dimensional array with only one element, which is set to 3.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The property is being set and the array contains an entry that is less than 0 or greater than 9.  
	///  -or-  
	///  The property is being set and the array contains an entry, other than the last entry, that is set to 0.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public int[] NumberGroupSizes => null;

	/// <summary>Gets or sets the number of digits in each group to the left of the decimal in percent values.</summary>
	/// <returns>The number of digits in each group to the left of the decimal in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is a one-dimensional array with only one element, which is set to 3.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The property is being set and the array contains an entry that is less than 0 or greater than 9.  
	///  -or-  
	///  The property is being set and the array contains an entry, other than the last entry, that is set to 0.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public int[] PercentGroupSizes => null;

	/// <summary>Gets or sets the string that separates groups of digits to the left of the decimal in currency values.</summary>
	/// <returns>The string that separates groups of digits to the left of the decimal in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ",".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public string CurrencyGroupSeparator => null;

	/// <summary>Gets or sets the string to use as the currency symbol.</summary>
	/// <returns>The string to use as the currency symbol. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "¤".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public string CurrencySymbol => null;

	/// <summary>Gets a read-only <see cref="T:System.Globalization.NumberFormatInfo" /> that formats values based on the current culture.</summary>
	/// <returns>A read-only <see cref="T:System.Globalization.NumberFormatInfo" /> based on the culture of the current thread.</returns>
	public static NumberFormatInfo CurrentInfo => null;

	/// <summary>Gets or sets the string that represents the IEEE NaN (not a number) value.</summary>
	/// <returns>The string that represents the IEEE NaN (not a number) value. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "NaN".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public string NaNSymbol
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the format pattern for negative currency values.</summary>
	/// <returns>The format pattern for negative currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "($n)", where "$" is the <see cref="P:System.Globalization.NumberFormatInfo.CurrencySymbol" /> and <paramref name="n" /> is a number.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 15.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public int CurrencyNegativePattern => 0;

	/// <summary>Gets or sets the format pattern for negative numeric values.</summary>
	/// <returns>The format pattern for negative numeric values.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 4.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public int NumberNegativePattern => 0;

	/// <summary>Gets or sets the format pattern for positive percent values.</summary>
	/// <returns>The format pattern for positive percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "n %", where "%" is the <see cref="P:System.Globalization.NumberFormatInfo.PercentSymbol" /> and <paramref name="n" /> is a number.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 3.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public int PercentPositivePattern => 0;

	/// <summary>Gets or sets the format pattern for negative percent values.</summary>
	/// <returns>The format pattern for negative percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "-n %", where "%" is the <see cref="P:System.Globalization.NumberFormatInfo.PercentSymbol" /> and <paramref name="n" /> is a number.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 11.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public int PercentNegativePattern => 0;

	/// <summary>Gets or sets the string that represents negative infinity.</summary>
	/// <returns>The string that represents negative infinity. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "-Infinity".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public string NegativeInfinitySymbol => null;

	/// <summary>Gets or sets the string that denotes that the associated number is negative.</summary>
	/// <returns>The string that denotes that the associated number is negative. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "-".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public string NegativeSign => null;

	/// <summary>Gets or sets the number of decimal places to use in numeric values.</summary>
	/// <returns>The number of decimal places to use in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 2.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 99.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public int NumberDecimalDigits => 0;

	/// <summary>Gets or sets the string to use as the decimal separator in numeric values.</summary>
	/// <returns>The string to use as the decimal separator in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ".".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	/// <exception cref="T:System.ArgumentException">The property is being set to an empty string.</exception>
	public string NumberDecimalSeparator => null;

	/// <summary>Gets or sets the string that separates groups of digits to the left of the decimal in numeric values.</summary>
	/// <returns>The string that separates groups of digits to the left of the decimal in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ",".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public string NumberGroupSeparator => null;

	/// <summary>Gets or sets the format pattern for positive currency values.</summary>
	/// <returns>The format pattern for positive currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "$n", where "$" is the <see cref="P:System.Globalization.NumberFormatInfo.CurrencySymbol" /> and <paramref name="n" /> is a number.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 3.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public int CurrencyPositivePattern => 0;

	/// <summary>Gets or sets the string that represents positive infinity.</summary>
	/// <returns>The string that represents positive infinity. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "Infinity".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public string PositiveInfinitySymbol => null;

	/// <summary>Gets or sets the string that denotes that the associated number is positive.</summary>
	/// <returns>The string that denotes that the associated number is positive. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "+".</returns>
	/// <exception cref="T:System.ArgumentNullException">In a set operation, the value to be assigned is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public string PositiveSign => null;

	/// <summary>Gets or sets the number of decimal places to use in percent values.</summary>
	/// <returns>The number of decimal places to use in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 2.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 99.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public int PercentDecimalDigits => 0;

	/// <summary>Gets or sets the string to use as the decimal separator in percent values.</summary>
	/// <returns>The string to use as the decimal separator in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ".".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	/// <exception cref="T:System.ArgumentException">The property is being set to an empty string.</exception>
	public string PercentDecimalSeparator => null;

	/// <summary>Gets or sets the string that separates groups of digits to the left of the decimal in percent values.</summary>
	/// <returns>The string that separates groups of digits to the left of the decimal in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ",".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public string PercentGroupSeparator => null;

	/// <summary>Gets or sets the string to use as the percent symbol.</summary>
	/// <returns>The string to use as the percent symbol. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "%".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public string PercentSymbol => null;

	/// <summary>Gets or sets the string to use as the per mille symbol.</summary>
	/// <returns>The string to use as the per mille symbol. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "‰", which is the Unicode character U+2030.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</exception>
	public string PerMilleSymbol => null;

	/// <summary>Initializes a new writable instance of the <see cref="T:System.Globalization.NumberFormatInfo" /> class that is culture-independent (invariant).</summary>
	public NumberFormatInfo()
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	internal NumberFormatInfo(CultureData cultureData)
	{
	}

	private void VerifyWritable()
	{
	}

	/// <summary>Gets the <see cref="T:System.Globalization.NumberFormatInfo" /> associated with the specified <see cref="T:System.IFormatProvider" />.</summary>
	/// <param name="formatProvider">The <see cref="T:System.IFormatProvider" /> used to get the <see cref="T:System.Globalization.NumberFormatInfo" />.  
	///  -or-  
	///  <see langword="null" /> to get <see cref="P:System.Globalization.NumberFormatInfo.CurrentInfo" />.</param>
	/// <returns>The <see cref="T:System.Globalization.NumberFormatInfo" /> associated with the specified <see cref="T:System.IFormatProvider" />.</returns>
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider)
	{
		return null;
	}

	/// <summary>Creates a shallow copy of the <see cref="T:System.Globalization.NumberFormatInfo" /> object.</summary>
	/// <returns>A new object copied from the original <see cref="T:System.Globalization.NumberFormatInfo" /> object.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Gets an object of the specified type that provides a number formatting service.</summary>
	/// <param name="formatType">The <see cref="T:System.Type" /> of the required formatting service.</param>
	/// <returns>The current <see cref="T:System.Globalization.NumberFormatInfo" />, if <paramref name="formatType" /> is the same as the type of the current <see cref="T:System.Globalization.NumberFormatInfo" />; otherwise, <see langword="null" />.</returns>
	public object GetFormat(Type formatType)
	{
		return null;
	}

	/// <summary>Returns a read-only <see cref="T:System.Globalization.NumberFormatInfo" /> wrapper.</summary>
	/// <param name="nfi">The <see cref="T:System.Globalization.NumberFormatInfo" /> to wrap.</param>
	/// <returns>A read-only <see cref="T:System.Globalization.NumberFormatInfo" /> wrapper around <paramref name="nfi" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="nfi" /> is <see langword="null" />.</exception>
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
	{
		return null;
	}

	internal static void ValidateParseStyleInteger(NumberStyles style)
	{
	}

	internal static void ValidateParseStyleFloatingPoint(NumberStyles style)
	{
	}
}
