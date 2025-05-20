namespace System;

/// <summary>Specifies whether relevant <see cref="Overload:System.Convert.ToBase64CharArray" /> and <see cref="Overload:System.Convert.ToBase64String" /> methods insert line breaks in their output.</summary>
[Flags]
public enum Base64FormattingOptions
{
	/// <summary>Does not insert line breaks after every 76 characters in the string representation.</summary>
	None = 0,
	/// <summary>Inserts line breaks after every 76 characters in the string representation.</summary>
	InsertLineBreaks = 1
}
