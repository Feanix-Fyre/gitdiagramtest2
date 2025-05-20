namespace Unity.Collections;

internal sealed class FixedList4096BytesDebugView<T> where T : struct
{
	private FixedList4096Bytes<T> m_List;

	public T[] Items => null;

	public FixedList4096BytesDebugView(FixedList4096Bytes<T> list)
	{
	}
}
