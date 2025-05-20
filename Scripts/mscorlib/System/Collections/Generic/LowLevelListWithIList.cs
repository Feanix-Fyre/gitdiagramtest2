namespace System.Collections.Generic;

internal sealed class LowLevelListWithIList<T> : LowLevelList<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	private struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private LowLevelListWithIList<T> _list;

		private int _index;

		private int _version;

		private T _current;

		public T Current => default(T);

		object IEnumerator.Current => null;

		internal Enumerator(LowLevelListWithIList<T> list)
		{
			_list = null;
			_index = 0;
			_version = 0;
			_current = default(T);
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		private bool MoveNextRare()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	bool ICollection<T>.IsReadOnly => false;

	public LowLevelListWithIList()
	{
	}

	public LowLevelListWithIList(int capacity)
	{
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
