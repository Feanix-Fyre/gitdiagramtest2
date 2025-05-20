using System.Globalization;

namespace System.Text.RegularExpressions;

internal sealed class RegexInterpreter : RegexRunner
{
	private readonly RegexCode _code;

	private readonly CultureInfo _culture;

	private int _operator;

	private int _codepos;

	private bool _rightToLeft;

	private bool _caseInsensitive;

	public RegexInterpreter(RegexCode code, CultureInfo culture)
	{
	}

	protected override void InitTrackCount()
	{
	}

	private void Advance(int i)
	{
	}

	private void Goto(int newpos)
	{
	}

	private void Textto(int newpos)
	{
	}

	private void Trackto(int newpos)
	{
	}

	private int Textstart()
	{
		return 0;
	}

	private int Textpos()
	{
		return 0;
	}

	private int Trackpos()
	{
		return 0;
	}

	private void TrackPush()
	{
	}

	private void TrackPush(int I1)
	{
	}

	private void TrackPush(int I1, int I2)
	{
	}

	private void TrackPush(int I1, int I2, int I3)
	{
	}

	private void TrackPush2(int I1)
	{
	}

	private void TrackPush2(int I1, int I2)
	{
	}

	private void Backtrack()
	{
	}

	private void SetOperator(int op)
	{
	}

	private void TrackPop()
	{
	}

	private void TrackPop(int framesize)
	{
	}

	private int TrackPeek()
	{
		return 0;
	}

	private int TrackPeek(int i)
	{
		return 0;
	}

	private void StackPush(int I1)
	{
	}

	private void StackPush(int I1, int I2)
	{
	}

	private void StackPop()
	{
	}

	private void StackPop(int framesize)
	{
	}

	private int StackPeek()
	{
		return 0;
	}

	private int StackPeek(int i)
	{
		return 0;
	}

	private int Operator()
	{
		return 0;
	}

	private int Operand(int i)
	{
		return 0;
	}

	private int Leftchars()
	{
		return 0;
	}

	private int Rightchars()
	{
		return 0;
	}

	private int Bump()
	{
		return 0;
	}

	private int Forwardchars()
	{
		return 0;
	}

	private char Forwardcharnext()
	{
		return '\0';
	}

	private bool Stringmatch(string str)
	{
		return false;
	}

	private bool Refmatch(int index, int len)
	{
		return false;
	}

	private void Backwardnext()
	{
	}

	private char CharAt(int j)
	{
		return '\0';
	}

	protected override bool FindFirstChar()
	{
		return false;
	}

	protected override void Go()
	{
	}
}
