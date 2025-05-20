namespace Unity.Collections.LowLevel.Unsafe;

public static class NativeSliceUnsafeUtility
{
	public unsafe static NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length) where T : struct
	{
		return default(NativeSlice<T>);
	}

	public unsafe static void* GetUnsafePtr<T>(this NativeSlice<T> nativeSlice) where T : struct
	{
		return null;
	}

	public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeSlice<T> nativeSlice) where T : struct
	{
		return null;
	}
}
