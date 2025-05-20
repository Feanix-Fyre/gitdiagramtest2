namespace System.Threading;

internal class SparselyPopulatedArray<T> where T : class
{
	private readonly SparselyPopulatedArrayFragment<T> _head;

	private SparselyPopulatedArrayFragment<T> _tail;

	internal SparselyPopulatedArrayFragment<T> Tail => null;

	internal SparselyPopulatedArray(int initialSize)
	{
	}

	internal SparselyPopulatedArrayAddInfo<T> Add(T element)
	{
		return default(SparselyPopulatedArrayAddInfo<T>);
	}
}
