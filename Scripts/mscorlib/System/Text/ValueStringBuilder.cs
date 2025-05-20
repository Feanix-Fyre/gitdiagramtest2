using System.Runtime.CompilerServices;

namespace System.Text;

internal ref struct ValueStringBuilder
{
	private char[] _arrayToReturnToPool;

	private Span<char> _chars;

	private int _pos;

	public int Length => 0;

	public ref char this[int index]
	{
		get
		{
			throw null;
		}
	}

	public ValueStringBuilder(Span<char> initialBuffer)
	{
		_arrayToReturnToPool = null;
		_chars = default(Span<char>);
		_pos = 0;
	}

	public override string ToString()
	{
		return null;
	}

	public bool TryCopyTo(Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Append(char c)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Append(string s)
	{
	}

	private void AppendSlow(string s)
	{
	}

	public void Append(char c, int count)
	{
	}

	public unsafe void Append(char* value, int length)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Span<char> AppendSpan(int length)
	{
		return default(Span<char>);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GrowAndAppend(char c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Grow(int requiredAdditionalCapacity)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Dispose()
	{
	}
}
