namespace Unity.Collections;

internal sealed class FixedList512BytesDebugView<T> where T : struct
{
	private FixedList512Bytes<T> m_List;

	public T[] Items => null;

	public FixedList512BytesDebugView(FixedList512Bytes<T> list)
	{
	}
}
