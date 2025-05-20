using System.Text;

namespace System.IO;

internal class CStreamWriter : StreamWriter
{
	private TermInfoDriver driver;

	public CStreamWriter(Stream stream, Encoding encoding, bool leaveOpen)
	{
	}

	public override void Write(char[] buffer, int index, int count)
	{
	}

	public override void Write(char val)
	{
	}

	public void InternalWriteString(string val)
	{
	}

	public void InternalWriteChar(char val)
	{
	}

	public void InternalWriteChars(char[] buffer, int n)
	{
	}

	public override void Write(char[] val)
	{
	}

	public override void Write(string val)
	{
	}

	public override void WriteLine(string val)
	{
	}
}
