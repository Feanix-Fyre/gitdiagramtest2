using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices;

public static class MemoryMarshal
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Span<byte> AsBytes<T>(Span<T> span) where T : struct
	{
		return default(Span<byte>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) where T : struct
	{
		return default(ReadOnlySpan<byte>);
	}

	public static Memory<T> AsMemory<T>(ReadOnlyMemory<T> memory)
	{
		return default(Memory<T>);
	}

	public static ref T GetReference<T>(Span<T> span)
	{
		throw null;
	}

	public static ref T GetReference<T>(ReadOnlySpan<T> span)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static ref T GetNonNullPinnableReference<T>(Span<T> span)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static ref T GetNonNullPinnableReference<T>(ReadOnlySpan<T> span)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T reference, int length)
	{
		return default(ReadOnlySpan<T>);
	}

	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment)
	{
		segment = default(ArraySegment<T>);
		return false;
	}
}
