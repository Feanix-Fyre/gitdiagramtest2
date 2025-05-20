namespace System.Text.RegularExpressions;

/// <summary>Represents the results from a single successful subexpression capture.</summary>
public class Capture
{
	/// <summary>The position in the original string where the first character of the captured substring is found.</summary>
	/// <returns>The zero-based starting position in the original string where the captured substring is found.</returns>
	public int Index { get; private protected set; }

	/// <summary>Gets the length of the captured substring.</summary>
	/// <returns>The length of the captured substring.</returns>
	public int Length { get; private protected set; }

	internal string Text { get; private protected set; }

	/// <summary>Gets the captured substring from the input string.</summary>
	/// <returns>The substring that is captured by the match.</returns>
	public string Value => null;

	internal Capture(string text, int index, int length)
	{
	}

	/// <summary>Retrieves the captured substring from the input string by calling the <see cref="P:System.Text.RegularExpressions.Capture.Value" /> property.</summary>
	/// <returns>The substring that was captured by the match.</returns>
	public override string ToString()
	{
		return null;
	}

	internal ReadOnlySpan<char> GetLeftSubstring()
	{
		return default(ReadOnlySpan<char>);
	}

	internal ReadOnlySpan<char> GetRightSubstring()
	{
		return default(ReadOnlySpan<char>);
	}
}
