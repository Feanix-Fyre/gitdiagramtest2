namespace System.Threading;

internal class SparselyPopulatedArrayFragment<T> where T : class
{
	internal readonly T[] _elements;

	internal int _freeCount;

	internal SparselyPopulatedArrayFragment<T> _next;

	internal SparselyPopulatedArrayFragment<T> _prev;

	internal T this[int index] => null;

	internal int Length => 0;

	internal SparselyPopulatedArrayFragment<T> Prev => null;

	internal SparselyPopulatedArrayFragment(int size)
	{
	}

	internal SparselyPopulatedArrayFragment(int size, SparselyPopulatedArrayFragment<T> prev)
	{
	}

	internal T SafeAtomicRemove(int index, T expectedElement)
	{
		return null;
	}
}
