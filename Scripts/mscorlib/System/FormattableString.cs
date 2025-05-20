namespace System;

/// <summary>Represents a composite format string, along with the arguments to be formatted.</summary>
public abstract class FormattableString : IFormattable
{
	/// <summary>Returns the composite format string.</summary>
	/// <returns>The composite format string.</returns>
	public abstract string Format { get; }

	/// <summary>Gets the number of arguments to be formatted.</summary>
	/// <returns>The number of arguments to be formatted.</returns>
	public abstract int ArgumentCount { get; }

	/// <summary>Returns an object array that contains one or more objects to format.</summary>
	/// <returns>An object array that contains one or more objects to format.</returns>
	public abstract object[] GetArguments();

	/// <summary>Returns the argument at the specified index position.</summary>
	/// <param name="index">The index of the argument. Its value can range from zero to one less than the value of <see cref="P:System.FormattableString.ArgumentCount" />.</param>
	/// <returns>The argument.</returns>
	public abstract object GetArgument(int index);

	/// <summary>Returns the string that results from formatting the composite format string along with its arguments by using the formatting conventions of a specified culture.</summary>
	/// <param name="formatProvider">An object that provides culture-specific formatting information.</param>
	/// <returns>A result string formatted by using the conventions of <paramref name="formatProvider" />.</returns>
	public abstract string ToString(IFormatProvider formatProvider);

	/// <summary>Returns the string that results from formatting the format string along with its arguments by using the formatting conventions of a specified culture.</summary>
	/// <param name="ignored">A string. This argument is ignored.</param>
	/// <param name="formatProvider">An object that provides culture-specific formatting information.</param>
	/// <returns>A string formatted using the conventions of the <paramref name="formatProvider" /> parameter.</returns>
	string IFormattable.ToString(string ignored, IFormatProvider formatProvider)
	{
		return null;
	}

	/// <summary>Returns the string that results from formatting the composite format string along with its arguments by using the formatting conventions of the current culture.</summary>
	/// <returns>A result string formatted by using the conventions of the current culture.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Instantiates a new instance of the <see cref="T:System.FormattableString" /> class.</summary>
	protected FormattableString()
	{
	}
}
