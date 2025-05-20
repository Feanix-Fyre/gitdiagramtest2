namespace Unity.Collections.LowLevel.Unsafe;

[NativeContainer]
[BurstCompatible]
internal struct UnsafeParallelHashMapDataDispose
{
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeParallelHashMapData* m_Buffer;

	internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

	public void Dispose()
	{
	}
}
