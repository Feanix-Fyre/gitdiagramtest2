using System.Runtime.InteropServices;
using System.Text;

namespace System.IO;

internal class CStreamReader : StreamReader
{
	private TermInfoDriver driver;

	public CStreamReader(Stream stream, Encoding encoding)
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

	public override int Read([In][Out] char[] dest, int index, int count)
	{
		return 0;
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
