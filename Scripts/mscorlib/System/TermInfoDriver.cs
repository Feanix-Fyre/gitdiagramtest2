using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

namespace System;

internal class TermInfoDriver : IConsoleDriver
{
	private unsafe static int* native_terminal_size;

	private static int terminal_size;

	private static readonly string[] locations;

	private TermInfoReader reader;

	private int cursorLeft;

	private int cursorTop;

	private string title;

	private string titleFormat;

	private bool cursorVisible;

	private string csrVisible;

	private string csrInvisible;

	private string clear;

	private string bell;

	private string term;

	private StreamReader stdin;

	private CStreamWriter stdout;

	private int windowWidth;

	private int windowHeight;

	private int bufferHeight;

	private int bufferWidth;

	private char[] buffer;

	private int readpos;

	private int writepos;

	private string keypadXmit;

	private string keypadLocal;

	private bool inited;

	private object initLock;

	private bool initKeys;

	private string origPair;

	private string origColors;

	private string cursorAddress;

	private ConsoleColor fgcolor;

	private string setfgcolor;

	private string setbgcolor;

	private int maxColors;

	private bool noGetPosition;

	private Hashtable keymap;

	private ByteMatcher rootmap;

	private int rl_startx;

	private int rl_starty;

	private byte[] control_characters;

	private static readonly int[] _consoleColorToAnsiCode;

	private char[] echobuf;

	private int echon;

	public bool Initialized => false;

	public int WindowHeight => 0;

	public int WindowWidth => 0;

	private static string TryTermInfoDir(string dir, string term)
	{
		return null;
	}

	private static string SearchTerminfo(string term)
	{
		return null;
	}

	private void WriteConsole(string str)
	{
	}

	public TermInfoDriver(string term)
	{
	}

	public void Init()
	{
	}

	private void IncrementX()
	{
	}

	public void WriteSpecialKey(ConsoleKeyInfo key)
	{
	}

	public void WriteSpecialKey(char c)
	{
	}

	public bool IsSpecialKey(ConsoleKeyInfo key)
	{
		return false;
	}

	public bool IsSpecialKey(char c)
	{
		return false;
	}

	private void GetCursorPosition()
	{
	}

	private void CheckWindowDimensions()
	{
	}

	private void AddToBuffer(int b)
	{
	}

	private void AdjustBuffer()
	{
	}

	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt)
	{
		return default(ConsoleKeyInfo);
	}

	private object GetKeyFromBuffer(bool cooked)
	{
		return null;
	}

	private ConsoleKeyInfo ReadKeyInternal(out bool fresh)
	{
		fresh = default(bool);
		return default(ConsoleKeyInfo);
	}

	private bool InputPending()
	{
		return false;
	}

	private void QueueEcho(char c)
	{
	}

	private void Echo(ConsoleKeyInfo key)
	{
	}

	private void EchoFlush()
	{
	}

	public int Read([In][Out] char[] dest, int index, int count)
	{
		return 0;
	}

	public ConsoleKeyInfo ReadKey(bool intercept)
	{
		return default(ConsoleKeyInfo);
	}

	public string ReadLine()
	{
		return null;
	}

	public string ReadToEnd()
	{
		return null;
	}

	private string ReadUntilConditionInternal(bool haltOnNewLine)
	{
		return null;
	}

	public void SetCursorPosition(int left, int top)
	{
	}

	private void CreateKeyMap()
	{
	}

	private void InitKeys()
	{
	}

	private void AddStringMapping(TermInfoStrings s)
	{
	}
}
