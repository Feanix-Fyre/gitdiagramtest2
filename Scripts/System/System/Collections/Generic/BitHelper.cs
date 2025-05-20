namespace System.Collections.Generic;

internal sealed class BitHelper
{
	private readonly int _length;

	private unsafe readonly int* _arrayPtr;

	private readonly int[] _array;

	private readonly bool _useStackAlloc;

	internal unsafe BitHelper(int* bitArrayPtr, int length)
	{
	}

	internal BitHelper(int[] bitArray, int length)
	{
	}

	internal void MarkBit(int bitPosition)
	{
	}

	internal bool IsMarked(int bitPosition)
	{
		return false;
	}

	internal static int ToIntArrayLength(int n)
	{
		return 0;
	}
}
