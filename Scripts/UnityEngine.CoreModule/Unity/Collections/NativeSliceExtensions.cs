namespace Unity.Collections;

public static class NativeSliceExtensions
{
	public static NativeSlice<T> Slice<T>(this NativeArray<T> thisArray, int start, int length) where T : struct
	{
		return default(NativeSlice<T>);
	}

	public static NativeSlice<T> Slice<T>(this NativeSlice<T> thisSlice, int start, int length) where T : struct
	{
		return default(NativeSlice<T>);
	}
}
