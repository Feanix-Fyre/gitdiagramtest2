namespace Unity.Collections;

internal sealed class FixedList32BytesDebugView<T> where T : struct
{
	private FixedList32Bytes<T> m_List;

	public T[] Items => null;

	public FixedList32BytesDebugView(FixedList32Bytes<T> list)
	{
	}
}
