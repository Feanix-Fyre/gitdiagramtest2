using System.IO;
using System.Text;

namespace System.Security.Util;

internal sealed class Tokenizer
{
	private enum TokenSource
	{
		UnicodeByteArray = 0,
		UTF8ByteArray = 1,
		ASCIIByteArray = 2,
		CharArray = 3,
		String = 4,
		NestedStrings = 5,
		Other = 6
	}

	[Serializable]
	internal sealed class StringMaker
	{
		private string[] aStrings;

		private uint cStringsMax;

		private uint cStringsUsed;

		public StringBuilder _outStringBuilder;

		public char[] _outChars;

		public int _outIndex;

		private static uint HashString(string str)
		{
			return 0u;
		}

		private static uint HashCharArray(char[] a, int l)
		{
			return 0u;
		}

		private bool CompareStringAndChars(string str, char[] a, int l)
		{
			return false;
		}

		public string MakeString()
		{
			return null;
		}
	}

	internal interface ITokenReader
	{
		int Read();
	}

	internal class StreamTokenReader : ITokenReader
	{
		internal StreamReader _in;

		internal int _numCharRead;

		internal int NumCharEncountered => 0;

		internal StreamTokenReader(StreamReader input)
		{
		}

		public virtual int Read()
		{
			return 0;
		}
	}

	public int LineNo;

	private int _inProcessingTag;

	private byte[] _inBytes;

	private char[] _inChars;

	private string _inString;

	private int _inIndex;

	private int _inSize;

	private int _inSavedCharacter;

	private TokenSource _inTokenSource;

	private ITokenReader _inTokenReader;

	private StringMaker _maker;

	private string[] _searchStrings;

	private string[] _replaceStrings;

	private int _inNestedIndex;

	private int _inNestedSize;

	private string _inNestedString;

	internal void BasicInitialization()
	{
	}

	public void Recycle()
	{
	}

	internal Tokenizer(string input)
	{
	}

	internal void ChangeFormat(Encoding encoding)
	{
	}

	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet)
	{
	}

	private string GetStringToken()
	{
		return null;
	}
}
