namespace Unity.Collections;

internal struct Long1024 : IIndexable<long>
{
	internal Long512 f0;

	internal Long512 f1;

	public int Length
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public ref long ElementAt(int index)
	{
		throw null;
	}
}
