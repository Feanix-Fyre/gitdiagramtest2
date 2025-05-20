namespace System.Threading;

internal struct SparselyPopulatedArrayAddInfo<T> where T : class
{
	private SparselyPopulatedArrayFragment<T> _source;

	private int _index;

	internal SparselyPopulatedArrayFragment<T> Source => null;

	internal int Index => 0;

	internal SparselyPopulatedArrayAddInfo(SparselyPopulatedArrayFragment<T> source, int index)
	{
		_source = null;
		_index = 0;
	}
}
