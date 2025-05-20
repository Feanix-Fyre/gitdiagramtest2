using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets;

internal abstract class BaseStyleMatcher
{
	private struct MatchContext
	{
		public int valueIndex;

		public int matchedVariableCount;
	}

	protected static readonly Regex s_CustomIdentRegex;

	private Stack<MatchContext> m_ContextStack;

	private MatchContext m_CurrentContext;

	public abstract int valueCount { get; }

	public abstract bool isCurrentVariable { get; }

	public abstract bool isCurrentComma { get; }

	public bool hasCurrent => false;

	public int currentIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int matchedVariableCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected abstract bool MatchKeyword(string keyword);

	protected abstract bool MatchNumber();

	protected abstract bool MatchInteger();

	protected abstract bool MatchLength();

	protected abstract bool MatchPercentage();

	protected abstract bool MatchColor();

	protected abstract bool MatchResource();

	protected abstract bool MatchUrl();

	protected abstract bool MatchTime();

	protected abstract bool MatchAngle();

	protected abstract bool MatchCustomIdent();

	protected void Initialize()
	{
	}

	public void MoveNext()
	{
	}

	public void SaveContext()
	{
	}

	public void RestoreContext()
	{
	}

	public void DropContext()
	{
	}

	protected bool Match(Expression exp)
	{
		return false;
	}

	private bool MatchExpression(Expression exp)
	{
		return false;
	}

	private bool MatchExpressionWithMultiplier(Expression exp)
	{
		return false;
	}

	private bool MatchGroup(Expression exp)
	{
		return false;
	}

	private bool MatchCombinator(Expression exp)
	{
		return false;
	}

	private bool MatchOr(Expression exp)
	{
		return false;
	}

	private bool MatchOrOr(Expression exp)
	{
		return false;
	}

	private bool MatchAndAnd(Expression exp)
	{
		return false;
	}

	private int MatchMany(Expression exp)
	{
		return 0;
	}

	private unsafe int MatchManyByOrder(Expression exp, int* matchOrder)
	{
		return 0;
	}

	private bool MatchJuxtaposition(Expression exp)
	{
		return false;
	}

	private bool MatchDataType(Expression exp)
	{
		return false;
	}
}
