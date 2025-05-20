using System.Runtime.CompilerServices;

namespace System.Buffers.Text;

internal static class FormattingHelpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int CountDigits(ulong value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int CountDigits(uint value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int CountHexDigits(ulong value)
	{
		return 0;
	}
}
