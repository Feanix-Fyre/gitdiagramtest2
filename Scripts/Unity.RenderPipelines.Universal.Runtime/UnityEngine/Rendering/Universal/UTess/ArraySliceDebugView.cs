namespace UnityEngine.Rendering.Universal.UTess;

internal sealed class ArraySliceDebugView<T> where T : struct
{
	private ArraySlice<T> m_Slice;

	public T[] Items => null;

	public ArraySliceDebugView(ArraySlice<T> slice)
	{
	}
}
