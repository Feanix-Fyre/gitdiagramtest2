namespace Unity.Collections;

internal sealed class FixedList128BytesDebugView<T> where T : struct
{
	private FixedList128Bytes<T> m_List;

	public T[] Items => null;

	public FixedList128BytesDebugView(FixedList128Bytes<T> list)
	{
	}
}
