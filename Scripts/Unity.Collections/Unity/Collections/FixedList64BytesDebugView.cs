namespace Unity.Collections;

internal sealed class FixedList64BytesDebugView<T> where T : struct
{
	private FixedList64Bytes<T> m_List;

	public T[] Items => null;

	public FixedList64BytesDebugView(FixedList64Bytes<T> list)
	{
	}
}
