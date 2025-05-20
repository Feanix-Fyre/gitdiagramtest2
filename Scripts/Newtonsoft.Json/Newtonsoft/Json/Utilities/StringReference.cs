namespace Newtonsoft.Json.Utilities;

internal readonly struct StringReference
{
	private readonly char[] _chars;

	private readonly int _startIndex;

	private readonly int _length;

	public char this[int i] => '\0';

	public char[] Chars => null;

	public int StartIndex => 0;

	public int Length => 0;

	public StringReference(char[] chars, int startIndex, int length)
	{
		_chars = null;
		_startIndex = 0;
		_length = 0;
	}

	public override string ToString()
	{
		return null;
	}
}
