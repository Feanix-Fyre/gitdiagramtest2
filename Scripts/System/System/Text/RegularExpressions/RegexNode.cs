using System.Collections.Generic;

namespace System.Text.RegularExpressions;

internal sealed class RegexNode
{
	public int NType;

	public List<RegexNode> Children;

	public string Str;

	public char Ch;

	public int M;

	public int N;

	public readonly RegexOptions Options;

	public RegexNode Next;

	public RegexNode(int type, RegexOptions options)
	{
	}

	public RegexNode(int type, RegexOptions options, char ch)
	{
	}

	public RegexNode(int type, RegexOptions options, string str)
	{
	}

	public RegexNode(int type, RegexOptions options, int m)
	{
	}

	public RegexNode(int type, RegexOptions options, int m, int n)
	{
	}

	public bool UseOptionR()
	{
		return false;
	}

	public RegexNode ReverseLeft()
	{
		return null;
	}

	private void MakeRep(int type, int min, int max)
	{
	}

	private RegexNode Reduce()
	{
		return null;
	}

	private RegexNode StripEnation(int emptyType)
	{
		return null;
	}

	private RegexNode ReduceGroup()
	{
		return null;
	}

	private RegexNode ReduceRep()
	{
		return null;
	}

	private RegexNode ReduceSet()
	{
		return null;
	}

	private RegexNode ReduceAlternation()
	{
		return null;
	}

	private RegexNode ReduceConcatenation()
	{
		return null;
	}

	public RegexNode MakeQuantifier(bool lazy, int min, int max)
	{
		return null;
	}

	public void AddChild(RegexNode newChild)
	{
	}

	public RegexNode Child(int i)
	{
		return null;
	}

	public int ChildCount()
	{
		return 0;
	}

	public int Type()
	{
		return 0;
	}
}
