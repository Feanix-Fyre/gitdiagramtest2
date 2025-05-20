namespace Unity.Collections.LowLevel.Unsafe;

internal sealed class UnsafeRingQueueDebugView<T> where T : struct
{
	private UnsafeRingQueue<T> Data;

	public T[] Items => null;

	public UnsafeRingQueueDebugView(UnsafeRingQueue<T> data)
	{
	}
}
