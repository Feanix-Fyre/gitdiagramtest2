namespace System;

internal static class FixedBufferExtensions
{
	internal static string GetStringFromFixedBuffer(this ReadOnlySpan<char> span)
	{
		return null;
	}

	internal static int GetFixedBufferStringLength(this ReadOnlySpan<char> span)
	{
		return 0;
	}

	internal static bool FixedBufferEqualsString(this ReadOnlySpan<char> span, string value)
	{
		return false;
	}
}
