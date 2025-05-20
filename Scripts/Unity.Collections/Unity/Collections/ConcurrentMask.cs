namespace Unity.Collections;

internal class ConcurrentMask
{
	internal const int ErrorFailedToFree = -1;

	internal const int ErrorFailedToAllocate = -2;

	internal const int EmptyBeforeAllocation = 0;

	internal const int EmptyAfterFree = 0;

	internal static void longestConsecutiveOnes(long value, out int offset, out int count)
	{
		offset = default(int);
		count = default(int);
	}

	internal static bool foundAtLeastThisManyConsecutiveOnes(long value, int minimum, out int offset, out int count)
	{
		offset = default(int);
		count = default(int);
		return false;
	}

	internal static bool foundAtLeastThisManyConsecutiveZeroes(long value, int minimum, out int offset, out int count)
	{
		offset = default(int);
		count = default(int);
		return false;
	}

	internal static bool Succeeded(int error)
	{
		return false;
	}

	internal static long MakeMask(int offset, int bits)
	{
		return 0L;
	}

	internal static int TryAllocate(ref long l, int offset, int bits)
	{
		return 0;
	}

	internal static int TryFree(ref long l, int offset, int bits)
	{
		return 0;
	}

	internal static int TryAllocate(ref long l, out int offset, int bits)
	{
		offset = default(int);
		return 0;
	}

	internal static int TryAllocate<T>(ref T t, int offset, int bits) where T : IIndexable<long>
	{
		return 0;
	}

	internal static int TryFree<T>(ref T t, int offset, int bits) where T : IIndexable<long>
	{
		return 0;
	}

	internal static int TryAllocate<T>(ref T t, out int offset, int begin, int end, int bits) where T : IIndexable<long>
	{
		offset = default(int);
		return 0;
	}

	internal static int TryAllocate<T>(ref T t, out int offset, int bits) where T : IIndexable<long>
	{
		offset = default(int);
		return 0;
	}
}
