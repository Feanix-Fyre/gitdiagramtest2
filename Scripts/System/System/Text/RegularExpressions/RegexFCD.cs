using System.Collections.Generic;

namespace System.Text.RegularExpressions;

internal ref struct RegexFCD
{
	private readonly List<RegexFC> _fcStack;

	private ValueListBuilder<int> _intStack;

	private bool _skipAllChildren;

	private bool _skipchild;

	private bool _failed;

	private RegexFCD(Span<int> intStack)
	{
		_fcStack = null;
		_intStack = default(ValueListBuilder<int>);
		_skipAllChildren = false;
		_skipchild = false;
		_failed = false;
	}

	public static RegexPrefix? FirstChars(RegexTree t)
	{
		return null;
	}

	public static RegexPrefix Prefix(RegexTree tree)
	{
		return default(RegexPrefix);
	}

	public static int Anchors(RegexTree tree)
	{
		return 0;
	}

	private static int AnchorFromType(int type)
	{
		return 0;
	}

	private void PushInt(int i)
	{
	}

	private bool IntIsEmpty()
	{
		return false;
	}

	private int PopInt()
	{
		return 0;
	}

	private void PushFC(RegexFC fc)
	{
	}

	private bool FCIsEmpty()
	{
		return false;
	}

	private RegexFC PopFC()
	{
		return null;
	}

	private RegexFC TopFC()
	{
		return null;
	}

	public void Dispose()
	{
	}

	private RegexFC RegexFCFromRegexTree(RegexTree tree)
	{
		return null;
	}

	private void SkipChild()
	{
	}

	private void CalculateFC(int NodeType, RegexNode node, int CurIndex)
	{
	}
}
