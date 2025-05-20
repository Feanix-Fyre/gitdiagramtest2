using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace System.Text.RegularExpressions;

internal sealed class RegexParser
{
	private RegexNode _stack;

	private RegexNode _group;

	private RegexNode _alternation;

	private RegexNode _concatenation;

	private RegexNode _unit;

	private string _pattern;

	private int _currentPos;

	private CultureInfo _culture;

	private int _autocap;

	private int _capcount;

	private int _captop;

	private int _capsize;

	private Hashtable _caps;

	private Hashtable _capnames;

	private int[] _capnumlist;

	private List<string> _capnamelist;

	private RegexOptions _options;

	private List<RegexOptions> _optionsStack;

	private bool _ignoreNextParen;

	private static readonly byte[] s_category;

	public static RegexTree Parse(string re, RegexOptions op)
	{
		return null;
	}

	public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op)
	{
		return null;
	}

	public static string Escape(string input)
	{
		return null;
	}

	private RegexParser(CultureInfo culture)
	{
	}

	private void SetPattern(string Re)
	{
	}

	private void Reset(RegexOptions topopts)
	{
	}

	private RegexNode ScanRegex()
	{
		return null;
	}

	private RegexNode ScanReplacement()
	{
		return null;
	}

	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly)
	{
		return null;
	}

	private RegexNode ScanGroupOpen()
	{
		return null;
	}

	private void ScanBlank()
	{
	}

	private RegexNode ScanBackslash(bool scanOnly)
	{
		return null;
	}

	private RegexNode ScanBasicBackslash(bool scanOnly)
	{
		return null;
	}

	private RegexNode ScanDollar()
	{
		return null;
	}

	private string ScanCapname()
	{
		return null;
	}

	private char ScanOctal()
	{
		return '\0';
	}

	private int ScanDecimal()
	{
		return 0;
	}

	private char ScanHex(int c)
	{
		return '\0';
	}

	private static int HexDigit(char ch)
	{
		return 0;
	}

	private char ScanControl()
	{
		return '\0';
	}

	private bool IsOnlyTopOption(RegexOptions option)
	{
		return false;
	}

	private void ScanOptions()
	{
	}

	private char ScanCharEscape()
	{
		return '\0';
	}

	private string ParseProperty()
	{
		return null;
	}

	private int TypeFromCode(char ch)
	{
		return 0;
	}

	private static RegexOptions OptionFromCode(char ch)
	{
		return default(RegexOptions);
	}

	private void CountCaptures()
	{
	}

	private void NoteCaptureSlot(int i, int pos)
	{
	}

	private void NoteCaptureName(string name, int pos)
	{
	}

	private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames)
	{
	}

	private void AssignNameSlots()
	{
	}

	private int CaptureSlotFromName(string capname)
	{
		return 0;
	}

	private bool IsCaptureSlot(int i)
	{
		return false;
	}

	private bool IsCaptureName(string capname)
	{
		return false;
	}

	private bool UseOptionN()
	{
		return false;
	}

	private bool UseOptionI()
	{
		return false;
	}

	private bool UseOptionM()
	{
		return false;
	}

	private bool UseOptionS()
	{
		return false;
	}

	private bool UseOptionX()
	{
		return false;
	}

	private bool UseOptionE()
	{
		return false;
	}

	private static bool IsSpecial(char ch)
	{
		return false;
	}

	private static bool IsStopperX(char ch)
	{
		return false;
	}

	private static bool IsQuantifier(char ch)
	{
		return false;
	}

	private bool IsTrueQuantifier()
	{
		return false;
	}

	private static bool IsSpace(char ch)
	{
		return false;
	}

	private static bool IsMetachar(char ch)
	{
		return false;
	}

	private void AddConcatenate(int pos, int cch, bool isReplacement)
	{
	}

	private void PushGroup()
	{
	}

	private void PopGroup()
	{
	}

	private bool EmptyStack()
	{
		return false;
	}

	private void StartGroup(RegexNode openGroup)
	{
	}

	private void AddAlternate()
	{
	}

	private void AddConcatenate()
	{
	}

	private void AddConcatenate(bool lazy, int min, int max)
	{
	}

	private RegexNode Unit()
	{
		return null;
	}

	private void AddUnitOne(char ch)
	{
	}

	private void AddUnitNotone(char ch)
	{
	}

	private void AddUnitSet(string cc)
	{
	}

	private void AddUnitNode(RegexNode node)
	{
	}

	private void AddUnitType(int type)
	{
	}

	private void AddGroup()
	{
	}

	private void PushOptions()
	{
	}

	private void PopOptions()
	{
	}

	private bool EmptyOptionsStack()
	{
		return false;
	}

	private void PopKeepOptions()
	{
	}

	private ArgumentException MakeException(string message)
	{
		return null;
	}

	private int Textpos()
	{
		return 0;
	}

	private void Textto(int pos)
	{
	}

	private char RightCharMoveRight()
	{
		return '\0';
	}

	private void MoveRight()
	{
	}

	private void MoveRight(int i)
	{
	}

	private void MoveLeft()
	{
	}

	private char CharAt(int i)
	{
		return '\0';
	}

	internal char RightChar()
	{
		return '\0';
	}

	private char RightChar(int i)
	{
		return '\0';
	}

	private int CharsRight()
	{
		return 0;
	}
}
