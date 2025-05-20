namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible]
internal struct UnsafeStreamBlockData
{
	internal const int AllocationSize = 4096;

	internal AllocatorManager.AllocatorHandle Allocator;

	internal unsafe UnsafeStreamBlock** Blocks;

	internal int BlockCount;

	internal unsafe UnsafeStreamBlock* Free;

	internal unsafe UnsafeStreamRange* Ranges;

	internal int RangeCount;

	internal unsafe UnsafeStreamBlock* Allocate(UnsafeStreamBlock* oldBlock, int threadIndex)
	{
		return null;
	}
}
