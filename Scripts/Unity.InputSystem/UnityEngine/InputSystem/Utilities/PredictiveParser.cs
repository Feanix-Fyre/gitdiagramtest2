using System;

namespace UnityEngine.InputSystem.Utilities;

internal struct PredictiveParser
{
	private int m_Position;

	public void ExpectSingleChar(ReadOnlySpan<char> str, char c)
	{
	}

	public int ExpectInt(ReadOnlySpan<char> str)
	{
		return 0;
	}

	public ReadOnlySpan<char> ExpectString(ReadOnlySpan<char> str)
	{
		return default(ReadOnlySpan<char>);
	}

	public bool AcceptSingleChar(ReadOnlySpan<char> str, char c)
	{
		return false;
	}

	public bool AcceptString(ReadOnlySpan<char> input, out ReadOnlySpan<char> output)
	{
		output = default(ReadOnlySpan<char>);
		return false;
	}

	public void AcceptInt(ReadOnlySpan<char> str)
	{
	}
}
