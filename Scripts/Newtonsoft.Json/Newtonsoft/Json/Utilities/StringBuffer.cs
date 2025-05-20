namespace Newtonsoft.Json.Utilities;

internal struct StringBuffer
{
	private char[]? _buffer;

	private int _position;

	public int Position
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsEmpty => false;

	public char[]? InternalBuffer => null;

	public StringBuffer(IArrayPool<char>? bufferPool, int initalSize)
	{
		_buffer = null;
		_position = 0;
	}

	private StringBuffer(char[] buffer)
	{
		_buffer = null;
		_position = 0;
	}

	public void Append(IArrayPool<char>? bufferPool, char value)
	{
	}

	public void Append(IArrayPool<char>? bufferPool, char[] buffer, int startIndex, int count)
	{
	}

	public void Clear(IArrayPool<char>? bufferPool)
	{
	}

	private void EnsureSize(IArrayPool<char>? bufferPool, int appendLength)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(int start, int length)
	{
		return null;
	}
}
