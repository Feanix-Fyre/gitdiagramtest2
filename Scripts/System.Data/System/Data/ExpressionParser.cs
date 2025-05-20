namespace System.Data;

internal sealed class ExpressionParser
{
	private readonly struct ReservedWords
	{
		internal readonly string _word;

		internal readonly Tokens _token;

		internal readonly int _op;

		internal ReservedWords(string word, Tokens token, int op)
		{
			_word = null;
			_token = default(Tokens);
			_op = 0;
		}
	}

	private static readonly ReservedWords[] s_reservedwords;

	private char _escape;

	private char _decimalSeparator;

	private char _listSeparator;

	private char _exponentL;

	private char _exponentU;

	internal char[] _text;

	internal int _pos;

	internal int _start;

	internal Tokens _token;

	internal int _op;

	internal OperatorInfo[] _ops;

	internal int _topOperator;

	internal int _topNode;

	private readonly DataTable _table;

	internal ExpressionNode[] _nodeStack;

	internal int _prevOperand;

	internal ExpressionNode _expression;

	internal ExpressionParser(DataTable table)
	{
	}

	internal void LoadExpression(string data)
	{
	}

	internal void StartScan()
	{
	}

	internal ExpressionNode Parse()
	{
		return null;
	}

	private ExpressionNode ParseAggregateArgument(FunctionId aggregate)
	{
		return null;
	}

	private ExpressionNode NodePop()
	{
		return null;
	}

	private ExpressionNode NodePeek()
	{
		return null;
	}

	private void NodePush(ExpressionNode node)
	{
	}

	private void BuildExpression(int pri)
	{
	}

	internal void CheckToken(Tokens token)
	{
	}

	internal Tokens Scan()
	{
		return default(Tokens);
	}

	private void ScanNumeric()
	{
	}

	private void ScanName()
	{
	}

	private void ScanName(char chEnd, char esc, string charsToEscape)
	{
	}

	private void ScanDate()
	{
	}

	private void ScanBinaryConstant()
	{
	}

	private void ScanReserved()
	{
	}

	private void ScanString(char escape)
	{
	}

	internal void ScanToken(Tokens token)
	{
	}

	private void ScanWhite()
	{
	}

	private bool IsWhiteSpace(char ch)
	{
		return false;
	}

	private bool IsAlphaNumeric(char ch)
	{
		return false;
	}

	private bool IsDigit(char ch)
	{
		return false;
	}

	private bool IsAlpha(char ch)
	{
		return false;
	}
}
