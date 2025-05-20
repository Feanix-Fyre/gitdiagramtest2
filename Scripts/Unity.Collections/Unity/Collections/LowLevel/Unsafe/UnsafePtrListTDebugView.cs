namespace Unity.Collections.LowLevel.Unsafe;

internal sealed class UnsafePtrListTDebugView<T> where T : struct
{
	private UnsafePtrList<T> Data;

	public unsafe T*[] Items => null;

	public UnsafePtrListTDebugView(UnsafePtrList<T> data)
	{
	}
}
