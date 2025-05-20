using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

internal static class NativeArrayExtensions
{
	public static ref T UnsafeElementAt<T>(this NativeArray<T> array, int index) where T : struct
	{
		throw null;
	}

	public static ref T UnsafeElementAtMutable<T>(this NativeArray<T> array, int index) where T : struct
	{
		throw null;
	}
}
