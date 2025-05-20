using System.Collections.Generic;

namespace MS.Internal.Xml.XPath;

internal sealed class QueryBuilder
{
	private enum Flags
	{
		None = 0,
		SmartDesc = 1,
		PosFilter = 2,
		Filter = 4
	}

	private enum Props
	{
		None = 0,
		PosFilter = 1,
		HasPosition = 2,
		HasLast = 4,
		NonFlat = 8
	}

	private string _query;

	private bool _allowVar;

	private bool _allowKey;

	private bool _allowCurrent;

	private bool _needContext;

	private BaseAxisQuery _firstInput;

	private int _parseDepth;

	private void Reset()
	{
	}

	private Query ProcessAxis(Axis root, Flags flags, out Props props)
	{
		props = default(Props);
		return null;
	}

	private static bool CanBeNumber(Query q)
	{
		return false;
	}

	private Query ProcessFilter(Filter root, Flags flags, out Props props)
	{
		props = default(Props);
		return null;
	}

	private Query ProcessOperator(Operator root, out Props props)
	{
		props = default(Props);
		return null;
	}

	private Query ProcessVariable(Variable root)
	{
		return null;
	}

	private Query ProcessFunction(Function root, out Props props)
	{
		props = default(Props);
		return null;
	}

	private List<Query> ProcessArguments(List<AstNode> args, out Props props)
	{
		props = default(Props);
		return null;
	}

	private Query ProcessNode(AstNode root, Flags flags, out Props props)
	{
		props = default(Props);
		return null;
	}

	private Query Build(AstNode root, string query)
	{
		return null;
	}

	internal Query Build(string query, bool allowVar, bool allowKey)
	{
		return null;
	}

	internal Query Build(string query, out bool needContext)
	{
		needContext = default(bool);
		return null;
	}
}
