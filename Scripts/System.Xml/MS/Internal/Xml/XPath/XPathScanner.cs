using System.Xml;

namespace MS.Internal.Xml.XPath;

internal sealed class XPathScanner
{
	public enum LexKind
	{
		Comma = 44,
		Slash = 47,
		At = 64,
		Dot = 46,
		LParens = 40,
		RParens = 41,
		LBracket = 91,
		RBracket = 93,
		Star = 42,
		Plus = 43,
		Minus = 45,
		Eq = 61,
		Lt = 60,
		Gt = 62,
		Bang = 33,
		Dollar = 36,
		Apos = 39,
		Quote = 34,
		Union = 124,
		Ne = 78,
		Le = 76,
		Ge = 71,
		And = 65,
		Or = 79,
		DotDot = 68,
		SlashSlash = 83,
		Name = 110,
		String = 115,
		Number = 100,
		Axe = 97,
		Eof = 69
	}

	private string _xpathExpr;

	private int _xpathExprIndex;

	private LexKind _kind;

	private char _currentChar;

	private string _name;

	private string _prefix;

	private string _stringValue;

	private double _numberValue;

	private bool _canBeFunction;

	private XmlCharType _xmlCharType;

	public string SourceText => null;

	private char CurrentChar => '\0';

	public LexKind Kind => default(LexKind);

	public string Name => null;

	public string Prefix => null;

	public string StringValue => null;

	public double NumberValue => 0.0;

	public bool CanBeFunction => false;

	public XPathScanner(string xpathExpr)
	{
	}

	private bool NextChar()
	{
		return false;
	}

	private void SkipSpace()
	{
	}

	public bool NextLex()
	{
		return false;
	}

	private double ScanNumber()
	{
		return 0.0;
	}

	private double ScanFraction()
	{
		return 0.0;
	}

	private string ScanString()
	{
		return null;
	}

	private string ScanName()
	{
		return null;
	}
}
