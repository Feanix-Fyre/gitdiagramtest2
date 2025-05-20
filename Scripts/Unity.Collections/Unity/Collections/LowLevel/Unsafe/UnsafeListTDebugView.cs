namespace Unity.Collections.LowLevel.Unsafe;

internal sealed class UnsafeListTDebugView<T> where T : struct
{
	private UnsafeList<T> Data;

	public T[] Items => null;

	public UnsafeListTDebugView(UnsafeList<T> data)
	{
	}
}
