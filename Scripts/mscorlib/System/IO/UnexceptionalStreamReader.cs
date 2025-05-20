using System.Runtime.InteropServices;
using System.Text;

namespace System.IO;

internal class UnexceptionalStreamReader : StreamReader
{
	private static bool[] newline;

	private static char newlineChar;

	static UnexceptionalStreamReader()
	{
	}

	public UnexceptionalStreamReader(Stream stream, Encoding encoding)
	{
	}

	public override int Peek()
	{
		return 0;
	}

	public override int Read()
	{
		return 0;
	}

	public override int Read([In][Out] char[] dest_buffer, int index, int count)
	{
		return 0;
	}

	private bool CheckEOL(char current)
	{
		return false;
	}

	public override string ReadLine()
	{
		return null;
	}

	public override string ReadToEnd()
	{
		return null;
	}
}
