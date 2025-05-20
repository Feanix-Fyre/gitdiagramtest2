namespace Unity.Collections;

internal sealed class NativeListDebugView<T> where T : struct
{
	private NativeList<T> m_Array;

	public T[] Items => null;

	public NativeListDebugView(NativeList<T> array)
	{
	}
}
