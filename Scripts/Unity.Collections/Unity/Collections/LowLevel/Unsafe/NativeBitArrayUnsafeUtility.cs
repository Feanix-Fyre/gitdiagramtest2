namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible]
public static class NativeBitArrayUnsafeUtility
{
	public unsafe static NativeBitArray ConvertExistingDataToNativeBitArray(void* ptr, int sizeInBytes, AllocatorManager.AllocatorHandle allocator)
	{
		return default(NativeBitArray);
	}
}
